using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace NF0203TH
{
    public partial class Bank : Form
    {
        DataTable dtAccount;
        string name;
        bool babaton;

        public Bank(DataTable THEAccounto, string hihi)
        {
            InitializeComponent();
            Starting(THEAccounto, hihi);
            balanceReset();
        }

        private void Starting(DataTable THEAccounto, string hihi)
        {
            dtAccount = THEAccounto;
            name = hihi;
            foreach (DataRow row in dtAccount.Rows)
            {
                if (row["Username"].ToString() == name)
                {
                    label1.Text = row["Username"].ToString();
                }
            }
        }

        private void balanceReset()
        {
            foreach (DataRow row in dtAccount.Rows)
            {
                if (row["Username"].ToString() == name)
                {
                    label1.Text = row["Username"].ToString();
                    label3.Text = string.Format("Rp {0:N2}", Convert.ToInt64(row["Balance"]));
                    listBox1.Items.Clear();
                    foreach (string history in (List<string>)row["BalanceHis"])
                    {
                        if (history.Substring(0, 1) == "+")
                        {
                            string hishis = history.Substring(2);
                            listBox1.Items.Add(string.Format("+ Rp {0:N2}", Convert.ToInt64(hishis)));
                        }
                        else
                        {
                            string hishis = history.Substring(2);
                            listBox1.Items.Add(string.Format("- Rp {0:N2}", Convert.ToInt64(hishis)));
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = panel1.Visible = true;
            textBox1.Text = string.Empty;
            button1.Visible = button2.Visible = button3.Visible = false;
            button1.Enabled = button2.Enabled = button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(dtAccount, true);
            this.Hide();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && long.TryParse(textBox1.Text, out _) && Convert.ToInt64(textBox1.Text) > 0)
            {
                foreach (DataRow row in dtAccount.Rows)
                {
                    if (row["Username"].ToString() == name)
                    {
                        row["Balance"] = Convert.ToInt64(row["Balance"]) + Convert.ToInt64(textBox1.Text);
                        ((List<string>)row["BalanceHis"]).Add("+ " + textBox1.Text);
                        balanceReset();
                        panel1.Enabled = panel1.Visible = false;
                        button1.Visible = button2.Visible = button3.Visible = true;
                        button1.Enabled = button2.Enabled = button3.Enabled = true;

                    }
                }
            }
            else
            {
                string text = string.Empty;
                if (textBox1.Text.Length == 0)
                {
                    text += "Please Fill In The Ammount.\n";
                }
                if (!long.TryParse(textBox1.Text, out long value))
                {
                    text += "Invalid input. Please enter a valid number.\n";

                }
                if (Convert.ToInt64(textBox1.Text) < 1)
                {
                    text += "Nominal Salah";
                }
                MessageBox.Show(text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Enabled = panel2.Visible = true;
            textBox2.Text = string.Empty;
            button1.Visible = button2.Visible = button3.Visible = false;
            button1.Enabled = button2.Enabled = button3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && long.TryParse(textBox2.Text, out _) && Convert.ToInt64(textBox2.Text) > 0)
            {
                foreach (DataRow row in dtAccount.Rows)
                {
                    if (row["Username"].ToString() == name)
                    {
                        if (Convert.ToInt64(textBox2.Text) <= Convert.ToInt64(row["Balance"]))
                        {
                            row["Balance"] = Convert.ToInt64(row["Balance"]) - Convert.ToInt64(textBox2.Text);
                            ((List<string>)row["BalanceHis"]).Add("- " + textBox2.Text);
                            balanceReset();
                            panel2.Enabled = panel2.Visible = false;
                            button1.Visible = button2.Visible = button3.Visible = true;
                            button1.Enabled = button2.Enabled = button3.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Withdrawal Amount Exceeds Limit.");
                        }
                    }
                }
            }
            else
            {
                string text = string.Empty;
                if (textBox2.Text.Length == 0)
                {
                    text += "Please Fill In The Ammount.\n";
                }
                if (!long.TryParse(textBox2.Text, out long value))
                {
                    text += "Invalid input. Please enter a valid number.\n";
                }
                if (Convert.ToInt64(textBox2.Text) < 1)
                {
                    text += "Nominal Salah";
                }
                MessageBox.Show(text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dtAccount.Rows)
            {
                if (row["Username".ToString()] == name)
                {
                    Bored bored = new Bored(Convert.ToInt64(row["Balance"]));
                    bored.ShowDialog();
                }
            }
        }
    }
}
