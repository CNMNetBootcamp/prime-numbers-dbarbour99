using System;
using System.Timers;  

namespace prime
{
  class Program
  {

    static void Main(string[] args)
    {
      int gotonum = 10000;
      int theloop = 0;
      bool bolok = true;
      int innerloop = 0;
      DateTime starttime = DateTime.Now;
      DateTime endtime;

      for (theloop = 1; theloop < gotonum;theloop++)
      {
        //assume every number qualifies, until you find a condition where it doesn't        
        bolok = true;
        for (innerloop = 2; innerloop < theloop-1; innerloop++)
        {
          if (theloop % innerloop == 0)
          {
            bolok = false;
            break;
          }

        }

        //this is a good number, so output it
        if (bolok == true)
          Console.WriteLine(theloop);
           
      }
      endtime = DateTime.Now;

      Console.WriteLine("This took " + (endtime - starttime) + " seconds");
      Console.ReadLine();
    }


  }
}
