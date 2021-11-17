using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA211117_3
{
    internal partial class FrmMain : Form
    {
        static Random rnd = new Random();
        public AknaButton[,] Matrix { get; set; }
        const int Scale = 50;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetUpMatrix(30, 20);
            SetUpMines(200);
        }

        private void SetUpMines(int noMine)
        {
            int c = 0;
            while (c < noMine)
            {
                int x = rnd.Next(Matrix.GetLength(0));
                int y = rnd.Next(Matrix.GetLength(1));

                if (!Matrix[x, y].Mine)
                {
                    Matrix[x, y].Mine = true;
                    c++;
                }
            }
        }

        private void SetUpMatrix(int col, int row)
        {
            Matrix = new AknaButton[col, row];

            for (int x = 0; x < Matrix.GetLength(0); x++)
            {
                for (int y = 0; y < Matrix.GetLength(1); y++)
                {
                    Matrix[x, y] = new AknaButton()
                    {
                        Bounds = new Rectangle(
                            x: x * Scale,
                            y: y * Scale,
                            width: Scale,
                            height: Scale),
                        PositionInMatrix = (x, y),
                    };
                    //Matrix[x, y].MouseClick += FrmMain_MouseClick;
                    Matrix[x, y].MouseDown += FrmMain_MouseClick;

                    Controls.Add(Matrix[x, y]);
                }
            }

        }

        private void FrmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right)
            {
                (sender as AknaButton).Flag = true;
                (sender as AknaButton).BackColor = Color.Yellow;
            }
            else if (e.Button is MouseButtons.Left && (sender as AknaButton).Mine)
            {
                //THE END
                MessageBox.Show("KABOOOOM!!!!!");
            }
            else if (e.Button is MouseButtons.Left && !(sender as AknaButton).Mine)
            {
                int sx = (sender as AknaButton).PositionInMatrix.X;
                int sy = (sender as AknaButton).PositionInMatrix.Y;


                int minx = Math.Max(sx - 1, 0);
                int maxx = Math.Min(sx + 1, Matrix.GetLength(0) - 1);
                int miny = Math.Max(sy - 1, 0);
                int maxy = Math.Min(sy + 1, Matrix.GetLength(1) - 1);

                int dbAkna = 0;

                for (int x = minx; x <= maxx; x++)
                {
                    for (int y = miny; y <= maxy; y++)
                    {
                        if (x != sx || y != sy)
                        {
                            if (Matrix[x, y].Mine) dbAkna++;
                        }
                    }
                }

                (sender as AknaButton).Text = $"{dbAkna}";
            }
            

        }
    }
}
