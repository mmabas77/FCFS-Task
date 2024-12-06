using FCFSApp;

namespace FCFSTests;

public class FcfsTests
{
    [Fact]
    [Trait("TestGroup", "TestTurnAroundTime")]
    public void TestTurnAroundTime()
    {
        // Test Case 1: Simple case with known burst times
        double[] burstTime = { 4, 3, 2, 1 };
        FCFS fcfs = new FCFS(burstTime);

        // Expected Turnaround Time: [4, 7, 9, 10]
        double[] expectedTurnAroundTime = { 4, 7, 9, 10 };
        double[] actualTurnAroundTime = fcfs.GetTurnAroundTime();

        Assert.Equal(expectedTurnAroundTime, actualTurnAroundTime);
        Assert.False(fcfs.GetIsAiWritingThisFunction());
    }

    [Fact]
    [Trait("TestGroup", "TestWaitingTime")]
    public void TestWaitingTime()
    {
        // Test Case 2: Simple case with known burst times
        double[] burstTime = { 4, 3, 2, 1 };
        FCFS fcfs = new FCFS(burstTime);

        // Expected Waiting Time: [0, 4, 7, 9]
        double[] expectedWaitingTime = { 0, 4, 7, 9 };
        double[] actualWaitingTime = fcfs.GetWaitingTime();

        Assert.Equal(expectedWaitingTime, actualWaitingTime);
        Assert.False(fcfs.GetIsAiWritingThisFunction());
    }

    [Fact]
    [Trait("TestGroup", "TestAverageWaitingTime")]
    public void TestAverageWaitingTime()
    {
        // Test Case 3: Known burst times
        double[] burstTime = { 4, 3, 2, 1 };
        FCFS fcfs = new FCFS(burstTime);

        // Expected Average Waiting Time: (0 + 4 + 7 + 9) / 4 = 5
        double expectedAverageWaitingTime = 5;
        double actualAverageWaitingTime = fcfs.GetAverageWaitingTime();

        Assert.Equal(expectedAverageWaitingTime, actualAverageWaitingTime);
        Assert.False(fcfs.GetIsAiWritingThisFunction());
    }

    [Fact]
    [Trait("TestGroup", "TestAverageTurnAroundTime")]
    public void TestAverageTurnAroundTime()
    {
        // Test Case 4: Known burst times
        double[] burstTime = { 4, 3, 2, 1 };
        FCFS fcfs = new FCFS(burstTime);

        // Expected Average Turnaround Time: (4 + 7 + 9 + 10) / 4 = 7.5
        double expectedAverageTurnAroundTime = 7.5;
        double actualAverageTurnAroundTime = fcfs.GetAverageTurnAroundTime();

        Assert.Equal(expectedAverageTurnAroundTime, actualAverageTurnAroundTime);
        Assert.False(fcfs.GetIsAiWritingThisFunction());
    }

    [Fact]
    [Trait("TestGroup", "TestSingleProcess")]
    public void TestSingleProcess()
    {
        // Test Case 6: Single process edge case
        double[] burstTime = { 5 };
        FCFS fcfs = new FCFS(burstTime);

        // Expected Turnaround Time: [5]
        double[] expectedTurnAroundTime = { 5 };
        double[] actualTurnAroundTime = fcfs.GetTurnAroundTime();
        Assert.Equal(expectedTurnAroundTime, actualTurnAroundTime);

        // Expected Waiting Time: [0]
        double[] expectedWaitingTime = { 0 };
        double[] actualWaitingTime = fcfs.GetWaitingTime();
        Assert.Equal(expectedWaitingTime, actualWaitingTime);

        // Expected Average Waiting Time: 0
        double expectedAverageWaitingTime = 0;
        double actualAverageWaitingTime = fcfs.GetAverageWaitingTime();
        Assert.Equal(expectedAverageWaitingTime, actualAverageWaitingTime);

        // Expected Average Turnaround Time: 5
        double expectedAverageTurnAroundTime = 5;
        double actualAverageTurnAroundTime = fcfs.GetAverageTurnAroundTime();
        Assert.Equal(expectedAverageTurnAroundTime, actualAverageTurnAroundTime);
        Assert.False(fcfs.GetIsAiWritingThisFunction());
    }
}