using Oper.Extensions;

namespace Oper
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new DataTypes.Complex { Re = 1, Im = -2 };
            var cPseudo = c;
            var cClone = c.Clone();
            c.Re = 3;
            Console.WriteLine($"C : {c} cPseudo : {cPseudo} cClone : {cClone}");
            Console.WriteLine(c.Reflect());
            var f = new DataTypes.Fraction { Numerator = -2, Denominator = 3 };
            Console.WriteLine(f);
            Console.WriteLine(f.Inverse());
            Console.WriteLine(f.Abs());
        }
        static void Main3(string[] args)
        {
           

            var rand = new Random();
            Console.WriteLine();
           
            Console.Clear();
           

            #region Complex
            /*var c0 = new DataTypes.Complex { Re = 0, Im = 0 };
            var c1 = new DataTypes.Complex { Re = 1, Im = -2 };
            var c2 = new DataTypes.Complex { Re = 2, Im = -3 };
            var c3 = new DataTypes.Complex { Re = 0, Im = 1 };
            Console.WriteLine($"{c1} + {c2} = {c1+c2}");
            Console.WriteLine();
            Console.WriteLine($"{c1} - {c2} = {c1-c2}");
            Console.WriteLine();
            Console.WriteLine($"{c3} x {c3} = {c3*c3}");
            Console.WriteLine();
            try
            {
                Console.WriteLine($"{c1} / {c3} = {c1 / c3}");
                Console.WriteLine($"{c3} / {c3} = {c1 / c3}");
               // Console.WriteLine($"{c3} / {c0} = {c3 / c0}");
            }
            catch (Exceptions.ComplexException ex)
            {
                Console.WriteLine("Выброшено исключение: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неизвестное исключение: " + ex.Message);
            }*/
            #endregion


            #region Fraction
            // var f0 = new DataTypes.Fraction { Denominator = 0, Numerator = 1 };
            var f1 = new DataTypes.Fraction { Numerator = 2, Denominator = 3 };
            var f2 = new DataTypes.Fraction { Numerator = 2, Denominator = 6 };
            try
            {
                Console.WriteLine($"f1 = {f1}; f2 = {f2}");
                /*Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
                Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
                Console.WriteLine($"{f1} * {f2} = {f1 * f2}");
                Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
                Console.WriteLine($"{0} / {f1} = {0 / f1}");
                Console.WriteLine($"{f1} / {0} = {f1 / 0}");
                Console.WriteLine(f1[2]);*/

            }
            catch (Exceptions.FractionException ex)
            {
                Console.WriteLine("Выброшено исключение: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неизвестное исключение: " + ex.Message);
            }
            #endregion

        }
    }
}