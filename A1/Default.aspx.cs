using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)    //this prevents the page from refreshing everytime the Submit button is pressed
        {
            //create buttons 
            string[] tipPercent = { "Ten Percent", "Fifteen Percent", "Twenty Percent", "Other" };
            TipPercentRadioButtonList1.DataSource = tipPercent;
            TipPercentRadioButtonList1.DataBind();
        }//end PostBack
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetInfo();
    }

    protected void GetInfo()
    {
        Tip tip = new Tip();    //declars this a new constructor
        tip.MealAmount = double.Parse(MealTextBox.Text);    //double.Parse will convert any text into a number
        if (OtherTextBox.Text == "")
        {
            tip.TipPercent = 0; //if no tip selected leave tip amount at 0

            foreach (ListItem item in TipPercentRadioButtonList1.Items)
            {
                if (item.Selected)
                {

                }
                if (item.Text.Equals("Ten Percent"))
                {
                    tip.TipPercent = .1;
                }//end ten percent

                else if (item.Text.Equals("Fifteen Percent"))
                {
                    tip.TipPercent = .15;
                }//end 15 percent

                else if (item.Text.Equals("Twenty Percent"))
                {
                    tip.TipPercent = .2;
                }//end 20 percent
            }//end inner if statement
        }//end outter if statement
    
        else
        {
            tip.TipPercent = double.Parse(OtherTextBox.Text);
        }//end else 

        ResultLabel.Text = "Amount" + tip.MealAmount.ToString() + "<br/>" +
            "Tip: " + tip.CalculateTip().ToString("$#,##0.00") + "<br/>" +
            "Tax: " + tip.CalculateTax().ToString("$#,##0.00") + "<br/>" +
            "Total: " + tip.CalculateTotal().ToString("$#,##0.00");
        
    }//end GetInfo
}//end class