using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class LinkedStack : IStackADT
    {
        private Node top;

        public LinkedStack()
        {
            top = null;
        }

        object Push(object newItem)
        {
            if(newItem == null)
            {
                return null;
            }
            Node newNode = new Node(newItem, top);
            top = newNode;
            return newItem;
        }

        object Pop()
        {
            if(IsEmpty())
            {
                return null;
            }
            object topItem = top.Data;
            top = top.Next;
            return topItem;
        }
        
        object Peek()
        {
            if(IsEmpty())
            {
                return null;
            }
            return top.Data;
        }

        bool IsEmpty()
        {
            return top == null;
        }

        void clear()
        {
            top = null;
        }


    }
}
