using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class a : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        txtResult.Text = "";
        string[] onlineUserList = txtOnlineUsers.Text.ToString().ToLower().Split('|');
        char[] ReportName = txtReportName.Text.Replace("*", "").ToCharArray();

        foreach (string user in onlineUserList)
        {
            int i = 0;
            foreach (char letter in ReportName)
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