using System.Xml.Schema;
using System.Globalization;
namespace Store;
public class Inventory{
    public List<Product> inventory = new();

    public void Add(Product product){
        inventory.Add(product);
        Console.WriteLine(inventory[^1].Print());
    }

    public void Remove(long productID){
        for(int i = 0; i < inventory.Count; i++)
        {
            if(inventory[i].GetID() == productID){
                inventory.RemoveAt(i);
                i--;
            }
        }
    }
    public void ChangePrice(long productID, double newPrice){
        for(int i = 0; i < inventory.Count; i++)
        {
            if(inventory[i].GetID() == productID){
                inventory[i].SetPrice(newPrice);
            }
        }
    }

    public bool Empty(){
        return inventory.Count == 0;
    }

    public bool Contains(long productID){
        foreach(Product product in inventory){
            if(product.GetID() == productID){
                return true;
            }
        }
        return false;
    }

    public void PrintInventory(){
        if(Empty()){
            Console.WriteLine("There is nothing here yet...");
        }
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine(inventory[i].Print());
        }
    }
}