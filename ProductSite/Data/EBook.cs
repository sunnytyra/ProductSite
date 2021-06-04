using ProductSite.Interfaces.Enum;
using ProductSite.Interfaces.Public;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSite.Data
{
    class EBook : IProduct
    {
        ProductTypeEnum IProduct.ProductType => ProductTypeEnum.NonPhysical;

        ProductEnum IProduct.Product => ProductEnum.Book;

        ProductGenreEnum IProduct.ProductGenre => ProductGenreEnum.LowRiskLearning;

        bool IProduct.Sold()
        {
            throw new NotImplementedException();
        }
    }
}
