namespace Pizzeria{

    class Customer : Person{
        public Customer(string fO){
            firstOrder=fO;
        }

        public string firstOrder{ get; set;}
    }
}