using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_a
{
    class Program
    {
        static string[,] base_data = {
        { "A0001", "01/01/2020", "01/05/2020" },
        { "A0002", "01/10/2020", "01/13/2020" },
        { "A0003", "01/20/2020", "01/22/2020" },
        { "A0004", "02/09/2019", "02/16/2019" },
        { "A0005", "07/10/2019", "07/14/2019" },
        { "A0006", "03/10/2019", "03/15/2019" },
        { "A0007", "05/04/2019", "05/09/2019" },
        { "A0008", "05/21/2019", "05/24/2019" },
        { "A0011", "09/02/2019", "09/09/2019" },
        { "A0009", "06/02/2019", "06/05/2019" },
        { "A0010", "09/10/2019", "09/11/2019" },
        { "A0011", "10/22/2019", "10/31/2019" },
        { "A0012", "02/19/2020", "02/21/2020" },
        { "A0011", "12/11/2019", "12/17/2019" },
        { "A0013", "11/12/2019", "11/19/2019" },
        { "A0014", "04/13/2020", "04/16/2020" },
        { "A0015", "06/18/2020", "06/23/2020" },
        { "A0016", "08/10/2019", "08/11/2019" },
        { "A0017", "03/08/2020", "03/14/2020" },
        { "A0018", "08/08/2019", "08/17/2019" },
        { "A0019", "12/05/2019", "12/12/2019" },
        { "A0020", "12/19/2019", "12/27/2019" },
        { "A0020", "11/12/2019", "11/16/2019" }};
        

        static DateTime dpick, ddrop,d;
        static DateTime localDate = DateTime.Now;
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================================================================");
            Console.WriteLine();
            Console.WriteLine("                                       WELCOME TO HIRING CARS                                             ");
            Console.WriteLine("                             Choose the date preferably to rent a car.                                    ");
            Console.WriteLine("                             Simply Choose to book the available car.                                       ");
            Console.WriteLine("                                        Enjoy your time");
            Console.WriteLine();
            Console.WriteLine("==========================================================================================================");
            Console.WriteLine();
            Console.WriteLine("-Put the date in this format MM/dd/yyyy in AD(2001,2002,etc.)");
            Console.WriteLine("-Pick-up date must be not over a year");
            Console.WriteLine();
            Console.Write("Please enter pick-up date :");
            string pickup = Console.ReadLine();
            Console.Write("Please enter drop-off date :");
            string dropoff = Console.ReadLine();

            try
            {
                dpick = Convert.ToDateTime(pickup);
                ddrop = Convert.ToDateTime(dropoff);

            }
            catch
            {
                Console.WriteLine("Error: Please check your date");
                Console.Write("Please enter pick-up date <MM/dd/yyyy> :");
                pickup = Console.ReadLine();
                Console.Write("Please enter drop-off date <MM/dd/yyyy> :");
                dropoff = Console.ReadLine();
            }

            bool r = (dpick - localDate).TotalDays < 365;
            if (r == true)
            {

            }
            else
            {
                Console.WriteLine("Please check your date. It must be not over a year.");
                dpick = new DateTime(2019, 15, 02);
            }
            Console.WriteLine();
            Console.WriteLine("==========================================================================================================");
            Console.WriteLine("                           Your pick-up date is " + dpick.ToString("MM/dd/yyyy"));
            Console.WriteLine("                           Your drop-off date is " + ddrop.ToString("MM/dd/yyyy"));
            Console.WriteLine("                                 List of available cars");

            Finddate(dpick, ddrop);
        }
        static string Finddate(DateTime pick, DateTime drop)
        {
            int i, j, k, available = 0, dup=0;
            string x = "";
            for (i = 0; i < base_data.GetLength(0); i++)
            {
                for (j = 1; j < base_data.GetLength(1)-1; j++)
                {

                    DateTime finding_p = Convert.ToDateTime(base_data[i, j]);
                    DateTime finding_d = Convert.ToDateTime(base_data[i, j+1]);
                    if (drop<finding_p&&pick<finding_p)
                    {
                        available = 0;
                    }
                    else if(pick>finding_d&&drop>finding_d)
                    {
                        available = 0;
                    }
                    else
                    {
                        available = 1;
                        
                    }
                   
                }
                for (k = 0; k <i; k++)
                {
                    if (base_data[i, 0] == base_data[k, 0])
                    {
                        dup = 1;
                        break;
                    }
                    else
                    {
                        dup = 0;
                    }
                }
                if (available == 0 && dup == 0)
                {
                    Console.WriteLine(base_data[i, 0]);
                }
            }
            return x;
        }
    }
}
