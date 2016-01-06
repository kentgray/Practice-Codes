using System;
public class Calculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}
public class ScientificCalculator : Calculator
{
    public double Power(double num, double power)
    {
        return Math.Pow(num, power);
    }
}
public class ProgrammerCalculator : Calculator
{
    public int Or(int num1, int num2)
    {
        return num1 | num2;
    }
}