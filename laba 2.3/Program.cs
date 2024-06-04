using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace laba_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            InPutStack(stack);
            Console.WriteLine();
            int avg = FingAvg(stack);
            Console.WriteLine($"среднее значение = {avg}\n");
            ChangeEvenValue(stack, avg);
            WriteStack(stack);
            Console.ReadLine();
        }

        static void InPutStack(Stack<int> stack)
        {
            Console.Write("Введите число элементов стека : ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите {i + 1} элемент стека : ");
                int element = Convert.ToInt32(Console.ReadLine());
                stack.Push(element);
            }
        }
        static int FingAvg(Stack<int> stack)
        {
            int avg = 0;
            int count = stack.Count;
            Stack<int> stack2 = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                int element = stack.Pop();
                avg += element;
                stack2.Push(element);
            }
            avg /= count;
            for (int i = 0; i < count; i++)
            {
                int element = stack2.Pop();
                stack.Push(element);
            }
            return avg;
        }
        static void ChangeEvenValue(Stack<int> stack, int avg)
        {
            int count = stack.Count;
            Stack<int> stack2 = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                int element = stack.Pop();
                if (element % 2 == 0)
                {
                    stack2.Push(avg);
                }
                else
                {
                    stack2.Push(element);
                }
            }
            for (int i = 0; i < count; i++)
            {
                int element = stack2.Pop();
                stack.Push(element);
            }
        }
        static void WriteStack(Stack<int> stack)
        {
            int count = stack.Count;
            Stack<int> stack2 = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                int element = stack.Pop();
                Console.WriteLine($"{i + 1} элемент стека сверху = {element}");
                stack2.Push(element);
            }
            for (int i = 0; i < count; i++)
            {
                int element = stack2.Pop();
                stack.Push(element);
            }
        }
    }
}
