namespace Options
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Options opcoes = new Options();
            opcoes.AddOpcao(new Option("Teste", ScreenManager.Screen1(opcoes)));

            opcoes.EscreveOpcoes();

        }
    }
}