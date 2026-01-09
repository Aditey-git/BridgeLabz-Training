using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining2.DSA.LinkedList.text_editor_system
{
    internal class TextEditor
    {
        private Node head = null;
        private Node tail = null;
        private Node curr = null;
        private int history = 0;
        private const int HistoryMax = 10;

        public void Type(string text)
        {
            // When typing new text, any "redo" history beyond current state is cleared
            Node newState = new Node(text);

            if (head == null)
            {
                head = tail = curr = newState;
                history = 1;
            }
            else
            {
                // Clear redo path
                curr.Next = newState;
                newState.Prev = curr;
                curr = newState;
                tail = curr;

                // Recalculate size after clearing redo path
                int count = 0;
                Node temp = head;
                while (temp != null) { count++; temp = temp.Next; }
                history = count;

                // Enforce size limit
                if (history > HistoryMax)
                {
                    head = head.Next;
                    head.Prev = null;
                    history--;
                }
            }
            Console.WriteLine($"Typed: {text}");
        }

        public void Undo()
        {
            if (curr != null && curr.Prev != null)
            {
                curr = curr.Prev;
                Console.WriteLine("Action: Undo");
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void Redo()
        {
            if (curr != null && curr.Next != null)
            {
                curr = curr.Next;
                Console.WriteLine("Action: Redo");
            }
            else
            {
                Console.WriteLine("Nothing to redo.");
            }
        }

        public void Display()
        {
            if (curr != null)
            {
                Console.WriteLine($"Current Screen: {curr.Content}");
            }
            else
            {
                Console.WriteLine("Screen is empty.");
            }
        }

        public static void Main()
        {
            TextEditor editor = new TextEditor();

            editor.Type("Hello");
            editor.Type("Hello World");
            editor.Type("Hello World!");
            editor.Display();

            editor.Undo();
            editor.Display();

            editor.Undo();
            editor.Display();

            editor.Redo();
            editor.Display();

            editor.Type("Hello C#"); // This clears the previous redo "Hello World!"
            editor.Redo(); // Should show nothing to redo
            editor.Display();
        }
    }
}
