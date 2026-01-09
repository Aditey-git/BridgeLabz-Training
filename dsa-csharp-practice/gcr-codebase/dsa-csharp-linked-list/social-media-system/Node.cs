using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.social_media_system
{
    internal class Node
    {
        public int IdOfFriend;
        public Node Next;

        public Node(int id)
        {
            IdOfFriend = id;
            Next = null;
        }
    }
}
