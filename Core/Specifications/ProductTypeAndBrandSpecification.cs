using Core.Entities;

namespace Core.Specifications
{
  public class ProductTypeAndBrandSpecification : BaseSpecification<Product>
  {
    public ProductTypeAndBrandSpecification(string sort)
    {
        AddInclude(x => x.ProductBrand);
        AddInclude(x => x.ProductType);
        AddOrderBy(x => x.Name);
    }

    public ProductTypeAndBrandSpecification(int id)
    : base(x => x.Id == id)
    {
        AddInclude(x => x.ProductBrand);
        AddInclude(x => x.ProductType);
    }
  }
}