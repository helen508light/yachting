using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using Word =Microsoft.Office.Interop.Word;
using System.IO;
using System.Security.Cryptography;


namespace yachting_firm
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();//create new collection of data

        public int nom;

        public Form1()
        {
            InitializeComponent();

            label_today.Text = "Today: " + DateTime.Today.ToShortDateString();

            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);
          // nom = ds.Tables["yachting"].Rows.Count + 1;

            dataGridView1.DataSource = ds.Tables["yachting"];
        }
        
        order_serialized create_order(int order_number)
        {
            DataRow dr=ds.Tables["yachting"].Rows.Find(new object[] {order_number});//не находит по ключу!"!!!
            DataRow[] row_info = dr.GetChildRows("info_yachting");
            order_info info = new order_info((string)row_info[0]["ships_type"],(int)row_info[0]["team_id"],(DateTime)row_info[0]["date_begin"],
                (DateTime)row_info[0]["date_end"],(int)row_info[0]["crew_number"],(string)row_info[0]["sails_type"]);
            order_serialized order = new order_serialized((DateTime)dr["order_date"],(int)dr["order_number"],(double)dr["total_cost"],
                (int)dr["total_discount"],(int)dr["number_of_people"],info);
                      
            return order;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            int count = ds.Tables["yachting"].Rows.Count;
          int nom =(int)(ds.Tables["yachting"].Rows[count - 1]["order_number"])+1 ;
            
            AddOrder dlg = new AddOrder(nom, date, ds.Tables["yachting"],ds.Tables["info"], ds.Tables["clients"],ds.Tables["services_in_order"]);
           dlg.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int nom = (int)dataGridView1.SelectedRows[0].Cells["order_number"].Value;

            DataRow dr = ds.Tables["yachting"].Rows.Find(new object[] { (object)nom });
            dr.Delete();
        }

        private void details_Click(object sender, EventArgs e)
        {
            // если чек не был выбран, удалять нечего
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            //получение номера текущего выбранного чека
            int nom = (int)dataGridView1.SelectedRows[0].Cells["order_number"].Value;
            //получение даты текущего выбранного чека
            DateTime date =
            (DateTime)dataGridView1.SelectedRows[0].Cells["order_date"].Value;
            // вызываем диалог показа детализации выбранного чека
            
            
                Details dlg = new Details(date,ds.Tables["yachting"], ds.Tables["info"],ds.Tables["services_in_order"],ds.Tables["services"],
                 ds.Tables["yachting"].Rows.Find(new object[] { nom }), ds.Tables["clients"]/*.Rows.Find(new object[] { nom })*/);
                  dlg.ShowDialog();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ds.WriteXml("yachting.xml", XmlWriteMode.WriteSchema);
        }

        private void label_today_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int nom = (int)dataGridView1.SelectedRows[0].Cells["order_number"].Value;

            order_serialized order = create_order(nom);
            Word.Application app = new Word.Application();
            Word.Document doc =app.Documents.Add();

            Word.Paragraph p =  doc.Content.Paragraphs.Add();
            p.Range.Text = "Order №" + order.Order_number + " Date: " + order.Order_date.ToShortDateString();
            p.Range.Font.Bold = 3;
            p.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p.Format.SpaceAfter = 20;
            p.Range.InsertParagraphAfter();

            p = doc.Content.Paragraphs.Add();
            p.Range.Text = "Total cost: " + order.Total_cost+" RUR";
            p.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            p.Format.SpaceAfter = 20;
            p.Range.InsertParagraphAfter();
          

            p = doc.Content.Paragraphs.Add();
            p.Range.Text = "Total discount: " + order.Total_discount + " %";
            p.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            p.Format.SpaceAfter = 20;
            p.Range.InsertParagraphAfter();

            p = doc.Content.Paragraphs.Add();
            p.Range.Text = "Passenger's number: " + order.Number_of_people  ;
            p.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            p.Format.SpaceAfter = 20;
            p.Range.InsertParagraphAfter();


             p = doc.Content.Paragraphs.Add();
            p.Range.Text = "Main information" ;
            p.Range.Font.Bold = 3;
            p.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p.Format.SpaceAfter = 20;
            p.Range.InsertParagraphAfter();
            p = doc.Content.Paragraphs.Add();
            Word.Table table = doc.Tables.Add(p.Range, 2, 6);           
            table.Borders.Enable = 1;
            table.Cell(1, 1).Range.Text = "Ship's type";
            table.Cell(1, 2).Range.Text = "Sail's type";
            table.Cell(1,3).Range.Text = "Team's id";
            table.Cell(1,4).Range.Text = "Date of begin";
            table.Cell(1,5).Range.Text = "Date of end";
            table.Cell(1,6).Range.Text = "Crew number";


            table.Cell(2, 1).Range.Text = " " + order.Info.Ships_type;
            table.Cell(2, 2).Range.Text = " " + order.Info.Sails_type;
            
            table.Cell(2, 3).Range.Text = " " + order.Info.Team_id;
            table.Cell(2, 4).Range.Text = " " + order.Info.Date_begin;
            table.Cell(2,5).Range.Text = " " + order.Info.Date_end;
            table.Cell(2, 6).Range.Text = " " + order.Info.Crew_number;

            doc.Save();
            app.Visible = true;

        }

        private void serialize_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==0)return;
            int nom=(int)dataGridView1.SelectedRows[0].Cells["order_number"].Value;
            order_serialized order = create_order(nom);
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName,FileMode.Create);
                SoapFormatter serialize = new SoapFormatter();
                serialize.Serialize(fs,order);
                fs.Close();
                MessageBox.Show("Сформирован файл "+dlg.FileName);
            }
        }

        private void gen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int nom=(int)dataGridView1.SelectedRows[0].Cells["order_number"].Value;
            order_serialized order = create_order(nom);
            SoapFormatter serialize = new SoapFormatter();
            MemoryStream ms=new MemoryStream();
            serialize.Serialize(ms,order);

            ms.Seek(0,SeekOrigin.Begin);
            byte[] message=new byte[ms.Length];
            ms.Read(message,0,(int)ms.Length);
            DSACryptoServiceProvider dsa = new DSACryptoServiceProvider();
            byte[] signature = dsa.SignData(message);
            string key = dsa.ToXmlString(true);
            BinaryWriter binwrite = new BinaryWriter(new FileStream("order"+order.Order_number+".dat",FileMode.Create));
            binwrite.Write(key);
            binwrite.Write(signature.Length);
            binwrite.Write(signature);
            binwrite.Close();
            MessageBox.Show("Создана цифровая подпись");

        }

        private void verify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int nom = (int)dataGridView1.SelectedRows[0].Cells["order_number"].Value;
            order_serialized order = create_order(nom);
            SoapFormatter serialize = new SoapFormatter();
            MemoryStream ms = new MemoryStream();
            serialize.Serialize(ms, order);

            ms.Seek(0, SeekOrigin.Begin);
            byte[] message = new byte[ms.Length];
            ms.Read(message, 0, (int)ms.Length);
            BinaryReader binread = new BinaryReader(new FileStream("order"+nom+".dat",FileMode.Open));
            string key = binread.ReadString();
            int new_sign = binread.ReadInt32();
            byte[] bin_sign = binread.ReadBytes(new_sign);
            binread.Close();
            DSACryptoServiceProvider dsa = new DSACryptoServiceProvider();
            dsa.FromXmlString(key);
            if (dsa.VerifyData(message, bin_sign))
                MessageBox.Show("Верификация заказа пройдена");
            else MessageBox.Show("Верификация не пройдена");


        }
    }

}
