using System.Threading;

namespace Fischer.DataSuite.Management.UI.DeviceManagement.BackupAndRestore;

public class ProgressTracker
{
    private int totalCount;
    private int completedCount = 0;

    public ProgressTracker(int totalCount)
    {
        this.totalCount = totalCount;
    }

    public int GetProgressPercentage()
    {
        Interlocked.Increment(ref completedCount);

        return (completedCount * 100) / totalCount;
    }
}
