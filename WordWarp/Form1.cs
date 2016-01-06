using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordWarp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            string[] onlineUserList = txtOnlineUsers.Text.Replace(" ", "").ToString().ToLower().Split('|');

            int WitnessNameLength = txtReportName.Text.Length;
            char[] WitnessNameSplit = txtReportName.Text.Replace("*", "").ToCharArray();

            foreach(string user in onlineUserList)
            {
                int i = 0;
                foreach(char letter in WitnessNameSplit)
                {
                    if (user.Contains(letter))
                    {
                        i++;
                    }
                }
                if(i == WitnessNameSplit.Length)
                {
                    if (user.Length == WitnessNameLength)
                    {
                        if (txtResult.Text == "")
                        {
                            txtResult.Text = user;
                        }
                        else
                        {
                            txtResult.Text = txtResult.Text + "," + user;
                        }
                    }
                }

              
            }
            if (txtResult.Text == "")
                txtResult.Text = "Not found!";
        }
    }
}
