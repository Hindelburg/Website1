﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class LinkedStack : IStackADT
    {
        private Node top;

        public LinkedStack()
        {
            top = null;
        }

        public object Push(object newItem)
        {
            if(newItem == null)
            {
                return null;
            }
            Node newNode = new Node(newItem, top);
            top = newNode;
            return newItem;
        }

        public object Pop()
        {
            if(IsEmpty())
            {
                return null;
            }
            object topItem = top.Data;
            top = top.Next;
            return topItem;
        }

        public object Peek()
        {
            if(IsEmpty())
            {
                return null;
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Clear()
        {
            top = null;
        }


    }
}
