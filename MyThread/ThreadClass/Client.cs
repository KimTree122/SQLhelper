using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThread.ThreadClass
{
    public class Client
    {
        public FinancialWorker GetFinancialTotalsBackground(int foo, int bar)
        {
            return new FinancialWorker(foo, bar);
        }
    }

    public class FinancialWorker : BackgroundWorker
    {
        public Dictionary<string, int> Result;   // We can add typed fields.
        public volatile int Foo, Bar;            // We could even expose them
        // via properties with locks!
        public FinancialWorker()
        {
            WorkerReportsProgress = true;
            WorkerSupportsCancellation = true;
        }

        public FinancialWorker(int foo, int bar)
            : this()
        {
            this.Foo = foo; this.Bar = bar;
        }

        protected override void OnDoWork(DoWorkEventArgs e) {
    ReportProgress (0, "Working hard on this report...");
    //Initialize financial report data
  
    //while (!finished report ) {
    //  if (CancellationPending) {
    //    e.Cancel = true;
    //    return;
    //  }
      //Perform another calculation step
      //ReportProgress (percentCompleteCalc, "Getting there...");
    }      
    //ReportProgress (100, "Done!");
    //e.Result = Result = completed report data;
  }     
}
