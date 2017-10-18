using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IStackADT
    {
        object Push(object newItem);
        object Pop();
        object Peek();
        bool IsEmpty();
        void Clear();
    }
}
