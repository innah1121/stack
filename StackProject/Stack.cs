using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    class Stack : IStack
    {
        private int[]  items = new int[5];
        private int lastItem = 0;
        private enum Exceptions
        {
            StackEmpty = 0,
            StackFull = 5
        }

        public int Length
        {
            get
            {
                return lastItem;
            }
        }
       

        public void Push(int item)
        {
            items[lastItem] = item;
            lastItem++;
            if (lastItem == (int)Exceptions.StackFull)
            {
                Console.WriteLine("Cant push any item becouse stack is full");
            }
         }

        public int Pop()
        {
            if(lastItem == (int)Exceptions.StackEmpty)
            {
                Console.WriteLine("Cant pop any element becouse the stack is empty");
            }

            lastItem--;
            return items[lastItem];
        }
    }

 }

