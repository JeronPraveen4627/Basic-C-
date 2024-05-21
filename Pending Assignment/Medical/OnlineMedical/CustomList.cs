using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public partial class CustomList<Type>
    {
        private int _count;

        private int _capacity;

        private Type[] array;

        public int Count{get{return _count;}}

        public int Capacity{get{return _capacity;}}

        
        public Type this[int index]
        {
            get{return array[index];}
            set{array[index]=value;}
        }

        public CustomList()
        {
            _count=0;
            _capacity=4;
            array=new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            array=new Type[_capacity];
        }
        public void Add(Type element)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            array[_count]=element;
            _count++;
        }
        void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for (int i=0;i<_count;i++)
            {
                temp[i]=array[i];
            }
            array=temp;
        }
        public void AddRange(CustomList<Type> elements)
        {
            _capacity=_count+elements.Count+5;
            Type[] temp=new Type[_capacity];
            for(int i =0;i<_count;i++)
            {
                temp[i]=array[i];
            }
            int k=0;
            for(int i=_count;i<_count+elements.Count;i++)
            {
                temp[i]=elements[k];
                k++;
            }
            array=temp;
            _count=_count+elements.Count;
        }

        public bool Contains(Type elements)
        {
            bool flag =false;
            foreach(Type i in array)
            {
                if(i.Equals(elements))
                {
                    flag=true;
                    break;
                }
               
            }
             return flag;
        }
        public int IndexOf(Type element)
        {
            int index=-1;
            for(int i=0;i<_count;i++)
            {
                if(element.Equals(array[i]))
                {
                    index=i;
                    break;
                }
            }
            return index;
        }

        public void InsertOf(int position,Type elements)
        {
            _capacity=_capacity+1+4;
            Type[] temp=new Type[_capacity];
            for(int i =0;i<=_count;i++)
            {
                if(i<position)
                {
                    temp[i]=array[i];
                }
                else if(i==position)
                {
                    temp[i]=elements;
                }
                else
                {
                    temp[i]=array[i-1];
                }
            }
            array=temp;
            _count++;
        }

        /* 1 2 3 4 5 Remove the element of 3 Index
            Output==> 1 2 3 5
        */
        public void RemoveAt(int position)
        {
            for (int i=0;i<_count-1;i++)
            {
                if(i>=position)
                {
                    array[i]=array[i+1];
                }
               
            }
             _count--;
        }

        public bool Remove(Type element)
        {
            int position=IndexOf(element);
            if(position>=0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }
    }
}