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
        { "A0009", "06/02/2019", "06/05/2019" },
        { "A0010", "09/10/2019", "09/11/2019" },
        { "A0011", "10/22/2019", "10/31/2019" },
        { "A0006", "01/11/2019", "01/13/2019" },
        { "A0012", "02/19/2020", "02/21/2020" },
        { "A0013", "11/12/2019", "11/19/2019" },
        { "A0014", "04/13/2020", "04/16/2020" },
        { "A0015", "06/18/2020", "06/23/2020" },
        { "A0016", "08/10/2019", "08/11/2019" },
        { "A0017", "03/08/2020", "03/14/2020" },
        { "A0018", "08/08/2019", "08/17/2019" },
        { "A0019", "12/05/2019", "12/12/2019" },
        { "A0020", "12/19/2019", "12/27/2019" },
        { "A0020", "12/19/2020", "12/27/2020" }};
        static DateTime dpick, ddrop;
        static DateTime localDate = DateTime.Now;
        static void Main(string[] args)
        {
            Console.Write("Please enter pick-up date <MM/dd/yyyy> :");
            string pickup = Console.ReadLine();
            Console.Write("Please enter drop-off date <MM/dd/yyyy> :");
            string dropoff = Console.ReadLine();
      

            try
            {
                string.Format("{MM/dd/yyyy}");
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

            Console.WriteLine("Your pick-update is " + dpick.ToString("MM/dd/yyyy"));
            Console.WriteLine("Your pick-update is " + ddrop.ToString("MM/dd/yyyy"));
            Console.WriteLine("===========================================================================");
            Finddate(dpick, ddrop);
        }
        static string Finddate(DateTime pick, DateTime drop)
        {
            
            int i, j, k, available = 0, dup=0;
            string z = "";
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
                for (k = 0; k <= i-1; k++)
                {
                    if (base_data[i, 0] == base_data[k, 0])
                    {
                        dup = 1;
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
