using System;

namespace cccalculator
{
    public class Class1
    {
            // Square function   
          static  public int Square(int num)
            {
                return num* num;
            }
            // Add two integers and returns the sum  
            static public int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            // Multiply two integers and retuns the result  
           static public int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }
            // Subtracts small number from big number  
           static public int Subtract(int num1, int num2)
        {
                if (num1 > num2)
                {
                    return num1 - num2;
                }

                return num2 - num1;

            }
            //performing Division on two float variables.  
            public static float Division(float num1, float num2)
            {
                return num1 / num2;
            }

        
    }
}
