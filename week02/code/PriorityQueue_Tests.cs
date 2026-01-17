using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue function shall add an item to the back of the queue
    // Expected Result: Value with the highest priority should be removed and returned.
    // Defect(s) Found: The original code do not always return the highest priority
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Dequeue function shall remove the item with the highest priority and return its value
    // Expected Result: The first item enqueued with the highest priority (FIFO) should be removed.
    // Defect(s) Found: Causing the last item with the same priority to be removed instead of the first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
        // Assert.Fail("Implement the test case and then remove this.");
    }

        [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: Each dequeue should remove the returned item from the queue.
    // Defect(s) Found: The original code returned the correct value but did not remove it from the queue.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();

        Assert.AreEqual("B", first);
        Assert.AreEqual("A", second);
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    // Scenario: If the queue is empty.
    // Expected Result: An InvalidOperationException should be thrown with the message "The queue is empty.".
    // Defect(s) Found: Original code did not throw correct exception message
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Dequeue();
        // Assert.Fail("Implement the test case and then remove this.");
    }
    // Add more test cases as needed below.
}