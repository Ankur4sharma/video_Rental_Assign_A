using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_Rental_Assign_A
{
  public  class Booking:DBSetting
    {
        public int CustomerID { get; set; }
        public int VideoID { get; set; }

        public String bookDt { get; set; }

        public String returnDt { get; set; }



        //this code is used to insert the details 
        public Boolean Insrt(int customerID,int VideoID, String bookDt)
        {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from Video where VideoID=" + VideoID + "");
            int totlVido = Convert.ToInt32(tbl.Rows[0]["Copies"].ToString());

            DataTable tbl1 = new DataTable();
            tbl1 = CmdRecord("select * from Booking  where VideoID=" + VideoID + " and ReturnDT='booked'");
            int totlbooked = tbl.Rows.Count-1;
            if (totlbooked < totlVido)
            {
                DataTable tbl2 = new DataTable();
                tbl2 = CmdRecord("select * from Booking  where CustomerID=" +customerID + " and ReturnDT='booked'");
                int totlcust = tbl.Rows.Count - 1;
                if (totlcust <= 2)
                {
                    String dt = "insert into Booking(CustomerID,VideoID,BookDt,ReturnDt) values(" + customerID + "," + VideoID + ",'" + bookDt + "','booked')";
                    CmdQuery(dt);
                    return true;
                }
                else {
                    MessageBox.Show("YOu need to set your limit ");
                    return false;
                }

            }
            else {
                MessageBox.Show("all Sample Booked  ");
                return false;
            }

            
        }

        //this code is used to insert the details 
        public Boolean DelBooking(int id)
        {
            String dt = "Delete from  Booking where BookingID=" + id + "";
            CmdQuery(dt);
            return true;
        }


        //this code is used to insert the details 
        public int returnBooking(int customerID, int VideoID, String bookDt,String retDt, int id)
        {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from Video where VideoID=" + VideoID + "");
            int totlCost = Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());



            DateTime current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(bookDt);


            //get the difference in the days fromat
            String Daysdiff = (current_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


            int total = totlCost * Convert.ToInt32(DaysInterval);


            String dt = "update Booking set CustomerID=" + customerID + ",VideoID=" + VideoID + ",BookDt='" + bookDt + "',ReturnDt='"+retDt+ "' where BookingID=" + id + "";
            CmdQuery(dt);
            return total;
        }
    }
}
