using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        public static void AddDriver()
        {
            BGlobalEntities ctx = new BGlobalEntities();

            Driver driver = new Driver();

            driver.Id_driver = 1;
            driver.Name = "Juancho";
            driver.DNI = "10548875";
            driver.Address = "Street";
            driver.Telephone = "31134000";
            driver.Number_card = "54712900";

            ctx.Drivers.Add(driver);

            ctx.SaveChanges();
        }

        static void Main(string[] args)
        {
            AddDriver();
        }
    }
}