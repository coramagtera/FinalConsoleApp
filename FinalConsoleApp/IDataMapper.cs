using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
   internal interface IDataMapper<T>
    {
        /*
        T in <T>
        a generic type paramter allows you to speicy and arbitarty type "t" to a method a compile time, 
        without specifying a conrete type in the method or class declration
        */

        List<T> Select();

        List<T> Find(string LastName);
    }
}
