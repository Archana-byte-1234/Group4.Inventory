﻿using System;
using System.Collections.Generic;
using Znalytics.Inventory.Product.Entities;

namespace Znalytics.Group4.Inventory.IDataAccessLayer
{
    interface IproductDataAccessLogic
    {
        void AddProduct(ProductEntitie productDetails);
        List<ProductEntitie> DisplayProducts();
    }
}
