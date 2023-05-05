using System.Xml.Schema;
using System.Globalization;
namespace Store;
public class Inventory{ //inventoryklassen. Denna håller reda på alla produkter i en lista.
    public List<Product> inventory = new();

    public void Add(Product product){   //lägger till en produkt till listan.
        inventory.Add(product);
    }

    public void Remove(long productID){ //tar bort alla produkter med samma produkt ID.
        for(int i = 0; i < inventory.Count; i++)
        {
            if(inventory[i].GetID() == productID){
                inventory.RemoveAt(i);
                i--;
            }
        }
    }
    public void ChangePrice(long productID, double newPrice){   //Ändrar priset på alla produkter med samma produktID.
        for(int i = 0; i < inventory.Count; i++)
        {
            if(inventory[i].GetID() == productID){
                inventory[i].SetPrice(newPrice);
            }
        }
    }

    public bool Empty(){    //Kollar om inventoryt är tomt :O!
        return inventory.Count == 0;
    }

    public bool Contains(long productID){   //Kollar om ett produkt ID faktiskt finns registrerat i inventoryt. 
        foreach(Product product in inventory){
            if(product.GetID() == productID){
                return true;
            }
        }
        return false;
    }

    public void PrintInventory(){   //skriver ut inventoryt om det finns något i det, annars skriver den att det inte finns något!
        if(Empty()){
            Console.WriteLine("There is nothing here yet...");
        }
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine(inventory[i].Print());
        }
    }
}