using System;
using System.Collections.Generic;
using System.Text;

namespace laba4
{
    public interface IAdd_Delete_Look<T>
    {
        void Add(T var);
        void Remove(CollectionType<T> Var, int position);
        void Info(int size1);
    }
}
