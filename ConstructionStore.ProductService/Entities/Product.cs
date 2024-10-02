namespace ConstructionStore.ProductService.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }            // Ad (Dinamik)
        public string? Description { get; set; }     // Açıklama
        public decimal Price { get; set; }          // Ücret
        public int Quantity { get; set; }           // Adet
        public string? Size { get; set; }            // Ebat (10L, 15L)

        public int BrandId { get; set; }            // Marka Id
        public int CategoryId { get; set; }         // Kategori Id
    }
}
