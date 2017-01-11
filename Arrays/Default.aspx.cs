using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //two dimentional array, so use one comma
    string[,] product = new string[5, 2]; //string array with 5 rows and 2 columns or [row,column]

    protected void Page_Load(object sender, EventArgs e)
    {
       
            //declare objects
            //when specifing contents always begin with ROW 0 (NOT row 1)
            product[0, 0] = "Lettuce";
            product[0, 1] = ".99";
            product[1, 0] = "Carrots";
            product[1, 1] = "2.98";
            product[2, 0] = "Prunes";
            product[2, 1] = "1.99";
            product[3, 0] = "Sauerkraut";
            product[3, 1] = "3.25";
            product[4, 0] = "Bok Choy";
            product[4, 1] = "2.99";
        
        //Create IF Statement to stop the list from repeating each time
        if (!IsPostBack)
        {
            //call the method
            GetProduce();
        }//end if post back
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //compare dates

        /*
        //METHOD 1: compare dates as a string comparison
        string birthday = "5/9/2017";
        Label1.Text = Calendar1.SelectedDate.ToShortDateString();

        if (Calendar1.SelectedDate.ToShortDateString().Equals(birthday))
        {
            //in this method they must match EXACTLY
            //when comparring strings "=" is the best method
            Label1.Text += " Happy Birthday!";
        }
        */

        //METHOD 2: using DateTime
        DateTime birthday = DateTime.Parse("5/9/2017");
        Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        if (Calendar1.SelectedDate==birthday)
        {
            Label1.Text += " Happy Birthday!";
        }
    }

    protected void GetProduce()
    {
        //declare a for statement method
        for (int i=0; i<5; i++)
        {
            //declare object called item and add them to the check box list
            ListItem item = new ListItem();
            item.Text = product[i, 0];
            ProduceCheckBoxList.Items.Add(item);
        }
    }

    protected void TotalButton_Click(object sender, EventArgs e)
    {
        //declare variables
        int counter = 0;
        double total = 0;

        foreach (ListItem item in ProduceCheckBoxList.Items)
        {
            string productName = product[counter, 0];
            
            //check each box to see if the box IS selected
            if (item.Selected)
            {
                //loop through all checkbox items
                if (item.Text.Equals(productName))  //check if product matches array
                {
                    //this will now match the price of an item IF the box is checked
                    total += double.Parse(product[counter, 1]);  //IF it is checked, converts the string to a double number then show total
                }
            }

            counter++;  //increment rows
        }//end foreach loop

        Label2.Text = "Your total is: " + total.ToString("C");
    }
}