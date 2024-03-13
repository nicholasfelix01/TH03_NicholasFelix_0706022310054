using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NF0203TH
{
    public partial class Form1 : Form
    {
        DataTable Account = new DataTable();
        string tampungUsername = string.Empty;
        string tampungPassword = string.Empty;
        bool hasReset = false;
        public Form1(DataTable Redo, bool Reset)
        {
            InitializeComponent();
            if (Reset)
            {
                hasReset = true;
            }
            if (hasReset == false)
            {
                Account.Columns.Add("Username", typeof(string));
                Account.Columns.Add("Password", typeof(string));
                Account.Columns.Add("Balance", typeof(long));
                Account.Columns.Add("BalanceHis", typeof(List<string>));
            }
            else
            {
                Account = Redo;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            bool idontwannalive = false;
            tampungUsername = textBox1.Text.ToUpper();
            tampungPassword = textBox2.Text;
            if (tampungUsername.Length == 0)
            {
                text += "Please Input Username.\n";
                idontwannalive = true;
            }
            if (tampungPassword.Length == 0)
            {
                text += "Please Input Password.\n";
                idontwannalive = true;
            }
            foreach (DataRow row in Account.Rows)
            {
                if (row["Username"].ToString() == tampungUsername)
                {
                    text += "Username Has Already Exist.";
                    idontwannalive = true;
                }
            }
            if (!idontwannalive)
            {
                Account.Rows.Add(tampungUsername, tampungPassword, 0, new List<string>());
                MessageBox.Show("Register Succesful");
            }
            else
            {
                MessageBox.Show(text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            bool idontwannalive = false;
            bool live = false;
            tampungUsername = textBox1.Text.ToUpper();
            tampungPassword = textBox2.Text;
            if (tampungUsername.Length == 0)
            {
                text += "Please Input Username.\n";
                idontwannalive = true;
            }
            if (tampungPassword.Length == 0)
            {
                text += "Please Input Password.\n";
                idontwannalive = true;
            }
            foreach (DataRow row in Account.Rows)
            {
                if (row["Username"].ToString() == tampungUsername)
                {
                    if (row["Password"].ToString() == tampungPassword)
                    {
                        live = true;
                        string hihi = row["Username"].ToString();
                        MessageBox.Show("Login Succesful");
                        Bank bank = new Bank(Account, hihi);
                        this.Hide();
                        bank.ShowDialog();
                    }
                    else
                    {
                        text += "Password Incorrect.\n";
                        idontwannalive = true;
                    }
                }
            }
            if (idontwannalive)
            {
                MessageBox.Show(text);
            }
            else
            {
                if (!live)
                {
                    MessageBox.Show("Username Not Found.");
                }
            }
        }
    }
}
