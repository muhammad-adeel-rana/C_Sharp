using System.Security.Cryptography;

namespace EventsDelegatesAndLambdas;
//public delegate int WorkPerformHandler(int hours, WorkType workType);
internal class Worker
{
    public event EventHandler<WorkPerforemedEventArgs>? WorkPerformed;
    public event EventHandler? WorkCompleted;

    public void DoWork(int hours, WorkType workType)
    {
        for (int i = 0; i < hours; i++)
        {
            Thread.Sleep(1000);
            OnWorkPerformed(i+1, workType);
        }

        OnWorkCompleted();
    }

    protected virtual void OnWorkPerformed(int hours, WorkType workType)
    {
        WorkPerformed?.Invoke(this, new WorkPerforemedEventArgs(hours, workType));
    }

    protected virtual void OnWorkCompleted()
    {
        WorkCompleted?.Invoke(this, EventArgs.Empty);
    }
}
