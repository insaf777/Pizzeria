// See https://aka.ms/new-console-template for more information
using System;

namespace Pizzeria{

    class Program{
        static void Main (string[] args){
            Console.WriteLine("Hello, World!");

            Person p= new Person();
            p.firstName="Patrick";
            Console.WriteLine(p.ToString());
        }

    }

}
