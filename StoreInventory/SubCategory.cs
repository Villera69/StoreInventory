namespace Store;
 public class SubCategory : Category
    {
        List<Product> Products ;

        public SubCategory(String name, List<Product> Products): base(name) {
            
            this.Products = Products;
        }
        
    }