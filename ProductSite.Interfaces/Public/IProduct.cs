using ProductSite.Interfaces.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSite.Interfaces.Public
{
    public interface IProduct
    {
        ProductTypeEnum ProductType { get; }
        ProductEnum Product { get; }
        ProductGenreEnum ProductGenre { get; }

        bool Sold();
    }
}
