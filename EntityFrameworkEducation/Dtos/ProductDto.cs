using EntityFrameworkEducation.Models;

namespace EntityFrameworkEducation.Dtos
{
    //DTO Data Transfer Object
    public class ProductDto: Product
    {
        public string CategoryName { get; set; }
        public decimal Total { get; set; }
    }
}
