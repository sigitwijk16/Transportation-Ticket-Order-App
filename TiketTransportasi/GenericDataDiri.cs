using System;
using System.Collections.Generic;
using System.Text;

namespace TiketTransportasi
{
    class GenericDataDiri<T>
    {
        public T value;
        public GenericDataDiri(T macamdata)
        {
            this.value = macamdata;
        }
    }
}
