using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter pick-up date <MM/dd/yyyy> :");
            string pickup = Console.ReadLine();
            Console.Write("Please enter drop-off date <MM/dd/yyyy> :");
            string dropoff = Console.ReadLine();

            DateTime dpick, ddrop;
            dpick = Convert.ToDateTime(pickup);
            ddrop = Convert.ToDateTime(dropoff);
            Console.WriteLine(dpick.ToString("MM/dd/yyyy"));
            Console.WriteLine(ddrop.ToString("MM/dd/yyyy"));

            Finddate(dpick, ddrop);
        }
        static string Finddate(DateTime pick, DateTime drop)
        {
            string[,] base_data = {{ "A0001", "05/02/2019", "05/05/2019" },
                                    { "A0002", "02/05/2019", "02/08/2019" },
                                    { "A0003", "10/20/2019", "10/25/2019" },
                                    { "A0004", "11/14/2019", "11/18/2019" },
                                    { "A0005", "03/08/2019", "03/09/2019" },
                                     { "A0005", "03/10/2019", "03/15/2019" }};

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
