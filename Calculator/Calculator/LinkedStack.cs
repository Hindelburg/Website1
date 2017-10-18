using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class LinkedStack : IStackADT
    {
        private Node top;

        /// Constructor for the LinkedStack.
        ///
        /// parameters: NA
        /// Returns: NA
        public LinkedStack()
        {
            top = null;
        }

        /// Pushes a nonnull value to the top of the stack. 
        ///
        /// parameters: object newItem (The item to add to the stack.)
        /// Returns: object newItem (the item added to the stack.)
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

        /// Pops an object off the top of the list.
        ///
        /// parameters: NA
        /// Returns: object topItem (The item on the top of the list.)
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

        /// Peeks at the top of the stack without popping it.
        ///
        /// parameters: NA
        /// Returns: object top.Data (The value held in the top node of the stack.)
        public object Peek()
        {
            if(IsEmpty())
            {
                return null;
            }
            return top.Data;
        }

        /// Tests to see if the stack is empty.
        ///
        /// parameters: NA
        /// Returns: bool (True if the stack is empty.)
        public bool IsEmpty()
        {
            return top == null;
        }

        /// Clears the stack of all nodes.
        ///
        /// parameters: NA
        /// Returns: void
        public void Clear()
        {
            top = null;
        }
    }
}
