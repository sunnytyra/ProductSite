using ProductSite.Interfaces.Enum;
using ProductSite.Interfaces.Public;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSite.Data
{
    class UpdateMemberShip : IProduct
    {
        ProductTypeEnum IProduct.ProductType => ProductTypeEnum.NonPhysical;

        ProductEnum IProduct.Product => ProductEnum.Membership;

        ProductGenreEnum IProduct.ProductGenre => ProductGenreEnum.CustomerService;

        public bool Sold()
        {
            throw new NotImplementedException();
        }
    }
}
