using ProductSite.Interfaces.Enum;
using ProductSite.Interfaces.Public;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSite.Data
{
    class Video : IProduct
    {
        ProductTypeEnum IProduct.ProductType => ProductTypeEnum.NonPhysical;

        ProductEnum IProduct.Product => ProductEnum.Video;

        ProductGenreEnum IProduct.ProductGenre => throw new NotImplementedException();

        bool IProduct.Sold()
        {
            throw new NotImplementedException();
        }
    }
}
