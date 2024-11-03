   # UML Diagram 
    
       ---------------------------------------
      |              ClassName                |
      |---------------------------------------|
      | + type                 : Type         |    +      public
      |   ----                                |     
      | - vehi_id              : int          |    -      private
      | # vechi_name           : string       |    #      protected
      |---------------------------------------|
      | + getVehiParts(int id) : list<parts>  |
      |   -------------------                 |    ----   static
      | - changeTyre(Tyre __)  : Tyre         |
      | #                                     |
       ---------------------------------------

   - Associatn : 

      - Bidirectional

         A ---------- B [A can call B, B can call A]

         A ---------> B [A can call B, but B can't call A i.e. unidirectional]

      - Multiplicity :

               2         1
         Person ----------- Room [In a room there can be two persons]
               \ 1
                \
                 \ *
                  Vehicles [One person can have any number of vehicles]   

               1..4      1  
         Rider  ----------- Cab [In cab there can be 1 to 4 number of riders]
               \ 1..2
                \ 
                 \ 1
                  Bike 

               1    1..*
         Person -------- IDs [A person should have atleast one identification]

      - Role

                  eats
         Guests -------- Food 
                       /
                cooks /
                     /  
                Cook

         here eats, cooks  

   # Architectual pattern
   
      Ref: Gang of Four book(1994)
   
      1. Creational
         a. Builder
         b. Factories
            i.  Abstrcact Factory
            ii. Factory Method
         c. Prototype
         d. Singleton   

      2. Structural
         a. Adapter
         b. Bridge
         c. Composite
         d. Decorator
         e. Facade
         f. Flyweight
         g. Proxy

      3. Behavioral
         a. Chain of Responsibility
         b. Command
         c. Interpreter
         d. Iterator
         e. Mediator
         f. Memento
         g. Null Object
         h. Observer
         i. State
         j Strategy
         k. Template method
         l. Visitor

   # Solid Design Principles
 
   - S

      Before:

      class Marker 
      {
         string Name;
         string color;
         int year;
         int price;

         public Marker(string name, string color, year, price) 
         {
            this.name = name;
            this.color = color;
            this.year = year;
            this.price = price;
         }
      }

      class Invoice 
      {
         private Marker marker;
         private int quantity;

         public Invoice(Marker marker, int quantity) 
         {
            this.marker = marker;
            this.quantity = quantity;
         }

         public int calculateTotal()  
         {
            int price = marker.price * quantity;
            return price;
         }

         public void printInvoice()
         {
            //print the invoice
         }

         public void saveToDB()
         {
            //save the data into DB
         }
      }

      After:

      class Invoice 
      {  
         private Marker marker;
         private int quantity;

         public Invoice(Marker marker, int quantity) {
            this.marker = marker;
            this.quantity = quantity;
         }

         public int calculateTotal() {
            int price = marker.price * quantity;
            return price;
         }
      }

      class InvoiceDao
      {
         Invoice invoice;

         public InvoiceDao(Invoice invoice) 
         {
            this.invoice = invoice;
         }

         public void saveToDB() 
         {
            // save into the DB
         }
      }

      class InvoicePrinter
      {
         private Invoice invoice;

         public InvoicePrinter(Invoice invoice) 
         {
            this.invoice = invoice;
         }

         public void Print() 
         {
            //print the invoice
         }
      }

   