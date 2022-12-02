using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class Options
    {
        static int opcaoMarcada = 0;
        Option opcaoSelect = new Option();
        List<Option> Opcoes = new List<Option>();
        public Options() { }

        public void AddOpcao(Option opcao)
        {
            Opcoes.Add(opcao);
        }

        public void EscreveOpcoes()
        {
            Console.SetCursorPosition(0, 4);
            foreach (Option opc in Opcoes)
            {
                if(Opcoes.IndexOf(opc) == opcaoMarcada) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(opc.Texto.ToString());
                Console.ForegroundColor = ConsoleColor.White;
            }
            EventListener();
        }

        public void LimparOpcoes()
        {
            Opcoes = new List<Option>();
        }

        public void EventListener()
        {
            while (true && Opcoes.Count > 0)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (opcaoMarcada > 0) opcaoMarcada--;
                            EscreveOpcoes();
                            break;
                        case ConsoleKey.DownArrow:
                            if (opcaoMarcada < Opcoes.Count - 1) opcaoMarcada++;
                            EscreveOpcoes();
                            break;
                        case ConsoleKey.Enter:
                            opcaoSelect = Opcoes[opcaoMarcada];
                            LimparOpcoes();
                            opcaoSelect.Tela.Init();
                            opcaoSelect.Tela.AddOpt();
                            EscreveOpcoes();
                            break;
                    }
                }
            }
        }

    }
}
