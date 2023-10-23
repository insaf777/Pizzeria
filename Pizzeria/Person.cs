namespace Pizzeria{

    class Person{
        public Person(){}

        public Person(string fN, string lN, string ph, string a){
            firstName=fN;
            lastName=lN;
            phoneNumber=ph;
            address=a;
        }

        public string firstName{ get; set;}
        public string lastName{ get; set;}
        public string phoneNumber{ get; set;}
        public string address{ get; set;}

        public override string ToString(){
            return firstName;
        }
    }
}