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
            string[] onlineUserList = txtOnlineUsers.Text.ToString().Split('|');
            char[] ReportName = txtReportName.Text.Replace("*", "").ToCharArray();

            foreach(string user in onlineUserList)
            {
                int i = 0;
                foreach(char letter in ReportName)
                {
                    if (user.Contains(letter))
                    {
                        i++;
                    }
                }
                if (i == ReportName.Length)
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

            if (txtResult.Text == "")
                txtResult.Text = "Not found!";
        }

    }
}
