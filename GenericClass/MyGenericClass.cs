using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class MyGenericClass<T> where T : struct
    {
        private List<T> privateList;
        public MyGenericClass()
        {
            privateList = new List<T>();
        }
        public void AddToList(T addedObject)
        {
            privateList.Add(addedObject);
        }
        public T ReturnItemFromList(int index)
        {
            return privateList[index];
        }
        public List<T> ReturnSortedList()
        {
            privateList.Sort();
            privateList.Reverse();
            return privateList;
        }
    }
}
