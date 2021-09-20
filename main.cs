using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter sales ammount");
    int sales = Convert.ToInt32(Console.ReadLine());
    double commission = 200 + (.09 * Convert.ToDouble(sales));
    Console.WriteLine("Sales commission for " + name + " is " + commission);
    if (sales <= 2999)
    {
      Console.WriteLine("Performance for " + name + " is poor");
    }
    else if (sales <= 4999 && sales >= 3000)
    {
      Console.WriteLine("Peformance for " + name + " is average");
    }
    else if (sales <= 9999 && sales >= 5000)
    {
      Console.WriteLine("Performance for " + name + " is excellent");
    }
    else if(sales >= 15000)
    {
      Console.WriteLine("Performance for " + name + " is outstanding");
    }

  }
}