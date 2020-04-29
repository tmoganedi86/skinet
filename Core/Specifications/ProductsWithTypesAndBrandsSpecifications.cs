using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecifications : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecifications()
        {
            AddIclude(x => x.ProductBrand);
             AddIclude(x => x.ProductType);
        }

        public ProductsWithTypesAndBrandsSpecifications(int id) : base(x=>x.Id == id)
        {
            AddIclude(x => x.ProductBrand);
             AddIclude(x => x.ProductType);
        }
    }
}