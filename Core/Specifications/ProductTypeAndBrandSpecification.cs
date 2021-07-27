using Core.Entities;

namespace Core.Specifications
{
  public class ProductTypeAndBrandSpecification : BaseSpecification<Product>
  {
    public ProductTypeAndBrandSpecification()
    {
        AddInclude(x => x.ProductBrand);
        AddInclude(x => x.ProductType);
    }
  }
}