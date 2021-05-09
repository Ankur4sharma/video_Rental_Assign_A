using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_Rental_Assign_A
{
  public  class Video: DBSetting
    {

        public string Name { get; set; }
        
        public string Rate { get; set; }
        
        public string Year { get; set; }

        public string Cost { get; set; }

        public string Copies { get; set; }

        public string Plot { get; set; }

        public string Genre { get; set; }


        //this code is used to insert the details 
        public Boolean Insrt(string nm, string rte, string yer, string cost,string copies,string plot,string genre)
        {
            String dt = "insert into Video(Name,Rate,Year,Cost,Copies,Plot,Genre) values('" + nm + "','" + rte + "','" + yer + "','" + cost + "','"+copies+"','"+plot+"','"+genre+"')";
            CmdQuery(dt);
            return true;
        }

        //this code is used to insert the details 
        public Boolean DelVideo(int id)
        {
            String dt = "Delete from  Video where VideoID=" + id + "";
            CmdQuery(dt);
            return true;
        }


        //this code is used to insert the details 
        public Boolean UpdtVideo(string nm, string rte, string yer, string cost, string copies, string plot, string genre, int id)
        {
            String dt = "Update Video set Name='" + nm + "',Rate='" + rte + "',Year='" + yer + "',Cost='" + cost + "',Copies='" + copies + "',Plot='" + plot + "', Genre='" + genre + "' where VideoID=" + id + "";
            CmdQuery(dt);
            return true;
        }


    }
}
