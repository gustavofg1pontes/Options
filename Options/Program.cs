namespace Options
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Options opcoes = new Options();

            Screen Init = ScreenManager.TelaInicial(opcoes);

            Init.Init();
            Init.AddOpt();

            opcoes.EscreveOpcoes();

        }
    }
}