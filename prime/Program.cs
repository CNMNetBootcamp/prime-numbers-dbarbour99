using System;
using System.Collections.Specialized;

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
      StringCollection authorNames = new StringCollection();
      

      for (theloop = 1; theloop < gotonum; theloop++)
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
      
  
      Console.ReadLine();
    }
  }
}
