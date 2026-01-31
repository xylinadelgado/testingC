using System;

Panda p1 = new Panda("Pan Dee");
Panda p2 = new Panda("Pan Dah");
Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);

Console.WriteLine(Panda.Population);
public class Panda
{
  public string Name; //Intance field
  public static int Population; // static field
  public Panda(string n) //constructor
  {
    Name = n; 
    Population = Population + 1; //asign the instance field and then increment
  }
}



