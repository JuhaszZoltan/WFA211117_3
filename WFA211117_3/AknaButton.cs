using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA211117_3
{
    internal class AknaButton : Button
    {
        public (int X, int Y) PositionInMatrix { get; set; }
        public bool Mine { get; set; } = false;
        public bool Flag { get; set; } = false;
        public bool IsStep { get; set; } = false;
    }
}
