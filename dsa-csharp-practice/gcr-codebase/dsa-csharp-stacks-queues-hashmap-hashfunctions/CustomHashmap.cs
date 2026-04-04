using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.StackQueueHasmap
{
    class HashNode<K, V>
    {
        public K Key;
        public V Value;
        public HashNode<K, V> Next;

        public HashNode(K key, V value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
    internal class CustomHashmap<K, V>
    {
        private int capacityInt;
        private HashNode<K, V>[] bucketsArr;

        public CustomHashmap(int capacityInt = 10)
        {
            this.capacityInt = capacityInt;
            bucketsArr = new HashNode<K, V>[capacityInt];
        }

        // Hash function
        private int BucketIndexGetter(K key)
        {
            return Math.Abs(key.GetHashCode()) % capacityInt;
        }

        // Insert or Update
        public void Put(K key, V value)
        {
            int ind = BucketIndexGetter(key);
            HashNode<K, V> head = bucketsArr[ind];

            // Check if key exists
            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    head.Value = value; // update
                    return;
                }
                head = head.Next;
            }

            // Insert new node at head
            HashNode<K, V> newNode = new HashNode<K, V>(key, value);
            newNode.Next = bucketsArr[ind];
            bucketsArr[ind] = newNode;
        }

        // Retrieve value
        public V Get(K key)
        {
            int ind = BucketIndexGetter(key);
            HashNode<K, V> head = bucketsArr[ind];

            while (head != null)
            {
                if (head.Key.Equals(key))
                    return head.Value;

                head = head.Next;
            }

            throw new Exception("Key not found");
        }

        // Remove key
        public void Remove(K key)
        {
            int ind = BucketIndexGetter(key);
            HashNode<K, V> head = bucketsArr[ind];
            HashNode<K, V> prev = null;

            while (head != null)
            {
                if (head.Key.Equals(key))
                {
                    if (prev == null)
                        bucketsArr[ind] = head.Next;
                    else
                        prev.Next = head.Next;

                    return;
                }
                prev = head;
                head = head.Next;
            }
        }
    }

    class HashmapCustomize
    {
        public static void Main(string[] args)
        {
            CustomHashmap<string, int> map = new CustomHashmap<string, int>();

            map.Put("Apple", 100);
            map.Put("Banana", 50);
            map.Put("Orange", 80);

            Console.WriteLine(map.Get("Apple"));   // 100
            Console.WriteLine(map.Get("Banana"));  // 50

            map.Remove("Banana");

            // map.Get("Banana"); // Throws exception
        }
    }
}
