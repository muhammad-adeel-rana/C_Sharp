namespace EventsDelegatesAndLambdas;
public class WorkPerforemedEventArgs
{   
    public int Hours { get; set; }
    public WorkType WorkType { get; set; }

    public WorkPerforemedEventArgs(int hours, WorkType workType) =>
        (Hours, WorkType) = (hours, workType);
    //{
    //    Hours = hours;
    //    WorkType = workType;
    //}
}