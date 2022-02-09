using System;

namespace Oper.DataTypes
{
    class Vector 
    {

     
        public int Size { get; private set; }
    
    
    public Vector ( int size)
    {
        this.Size = size;
        _data = new double[size];
    }
    
    public double this[int index] 
    {
        get 
        {
         if ( index < 0 || index >= this.Size)      
         {
                
         } 
         else return _data[index];
        }
    }


    }
}