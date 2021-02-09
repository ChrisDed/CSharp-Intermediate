using System;
using System.Collections;

namespace InheritanceExercises
{
    public class Stack
    {
        private readonly ArrayList stack = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot pass null to Stack.Push()");

            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count < 1)
                throw new InvalidOperationException("Cannot pop on an empty Stack.");

            return RemoveLastElement();
        }

        public void Clear()
        {
            stack.Clear();
        }

        public void LogAllElements()
        {
            if (stack.Count < 1)
                Console.WriteLine("Stack is empty");

            foreach (var element in stack)
                Console.WriteLine(element);
        }

        private object RemoveLastElement()
        {
            int lastIndex = stack.Count - 1;
            var popped = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return popped;
        }
    }
}
