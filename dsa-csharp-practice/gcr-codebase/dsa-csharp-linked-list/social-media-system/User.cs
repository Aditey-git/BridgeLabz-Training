using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.social_media_system
{
    internal class User
    {
        public int IdOfUser;
        public string UserName;
        public int Age;
        public Node FriendsList; // Singly linked list of Friend IDs
        public User Next;

        public User(int id, string name, int age)
        {
            IdOfUser = id;
            UserName = name;
            Age = age;
            FriendsList = null;
            Next = null;
        }
    }
}
