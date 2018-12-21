using System;
using System.Collections.Generic;
using System.Text;
using Application.Interface;
using Domain.Entities;
using Domain.Interface;

namespace Application.App
{
    public class AppProduct : IAppProduct
    {
        IProduct _IProduct;

        public AppProduct(IProduct iProduct)
        {
            _IProduct = iProduct;
        }
        public void Add(Product entities)
        {
            _IProduct.Add(entities);
        }
    }
}
