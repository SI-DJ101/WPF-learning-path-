using System;

namespace Example_16;

public class Product
{
    public string Symbol { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string StockId { get; set; }

    public Product(string symbol, string name, int quantity, string stockId)
    {
        Symbol = symbol;
        Name = name;
        Quantity = quantity;
        StockId = stockId;
    }

    public override string ToString()
    {
        return $"{Symbol} {Name} {Quantity} {StockId}";
    }
}