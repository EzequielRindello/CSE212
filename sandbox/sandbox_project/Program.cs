using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("\n======================\nSimple Stack\n======================");

        var stack = new Stack<int>();
        // The solution notes here show the back of the stack to the right, so it is
        // easier to visualize the items that are added and removed.
        stack.Push(1);  // 1
        stack.Push(2);  // 1, 2
        stack.Push(3);  // 1, 2, 3
        stack.Pop();    // 1, 2
        stack.Pop();    // 1
        stack.Push(4);  // 1, 4
        stack.Push(5);  // 1, 4, 5
        stack.Pop();    // 1, 4
        stack.Push(6);  // 1, 4, 6
        stack.Push(7);  // 1, 4, 6, 7
        stack.Push(8);  // 1, 4, 6, 7, 8
        stack.Push(9);  // 1, 4, 6, 7, 8, 9
        stack.Pop();    // 1, 4, 6, 7, 8
        stack.Pop();    // 1, 4, 6, 7
        stack.Push(10); // 1, 4, 6, 7, 10
        stack.Pop();    // 1, 4, 6, 7
        stack.Pop();    // 1, 4, 6
        stack.Pop();    // 1, 4
        stack.Push(11); // 1, 4, 11
        stack.Push(12); // 1, 4, 11, 12
        stack.Pop();    // 1, 4, 11
        stack.Pop();    // 1, 4
        stack.Pop();    // 1
        stack.Push(13); // 1, 13
        stack.Push(14); // 1, 13, 14
        stack.Push(15); // 1, 13, 14, 15
        stack.Push(16); // 1, 13, 14, 15, 16
        stack.Pop();    // 1, 13, 14, 15
        stack.Pop();    // 1, 13, 14
        stack.Pop();    // 1, 13
        stack.Push(17); // 1, 13, 17
        stack.Push(18); // 1, 13, 17, 18
        stack.Pop();    // 1, 13, 17
        stack.Push(19); // 1, 13, 17, 19
        stack.Push(20); // 1, 13, 17, 19, 20
        stack.Pop();    // 1, 13, 17, 19
        stack.Pop();    // 1, 13, 17

        Console.WriteLine("Final contents:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));


        Console.WriteLine("\n======================\nSimple Queue\n======================");

        var queue = new Queue<int>();
        queue.Enqueue(1); 
        queue.Enqueue(2); 
        queue.Enqueue(3); // 1 2 3
        queue.Dequeue();
        queue.Dequeue();  // 3
        queue.Enqueue(4);
        queue.Enqueue(5); // 3 4 5
        queue.Dequeue();
        queue.Enqueue(6);
        queue.Enqueue(7);
        queue.Enqueue(8);
        queue.Enqueue(9); // 4 5 6 7 8 9 
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(10); // 6 7 8 9 10
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();  
        queue.Enqueue(11);
        queue.Enqueue(12); // 9 10 11 12 
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(13);
        queue.Enqueue(14);
        queue.Enqueue(15);
        queue.Enqueue(16); // 12 13 14 15 16 
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(17);
        queue.Enqueue(18); // 15 16 17 18
        queue.Dequeue();
        queue.Enqueue(19);
        queue.Enqueue(20); // 16 17 18 19 20 
        queue.Dequeue();
        queue.Dequeue();

        Console.WriteLine("Final contents:"); // 18 19 20 
        Console.WriteLine(String.Join(", ", queue.ToArray()));

        Random rnd = new Random();
        int num  = rnd.Next(1, 11);
        int guess = 0;
        
        while(true){
            Console.WriteLine("Enter a number");
            guess = Convert.ToInt32(Console.ReadLine());
            
            if(guess==num)
            {
                Console.WriteLine("Congrats!");
                break;
            }
            else if(guess < num)
            {
                Console.WriteLine("To low");
            }
            else
            {
                Console.WriteLine("To higth");
            }
        }
    }
}