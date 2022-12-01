using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options
{
    public class Screen
    {
        public Screen(Action func, Action addOpt)
        {
            Init = func;
            AddOpt = addOpt;
        }

        public Action Init { get; set; }
        public Action AddOpt { get; set; }
    }
}
