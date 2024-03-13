using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NF0203TH
{
    public partial class Bored : Form
    {
        long balance;
        int currency = 0;
        public Bored(long Balbal)
        {
            InitializeComponent();
            balance = Balbal;
            BalanceReset();
        }

        private void BalanceReset()
        {
            if (currency == 0)
            {
                label3.Text = string.Format("Rp {0:N2}", balance);
            }
            else if (currency == 1)
            {
                label3.Text = string.Format("$ {0:N2}", Convert.ToDecimal(balance* 0.00006667));
            }
            else if (currency == 2)
            {
                label3.Text = string.Format("¥ {0:N2}", Convert.ToDecimal(balance * 0.00046));
            }
            else if (currency == 3)
            {
                label3.Text = string.Format("₩ {0:N2}", Convert.ToDecimal(balance * 0.085));
            }
            else if (currency == 4)
            {
                label3.Text = string.Format("¥ {0:N2}", Convert.ToDecimal(balance * 0.0095));
            }
            else if (currency == 5)
            {
                label3.Text = string.Format("€ {0:N2}", Convert.ToDecimal(balance* 0.000060));
            }
        }

        private void Bored_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = comboBox1.SelectedIndex;
            BalanceReset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
