using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProgramming_Compulsory_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spinner.Hide();            
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            resetCalculation();
            spinner.Show();
            long fromValueLong = Convert.ToInt64(fromValue.Text);
            long toValueLong = Convert.ToInt64(toValue.Text);
            calculateBtn.Enabled = false;
            parallelBtn.Enabled = false;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var uictx = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Factory.StartNew(() =>
            {
                return GetPrimeNumbersInRangeSequential(fromValueLong, toValueLong);
            }).ContinueWith((taskDone) =>
            {
                watch.Stop();
                var primeList = taskDone.Result;
                string resultString = "";
                Debug.WriteLine("Generating result string");
                for (int i = 0; i < (primeList.Count > 10_000 ? 10_000 : primeList.Count); i++)
                {
                    resultString += primeList[i];
                    if (i + 1 != primeList.Count)
                    {
                        resultString += " - ";
                    }
                };
                return resultString;
            }).ContinueWith((textTaskDone) =>
            {    
                timeLabel.Text = "Time: " + watch.ElapsedMilliseconds.ToString() + " milliseconds";
                resultBox.Text = textTaskDone.Result;
                spinner.Hide();
                calculateBtn.Enabled = true;
                parallelBtn.Enabled = true;
            },
            uictx // execute this task on UI thread:
            );
        }

        private List<long> GetPrimeNumbersInRangeSequential(long startValue, long toValue)
        {
            List<long> primeList = new List<long>();
            for (long i = startValue; i <= toValue; i++)
            {
                if (Check_Prime(i))
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }

        private bool Check_Prime(long number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            int root = (int)Math.Sqrt((double)number);
            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private List<long> GetPrimeNumbersInRangeParralel(long startValue, long toValue)
        {
            
            ConcurrentBag<long> bag = new ConcurrentBag<long>();

            Parallel.For(startValue, toValue, index =>
            {                
                if (Check_Prime(index))
                {                    
                    bag.Add(index);                    
                }
                
            });
            var list = bag.ToList();
            list.Sort();

            return list;
        }
        private void resetCalculation()
        {
            timeLabel.Text = "";
            resultBox.Text = "";
        }

        private void parallelBtn_Click(object sender, EventArgs e)
        {
            resetCalculation();
            spinner.Show();
            calculateBtn.Enabled = false;
            parallelBtn.Enabled = false;
            long fromValueLong = Convert.ToInt64(fromValue.Text);
            long toValueLong = Convert.ToInt64(toValue.Text);
            Debug.WriteLine("From:" + fromValueLong);
            Debug.WriteLine("To:" + toValueLong);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var uictx = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Factory.StartNew(() =>
            {
                return GetPrimeNumbersInRangeParralel(fromValueLong, toValueLong);
            }).ContinueWith((taskDone) =>
            {
                watch.Stop();
                var primeList = taskDone.Result;
                string resultString = "";
                Debug.WriteLine("Generating result string");
                // I am only showing the first 10_000 results
                for (int i = 0; i < (primeList.Count > 10_000 ? 10_000 : primeList.Count); i++)
                {
                    resultString += primeList[i];
                    if (i + 1 != primeList.Count)
                    {
                        resultString += " - ";
                    }
                };
                return resultString;
            }
            ).ContinueWith((textTaskDone) =>
            {              
                timeLabel.Text = "Time: " + watch.ElapsedMilliseconds.ToString() + " milliseconds";               
                resultBox.Text = textTaskDone.Result;
                spinner.Hide();
                calculateBtn.Enabled = true;
                parallelBtn.Enabled = true;
            },
            uictx // execute this task on UI thread:
            );   
        }
    }


}
