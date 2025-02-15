namespace StockAdvantage.Client;

public class PurchaseHistory
{
    public string Symbol { get; set; }
    public DateTime PurchaseDate { get; set; } = DateTime.Today;
    public int NumberOfShares { get; set; }
    public decimal Price { get; set; }
    public decimal Profit { get; set; }

    public PurchaseHistory(string symbol, DateTime purchaseDate, int numberOfShares, decimal price, decimal profit)
    {
        Symbol = symbol;
        PurchaseDate = purchaseDate;
        NumberOfShares = numberOfShares;
        Price = price;
        Profit = profit;
    }

    public PurchaseHistory()
    {
    }

    public PurchaseHistory(string symbol, DateTime purchaseDate, int numberOfShares, decimal price)
    {
        Symbol = symbol;
        PurchaseDate = purchaseDate;
        NumberOfShares = numberOfShares;
        Price = price;
    }
}