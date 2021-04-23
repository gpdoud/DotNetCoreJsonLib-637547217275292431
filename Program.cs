using System;

namespace DotNetCoreJsonLib {

    class Program {
    
        static void Main(string[] args) {
    
            var c = new Customer {
                Name = "ABC MFG",
                Sales = 12345.00M
            };

            var s = Customer.Serialize(c);

            System.IO.File.WriteAllText("./Customer.json", s);
        }
    }
}