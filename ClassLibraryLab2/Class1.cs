using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab2
{
    public class ExtendedDictionary<T, U, V> : IEnumerator, IEnumerable
    {
        public object Current => throw new NotImplementedException();
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
        public void Reset()
        {
            throw new NotImplementedException();
        }
        List<Element<T, U, V>> elements = new List<Element<T, U, V>>();
        public void AddValues(T key, U value1, V value2)
        {
            elements.Add(new Element<T, U, V>(key, value1, value2));
        }
        public void RemoveValues(T key)
        {
            foreach (var element in elements)
            {
                if (element.Key.Equals(key))
                {
                    elements.Remove(element);
                    break;
                }
            }
        }
        public void ContainsKey(T key)
        {
            foreach (var element in elements)
            {
                if (element.Key.Equals(key))
                {
                    Console.WriteLine($"Елемент з ключем {key} існує");
                }
                else Console.WriteLine($"Елемент з ключем {key} не існує");
            }

        }
        public void ContainsValue(U value1, V value2)
        {
            foreach (var element in elements)
            {
                if (element.Value1.Equals(value1) && element.Value2.Equals(value2))
                {
                    Console.WriteLine($"Значення {value1} та {value2} існують");
                }
                else Console.WriteLine($"Значення {value1} та {value2} не існують");
            }

        }
        public Element<T, U, V> this[T key]
        {
            get
            {
                foreach (var element in elements)
                {
                    if (element.Key.Equals(key)) return element;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public int AmountValues()
        {
            return elements.Count();
        }
    }
}
