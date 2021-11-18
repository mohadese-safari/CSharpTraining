using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MultiThreadingInWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnClickMe_Click(object sender, EventArgs e)
        {
            string str;
            new Thread(() =>
            str = lblTestReadAccess.Text
            ).Start();
            lblAccessGranted.Text = "True";
        }

        #region Message loop using BeginInvoke
        // Works properly
        //private void btnCalculateNthPrime_Click(object sender, EventArgs e)
        //{
        //    var t = new Thread(() =>
        //    {
        //        var reult = new PrimeNumberCalculator().NthPrimeNumber(400000);
        //        this.BeginInvoke(new Action(() =>
        //        {
        //            lblNthPrime.Text = reult.ToString();
        //        }));
        //    });
        //    t.Start();
        //    t.Join();
        //}
        #endregion

        #region Message loop using Invoke
        //Example of live lock
        //private void btnCalculateNthPrime_Click(object sender, EventArgs e)
        //{
        //    var t = new Thread(() =>
        //    {
        //        var reult = new PrimeNumberCalculator().NthPrimeNumber(10000);
        //        this.Invoke(new Action(() =>
        //        {
        //            lblNthPrime.Text = reult.ToString();
        //        }));
        //    });
        //    t.Start();
        //    t.Join();
        //}
        #endregion

        #region Background worker
        // Using background worker
        private long result;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            result = new PrimeNumberCalculator().NthPrimeNumber(300000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblNthPrime.Text = result.ToString();
        }

        //private void btnCalculateNthPrime_Click(object sender, EventArgs e)
        //{

        //    backgroundWorker1.RunWorkerAsync();
        //}
        #endregion
        private void btnCalculateNthPrime_Click(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            var t = new Thread(() =>
            {
                var reult = new PrimeNumberCalculator().NthPrimeNumber(400000);
                this.BeginInvoke(new Action(() =>
                {
                    lblNthPrime.Text = reult.ToString();
                }));
            });
            t.Start();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            lblExceptionOccuered.Text = "Exception caught";
        }
    }
}
