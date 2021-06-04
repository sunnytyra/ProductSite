using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSite.Interfaces
{
    interface IProductCommand
    {
        bool CanExecute();
        bool Execute(); //TODO revisit

    }
}
