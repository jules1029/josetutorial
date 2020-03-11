//this file is for actually consuming them (using them in your own code)

//if your code is not in the namespace (very very common)
//you will have to import that namespace (and all the classes in it) with a use statement
using System;
//we need to import the namespaces with the car class we want to use
using mySecondNameSpace;
//need to import namespaces even if they have dots in them
using mySecondNameSpace.Classes;

namespace myActualProgram {
    public class Program {
        public static void Main(string[] args)
        {
            //car is not inside my namespace
            var car = new Car();
            var secondClass = new SecondClass();
        }
    }
}
