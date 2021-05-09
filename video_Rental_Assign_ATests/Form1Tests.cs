using Microsoft.VisualStudio.TestTools.UnitTesting;
using video_Rental_Assign_A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_Rental_Assign_A.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Customer cust = new Customer();
            if (cust.Insrt("Hrry", "Hry@gmil.com", "567", "NZ"))
            {
                Assert.IsTrue(true);
            }
            else {

                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            Video cust = new Video();
            if (cust.Insrt("Test","4.5","2019","5","4","ok","comedt"))
            {
                Assert.IsTrue(true);
            }
            else
            {

                Assert.IsTrue(false);
            }
        }
    }
}