using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab2
{
    public class Element<T, U, V>
    {
        public T Key { get; set; }
        public U Value1 { get; set; }
        public V Value2 { get; set; }
        public Element(T key, U value1, V vlaue2)
        {
            Key = key;
            Value1 = value1;
            Value2 = vlaue2;
        }
    }
}
