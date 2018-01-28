using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace yachting_firm
{
   
    [Serializable]
    class order_serialized
    {
        DateTime order_date;
        int order_number;
        double total_cost;
        int total_discount;
        int number_of_people;
        
        public order_serialized()
        {
            order_date =DateTime.Today;
            order_number=0;
            total_cost = 0;
            total_discount = 0;
            number_of_people = 0;
            

        }
        public order_serialized(DateTime date,int order_number,double total_cost,int total_discount,int number_of_people)
        {
            order_date = date;
            this.order_number=order_number;
            this.total_cost = total_cost;
            this.total_discount = total_discount;
            this.number_of_people = number_of_people;
            
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

        
    }
}
