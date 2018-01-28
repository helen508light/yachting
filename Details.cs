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
    public partial class Details : Form
    {
        public Details(DateTime date,DataTable main,DataTable table,DataTable services_in_order,DataTable services,DataRow info,DataTable client)
        {
            InitializeComponent();
            int order_number=(int)info["order_number"];
            // показываем номер чека
            label_nom.Text = "Order's number: " + info["order_number"];
            // показываем дату чека
            label_date.Text = "Order's date: " + date.ToShortDateString();
            DataRow row = main.Rows.Find(new object[]{order_number});
            label5.Text="Total cost:"+row["total_cost"]+" RUR";
            // формирование DataGridView без автозаполнения
            // отмена генерации столбцов DataGridView
            dataGridView1.AutoGenerateColumns = false;
            // заполнение структуры таблицы записи чека для dataGridView1
            foreach (DataColumn dc in table.Columns)
            {
                // последовательное создание столбцов элемента управления
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                // заголовок столбца
                dgvc.HeaderText = dc.Caption;
                // не добавляем столбцы с номером и датой чека
                if (dc.Caption.Equals("order_number") ||
                dc.Caption.Equals("order_date"))
                    continue;
                // добавление столбца в коллекцию столбцов DataGridView
                dataGridView1.Columns.Add(dgvc);
            }
            
            // находим все дочерние записи для чека
            DataRow[] drs = info.GetChildRows("info_yachting");
            // заполнение DataGridView данным из полученного массива 
           
            foreach (DataRow dr in drs)
            {             
               DataGridViewRow dgwr = new DataGridViewRow();
                dgwr.CreateCells(dataGridView1, 
                 dr["ships_type"], dr["team_id"],dr["date_begin"],dr["date_end"],
                dr["crew_number"],dr["sails_type"]);
               dataGridView1.Rows.Add(dgwr);
              
            }

            dataGridView2.AutoGenerateColumns = false;
            foreach (DataColumn dc in services.Columns)
            {
                // последовательное создание столбцов элемента управления
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                // заголовок столбца
                dgvc.HeaderText = dc.Caption;
                // не добавляем столбцы с номером и датой чека
                
                // добавление столбца в коллекцию столбцов DataGridView
                dataGridView2.Columns.Add(dgvc);
                
            }
           
            foreach(DataRow dr in services_in_order.Rows)
            {  DataGridViewRow r = new DataGridViewRow();
                if ((int)dr["order_number"] ==(int)info["order_number"])
                {
                   
                   foreach(DataRow dr2 in services.Rows)
                    {
                        if ((int)dr["service_id"] ==(int) dr2["service_id"])
                        {
                            
                            r.CreateCells(dataGridView2, dr2["service_id"], dr2["service_name"], dr2["price"]);
                            dataGridView2.Rows.Add(r);
                       }

                    }              
                 
                }
            }

            dataGridView3.AutoGenerateColumns = false;
            foreach (DataColumn dc in client.Columns)
            {
                // последовательное создание столбцов элемента управления
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                // заголовок столбца
                dgvc.HeaderText = dc.Caption;
                // не добавляем столбцы с номером и датой чека

                // добавление столбца в коллекцию столбцов DataGridView
                dataGridView3.Columns.Add(dgvc);

            }
            foreach(DataRow  dr in client.Rows)
            {
                DataGridViewRow dgrw=new DataGridViewRow();
                
                DataRow drw = main.Rows.Find(new object[]{order_number});
                if((int)drw["clients_id"]==(int)dr["clients_id"])
                {
                    dgrw.CreateCells(dataGridView3,dr["clients_id"], dr["fio"],dr["phone_number"],dr["discount"],dr["email"]);
                    dataGridView3.Rows.Add(dgrw);
                }
                
            }

            // формирование записи об итоговой стоимости по чеку
           // label_total.Text = "Итого: " + chek["ОбщаяСтоимость"] + " рублей";

        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_dat_Click(object sender, EventArgs e)
        {

        }
    }
}
