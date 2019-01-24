using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace prime
{
  class Program
  {
    static void Main(string[] args)
    {
      Double gotonum = 100000.0;
      Double theloop = 0.0;
      bool bolok = true;
      Stopwatch stopWatch = new Stopwatch();
      List<Double> intlist = new List<Double>();

      //just add the first prime number so the loop is easier and you can step by 2
      intlist.Add(2);

      stopWatch.Start();
      for (theloop = 3; theloop < gotonum;theloop+=2)
      {
        //alternate method 3 - only search through already identified prime numbers for factors
        bolok = true;
        foreach (double anumber in intlist)
        {
          if (theloop % anumber == 0.0)
          {
            bolok = false;
            break;
          }
        }
        if (bolok == true) intlist.Add(theloop);
      }
      //stop the timer
      stopWatch.Stop();
      TimeSpan ts = stopWatch.Elapsed;

      //alternate method 3 output
      foreach (int anumber in intlist) Console.WriteLine(anumber);

      //tell the user the results
      Console.WriteLine("Total count: " + intlist.Count);
      Console.WriteLine("The stop watch recorded " + ts + " seconds");
      Console.ReadLine();
    }


  }
}
