using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class ScreenManager
    {
        public static Screen Screen1(Options opcoes)
        {
            return new Screen(() =>
            {
                Console.Clear();
                Console.WriteLine("oi");
            },
                () =>
                {
                    opcoes.AddOpcao(new Option("Cumprimentar", Cumprimentar()));
                    opcoes.AddOpcao(new Option("Despedir", Despedir()));
                }
                );
        }

        public static Screen Cumprimentar()
        {
            return new Screen(
                        () =>
                        {
                            Console.Clear();
                            Console.WriteLine("Oii");
                            Console.ReadKey();
                        }, () => { });
        }
        public static Screen Despedir()
        {
            return new Screen(
                        () =>
                        {
                            Console.Clear();
                            Console.WriteLine("Tchau");
                            Console.ReadKey();
                        }, () => { });
        }
    }
}
