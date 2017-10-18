using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calculator namespace.
namespace Calculator
{
    public class Node
    {
        object data;
        Node next;

        /// Constructor for an empty Node.
        ///
        /// parameters: NULL
        /// Returns: NA
        public Node()
        {
            data = null;
            next = null;
        }

        /// Constructor for Node with parameters.
        ///
        /// parameters: object data, Node next (Data is what should be held in the Node, while next points to the next Node on the stack.)
        /// Returns: NA
        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        /// The set and get commands for data.
        ///
        /// parameters: value
        /// Returns: object Data (Returns the value of data if using get, and sets it if using set.)
        public object Data
        {
            get { return data; }
            set { data = value; }
        }

        /// The get command for next.
        ///
        /// parameters: NA
        /// Returns: Node Next (Returns the value of next.)
        public Node Next
        {
            get { return next; }
        }
    }
}
