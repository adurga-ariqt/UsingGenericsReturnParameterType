using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericsReturnParameterType
{
    public  class Generics<T1>
    {
        private T1 value;
        public Generics(T1 v)
        {
            value = v;
        }
        public T1 GetValue()
        {
            return value;
        }
    }
}
