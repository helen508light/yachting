using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace yachting_firm
{
   
    [Serializable]
class order_info
{
        string ships_type;
        int team_id;
        DateTime date_begin;
        DateTime date_end;
        int crew_number;
        string sails_type;

        public order_info()
        {
            ships_type = "";
            team_id=0;
            date_begin = DateTime.Today;
            date_end = DateTime.Today;
            crew_number = 0; sails_type = "";            
        }
        public order_info(string ships_type,int team_id,DateTime date_begin,DateTime date_end,int crew_number,string sails_type)
        {
            this.ships_type = ships_type;
            this.team_id = team_id;
            this.date_begin = date_begin;
            this.date_end = date_end;
            this.crew_number = crew_number;
            this.sails_type = sails_type;

        }
        public string Ships_type
        {
            get { return ships_type; }
            set { ships_type = value; }
        }
        public int Team_id
        {
            get { return team_id; }
            set { team_id = value; }
        }
        public DateTime Date_begin
        {
            get { return date_begin; }
            set { date_begin = value; }
        }
        public DateTime Date_end
        {
            get { return date_end; }
            set { date_end = value; }

        }
        public int Crew_number
        {
            get { return crew_number; }
            set { crew_number = value; }
        }
        public string Sails_type
        {
            get { return sails_type; }
            set { sails_type = value; }
        }

}
    [Serializable]
    class order_serialized
    {
        DateTime order_date;
        int order_number;
        double total_cost;
        int total_discount;
        int number_of_people;
        order_info info;

        public order_serialized()
        {
            order_date =DateTime.Today;
            order_number=0;
            total_cost = 0;
            total_discount = 0;
            number_of_people = 0;
            info = null;

        }
        public order_serialized(DateTime date,int order_number,double total_cost,int total_discount,int number_of_people,order_info info)
        {
            order_date = date;
            this.order_number=order_number;
            this.total_cost = total_cost;
            this.total_discount = total_discount;
            this.number_of_people = number_of_people;
            this.info = info;
        }

        public int Order_number
        {
            get { return order_number; }
            set { order_number = value; }
        }

        public DateTime Order_date
        {
            get { return order_date; }
            set { order_date = value; }

        }
        public double Total_cost
        {
            get { return total_cost; }
            set { total_cost = value; }
        }
        public int Total_discount
        {
            get { return total_discount; }
            set { total_discount = value; }
        }
        public int Number_of_people
        {
            get { return number_of_people; }
            set { number_of_people = value; }
        }
        public order_info Info
        {
            get { return info; }
            set { info = value; }
        }
        
    }
}
