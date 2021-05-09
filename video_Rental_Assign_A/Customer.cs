using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_Rental_Assign_A
{
    public class Customer : DBSetting
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }

        public String address { get; set; }


        //this code is used to insert the details 
        public Boolean Insrt(String nm,String Emil, String ph, String address) {
            String dt = "insert into Customer(Name,Email,Phone,address) values('"+nm+"','"+Emil+"','"+ph+"','"+ address+ "')";
            CmdQuery(dt);
            return true;
        }

        //this code is used to insert the details 
        public Boolean DelCustomer(int id)
        {
            String dt = "Delete from  Customer where CustomerID="+id+"";
            CmdQuery(dt);
            return true;
        }


        //this code is used to insert the details 
        public Boolean UpdtCustomer(String nm, String Emil, String ph, String address, int id)
        {
            String dt = "Update Customer set Name='" + nm + "',Email='" + Emil + "',Phone='" + ph + "',address='" + address + "' where CustomerID=" + id + "";
            CmdQuery(dt);
            return true;
        }

    }
}
