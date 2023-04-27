using System.Globalization;
namespace Store;
public class Inventory{
    public List<Product> inventory = new();

    public void Add(Product product){
        inventory.Add(product);
        Console.WriteLine(inventory[^1].Print());
    }

    public void PrintInventory(){
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine(inventory[i].Print());
        }
    }
}