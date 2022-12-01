using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class Option
    {
        public Option(String texto, Screen tela)
        {
            Texto = texto;
            Tela = tela;
        }
        public Option() { }

        public String Texto { get; set; }
        public Screen Tela { get; set; }
    }
}
