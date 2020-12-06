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

        private static ulong[] FermatFactor(ulong n)
        {
            ulong a, b;

            //если число четное, возвращаем результат
            if ((n % 2UL) == 0)
            {
                return new[] { 2UL, n / 2UL };
            }

            a = Convert.ToUInt64(Math.Ceiling(Math.Sqrt(n)));
            if (a * a == n)
            {
                return new[] { a, a };
            }
            ulong k = 0;
            while (true)
            {
                ulong tmp = a * a - n;
                b = Convert.ToUInt64(Math.Sqrt(tmp));

                if (b * b == tmp)
                {
                    break;
                }

                a++;
                k++;
            }

            return new[] { a - b, a + b, a, b, k };
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
                label2.Text = "Число a-b: ";
                label1.Text = "Число a+b: " ;
                label3.Text = "Число a: " ;
                label4.Text = "Число b: " ;
                label5.Text = "Количество иттераций:" ;
            }
            else
            {
                if (Convert.ToUInt32(checkedPrimeNumber.Value) % 2UL == 0)
                {
                    primeCheckLabel.Text = "Число четное, введите нечетное число!";

                }
                else
                {

                    ulong[] resultFerma = FermatFactor(Convert.ToUInt32(checkedPrimeNumber.Value));
                    primeCheckLabel.Text = "Факторизация Ферма:";
                    primeCheckLabel.ForeColor = Color.Red;
                    label2.Text = "Число a-b: " + resultFerma[0];
                    label1.Text = "Число a+b: " + resultFerma[1];
                    label3.Text = "Число a: " + resultFerma[2];
                    label4.Text = "Число b: " + resultFerma[3];
                    label5.Text = "Количество иттераций:" + resultFerma[4];
                }
            }

            this.Enabled = true;
        }
    }
}
