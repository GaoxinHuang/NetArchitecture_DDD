using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.Generic
{
    public interface IGeneric<T> where T : class
    {
        void Add(T entities);
    }
}
