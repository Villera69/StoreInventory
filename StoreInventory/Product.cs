namespace Store;
public abstract class Product //huvudklassen till alla produkttyper. innehåller attributer som alla produkter har
{
    protected String name;
    protected long productID;

    protected double price;

    public long GetID(){    //returnerar produkt ID:t
        return productID;
    }
    public void SetPrice(double newPrice){  //sätter ett nytt pris på produkten
        price = newPrice;
    }
    public static long CurrentUnixTime(){   //kollar unix-tiden, antal sekunder efter år 1970. Används för att ge alla produkter ett unikt produkt ID
        var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
        return (long)timeSpan.TotalSeconds;
    }

    public abstract String Print(); // är med i alla produkter, används för att skriva ut 

    public abstract void AddValuesToAttributes(); //denna ärvs av dairyproducts, används för att tilldela värden till de olika attributerna i produkterna.
}