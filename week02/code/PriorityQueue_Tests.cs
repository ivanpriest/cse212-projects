using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
   
    // Scenario: Enqueue three items with different priorities, then dequeue
    // Expected Result: Dequeue returns the item with the highest priority
    // Defect(s) Found: Original Dequeue loop skips last item and doesn't remove item
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result); // Highest priority = 3
    }


    [TestMethod]
    // Scenario: Enqueue items with same highest priority, dequeue once
    // Expected Result: The first item with highest priority is returned
    // Defect(s) Found: Original code used >= and picks last item
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("X", 5);
        priorityQueue.Enqueue("Y", 5);
        priorityQueue.Enqueue("Z", 2);
        var result = priorityQueue.Dequeue();

        Assert.AreEqual("X", result); // FIFO behavior for ties
    }


    // Add more test cases as needed below.


    [TestMethod]
    // Scenario: Dequeue multiple times to ensure highest priority removed each time
    // Expected Result: Dequeue returns items in descending priority order
    // Defect(s) Found: Original code doesn't remove the item, so repeated dequeues return same value
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);
        Assert.AreEqual("B", priorityQueue.Dequeue()); // Highest priority
        Assert.AreEqual("C", priorityQueue.Dequeue()); // Next highest
        Assert.AreEqual("A", priorityQueue.Dequeue()); // Last
    }

    

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: InvalidOperationException thrown
    // Defect(s) Found: Original code may throw default exception but spec requires InvalidOperationException
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
    }


}