using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDb
{
    class Customer
    {
        public int Id { get; private set; }
        public string Name { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; private set; }
        public bool Active { get; set; } = true; // have to set to true because default to false

        private static int LastId { get; set; } = 0;

        public void AddSales(decimal amount) // this is a method if it doesnt return anything add void. give it a name and then add the parameters
        {
            Sales = Sales + amount;

           
        }

        public Customer(string name, string city = "Cincinnati", string state = "OH") // this is the class constructor and will set initial values of your properties
        {
            this.Name = name;
            this.City = city;
            this.State = state;
            LastId++;
            this.Id = LastId;
        }


    }

    

        
        
            
            
       

        
    
}
