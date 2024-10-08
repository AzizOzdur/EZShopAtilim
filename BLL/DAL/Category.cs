#nullable disable
namespace BLL.DAL
{
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public List<Product> Products { get; set; } // 1 to '''''many''''''

    }
}
