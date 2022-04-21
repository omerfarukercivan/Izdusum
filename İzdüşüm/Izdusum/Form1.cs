using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izdusum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Drawing.Graphics GrafikCiz;
        Pen klm = new Pen(Color.Blue, 2);

        #region DEĞERLER
        double[,] Xekseni = new double[2, 4] { { 0, 0, 0, 1 }, 
                                               { 2, 0, 0, 1 } };

        double[,] Yekseni = new double[2, 4] { { 0, 0, 0, 1 },
                                               { 0, 2, 0, 1 } };

        double[,] Zekseni = new double[2, 4] { { 0, 0, 0, 1 }, 
                                               { 0, 0, 2, 1 } };

        double[,] geciciBKub = new double[8, 4];

        double[,] Tizometrik = new double[4, 4] { {  0.707,  -0.408, 0, 0 },
                                                  {  0,       0.816, 0, 0 },
                                                  { -0.707,  -0.408, 0, 0 },
                                                  {  0,       0,     0, 1 } };

        double[,] XcisimNokta = new double[8, 4] { { 0, 0, 0, 1 },   //A
                                                   { 1, 0, 0, 1 },   //B
                                                   { 1, 0, 1, 1 },   //C
                                                   { 0, 0, 1, 1 },   //D
                                                   { 0, 1, 0, 1 },   //E
                                                   { 1, 1, 0, 1 },   //F
                                                   { 1, 1, 1, 1 },   //G
                                                   { 0, 1, 1, 1 } }; //H

        double[,] Xkenar = new double[12, 2] { { 0, 1 }, 
                                               { 1, 2 }, 
                                               { 2, 3 }, 
                                               { 3, 0 }, 
                                               { 4, 5 }, 
                                               { 5, 6 }, 
                                               { 6, 7 }, 
                                               { 7, 4 }, 
                                               { 0, 4 }, 
                                               { 1, 5 }, 
                                               { 2, 6 }, 
                                               { 3, 7 } };

        double[,] Totele = new double[4, 4] { { 1, 0, 0, 0 }, 
                                              { 0, 1, 0, 0 }, 
                                              { 0, 0, 1, 0 }, 
                                              { 0, 0, 0, 1 } };

        double[,] Tolcekle = new double[4, 4] { { 1, 0, 0, 0 }, 
                                                { 0, 1, 0, 0 }, 
                                                { 0, 0, 1, 0 }, 
                                                { 0, 0, 0, 1 } };

        double[,] Xyeni = new double[8, 4];
        #endregion

        #region EKSEN ÇİZ
        private void btnIzoEksen_Click(object sender, EventArgs e)
        {
            double[,] geciciXekseni = new double[2, 4];
            double[,] geciciYekseni = new double[2, 4];
            double[,] geciciZekseni = new double[2, 4];

            int i, j, k;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    geciciXekseni[i, j] = 0;
                    geciciYekseni[i, j] = 0;
                    geciciZekseni[i, j] = 0;

                    for (k = 0; k < 4; k++)
                    {
                        geciciXekseni[i, j] += Xekseni[i, k] * Tizometrik[k, j];
                        geciciYekseni[i, j] += Yekseni[i, k] * Tizometrik[k, j];
                        geciciZekseni[i, j] += Zekseni[i, k] * Tizometrik[k, j];
                    }
                }
            }

            GrafikCiz.DrawLine(klm, KhesaplaX(geciciXekseni[0, 0]), KhesaplaY(geciciXekseni[0, 1]), 
                                    KhesaplaX(geciciXekseni[1, 0]), KhesaplaY(geciciXekseni[1, 1]));

            GrafikCiz.DrawLine(klm, KhesaplaX(geciciYekseni[0, 0]), KhesaplaY(geciciYekseni[0, 1]), 
                                    KhesaplaX(geciciYekseni[1, 0]), KhesaplaY(geciciYekseni[1, 1]));

            GrafikCiz.DrawLine(klm, KhesaplaX(geciciZekseni[0, 0]), KhesaplaY(geciciZekseni[0, 1]),
                                    KhesaplaX(geciciZekseni[1, 0]), KhesaplaY(geciciZekseni[1, 1]));
        }
        #endregion

        #region BİRİM KÜP ÇİZ
        private void btnBirim_Click(object sender, EventArgs e)
        {
            //double[,] geciciBKub = new double[8, 4];
            int i, j, k;

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    geciciBKub[i, j] = 0;

                    for (k = 0; k < 4; k++)
                    {
                        geciciBKub[i, j] += XcisimNokta[i, k] * Tizometrik[k, j];
                    }
                }
            }

            klm.Color = Color.BurlyWood;
            klm.Width = 1;

            for (i = 0; i < 12; i++)
            {
                GrafikCiz.DrawLine(klm, KhesaplaX(geciciBKub[Convert.ToInt16(Xkenar[i, 0]), 0]), KhesaplaY(geciciBKub[Convert.ToInt16(Xkenar[i, 0]), 1]),
                                        KhesaplaX(geciciBKub[Convert.ToInt16(Xkenar[i, 1]), 0]), KhesaplaY(geciciBKub[Convert.ToInt16(Xkenar[i, 1]), 1]));
            }
        }
        #endregion

        #region ÖTELE
        private void btnOtele_Click(object sender, EventArgs e)
        {
            if (txtx1.Text != "")
                Totele[3, 0] = Convert.ToDouble(txtx1.Text);
            if (txty1.Text != "")
                Totele[3, 1] = Convert.ToDouble(txty1.Text);
            if (txtz1.Text != "")
                Totele[3, 2] = Convert.ToDouble(txtz1.Text);

            double[,] gecici = new double[8, 4];
            int i, j, k;

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    gecici[i, j] = 0;

                    for (k = 0; k < 4; k++)
                    {
                        gecici[i, j] += XcisimNokta[i, k] * Totele[k, j];
                    }
                }
            }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    geciciBKub[i, j] = 0;

                    for (k = 0; k < 4; k++)
                    {
                        geciciBKub[i, j] += gecici[i, k] * Tizometrik[k, j];
                    }
                }
            }
            for (i = 0; i < 12; i++)
            {
                GrafikCiz.DrawLine(klm, KhesaplaX(geciciBKub[Convert.ToInt16(Xkenar[i, 0]), 0]), KhesaplaY(geciciBKub[Convert.ToInt16(Xkenar[i, 0]), 1]),
                                        KhesaplaX(geciciBKub[Convert.ToInt16(Xkenar[i, 1]), 0]), KhesaplaY(geciciBKub[Convert.ToInt16(Xkenar[i, 1]), 1]));
            }
        }
        #endregion

        #region ÖLÇEKLE
        private void btnOlcekle_Click(object sender, EventArgs e)
        {
            double[,] gecici = new double[8, 4];
            int i, j, k;

            if (txtx2.Text != "")
                Tolcekle[0, 0] = Convert.ToDouble(txtx2.Text);
            if (txty2.Text != "")
                Tolcekle[1, 1] = Convert.ToDouble(txty2.Text);
            if (txtz2.Text != "")
                Tolcekle[2, 2] = Convert.ToDouble(txtz2.Text);

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    gecici[i, j] = 0;

                    for (k = 0; k < 4; k++)
                    {
                        gecici[i, k] += XcisimNokta[i, k] * Tolcekle[k, j];
                    }
                }
            }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    geciciBKub[i, j] = 0;

                    for (k = 0; k < 4; k++)
                    {
                        geciciBKub[i, j] += gecici[i, k] * Tizometrik[k, j];
                    }
                }
            }

            for (i = 0; i < 12; i++)
            {
                GrafikCiz.DrawLine(klm, KhesaplaX(geciciBKub[Convert.ToInt16(Xkenar[i, 0]), 0]), KhesaplaY(geciciBKub[Convert.ToInt16(Xkenar[i, 0]), 1]),
                                        KhesaplaX(geciciBKub[Convert.ToInt16(Xkenar[i, 1]), 0]), KhesaplaY(geciciBKub[Convert.ToInt16(Xkenar[i, 1]), 1]));
            }
        }
        #endregion

        #region ÇİZİM ALANI
        private int KhesaplaX(double geciciX)
        {
            return Convert.ToInt32(450 + (100 * geciciX));
        }

        private int KhesaplaY(double geciciY)
        {
            return Convert.ToInt32(250 + (-100 * geciciY));
        }
        #endregion

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GrafikCiz = this.CreateGraphics();
        }
    }
}
