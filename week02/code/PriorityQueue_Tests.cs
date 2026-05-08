using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: This test checks if the queue removes the item with the highest priority first.
    // Expected Result: B should be returned because it has the highest priority.
    // Defect(s) Found: No defect found after the priority queue logic was fixed.
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 1);
        queue.Enqueue("B", 5);
        queue.Enqueue("C", 3);

        Assert.AreEqual("B", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: This test checks if items with the same priority follow FIFO order.
    // Expected Result: A should be returned before B because A was added first.
    // Defect(s) Found: No defect found after the priority queue logic was fixed. 
    public void TestPriorityQueue_2()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 4);
        queue.Enqueue("B", 4);
        queue.Enqueue("C", 2);

        Assert.AreEqual("A", queue.Dequeue());
    }

    // Add more test cases as needed below.
}