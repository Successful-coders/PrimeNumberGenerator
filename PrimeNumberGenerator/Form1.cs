using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PrimeNumberGenerator
{
    public partial class Form1 : Form
    {
        private const int MIN_GEN_NUM = 0;
        private const int MAX_GEN_NUM = 50000;


        public Form1()
        {
            InitializeComponent();

            resulLabel.Visible = false;
            generatedNumberLabel.Visible = false;

            leadtimeLabel.Visible = false;
            leadtime.Visible = false;

            iterationCountLabel.Visible = false;
            iterationCountForm.Visible = false;

            primeCheckLabel.Visible = false;
        }

        private void generatePrimeNumber_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            double leadTimeSeconds;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int generatedNumber = PrimeNumGenerator.Generate(MIN_GEN_NUM, MAX_GEN_NUM, out int iterationCount);

            timer.Stop();
            leadTimeSeconds = timer.ElapsedMilliseconds / 1000.0d;

            this.Enabled = true;

            resulLabel.Visible = true;
            generatedNumberLabel.Visible = true;
            generatedNumberLabel.Text = generatedNumber.ToString();

            leadtimeLabel.Visible = true;
            leadtime.Visible = true;
            leadtime.Text = leadTimeSeconds + "сек.";

            iterationCountLabel.Visible = true;
            iterationCountForm.Visible = true;
            iterationCountForm.Text = iterationCount.ToString();
        }

        private void checkPrimeButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            bool isPrime = PrimeNumChecker.IsPrime(Convert.ToInt32(checkedPrimeNumber.Value));

            primeCheckLabel.Visible = true;

            if(isPrime)
            {
                primeCheckLabel.Text = "Число является простым!";
                primeCheckLabel.ForeColor = Color.Green;
            }
            else
            {
                primeCheckLabel.Text = "Число не является простым!";
                primeCheckLabel.ForeColor = Color.Red;
            }

            this.Enabled = true;
        }
    }
}
