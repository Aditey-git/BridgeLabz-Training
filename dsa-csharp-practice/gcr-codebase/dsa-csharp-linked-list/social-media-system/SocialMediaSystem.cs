using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.social_media_system
{
    internal class SocialMediaSystem
    {
        private User head = null;

        public void AddUserToList(int id, string name, int age)
        {
            User newUser = new User(id, name, age);
            newUser.Next = head;
            head = newUser;
        }

        private User SearchUser(int id)
        {
            User current = head;
            while (current != null)
            {
                if (current.IdOfUser == id) return current;
                current = current.Next;
            }
            return null;
        }

        public void FriendConnectionAdd(int id1, int id2)
        {
            User us1 = SearchUser(id1);
            User us2 = SearchUser(id2);

            if (us1 != null && us2 != null)
            {
                us1.FriendsList = FriendIDAdd(us1.FriendsList, id2);
                us2.FriendsList = FriendIDAdd(us2.FriendsList, id1);
            }
        }

        private Node FriendIDAdd(Node list, int id)
        {
            Node curr = list;
            while (curr != null)
            {
                if (curr.IdOfFriend == id) return list;
                curr = curr.Next;
            }
            return new Node(id) { Next = list };
        }

        public void FriendConnectionRemove(int id1, int id2)
        {
            User us1 = SearchUser(id1);
            User us2 = SearchUser(id2);

            if (us1 != null && us2 != null)
            {
                us1.FriendsList = FriendIDRemove(us1.FriendsList, id2);
                us2.FriendsList = FriendIDRemove(us2.FriendsList, id1);
            }
        }

        private Node FriendIDRemove(Node list, int id)
        {
            if (list == null) return null;
            if (list.IdOfFriend == id) return list.Next;

            Node current = list;
            while (current.Next != null)
            {
                if (current.Next.IdOfFriend == id)
                {
                    current.Next = current.Next.Next;
                    return list;
                }
                current = current.Next;
            }
            return list;
        }

        public void SearchMutualFriends(int id1, int id2)
        {
            User us1 = SearchUser(id1);
            User us2 = SearchUser(id2);
            if (us1 == null || us2 == null) return;

            Console.Write($"Mutual Friends of {us1.UserName} and {us2.UserName}: ");
            Node fr1 = us1.FriendsList;
            while (fr1 != null)
            {
                Node fr2 = us2.FriendsList;
                while (fr2 != null)
                {
                    if (fr1.IdOfFriend == fr2.IdOfFriend)
                    {
                        User mutual = SearchUser(fr1.IdOfFriend);
                        Console.Write($"{mutual.UserName} ");
                    }
                    fr2 = fr2.Next;
                }
                fr1 = fr1.Next;
            }
            Console.WriteLine();
        }

        public void DisplayUserFriends(int id)
        {
            User us = SearchUser(id);
            if (us == null) return;

            Console.Write($"{us.UserName}'s Friends: ");
            Node current = us.FriendsList;
            while (current != null)
            {
                User fr = SearchUser(current.IdOfFriend);
                Console.Write($"{fr.UserName} ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void SearchUser(string name = null, int? id = null)
        {
            User current = head;
            while (current != null)
            {
                if ((id.HasValue && current.IdOfUser == id.Value) ||
                    (name != null && current.UserName.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Found: {current.UserName} (ID: {current.IdOfUser}), Age: {current.Age}");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("User not found.");
        }

        public void DisplayFriendCounts()
        {
            User curr = head;
            while (curr != null)
            {
                int count = 0;
                Node f = curr.FriendsList;
                while (f != null) { count++; f = f.Next; }
                Console.WriteLine($"{curr.UserName}: {count} friends");
                curr = curr.Next;
            }
        }

        public static void Main()
        {
            SocialMediaSystem sm = new SocialMediaSystem();
            sm.AddUserToList(1, "Alice", 20);
            sm.AddUserToList(2, "Bob", 22);
            sm.AddUserToList(3, "Charlie", 21);
            sm.AddUserToList(4, "David", 23);

            sm.FriendConnectionAdd(1, 2);
            sm.FriendConnectionAdd(1, 3);
            sm.FriendConnectionAdd(4, 2);
            sm.FriendConnectionAdd(4, 3);

            sm.DisplayUserFriends(1);
            sm.SearchMutualFriends(1, 4);
            sm.DisplayFriendCounts();
        }
    }
}
