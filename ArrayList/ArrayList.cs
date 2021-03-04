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

        public int IndexOf(int value)
        {
            int index = -1;
            //bool flag=false;

            if (!isEmpty)
            {
                for (int i = 0; i < count; i++)
                {
                    if (data[i] == value)
                    {
                        //flag=true;
                        index = i;
                        return index;
                    }
                }
                throw new ArgumentException();
            }

            return index;
        }

        public string AddAll(int[] arr)
        {
            int spaceNeeded = Length(arr) - (capacity - count);

            if (spaceNeeded > capacity)
            {
                Resize(spaceNeeded);
            }
            foreach (int i in arr)
            {
                data[count] = i;
                count += 1;
            }

            if (count == capacity)
            {
                Resize();
            }
            IsEmpty();

            return print();
        }

        public int Length(ICollection<int> l)
        {
            int len = 0;
            
            foreach (int i in l)
            {
                len += 0;
            }

            return len;
        }

        public string Resize(int upperBound)
        {
            int[] temp = new int[count];
            while (capacity <= upperBound)
            {
                capacity = capacity * 2;
            }
            

            for (int i = 0; i < count; i++)
            {
                temp[i] = data[i];
            }
            data = temp;

            return print();
        }

        public string Remove(int value, bool removeAll = false)
        {
            if (!isEmpty)
            {
                if (removeAll)
                {
                    
                    int[] temp = new int[capacity];

                    for (int i = 0; i < count; i++)
                    {
                        bool flag = false;
                        int skipCount = 0;
                        if (data[i] == value)
                        {
                            int j = i;
                            while (data[j] == value && j<count)
                            {
                                flag = true;
                                count -= 1;
                                skipCount += 1;
                                j+=1;
                            }
                        }
                        if (flag && skipCount>=count-i)
                        {
                            temp[i] = data[i + skipCount];
                            data[i + skipCount] = value;
                        }
                    }

                    data = temp;

                }
                else
                {
                    bool flag = false;
                    for (int i = 0; i < count; i++)
                    {
                        if (data[i] == value)
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            data[i] = data[i + 1];
                        }
                    }
                    if (flag)
                    {
                        count -= 1;
                    }
                }
                
            }
            else
            {
                throw new ArgumentException();
            }
            IsEmpty();

            return print();
        }

        public string InserAll(int index, int[] arr)
        {

            return print();
        }

        public int Max()
        {
            int max = int.MinValue;
            if (!isEmpty)
            {
                for (int i = 0; i < count; i++)
                {
                    if (data[i] > max)
                    {
                        max = data[i];
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }

            return max;
        }

        public int Min()
        {
            int min = int.MaxValue;

            if (!isEmpty)
            {
                for (int i = 0; i < count; i++)
                {
                    if (data[i] < min)
                    {
                        min = data[i];
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }

            return min;
        }

        public int Sum()
        {
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += data[i];
            }

            return sum;
        }

        public string Reverse()
        {
            int[] temp = new int[capacity];
            //somewhat wrong
            for (int i = 0,j=count-1; i < count&& j<count; i++,j--)
            {
                temp[i] = data[j-i];
                temp[j] = data[i];
            }

            return print();
        }

        public int[] ToArray(int startIndex)
        {
            int size = count - startIndex;
            int[] temp = new int[size];
            if (!isEmpty)
            {
                if (startIndex >= 0 && startIndex < count)
                {
                    for (int i = startIndex, j = 0; i < count && j < size; i++, j++)
                    {
                        temp[j] = data[i];
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentException();
            }

            return temp;
        }

        public string ToArray(int startIndex, int endIndex)
        {

            return print();
        }


    }
}
