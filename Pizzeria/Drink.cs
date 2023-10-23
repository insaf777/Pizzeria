using System.Dynamic;

namespace Pizzeria{

    class Drink: Items{
        public Drink(string t, char s, double price):base(price){
            type=t;
            size=s;
        }

        public string type{get; set;}
        public char size{get; set;}
    }
}