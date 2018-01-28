using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yachting_firm
{
    public partial class AddOrder : Form
    {

        DataSet ds = new DataSet();
        int nom;
       DateTime date;
       DataTable table,info,clients,services_in_order;      
      public  DataRow newr;
        public  DataRow newrow ;
        public DataRow nr;
       int count = 0;
      double total_cost = 0;

        public AddOrder(int nom,DateTime date,DataTable table,DataTable info, DataTable clients,DataTable services_in_order){
            newr = clients.NewRow();
            newrow = table.NewRow();
            nr = info.NewRow();
            InitializeComponent();
            button2.Visible = false;
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);
            checkedListBox1.Visible = false;
           
            // сохраняем данные чека
this.nom = nom;
this.date = date;
this.table = table;
this.info = info;
this.clients = clients;
this.services_in_order = services_in_order;
label1.Text = " ";
           
// устанавливаем отсутсвие скидки по умолчанию
//textBox_discont.Text = "0";
// делаем поле скидки недоступным
//textBox_discont.Enabled = true;
// показываем номер чека
label_number.Text = "Order number" + nom;
// формирование DataGridView без автозаполнения
// отмена генерации столбцов DataGridView
dataGridView1.AutoGenerateColumns = false;
// заполнение структуры таблицы записи чека для dataGridView1
foreach (DataColumn dc in table.Columns)
{
  
     
        DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
        // заголовок столбца
        dgvc.HeaderText = dc.Caption;
      
        if (dc.Caption.Equals("order_number") ||
        dc.Caption.Equals("order_date")||(dc.Caption.Equals("total_cost"))||(dc.Caption.Equals("total_discount")))
            continue;        
   
    
    dataGridView1.Columns.Add(dgvc);
}
 
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            // вводим информацию о записи чека
                      
            newrow["order_number"] = nom;
            newrow["order_date"] = date;
            // считываем данные из текстовых полей о товаре, количестве и цене
            newrow["number_of_people"] =int.Parse(textBox_number_of_people.Text);
           // newrow["fio"] = textBox_clients_name.Text;
            string fio =textBox_clients_name.Text;
            newrow["presents"] = TextBox_presents.Text;
            newrow["legal_entity"] = checkBox_legal_entity.Checked;
            newrow["services"] = checkBox_services.Checked;
            newrow["total_cost"]=0;
            newrow["total_discount"]=0;
           newrow["clients_id"]=0;
           // * (int)newrow["Количество"];
            // запоминаем стоимость
           // int cost = (int)newrow["Стоимость"];
            // добавляем запись о купленном товаре в таблицу
            


           
            nr["order_number"] = nom;
            if (motorboat.Checked) { nr["ships_type"] = "motorboat";nr["crew_number"]=3; }
            if (yacht.Checked) { nr["ships_type"] = "yacht"; nr["crew_number"] = 4; }
            if (sails_yacht.Checked) { nr["ships_type"] = "sails_yacht"; nr["crew_number"]=4;}
            //crew number teamid
            foreach (int index in listBox2.SelectedIndices)
            {
                if (index==0) nr["sails_type"] = "NO";
                if (index==1) nr["sails_type"] = "square";
                if (index==2) nr["sails_type"] = "oblique";
            }
            nr["team_id"] =55;
            int y=date_begin.Value.Year;
            int m=date_begin.Value.Month;
            int d=date_begin.Value.Day;
            int hours=(int)hours_begin.Value;
            int minuts=(int)minutes_begin.Value;
            DateTime dt=new DateTime(y,m,d,hours,minuts,0);
            nr["date_begin"]=dt;

            y=date_end.Value.Year;
            m=date_end.Value.Month;
            d=date_end.Value.Day;
            hours=(int)hours_end.Value;
            minuts=(int)hours_end.Value;
            DateTime dt2=new DateTime(y,m,d,hours,minuts,0);
            nr["date_end"]=dt2;
            TimeSpan ts = dt2 - dt;

            switch ((int)nr["crew_number"])
            {
                case 3:
                    total_cost+=80*(int)ts.TotalMinutes;
                    break;
                case 4:
                    total_cost+=90*(int)ts.TotalMinutes;
                    break;
                default:
                    
                    break;
            }                     

            
            
         

           // DataRow drw = clients.Rows.Find(new object[] {fio });
            DataRow drw = ds.Tables["clients"].NewRow();
            bool found = false; 
            foreach(DataRow dr in clients.Rows)
            {
                if (dr["fio"].Equals(fio))
                { drw = dr; found = true; }
            }


            if( found ){
                newrow[ "clients_id" ] = drw[ "clients_id" ];
                newrow["total_discount"] = drw["discount"];
                table.Rows.Add(newrow); info.Rows.Add(nr);
                DataGridViewRow dgwr = new DataGridViewRow();

                dgwr.CreateCells(dataGridView1,
                 newrow["clients_id"],
                newrow["legal_entity"], newrow["number_of_people"],
                newrow["services"], newrow["presents"]);
                dataGridView1.Rows.Add(dgwr);
                DataRow dr2 = table.Rows.Find(new object[] { nom });
                dr2["total_cost"] = total_cost;
                if (checkBox_services.Checked)
                {
                   

                    if (checkedListBox1.GetSelected(0) == true)
                    {
                        DataRow serv = services_in_order.NewRow();
                        serv["service_id"] = 1;
                        serv["order_number"] = nom;
                        services_in_order.Rows.Add(serv);

                        // DataRow []dr2 = ds.Tables["yachting"].Select( "order_number=nom");
                        DataRow [] r = ds.Tables["services"].Select("service_id=1");
                        total_cost += (int)r[0]["price"];
         
                    }

                    if (checkedListBox1.GetSelected(1) == true)
                    {
                        DataRow serv = services_in_order.NewRow();
                        serv["service_id"] = 2;
                        serv["order_number"] = nom;
                        services_in_order.Rows.Add(serv);
                        DataRow[] r = ds.Tables["services"].Select("service_id=2");
                        total_cost += (int)r[0]["price"];
                    }

                    if (checkedListBox1.GetSelected(2) == true)
                    {
                        DataRow serv = services_in_order.NewRow();
                        serv["service_id"] = 3;
                        serv["order_number"] = nom;
                        services_in_order.Rows.Add(serv);
                        DataRow[] r = ds.Tables["services"].Select("service_id=3");
                        total_cost += (int)r[0]["price"];
                    }
                    if (checkedListBox1.GetSelected(3) == true)
                    {
                        DataRow serv = services_in_order.NewRow();
                        serv["service_id"] = 4;
                        serv["order_number"] = nom;
                        services_in_order.Rows.Add(serv);
                        DataRow[] r = ds.Tables["services"].Select("service_id=4");
                        total_cost +=(double)r[0]["price"];
                    }

                    
                   

                }


            }
           
            if(!found)
            {
               
                label1.Text += "Enter information about new client!";
                label9.Visible = true;
                label10.Visible = true;
                label8.Visible = true;
                email.Visible = true;
                discount.Visible = true;
                phone_number.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
            }

               
           
            if(checkBox_legal_entity.Checked)total_cost*=1.5;
            
             label_total.Text = "Total Cost: " + total_cost + " RUR";
           
           
             
            // корректировка общей стоимости в родительской таблице
           /* 
            dr["ОбщаяСтоимость"] = total_cost;
            // очищаем текстовые поля с данными нового покупаемого товара
            textBox_number_of_people.Text = "";
            textBox_clients_name.Text = "";
            TextBox_presents.Text = "";
            checkBox_legal_entity.Checked = false;
            checkBox_services.Checked = false;
            motorboat.Checked = false;
            yacht.Checked = false;
            sails_yacht.Checked = false;
            checkedListBox1.ClearSelected();
            listBox2.ClearSelected();
            * /
            
            // корректировка общей стоимости
           /* total_cost = total_cost + cost;
            label_total.Text = "Итого: " + total_cost + " рублей";
            // корректировка общей стоимости в родительской таблице
            DataRow dr = newrow.GetParentRow("СвязьЧека");
            dr["ОбщаяСтоимость"] = total_cost;*/
            count++;
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_services_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_services.Checked)checkedListBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;

            int count_cl = ds.Tables["clients"].Rows.Count;
            int nomer = (int)(ds.Tables["clients"].Rows[count_cl - 1]["clients_id"]) + 1;

          
            newr[ "phone_number"] = phone_number.Text;
            newr["email"] = email.Text;
            newr["fio"] = textBox_clients_name.Text;
            newr["discount"] = discount.Text;

            //ds.Tables["clients"].Rows.Add(newr);//??номер посделнего
            int clients_nom = (int)(clients.Rows[clients.Rows.Count - 1]["clients_id"]);
            clients_nom += 1;
            newrow["clients_id"] =clients_nom;
            newrow["total_discount"] =int.Parse(discount.Text);
            newr["clients_id"] = clients_nom;
            clients.Rows.Add(newr);
            table.Rows.Add(newrow); info.Rows.Add(nr);

            DataGridViewRow dgwr = new DataGridViewRow();

            dgwr.CreateCells(dataGridView1,
             newrow["clients_id"],
            newrow["legal_entity"], newrow["number_of_people"],
            newrow["services"], newrow["presents"]);
            dataGridView1.Rows.Add(dgwr);
            DataRow dr2 = table.Rows.Find(new object[] { nom });

            dr2["total_cost"] = total_cost;
            if (checkBox_services.Checked)
            {
                DataRow serv = services_in_order.NewRow();

                if (checkedListBox1.GetSelected(0) == true)
                {
                    serv["service_id"] = 1;
                    serv["order_number"] = nom;
                    services_in_order.Rows.Add(serv);
                }

                if (checkedListBox1.GetSelected(1) == true)
                {
                    serv["service_id"] = 2;
                    serv["order_number"] = nom;
                    services_in_order.Rows.Add(serv);
                }

                if (checkedListBox1.GetSelected(2) == true)
                {
                    serv["service_id"] = 3;
                    serv["order_number"] = nom;
                    services_in_order.Rows.Add(serv);
                }
                if (checkedListBox1.GetSelected(3) == true)
                {
                    serv["service_id"] = 4;
                    serv["order_number"] = nom;
                    services_in_order.Rows.Add(serv);
                }

               
                DataRow r = ds.Tables["services"].Rows.Find(new object[] { (int)serv["service_id"] });
                total_cost += (double)r["price"];

            }


         
        }

       
//       
//        public AddOrder(int number,DateTime date, DataTable table)
//        {
//            InitializeComponent();
//// сохраняем данные чека
//this.nom = nom;
//this.date = date;
//this.table = table;
//// устанавливаем отсутсвие скидки по умолчанию
//textBox_Discont.Text = "0";
//// делаем поле скидки недоступным
//textBox_Discont.Enabled = true;
//// показываем номер чека
//label_nomer.Text = "" + nom;
//// формирование DataGridView без автозаполнения
//// отмена генерации столбцов DataGridView
//dataGridView1.AutoGenerateColumns = false;
//// заполнение структуры таблицы записи чека для dataGridView1
//foreach (DataColumn dc in table.Columns)
//{
//// последовательное создание столбцов элемента управления
//DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
//// заголовок столбца
//dgvc.HeaderText = dc.Caption;
//// добавление столбца в коллекцию столбцов DataGridView
//dataGridView1.Columns.Add(dgvc);
//        }
//    }
    }
}
