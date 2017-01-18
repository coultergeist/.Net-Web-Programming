using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] alert = new string[5, 2];

    protected void Page_Load(object sender, EventArgs e)
    {
        alert[0, 0] = "Mom's Birthday";
        alert[0, 1] = "9/28/2017";
        alert[1, 0] = "Quarterly Eval";
        alert[1, 1] = "3/1/2017";
        alert[2, 0] = "Cat Teeth Cleaning";
        alert[2, 1] = "5/15/2017";
        alert[3, 0] = "Get Christmas Cards in the Mail ";
        alert[3, 1] = "12/12/2017";
        alert[4, 0] = "Vacation Begins!";
        alert[4, 1] = "12/12/2017";
    }


    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        GetAlert();
    }

    protected void GetAlert()
    {
        for (int i = 0; i < 5; i++)
        {
            if (Calendar1.SelectedDate.ToShortDateString() == alert[i, 1])
            {
                Label1.Text += alert[i, 0];
            }
        }
    }

    }

