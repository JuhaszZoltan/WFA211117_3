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
        private static Color[] NumCols = new Color[]
        {
            Color.Empty, Color.Blue, Color.Green, Color.Red, Color.Indigo,
            Color.DarkRed, Color.DarkCyan, Color.Black, Color.Gray
        };

        static Random rnd = new Random();
        public AknaButton[,] Matrix { get; set; }

        public int Szelesseg { get; set; }
        public int Magassag { get; set; }
        public int Scale { get; set; }
        public int NoAkna { get; set; }

        public FrmMain(int szelesseg, int magassag, int scale, int noAkna)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
            Scale = scale;
            NoAkna = noAkna;

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            SetUpMatrix(Magassag, Szelesseg);
            SetUpMines(NoAkna);
            this.CenterToScreen();
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
                        Font = new Font(
                            familyName: "Consolas",
                            emSize: Scale / 2,
                            style: FontStyle.Bold),
                        BackgroundImageLayout = ImageLayout.Zoom,
                    };

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
                (sender as AknaButton).BackgroundImage = Properties.Resources.flag;
            }
            else if (e.Button is MouseButtons.Left)
            {
                (sender as AknaButton).IsStep = true;

                if ((sender as AknaButton).Mine)
                {
                    (sender as AknaButton).BackgroundImage = Properties.Resources.mine;
                    (sender as AknaButton).BackColor = Color.Red;
                    Lose();
                }
                else
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

                    if (dbAkna == 0)
                    {
                        (sender as Button).BackColor = Color.White;
                        for (int x = minx; x <= maxx; x++)
                        {
                            for (int y = miny; y <= maxy; y++)
                            {
                                if (x != sx || y != sy)
                                {
                                    if (!Matrix[x, y].IsStep) FrmMain_MouseClick(Matrix[x, y], new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                                }
                            }
                        }
                    }
                    else
                    {
                        (sender as AknaButton).ForeColor = NumCols[dbAkna];
                        (sender as AknaButton).Text = $"{dbAkna}";
                    }
                }
            }
            if (Win()) MessageBox.Show("grat, majd ide még jön a pontszám!");
        }

        private void Lose()
        {
            foreach (var ab in Matrix)
            {
                if (ab.Flag && !ab.Mine)
                {
                    ab.BackColor = Color.Red;
                }
                else if (!ab.Flag && ab.Mine)
                {
                    ab.BackgroundImage = Properties.Resources.mine;
                }
            }

            if (MessageBox.Show(
                    caption: "Vesztettél",
                    text: "hát ez nem jött össze",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private bool Win()
        {
            foreach (var ab in Matrix)
            {
                if (ab.Mine && !ab.Flag) return false;
            }
            return true;
        }
    }
}
