using ProductSite.Interfaces.Enum;
using ProductSite.Interfaces.Public;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSite.Data
{
    class ProductBase : IProduct
    {   //TODO remove this may not be needed
        private readonly IProduct product;

        public ProductTypeEnum ProductType => product.ProductType;

        public ProductEnum Product => product.Product;

        public ProductGenreEnum ProductGenre => product.ProductGenre;
        public ProductCost Cost { get; set; }

        public ProductBase(IProduct product)
        {
            this.product = product;
        }

        public bool Sold()
        {
           return product.Sold();
        }
    }
}
