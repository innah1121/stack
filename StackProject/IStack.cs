using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    interface IStack
    {
        void Push(int item);
        int Pop();
        int Length { get; }
    }
}
