using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayList
{
    public class arrayList
    {
        int capacity;
        int[] data ;
        int count ;
        bool isEmpty;

        public arrayList()
        {
            capacity = 2;
            data = new int[capacity];
            count = 0;
            isEmpty = true;
        }

        //public arrayList(int cap)
        //{
        //    data = new int[cap];
        //    capacity = cap;
        //}

        public int Get(int index)
        {
            int ind = int.MaxValue;
            if(index<capacity)
            {
                ind = data[index];
            }
            

            return ind;
        }

        public string Set(int index, int value)
        {
            StringBuilder sb = new StringBuilder();
            if (index <= count)
            {
                data[index] = value;
                count += 1;

                for (int i = 0; i < count; i++)
                {
                    sb.Append(data[i]);
                    sb.Append(" ");
                }
            }

            if (count == capacity)
            {
                Resize();
            }
            return sb.ToString();
        }

        public string Insert(int index, int value)
        {
            int[] temp = new int[capacity];
            StringBuilder sb = new StringBuilder();

            if (index <= count)
            {
                for (int i = 0; i <= count; i++)
                {
                    if (i < index)
                    {
                        temp[i] = data[i];
                    }
                    else if (i > index)
                    {
                        temp[i] = data[i - 1];
                    }
                    else if (i == index)
                    {
                        temp[i] = value;
                    }
                    sb.Append(temp[i]);
                    sb.Append(" ");
                }
            }
            
            count += 1;

            data = temp;

            if (count == capacity)
            {
                Resize();
            }

            return sb.ToString();
        }

        public void Delete(int index)
        {
            int[] temp = new int[capacity];

            for (int i = 0; i < count; i++)
            {
                if (i < index)
                {
                    temp[i] = data[i];
                }
                else if(i>index)
                {
                    temp[i - 1] = data[i];
                }
            }
            data = temp;
            count -= 1;
        }

        public bool Contaions(int value)
        {
            bool flag = false;

            for (int i = 0; i < count; i++)
            {
                if (data[i] == value)
                {
                    flag = true;
                    return flag;
                }
            }

            return flag;
        }

        public void Add(int value)
        {
            data[count] = value;
            count += 1;
        }

        public void Resize()
        {
            capacity *= 2;
            int[] temp = new int[capacity];

            for (int i = 0; i < count; i++)
            {
                temp[i] = data[i];
            }

            data = temp;
        }

        public void print()
        {
            
        }
    }
}
