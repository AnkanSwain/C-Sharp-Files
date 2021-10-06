using System;
public class QAR {
   public static void Main(){
      int dividend = 30;
      int divisor = 7;
      int remainder;
      int quotient = Math.DivRem(dividend, divisor, out remainder);
      Console.WriteLine("Quotient = "+quotient);
      Console.WriteLine("Remainder = "+remainder);
   }
}
