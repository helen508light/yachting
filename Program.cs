using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace yachting_firm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Create_new_XML();
             add_services(1, "walk", 800);
             add_services(2, "foto", 1000);
             add_services(3, "disco", 1400);
             add_services(4, "restaurant", 23456);
             add_clients_id(1231, "Alex_Alex_company", "89178765653", 12, "13jghft@mail.ru");
             add_clients_id(1222, "jANE_Jane", "+79864357322", 10, "h34hu23yh@yandex.ru");
             int[] ids = { 1, 2 };
             add_new_order(1222, 10000, false, true);
             add_serv_in_order(1, ids);
             int[] ids1 = { 2, 3, 4 };
             add_new_order(1231, 300000, true, true);
             int[] ids2 = { 4 };
             add_serv_in_order(2, ids1);
             add_new_order(1231, 123456, true, true);
             add_serv_in_order(3, ids2);
             DateTime dt1 = new DateTime(2015, 6, 23, 9, 0, 0);
             DateTime dt2 = new DateTime(2015, 6, 25, 9, 0, 0);

             add_info(1, "motor_boat", 55, dt1, dt2, 3, "NO");
             dt1 = new DateTime(2015, 7, 7, 7, 22, 0, 0);
             dt2 = new DateTime(2015, 7, 10, 20, 30, 0);
             add_info(2, "yacht", 56, dt1, dt2, 4, "");
             dt1 = new DateTime(2015, 8, 7, 7, 22, 0, 0);
             dt2 = new DateTime(2015, 8, 10, 20, 30, 0);
             add_info(3, "sails_yacht", 56, dt1, dt2, 2, "");*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public void add_new_order(int clients_id, int total_cost, bool legal_entity, bool services)
        {

            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);


            DataRow newrow = ds.Tables["yachting"].NewRow();

            newrow["order_number"] = ds.Tables["yachting"].Rows.Count + 1;
            int nom = (int)newrow["order_number"];
            newrow["order_date"] = DateTime.Today;
            DateTime date = (DateTime)newrow["order_date"];
            newrow["clients_id"] = clients_id;
            newrow["legal_entity"] = legal_entity;
            newrow["total_cost"] = total_cost;
            newrow["total_discount"] = 0;
            newrow["services"] = services;
            // if (services) add_serv_in_order(ds.Tables["yachting"].Rows.Count+1,ids);
            newrow["presents"] = "";
            ds.Tables["yachting"].Rows.Add(newrow);
            ds.WriteXml("yachting.xml", XmlWriteMode.WriteSchema);


        }


        static public void add_clients_id(int clients_id, string fio, string phone_number, int discount, string email)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);

            DataRow newrow = ds.Tables["clients"].NewRow();
            newrow["clients_id"] = clients_id;

            newrow["fio"] = fio;
            newrow["phone_number"] = phone_number;
            newrow["discount"] = discount;
            newrow["email"] = email;
            ds.Tables["clients"].Rows.Add(newrow);
            ds.WriteXml("yachting.xml", XmlWriteMode.WriteSchema);

        }

        public static void add_info(int order_number, string ships_type, int team_id, DateTime date_begin, DateTime date_end, int crew_number, string sails_type)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);

            DataRow newrow = ds.Tables["info"].NewRow();
            newrow["ships_type"] = ships_type;
            newrow["team_id"] = team_id;
            newrow["date_begin"] = date_begin;
            newrow["date_end"] = date_end;
            newrow["crew_number"] = crew_number;
            newrow["order_number"] = order_number;
            newrow["sails_type"] = sails_type;
            ds.Tables["info"].Rows.Add(newrow);
            ds.WriteXml("yachting.xml", XmlWriteMode.WriteSchema);
        }

        public static void add_services(int service_id, string service_name, double price)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);

            DataRow newrow = ds.Tables["services"].NewRow();
            newrow["service_id"] = service_id;
            newrow["service_name"] = service_name;
            newrow["price"] = price;
            ds.Tables["services"].Rows.Add(newrow);
            ds.WriteXml("yachting.xml", XmlWriteMode.WriteSchema);
        }

        public static void add_serv_in_order(int order_number, int[] ids)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);
            for (int i = 0; i < ids.Length; i++)
            {
                DataRow newrow = ds.Tables["services_in_order"].NewRow();
                newrow["service_id"] = ids[i];
                newrow["order_number"] = order_number;

                ds.Tables["services_in_order"].Rows.Add(newrow);
                ds.WriteXml("yachting.xml", XmlWriteMode.WriteSchema);
            }
        }

        static public void print(string name)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);
            foreach (DataRow dr in ds.Tables[name].Rows)
            {
                string str = "";
                foreach (DataColumn dc in ds.Tables[name].Columns)
                    str += (dc.Caption + ":" + dr[dc.Caption] + ";\t");
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }

        static public DataRow search_by_primary_key(string table_name, int key_value)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);
            return ds.Tables[table_name].Rows.Find
            (new object[] { key_value });
        }
        static public DataRow[] search_by_external_key_child(DataRow dr, string relation_name)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);
            return dr.GetChildRows(relation_name);
        }
        static public DataRow[] searc_by_external_key_parents(DataRow dr, string relation_name)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);
            return dr.GetParentRows(relation_name);
        }

        static public DataRow[] search_by_conditional(string table_name, string condition)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);
            return ds.Tables[table_name].Select(condition);
        }

        static public void Delete_row(string table_name, int key_value)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("yachting.xml", XmlReadMode.ReadSchema);

            DataRow dr = ds.Tables[table_name].Rows.Find
            (new object[] { key_value });
            dr.Delete();
        }

        static public void Create_new_XML()
        {
            DataSet ds = new DataSet();//create new collection of data

            DataTable yachting = new DataTable("yachting");
            //Main table
            ds.Tables.Add(yachting);
            DataColumn dc = new DataColumn("order_number", Type.GetType("System.Int32"));
            ds.Tables["yachting"].Columns.Add(dc);
            dc = new DataColumn("order_date", Type.GetType("System.DateTime"));
            ds.Tables["yachting"].Columns.Add(dc);
            dc = new DataColumn("clients_id", Type.GetType("System.Int32"));
            ds.Tables["yachting"].Columns.Add(dc);
            dc = new DataColumn("legal_entity", Type.GetType("System.Boolean"));//legal entities pay more
            ds.Tables["yachting"].Columns.Add(dc);
            dc = new DataColumn("total_cost", Type.GetType("System.Double"));
            ds.Tables["yachting"].Columns.Add(dc);
            dc = new DataColumn("number_of_people", Type.GetType("System.Int32"));
            ds.Tables["yachting"].Columns.Add(dc);
            dc = new DataColumn("total_discount", Type.GetType("System.Int32"));
            ds.Tables["yachting"].Columns.Add(dc);
            dc = new DataColumn("services", Type.GetType("System.Boolean"));//?sevices 1 2 6
            ds.Tables["yachting"].Columns.Add(dc);
            dc = new DataColumn("presents", Type.GetType("System.String"));
            ds.Tables["yachting"].Columns.Add(dc);


            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["yachting"].Columns["order_number"];
            ds.Tables["yachting"].PrimaryKey = key;
            //Clients 
            ds.Tables.Add(new DataTable("clients"));
            dc = new DataColumn("clients_id", Type.GetType("System.Int32"));
            ds.Tables["clients"].Columns.Add(dc);
            dc = new DataColumn("fio", Type.GetType("System.String"));
            ds.Tables["clients"].Columns.Add(dc);
            dc = new DataColumn("phone_number", Type.GetType("System.String"));
            ds.Tables["clients"].Columns.Add(dc);
            dc = new DataColumn("discount", Type.GetType("System.String"));
            ds.Tables["clients"].Columns.Add(dc);
            dc = new DataColumn("email", Type.GetType("System.String"));
            ds.Tables["clients"].Columns.Add(dc);

            key = new DataColumn[1] { ds.Tables["clients"].Columns["clients_id"] };
            ds.Tables["clients"].PrimaryKey = key;

            ds.Tables.Add(new DataTable("info"));
            dc = new DataColumn("ships_type", Type.GetType("System.String"));
            ds.Tables["info"].Columns.Add(dc);
            dc = new DataColumn("team_id", Type.GetType("System.Int32"));
            ds.Tables["info"].Columns.Add(dc);
            dc = new DataColumn("date_begin", Type.GetType("System.DateTime"));
            ds.Tables["info"].Columns.Add(dc);
            dc = new DataColumn("date_end", Type.GetType("System.DateTime"));
            ds.Tables["info"].Columns.Add(dc);
            dc = new DataColumn("crew_number", Type.GetType("System.Int32"));
            ds.Tables["info"].Columns.Add(dc);
            dc = new DataColumn("order_number", Type.GetType("System.Int32"));
            ds.Tables["info"].Columns.Add(dc);
            dc = new DataColumn("sails_type", Type.GetType("System.String"));
            ds.Tables["info"].Columns.Add(dc);

            key = new DataColumn[1] { ds.Tables["info"].Columns["order_number"] };
            ds.Tables["info"].PrimaryKey = key;


            ds.Tables.Add(new DataTable("services"));
            //dc = new DataColumn("order_number", Type.GetType("System.Int32"));
            // ds.Tables["services"].Columns.Add(dc);
            dc = new DataColumn("service_id", Type.GetType("System.Int32"));
            ds.Tables["services"].Columns.Add(dc);
            dc = new DataColumn("service_name", Type.GetType("System.String"));
            ds.Tables["services"].Columns.Add(dc);
            dc = new DataColumn("price", Type.GetType("System.Double"));
            ds.Tables["services"].Columns.Add(dc);


            key = new DataColumn[1] { ds.Tables["services"].Columns["service_id"] };
            ds.Tables["services"].PrimaryKey = key;

            ds.Tables.Add(new DataTable("services_in_order"));
            dc = new DataColumn("service_id", Type.GetType("System.Int32"));
            ds.Tables["services_in_order"].Columns.Add(dc);
            dc = new DataColumn("order_number", Type.GetType("System.Int32"));
            ds.Tables["services_in_order"].Columns.Add(dc);

            key = new DataColumn[2] { ds.Tables["services_in_order"].Columns["service_id"], ds.Tables["services_in_order"].Columns["order_number"] };
            ds.Tables["services_in_order"].PrimaryKey = key;

            DataRelation rel = new DataRelation("clients_yachting",
                new DataColumn[] { ds.Tables["clients"].Columns["clients_id"] },
                new DataColumn[] { ds.Tables["yachting"].Columns["clients_id"] }
                );
            ds.Relations.Add(rel);

            DataRelation rel3 = new DataRelation("info_yachting",
              new DataColumn[] { ds.Tables["yachting"].Columns["order_number"] },

              new DataColumn[] { ds.Tables["info"].Columns["order_number"] }
              );
            ds.Relations.Add(rel3);

            DataRelation rel4 = new DataRelation("services_in_order_yachting",
              new DataColumn[] { ds.Tables["yachting"].Columns["order_number"] },

              new DataColumn[] { ds.Tables["services_in_order"].Columns["order_number"] }
              );
            ds.Relations.Add(rel4);

            DataRelation rel5 = new DataRelation("services_in_order_services",
              new DataColumn[] { ds.Tables["services"].Columns["service_id"] },

              new DataColumn[] { ds.Tables["services_in_order"].Columns["service_id"] }
              );
            ds.Relations.Add(rel5);

            ds.WriteXml("yachting.xml", XmlWriteMode.WriteSchema);
            //DataSet d=new DataSet(Database.`);

        }

    }
}
