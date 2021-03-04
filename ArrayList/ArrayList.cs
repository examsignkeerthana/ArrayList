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

        public void IsEmpty()
        {
            if (count > 0)
            {
                isEmpty = false;
            }
            else
            {
               isEmpty = true;
            }
        }

        public int Get(int index)
        {
            int ind = int.MaxValue;
            if (index < count && index > -1)
            {
                ind = data[index];
            }
            else
            {
                throw new ArgumentException();
            }

            return ind;
        }

        public string Set(int index, int value)
        {
            if (index < count && index > -1)
            {
                data[index] = value;
                count += 1;
            }
            else
            {
                throw new ArgumentException();
            }
            
            return print();
        }

        public string Insert(int index, int value)
        {
            if (index <= count && index > -1)
            {
                for (int i = count; i >= index; i--)
                {
                    if (i != index)
                    {
                        data[i] = data[i - 1];
                    }
                    else
                    {
                        data[i] = value;
                    }
                }
                count += 1;
            }
            else
            {
                throw new ArgumentException();
            }

            if (count == capacity)
            {
                Resize();
            }
            IsEmpty();

            return print();
        }

        public string Delete(int index)
        {
            if (index < count && index > -1)
            {
                for (int i = index; i < count; i++)
                {
                    data[i] = data[i + 1];
                }
                data[count] = 0;

                count -= 1;
            }
            else
            {
                throw new ArgumentException();
            }
            IsEmpty();
            return print();
        }

        public bool Contaions(int value)
        {
            bool flag = false;
            if (!isEmpty)
            {
                for (int i = 0; i < count; i++)
                {
                    if (data[i] == value)
                    {
                        flag = true;
                        return flag;
                    }
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
            
            return flag;
        }

        public string Add(int value)
        {
            data[count] = value;
            count += 1;

            IsEmpty();

            return print();
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

        public string print()
        {
            StringBuilder sb = new StringBuilder();
            
            if (!isEmpty)
            {
                sb.Append("[");
                for (int i = 0; i < count - 1; i++)
                {
                    sb.Append(data[i] + ",");
                }
                sb.Append(data[count - 1] + "]");
            }
            else
            {
                throw new InvalidOperationException();
            }

            return sb.ToString();
        }
    }
}
