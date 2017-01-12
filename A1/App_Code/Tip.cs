using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tip
/// </summary>
public class Tip
{
    //fields: class level variables describing the class
    public double MealAmount { set; get; }    //shortcut
    public double TipPercent { set; get; }
    private const double TAXPERCENT = .09;

    //initalize constructors
    public Tip()
    {
        MealAmount = 0;
        TipPercent = 0;
    }
    public Tip(double meal, double percent)
    {
        MealAmount = meal;
        TipPercent = percent;
    }//end constructors

    //Begin methods for calculations
    public double CalculateTax()
    {
        return MealAmount * TAXPERCENT;
    }
    public double CalculateTip()
    {
        return MealAmount * TipPercent;
    }

    public double CalculateTotal()
    {
        return MealAmount + CalculateTax() + CalculateTip();
    }//end of calculation methods

}//end class