
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentlyUsedListLibrary
{
    public class RecentlyUsedList<T>
    {
        
        public RecentlyUsedList(int no)
        {

            list = new List<T>(no);
            limit = no;
        }
        List<T> list;
        int limit;
        public T this[int i]
        {
            get
            {
                return list.ElementAt(i);
            }
        }

        public void MyInsert(T item)
        {
            var flag = search(item);
            if (flag == -1)
            {
                InsertNew(item);
            }
            else
            {
                MoveToHead(item,flag);
            }
        }

        private void MoveToHead(T item,int index)
        {
            list.RemoveAt(index);
            list.Insert(0, item);
        }

        private void InsertNew(T item)
        {
            int count = list.Count();
            list.Insert(0, item);
            if (list.Count() > limit)
                Rearrange();
        }

        private void Rearrange()
        {
            list.RemoveAt(limit);
        }
        private int search(T item)
        {
            int index = list.IndexOf(item);
            return index;
        }
    }

}