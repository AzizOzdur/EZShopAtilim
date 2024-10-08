#nullable disable // referance type'larda "?" işaretini kullanmamak için
namespace BLL.DAL
{
    public class Product
    {
        // JAVA way:
        //private int id;
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}


        //public int GetId()
        //{
        //    return this.id;
        //}
        
        //C# way
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int? StockAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int CategoryId { get; set; } // foreign key için """1""" to many
        public Category Category { get; set; }

        // struct value tiptir, class referans tiptir önemli not aklında bulunsun
    }e
}
