using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IStackADT
    {
        /// Pushes a new object onto the top of the stack.
        ///
        /// parameters: object newItem (The object to be pushed onto the stack.)
        /// Returns: object (The object pushed onto stack.)
        object Push(object newItem);

        /// Pops off and returns the object on top of the stack.
        ///
        /// parameters: NULL
        /// Returns: object (The object on the top of the stack.)
        object Pop();

        /// Looks at the top element of the stack without popping it off.
        ///
        /// parameters: NULL
        /// Returns: object (The object on the top of the stack.)
        object Peek();

        /// Checks to see if the stack is empty.
        ///
        /// parameters: NULL
        /// Returns: bool (True if stack is empty, false otherwise.)
        bool IsEmpty();

        /// Clears the stack.
        ///
        /// parameters: NULL
        /// Returns: void
        void Clear();
    }
}
