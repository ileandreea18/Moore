using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeworkMoore
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Homework_Moore///
            string consol;
            double t;
            while(true)
            {
                Console.WriteLine("Introduceti un numar n pentru a afla cate procesoare se pot forma");
                consol = Console.ReadLine();
                if (double.TryParse(consol, out t))
                {
                    double a;
                    a = 1.5 * Math.Log(t, 2);
                    Console.WriteLine("Procesoarele vor fi mai dense de {0} ori in {1} ani", t, a);
                    break;

                }
                else
                {
                    Console.WriteLine("Introduceti un numar n care are mai multe zecimale dupa virgula");
                    Console.WriteLine("");
                }





            }
        }
    }
}
