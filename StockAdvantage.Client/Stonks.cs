namespace StockAdvantage.Client;

public class Stonks
{
    public string Symbol { get; set; }
    public decimal price { get; set; }
    public int ownedShares { get; set; }
    public decimal cummulativeValue => price * ownedShares;

    public Stonks(string symbol, decimal price, int ownedShares)
    {
        Symbol = symbol;
        this.price = price;
        this.ownedShares = ownedShares;
        //cummulativeValue = ownedShares * price; why the heck doesn't it auto calc in constructor lol
    }
}