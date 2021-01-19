using System;
using System.Collections.Generic;
using System.Text;

namespace Lista
{
    class List
    {
        private int[] list;

        public int Count
        {
            get;
            private set;
        }

        public int this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }

        public List()
        {
            list = new int[10]; 
        }

        private void Resize(int newSize)
        {
            int[] temp = list;
            list = new int[newSize];
            for (int i = 0; i < temp.Length; i++)
            {
                list[i] = temp[i];
            }
        }

        public void add(int item)
        {
            if (Count == list.Length)
            {
                int newSize = (int)(Count * 1.5f);
                Resize(newSize);
            }
                

            list[Count] = item;
            Count++;
        }

        public void Remove(int index)
        {
            for(int i = index; i < Count - 1; i++)
            {
                list[i] = list[i + 1];
            }
            Count--;
        }

        public void Clear()
        {
            list = new int[10];
            Count = 0;
        }        
    }
}
