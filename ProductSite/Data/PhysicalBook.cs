using ProductSite.Interfaces.Enum;
using ProductSite.Interfaces.Public;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSite.Data
{
    class PhysicalBook : IProduct
    {
        ProductTypeEnum IProduct.ProductType => throw new NotImplementedException();

        ProductEnum IProduct.Product => throw new NotImplementedException();

        ProductGenreEnum IProduct.ProductGenre => throw new NotImplementedException();

        bool IProduct.Sold()
        {
            throw new NotImplementedException();
        }
    }
}
