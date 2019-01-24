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
      Double innerloop = 0.0;
      DateTime endtime;
      Stopwatch stopWatch = new Stopwatch();
      Double thecount = 1.0;
      List<Double> intlist = new List<Double>();

      DateTime starttime = DateTime.Now;
      stopWatch.Start();

      //just add the first prime number so the loop is easier and you can step by 2
      Console.WriteLine("2");
      intlist.Add(2);

      for (theloop = 3; theloop < gotonum;theloop+=2)
      {

        //alternate method 1 - search through only prime number factors below 100
        //bolok = true;
        //if (theloop != 3 && theloop % 3 == 0) bolok = false;
        //if (theloop != 5 && theloop % 5 == 0) bolok = false;
        //if (theloop != 7 && theloop % 7 == 0) bolok = false;
        //if (theloop != 11 && theloop % 11 == 0) bolok = false;
        //if (theloop != 13 && theloop % 13 == 0) bolok = false;
        //if (theloop != 17 && theloop % 17 == 0) bolok = false;
        //if (theloop != 19 && theloop % 19 == 0) bolok = false;
        //if (theloop != 23 && theloop % 23 == 0) bolok = false;
        //if (theloop != 29 && theloop % 29 == 0) bolok = false;
        //if (theloop != 31 && theloop % 31 == 0) bolok = false;
        //if (theloop != 37 && theloop % 37 == 0) bolok = false;
        //if (theloop != 41 && theloop % 41 == 0) bolok = false;
        //if (theloop != 43 && theloop % 43 == 0) bolok = false;
        //if (theloop != 47 && theloop % 47 == 0) bolok = false;
        //if (theloop != 53 && theloop % 53 == 0) bolok = false;
        //if (theloop != 59 && theloop % 59 == 0) bolok = false;
        //if (theloop != 61 && theloop % 61 == 0) bolok = false;
        //if (theloop != 67 && theloop % 67 == 0) bolok = false;
        //if (theloop != 71 && theloop % 71 == 0) bolok = false;
        //if (theloop != 73 && theloop % 73 == 0) bolok = false;
        //if (theloop != 79 && theloop % 79 == 0) bolok = false;
        //if (theloop != 83 && theloop % 83 == 0) bolok = false;
        //if (theloop != 89 && theloop % 89 == 0) bolok = false;
        //if (theloop != 97 && theloop % 97 == 0) bolok = false;

        //alternate method 2 - search through every possible number up to the number
        // being evaluated, assume every number qualifies, until you find a 
        //condition where it doesn't        
        //bolok = true;
        //for (innerloop = 2; innerloop < theloop - 1; innerloop++)
        //{
        //  if (theloop % innerloop == 0)
        //  {
        //    //Console.WriteLine("Factor: " + innerloop);
        //    bolok = false;
        //    break;
        //  }
        //}
        //if (bolok == true)
        //  thecount = thecount + 1;          
        //  Console.WriteLine(theloop);

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
        if (bolok == true)
        {
          thecount = thecount + 1;         
          intlist.Add(theloop);
        }
      }
      //stop the two timers
      endtime = DateTime.Now;
      stopWatch.Stop();
      TimeSpan ts = stopWatch.Elapsed;

      //alternate method 3 output
      foreach (int anumber in intlist) Console.WriteLine(anumber);

      //tell the user the results
      Console.WriteLine("Total count: " + thecount);
      Console.WriteLine("Timer took " + (endtime - starttime) + " seconds , the stop watch recorded " + ts);
      Console.ReadLine();
    }


  }
}
