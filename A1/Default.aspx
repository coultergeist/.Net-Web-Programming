<!--Assignment 1: Create a web page for calculating tips. Due 1/9 at Midnight.

There should be a form that allows the user to enter the Meal amount and the tax Percent as a whole number. 
It should contain radio buttons for tips of 10, 15 and 20 percent as well as one for other. 
The other will have a text box where they can enter their custom percent as a whole number. 
There should be a button to submit and after it is clicked the page should display the amount, the tax, the tip and the total.

Apply a CSS style sheet to the page to make it more presentable.
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A1: Tip Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Tip Calculator</h1>
    <div>
         <p>
             <asp:Label ID="Label1" runat="server" Text="Enter Meal Amount"></asp:Label>  
             <asp:TextBox ID="MealTextBox" runat="server"></asp:TextBox>
             <asp:RadioButtonList ID="TipPercentRadioButtonList1" runat="server"></asp:RadioButtonList>
             <asp:TextBox ID="OtherTextBox" runat="server"></asp:TextBox>
             <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
             <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
         </p>
     </div>
    </form>
</body>
</html>
