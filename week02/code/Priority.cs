public static class Priority
{
    public static void Test()
    {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add items with different priorities and dequeue them.
        // Expected Result: Items are dequeued in order of their priority.
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "High"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Medium"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Low"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "The queue is empty."
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add multiple items with the same highest priority.
        // Expected Result: Items with the same priority are dequeued in FIFO order.
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 5);
        priorityQueue.Enqueue("Fourth", 1);
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "First"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Second"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Third"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Fourth"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "The queue is empty."
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Try to dequeue from an empty queue.
        // Expected Result: Error message should be displayed.
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "The queue is empty."
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}