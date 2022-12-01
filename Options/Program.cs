namespace Options
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Options opcoes = new Options();
            opcoes.AddOpcao(new Option("Teste", new Screen(
                () => {
                    Console.Clear();
                    Console.WriteLine("oi");
                },
                () =>
                {
                    opcoes.AddOpcao(new Option("oii", new Screen(
                        () => {
                            Console.Clear();
                            Console.WriteLine("oiia");
                            Console.ReadKey();
                        }, () => { })));
                    opcoes.AddOpcao(new Option("oii", new Screen(
                        () => {
                            Console.Clear();
                            Console.WriteLine("ola");
                            Console.ReadKey();
                        }, () => { })));
                }
                )));

            // opcoes.AddOpcao(new Option("Teste2"));
            //opcoes.AddOpcao(new Option("Teste3"));

            opcoes.EscreveOpcoes();

        }
    }
}