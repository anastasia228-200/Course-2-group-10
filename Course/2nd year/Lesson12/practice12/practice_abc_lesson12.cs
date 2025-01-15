//practice a+b
//1
using System.Text.Json;

public class Product
{
    public string Name {get; set;} 
    public int Price {get; set;}
    public string Description {get; set;}

}
//2

public class Product1
{
    public string Category { get; set; }
    public string Products { get; set; }
}
//3
public class Order
{
    public int ID {get; set;}
    public string Items { get; set; }
    public int Total {get; set;}
}
//4
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Purchases { get; set; }
}
//5
public class Cart
{
    public List<string> Products { get; set; }
}
//6
public class Shipping
{
    public string method { get; set; }
    public int price { get; set; }
    public int estimated_days { get; set; }
}
//7
public class Payment
{
    public string method { get; set; }
    public string status { get; set; }
}
//8
public class Review
{
    public string Product { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
}

public class ReviewsCollection
{
    public List<Review> Reviews { get; set; }
}
//9
public class Discounts
{
    public string Product { get; set; }
    public string discount { get; set; }
}
public class DiscountsColeection
{
    public List<Discounts> Discounts { get; set; }
}
//10
public class Addresses
{
    public string type { get; set; }
    public string address { get; set; }
}
public class AddressesCollection
{
    public List<Addresses> Addresses { get; set; }
}

//practice c
public class Program {
    public static void Main()
    {
        string jsonCustomer = "{\"Id\":1,\"Name\":\"Иван Иванов\",\"Email\":\"ivan.ivanov@example.com\"}";
        string jsonProduct = "{\"Id\":1, \"Name\":\"Умные часы\",\"Price\":\"1999.99\"}";
        string jsonPurchase = "{\"PurchaseId\":1,\"CustomerId\":1,\"ProductId\":1,\"PurchaseDate\":\"2023-10-05T14:30:00\"}\r\n";
    } 
}