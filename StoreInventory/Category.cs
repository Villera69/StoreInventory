namespace Store;
public class Category
{
    List<SubCategory> SubCategories = new List<SubCategory>();
    protected String name = "";
    

    public Category(String name){
        this.name = name;
    }
}