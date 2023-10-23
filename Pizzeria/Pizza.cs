using System.Dynamic;

namespace Pizzeria{

    class Pizza: Items{
        public Pizza(string t, char s, double price):base(price){
            type=t;
            size=s;
        }

        public string type{get; set;}
        public char size{get; set;}
    }
}