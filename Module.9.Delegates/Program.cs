using System;

namespace Module._9.Delegates
{
    class Parent { }
    class Child : Parent { }

    class Program
    {
        delegate void ChildDelegate(Child child);

        static void Main(string[] args)
        {
            ChildDelegate childDelegate = GetChildInfo;
        }

        static void GetChildInfo(Parent parent)
        {
          
        }
    }
}

