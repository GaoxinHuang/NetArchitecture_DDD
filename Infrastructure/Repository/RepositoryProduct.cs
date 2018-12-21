using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interface;
using Infrastructure.Repository.Generic;

namespace Infrastructure.Repository
{
    public class RepositoryProduct : RepositoryGeneric<Product>, IProduct
    {

    }
}
