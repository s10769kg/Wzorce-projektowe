namespace ProductRegistrationInfo
{
    public class ProductInfo
    {
        public string ProductName { get; set; }
        public string Category {  get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }

        public ProductInfo(string productName, string category, decimal price, int stock, string supplierName, string supplierContact)
        {
            ProductName = productName;  
            Category = category;
            Price = price;
            Stock = stock;
            SupplierName = supplierName;
            SupplierContact = supplierContact;
        }
   
    }

    public class Program
    {
        public static void Main()
        {
            var productInfo = new ProductInfo(
                           productName: "Laptop",
                           category: "Electronics",
                           price: 1500.00m,
                           stock: 10,
                           supplierName: "TechSupplier Inc.",
                           supplierContact: "contact@techsupplier.com");
            RegisterProduct(productInfo);
        }

        public static void RegisterProduct(ProductInfo productInfo)
        {
           
            Console.WriteLine($"Product: {productInfo.ProductName}, Category: {productInfo.Category}, Price: {productInfo.Price:C}, Stock: {productInfo.Stock}, Supplier: {productInfo.SupplierName}, Contact: {productInfo.SupplierContact}");
        }
    }
}