namespace JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
class Program
{
    //practice a
    static void Main()
    {   ////1
        //string json = @"
        //{
        //    ""id"": 12345,
        //    ""name"": ""Иван Иванов"",
        //    ""email"": ""ivanov@example.com"",
        //    ""isVerified"": true
        //}";

        //Person person = JsonSerializer.Deserialize<Person>(json);

        //Console.WriteLine($"Email: {person.email},ID: {person.id}");

        ////2+3
        string json2 = @"
        {
            ""orderId"": ""ORD10245"",
            ""customerName"": ""Анна Петрова"",
            ""totalPrice"": 5600,
            ""items"": [""Ноутбук"", ""Мышь""]
        }";
        Order order = JsonSerializer.Deserialize<Order>(json2);

        Console.WriteLine($"Товары, купленные {order.customerName}:");
        foreach (var item in order.items)
        {
            Console.WriteLine($"- {item}");
        }
        string newItem = "Салфетки для мониторов";
        decimal newItemPrice = 1550;
        // Обновление массива товаров
        Array.Resize(ref order.items, order.items.Length + 1);
        order.items[^1] = newItem;

        // Обновление итоговой цены
        order.totalPrice += newItemPrice;

        // Применение скидки 2%
        decimal discount = 0.02m;
        order.totalPrice *= (1 - discount);

        // Запись в JSON файл
        var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(order, jsonOptions);
        File.WriteAllText("updated_order.json", json);

        Console.WriteLine("Данные записаны в файл updated_order.json.");
    }

    
}

public class Person
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public bool isVerified { get; set; }
}

public class Order
{
    public string orderId { get; set; }
    public string customerName { get; set; }
    public decimal totalPrice { get; set; }
    public string[] items { get; set; }
}