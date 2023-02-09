using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Node
    {
        private double data;
        private Node next;

        public double Data { get => data; set => data = value; }
        public Node Next { get => next; set => next = value; }

        public Node()
        {
        }
    }
}
