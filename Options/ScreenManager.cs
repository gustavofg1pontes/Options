using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class ScreenManager
    {
        public static Screen TelaInicial(Options opcoes)
        {
            return new Screen(() =>
            {
                Console.Clear();
                Console.WriteLine("oii");
            },
                () =>
                {
                    opcoes.AddOpcao(new Option("Teste", ScreenManager.Screen1(opcoes)));
                });
        }

        public static Screen Screen1(Options opcoes)
        {
            return new Screen(() =>
            {
                Console.Clear();
                Console.WriteLine("Gustavo");
            },
                () =>
                {
                    opcoes.AddOpcao(new Option("Cumprimentar", Cumprimentar(opcoes)));
                    opcoes.AddOpcao(new Option("Despedir", Despedir(opcoes)));
                    opcoes.AddOpcao(new Option("Voltar", TelaInicial(opcoes)));
                }
                );
        }

        public static Screen Cumprimentar(Options opcoes)
        {
            return new Screen(
                        () =>
                        {
                            Console.Clear();
                            Console.WriteLine("Oii");
                        }, () => {
                            opcoes.AddOpcao(new Option("Voltar", Screen1(opcoes)));
                        });
        }
        public static Screen Despedir(Options opcoes)
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
