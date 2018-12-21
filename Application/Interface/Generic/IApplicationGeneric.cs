using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interface.Generic
{
    public interface IApplicationGeneric<T> where T : class
    {
        void Add(T entities);
    }
}
