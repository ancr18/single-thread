using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace single_thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            int numericValue = (int)numScore.Value;
            StringBuilder sb = new StringBuilder();
            lblResult.Text = "Proses...";
            for (int i =1; i <= numericValue; i++)
            {
                sb.Append(string.Format(i+". Menghitung Angka : {0}{1}", GoStart(i), Environment.NewLine));
            }
            String result = sb.ToString();
            txtResult.Text = result;
            lblResult.Text = "Selesai...";
            btnStart.Enabled = true;
        }



        private int GoStart (int i)
        {
            System.Threading.Thread.Sleep(500);
            return i * 1500;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtResult.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtResult.Visible = true;
        }
    }
}





