using System;

namespace Oper
{


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Operations!");
            //DataTypes.Complex c1 = new DataTypes.Complex { Re = 1 , Im = -2 }; // or [var] use

var c1 = new DataTypes.Complex
{
    Re = 1,
    Im = -2

};
var c2 = new DataTypes.Complex
{
    Re = 2,
    Im = -3
};
var c3 = new DataTypes.Complex
{
    Re = 0,
    Im = 1
};
Console.WriteLine($"{c1} + {c2} = {c1+c2}");
Console.WriteLine($"{c1} - {c2} = {c1-c2}");
Console.WriteLine($"{c3} x {c3} = {c3*c3}");
Console.WriteLine($"{c1} / {c3} = {c1/c3}");

        }
    }
}