using System;
using static System.Console;

namespace EventsDelegatesAndLambdas
{
    class Program
    {
        #region Delegates Initializer
        //static void Main()
        //{
        //    var del1 = new WorkPerformHandler(WorkPerformed1);
        //    var del2 = new WorkPerformHandler(WorkPerformed2);
        //    del1 += del2;
        //    del1(10, WorkType.Golf);

        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    WriteLine("WorkPerformed1 call " + hours.ToString());
        //    return hours + 1;
        //}
        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    WriteLine("WorkPerformed1 call " + workType.ToString());
        //    return hours + 1;
        //}
        #endregion

        static void Main(string[] args)
        {
            Worker worker = new Worker();
            //worker.WorkPerformed += new EventHandler<WorkPerforemedEventArgs>(Worker_WorkPerformed);
            //worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);
            worker.WorkPerformed += (s, e) =>
            {
                WriteLine("Hours worked: " + e.Hours + " " + e.WorkType.ToString());
                WriteLine("Some other Values");
            };
            worker.WorkCompleted += (s, e) => WriteLine("Work has been Complete.");
            worker.DoWork(8, WorkType.Golf);
        }

        //static void Worker_WorkPerformed(Object? sender, WorkPerforemedEventArgs e)
        //{
        //    WriteLine("Hours worked: " + e.Hours + " " + e.WorkType.ToString());
        //}

        //static void Worker_WorkCompleted(Object? sender, EventArgs e)
        //{
        //    WriteLine("Work has been Complete.");
        //}

    }
}