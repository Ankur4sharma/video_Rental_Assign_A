using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_Rental_Assign_A
{
    public partial class Form1 : Form
    {
        Video video = new Video();

        Customer customer = new Customer();

        Booking booking = new Booking();
        int bookingID = 0,selectedOption=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void customer_add_button_Click(object sender, EventArgs e)
        {
            //this code is used to insert the vlue to dtbse 
            if (customer_name_box.Text.Equals("") && customer_Email_box.Text.Equals("") && customer_ph_box.Text.Equals("") && address_box_customer.Text.Equals(""))
            {
                MessageBox.Show("Enter Proper Details to fill the details");
            }
            else {
                if (customer.Insrt(customer_name_box.Text.ToString(), customer_Email_box.Text.ToString(), customer_ph_box.Text.ToString(), address_box_customer.Text.ToString()))
                {
                    MessageBox.Show("Record is Inserted  ");
                    customer_name_box.Text = "";
                    customer_Email_box.Text = "";
                    customer_ph_box.Text = "";
                    address_box_customer.Text = "";
                    customer_id_box.Text = "";
                }
                else {
                    MessageBox.Show("Check Details Once ");
                }
            }
        }

        private void cutomer_delete_button_Click(object sender, EventArgs e)
        {
            //this code is used to insert the vlue to dtbse 
            if (customer_name_box.Text.Equals("") && customer_Email_box.Text.Equals("") && customer_ph_box.Text.Equals("") && address_box_customer.Text.Equals("") && customer_id_box.Text.Equals(""))
            {
                MessageBox.Show("Enter Proper Details to fill the details");
            }
            else
            {
                if (customer.DelCustomer(Convert.ToInt32(customer_id_box.Text)))
                {
                    MessageBox.Show("Record is Deleted");
                    customer_name_box.Text = "";
                    customer_Email_box.Text = "";
                    customer_ph_box.Text = "";
                    address_box_customer.Text = "";
                    customer_id_box.Text = "";
                

                }
                else
                {
                    MessageBox.Show("Check Details Once ");
                }
            }
        }

        private void update_customer_button_Click(object sender, EventArgs e)
        {
            //this code is used to insert the vlue to dtbse 
            if (customer_name_box.Text.Equals("") && customer_Email_box.Text.Equals("") && customer_ph_box.Text.Equals("") && address_box_customer.Text.Equals(""))
            {
                MessageBox.Show("Enter Proper Details to fill the details");
            }
            else
            {
                if (customer.UpdtCustomer(customer_name_box.Text.ToString(), customer_Email_box.Text.ToString(), customer_ph_box.Text.ToString(), address_box_customer.Text.ToString(), Convert.ToInt32(customer_id_box.Text)))
                {
                    MessageBox.Show("Record is Updated ");
                    customer_name_box.Text = "";
                    customer_Email_box.Text = "";
                    customer_ph_box.Text = "";
                    address_box_customer.Text = "";
                    customer_id_box.Text = "";
                }
                else
                {
                    MessageBox.Show("Check Details Once ");
                }
            }
        }

        private void issue_mov_Click(object sender, EventArgs e)
        {
            if (customer_id_box.Text.Equals("") && movie_id_box.Text.Equals(""))
            {
                MessageBox.Show("must need to select the details ");
            }
            else {
                if (booking.Insrt(Convert.ToInt32(customer_id_box.Text.ToString()),Convert.ToInt32(movie_id_box.Text.ToString()),issueDT.Text)) {
                    
                    customer_id_box.Text = "";
                    customer_name_box.Text = "";
                    customer_Email_box.Text = "";
                    customer_ph_box.Text = "";
                    address_box_customer.Text = "";


                    movie_id_box.Text = "";
                    title.Text = "";
                    video_rating.Text = "";
                    realease_year.Text = "";
                    cost.Text = "";
                    copies.Text = "";
                    plot.Text = "";
                    genre.Text = "";


                    MessageBox.Show("Movie is Booked ");
                }
                else
                {
                    MessageBox.Show("Must Need to select the Details");

                }

            
            }
        }

        private void del_movie_Click(object sender, EventArgs e)
        {
            if (customer_id_box.Text.Equals("") && movie_id_box.Text.Equals(""))
            {
                MessageBox.Show("must need to select the details ");
            }
            else
            {
                if (booking.DelBooking(Convert.ToInt32(bookingID)))
                {

                    customer_id_box.Text = "";
                    customer_name_box.Text = "";
                    customer_Email_box.Text = "";
                    customer_ph_box.Text = "";
                    address_box_customer.Text = "";


                    movie_id_box.Text = "";

                    title.Text = "";
                    video_rating.Text = "";
                    realease_year.Text = "";
                    cost.Text = "";
                    copies.Text = "";
                    plot.Text = "";
                    genre.Text = "";

                    MessageBox.Show("Booked Movie is Deleted ");
                }
                else
                {
                    MessageBox.Show("Must Need to select the Details");

                }


            }
        }

        private void return_mov_Click(object sender, EventArgs e)
        {
            if (customer_id_box.Text.Equals("") && movie_id_box.Text.Equals(""))
            {
                MessageBox.Show("must need to select the details ");
            }
            else
            {
                int ct = booking.returnBooking(Convert.ToInt32(customer_id_box.Text.ToString()), Convert.ToInt32(movie_id_box.Text.ToString()), issueDT.Text, returnDT.Text, Convert.ToInt32(bookingID));
                

                    customer_id_box.Text = "";
                    customer_name_box.Text = "";
                    customer_Email_box.Text = "";
                    customer_ph_box.Text = "";
                    address_box_customer.Text = "";


                    movie_id_box.Text = "";
                    title.Text = "";
                    video_rating.Text = "";
                    realease_year.Text = "";
                    cost.Text = "";
                    copies.Text = "";
                    plot.Text = "";
                    genre.Text = "";


                    MessageBox.Show("Booked Movie is Returned  and Charges  is "+ct);

                
                

            }
        }

        private void adding_video_button_Click(object sender, EventArgs e)
        {
            if (title.Text.Equals("") && realease_year.Text.Equals("") && video_rating.Text.Equals("") && cost.Text.Equals("") && copies.Text.Equals("") && plot.Text.Equals("") && genre.Text.Equals(""))
            {
                MessageBox.Show("Need to fill Details ");
            }
            else {
                if (video.Insrt(title.Text, video_rating.Text, realease_year.Text, cost.Text, copies.Text, plot.Text, genre.Text))
                {
                    MessageBox.Show("Video Record is Stored ");
                    
                    title.Text = "";
                    video_rating.Text = "";
                    realease_year.Text = "";
                    cost.Text = "";
                    copies.Text = "";
                    plot.Text = "";
                    genre.Text = "";
                    movie_id_box.Text = "";

                }
                else {
                    MessageBox.Show("Must need to check once ");
                }
            
            }


        }

        private void video_del_Click(object sender, EventArgs e)
        {
            if (title.Text.Equals("") && realease_year.Text.Equals("") && video_rating.Text.Equals("") && cost.Text.Equals("") && copies.Text.Equals("") && plot.Text.Equals("") && genre.Text.Equals(""))
            {
                MessageBox.Show("Need to fill Details ");
            }
            else
            {
                if (video.DelVideo(Convert.ToInt32(movie_id_box.Text)))
                {
                    MessageBox.Show("Video Record is Deleted ");

                    title.Text = "";
                    video_rating.Text = "";
                    realease_year.Text = "";
                    cost.Text = "";
                    copies.Text = "";
                    plot.Text = "";
                    genre.Text = "";
                    movie_id_box.Text = "";

                }
                else
                {
                    MessageBox.Show("Must need to check once ");
                }

            }

        }

        private void video_update_Click(object sender, EventArgs e)
        {

            if (title.Text.Equals("") && realease_year.Text.Equals("") && video_rating.Text.Equals("") && cost.Text.Equals("") && copies.Text.Equals("") && plot.Text.Equals("") && genre.Text.Equals(""))
            {
                MessageBox.Show("Need to fill Details ");
            }
            else
            {
                if (video.UpdtVideo(title.Text, video_rating.Text.ToString(), realease_year.Text, cost.Text, copies.Text, plot.Text, genre.Text,Convert.ToInt32(movie_id_box.Text)))
                {
                    MessageBox.Show("Video Record is updated");

                    title.Text = "";
                    video_rating.Text = "";
                    realease_year.Text = "";
                    cost.Text = "";
                    copies.Text = "";
                    plot.Text = "";
                    genre.Text = "";
                    movie_id_box.Text = "";

                }
                else
                {
                    MessageBox.Show("Must need to check once ");
                }

            }

        }

        // cutomer button showing data of all customers 

        private void customer_buttn_Click(object sender, EventArgs e)
        {
            selectedOption = 1;
            DataTable tbl = new DataTable();
            tbl= customer.CmdRecord("select * from Customer");
            dgvRecord.DataSource = tbl; 

        }

        // video button showing data of all videos

        private void video_buttn_Click(object sender, EventArgs e)
        {
            selectedOption = 2;
            DataTable tbl = new DataTable();
            tbl = customer.CmdRecord("select * from Video");
            dgvRecord.DataSource = tbl;
        }

        private void dgvRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedOption == 1) {

                customer_id_box.Text = dgvRecord.CurrentRow.Cells[0].Value.ToString();
                customer_name_box.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                customer_Email_box.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                customer_ph_box.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                address_box_customer.Text = dgvRecord.CurrentRow.Cells[4].Value.ToString();

            }
            else if (selectedOption == 2) {
                movie_id_box.Text = dgvRecord.CurrentRow.Cells[0].Value.ToString();
                title.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                video_rating.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                realease_year.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();
                cost.Text = dgvRecord.CurrentRow.Cells[4].Value.ToString();
                copies.Text = dgvRecord.CurrentRow.Cells[5].Value.ToString();
                plot.Text = dgvRecord.CurrentRow.Cells[6].Value.ToString();
                genre.Text = dgvRecord.CurrentRow.Cells[7].Value.ToString();


            } else if (selectedOption == 3) {
                bookingID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                customer_id_box.Text = dgvRecord.CurrentRow.Cells[1].Value.ToString();
                movie_id_box.Text = dgvRecord.CurrentRow.Cells[2].Value.ToString();
                issueDT.Text = dgvRecord.CurrentRow.Cells[3].Value.ToString();


            }
            selectedOption = 0;
        }

        // price is set according to the realase year

        private void realease_year_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(realease_year.Text);
                int cst = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cst = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cst = 5;
                }

                 cost.Text= "" + cst;
            }
            catch (Exception ex)
            {

            }

        }

        private void cost_TextChanged(object sender, EventArgs e)
        {

        }

        // showing popular movie

        private void pop_movie_button_Click(object sender, EventArgs e)
        {
            //compare the booking and fetch the most viewed movie
            DataTable tblData = new DataTable();
           

            tblData = booking.CmdRecord("select * from Video");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = booking.CmdRecord("select * from Booking where VideoID='" + tblData.Rows[x]["VideoID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Movie is " + Title);

        }

        // show popular customer

        private void pop_customer_button_Click(object sender, EventArgs e)
        {
            //compare the booking and fetch the most viewed movie
            DataTable tblData = new DataTable();


            tblData = booking.CmdRecord("select * from Customer");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = booking.CmdRecord("select * from Booking where CustomerID='" + tblData.Rows[x]["CustomerID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Customer is " + Title);

        }

        private void rental_buttn_Click(object sender, EventArgs e)
        {
            selectedOption = 3;
            DataTable tbl = new DataTable();
            tbl = customer.CmdRecord("select * from Booking");
            dgvRecord.DataSource = tbl;
        }
    }
}
