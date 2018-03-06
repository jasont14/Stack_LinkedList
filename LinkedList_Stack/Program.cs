/*
*****************************************
* Program.cs                   2018     *
*                                       *
* Entry point to demo stack.            *
*                                       *
* Jason Thatcher                        *
*****************************************
*/

using System;

namespace LinkedList_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack<string> stack = new LinkedListStack<string>();            

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Forth");

            Console.WriteLine("Pop four values");

            try { 

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("\nSHOULD BE EMPTY & THROW EMPTY EXCEPTION ");
            Console.WriteLine(stack.Pop());
            }

            catch (LinkedListStackEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
