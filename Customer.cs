using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class Customer {
    public string Name { get; set; }
    public decimal Sales { get; set; }

    public static string Serialize(Customer customer) {
        return JsonSerializer.Serialize(customer, typeof(Customer), new JsonSerializerOptions {WriteIndented = true}); 
    }
}