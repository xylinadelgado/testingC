using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine(FeetToInches(30));
    Console.WriteLine(FeetToInches(60));
   int FeetToInches(int Feet)
    {
      int inches = Feet * 12;
      return inches;
   }
  }
}
