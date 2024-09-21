using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeRate_4024____4
{
    public partial class Form1 : Form
    {
        double bath;
            double dollar = 36.3791;
            double pond = 46.2969;
            double euro = 39.1320;
            double yuan = 4.9638;
            double yen = 22.9279;
        public Form1()

        {
            

            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void picdollar_MouseHover(object sender, EventArgs e)
        {
            if(tbath.Text   !="   ")
            bath    =   double.Parse(tbath.Text);
            double result = bath / dollar;
            ladollar.Text = result.ToString("#.###");
        }

        private void picdollar_MouseLeave(object sender, EventArgs e)
        {
            ladollar.Text = "................";
        }

        private void picpond_MouseHover(object sender, EventArgs e)
        {
            if (tbath.Text != "   ")
                bath = double.Parse(tbath.Text);
            double result = bath / pond;
            lapond.Text = result.ToString("#.###");
        }

        private void picpond_MouseLeave(object sender, EventArgs e)
        {
            lapond.Text = "................";
        }

        private void piceuro_MouseHover(object sender, EventArgs e)
        {
            if (tbath.Text != "   ")
                bath = double.Parse(tbath.Text);
            double result = bath / euro;
            laeuro.Text = result.ToString("#.###");
        }

        private void piceuro_MouseLeave(object sender, EventArgs e)
        {
            laeuro.Text = "................";
        }

        private void picyuan_MouseHover(object sender, EventArgs e)
        {
            if (tbath.Text != "   ")
                bath = double.Parse(tbath.Text);
            double result = bath / yuan;
            layuan.Text = result.ToString("#.###");
        }

        private void picyuan_MouseLeave(object sender, EventArgs e)
        {
            layuan.Text = "................";
        }

        private void picyen_MouseHover(object sender, EventArgs e)
        {

            if (tbath.Text != "   ")
                bath = double.Parse(tbath.Text);
            double result = bath / yen;
            layen.Text = result.ToString("#.###");
        }

        private void picyen_MouseLeave(object sender, EventArgs e)
        {
            layen.Text = "................";
        }
    }
}
