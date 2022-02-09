using System;

namespace Oper.DataTypes
{

    class Fraction
    {
        private int _denominator
        public int Numerator { get ; set;}
        public int Denominator 
        {
             get => _denominator ;
              set
              {
                  if (value == 0) throw Exceptions.FractionException("Setting.......");
                  else _denominator = value;
              }
              }
    }
}