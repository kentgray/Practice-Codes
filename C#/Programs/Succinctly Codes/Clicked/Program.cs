﻿using System;
public class CalculatorButton
{
    public event ClickHandler Clicked;
    public void SimulateClick()
    {
        if (Clicked != null)
        {
            ClickEventArgs args = new ClickEventArgs();
            args.Name = "Add";
            Clicked(this, args);
        }
    }
}
public class Program
{
    public static void Main()
    {
        Program prg = new Program();
        CalculatorButton calcBtn = new CalculatorButton();
        calcBtn.Clicked += new ClickHandler(prg.CalculatorBtnClicked);
        calcBtn.Clicked += prg.CalculatorBtnClicked;
        calcBtn.SimulateClick();
        Console.ReadKey();
    }
    public void CalculatorBtnClicked(object sender, ClickEventArgs e)
    {
        Console.WriteLine($"Caller is a CalculatorButton: {sender is CalculatorButton} and is named
   { e.Name}");
    }
}