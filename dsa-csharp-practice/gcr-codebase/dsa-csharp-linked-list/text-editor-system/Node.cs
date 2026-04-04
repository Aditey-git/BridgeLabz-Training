using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.text_editor_system
{
    internal class Node
    {
        public string Content;
        public Node Prev;
        public Node Next;

        public Node(string content)
        {
            Content = content;
            Prev = null;
            Next = null;
        }
    }
}
