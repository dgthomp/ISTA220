# **Class: ISTA220**
## **Name:**   Daniel Thompson
## **Assignment:** Chapter 03 Lab - *C#Lab3*
## **Date:** January 23, 2020

**Methods**
~~~
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Methods
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            int calculatedValue = 0;

            try
            {
                int leftHandSide = System.Int32.Parse(lhsOperand.Text);
                int rightHandSide = System.Int32.Parse(rhsOperand.Text);

                if (addition.IsChecked.HasValue && addition.IsChecked.Value)
                {
                    calculatedValue = addValues(leftHandSide, rightHandSide);
                    showResult(calculatedValue);
                }
                else if (subtraction.IsChecked.HasValue && subtraction.IsChecked.Value)
                {
                    calculatedValue = subtractValues(leftHandSide, rightHandSide);
                    showResult(calculatedValue);
                }
                else if (multiplication.IsChecked.HasValue && multiplication.IsChecked.Value)
                {
                    calculatedValue = multiplyValues(leftHandSide, rightHandSide);
                    showResult(calculatedValue);
                }
                else if (division.IsChecked.HasValue && division.IsChecked.Value)
                { int division, remainder;
                  (division, remainder) = divide(leftHandSide, rightHandSide);
                  result.Text = $"{division} remainder {remainder}";
                }
            }
            catch (Exception caught)
            {
                expression.Text = "";
                result.Text = caught.Message;
            }
        }

        private int addValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = $"{leftHandSide} + {rightHandSide}";
            return leftHandSide + rightHandSide;
        }

        private int subtractValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = $"{leftHandSide} - {rightHandSide}";
            return leftHandSide - rightHandSide;
        }

        private int multiplyValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = $"{leftHandSide} * {rightHandSide}";
            return leftHandSide * rightHandSide;
        }

        private (int, int) divide(int leftHandSide, int rightHandSide)
        {
            expression.Text = $"{leftHandSide} / {rightHandSide}";
            int division = leftHandSide / rightHandSide;
            int remainder = leftHandSide % rightHandSide;
            return (division, remainder);
        }

        private void showResult(int answer) => result.Text = answer.ToString();
    }
}
~~~

**DailyRate**
~~~
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            writeFee(CalculateFee(dailyRate, noOfDays));
        }

        private void writeFee(double v) => Console.WriteLine($"The consultant's fee is: {v * 1.1}");


        private double CalculateFee(double dailyRate, int noOfDays) => dailyRate * noOfDays;


        private int readInt(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readDouble(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}
~~~

**DailyRate using optional parameters**
~~~
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        public void run()
        {
            double fee = calculateFee(noOfDays : 4);
            Console.WriteLine($"Fee is {fee}");
        }

        private double calculateFee(double thedailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("calculateFee using two optional parameters");
            return thedailyRate * noOfDays;
        }
        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("calculateFee using two optional parameters");
            int defaultNoOfDays = 1; return dailyRate * defaultNoOfDays;
        }
        private double calculateFee()
        { Console.WriteLine("calculateFee using hardcoded values");
            double defaultDailyRate = 400.0; int defaultNoOfDays = 1;
            return defaultDailyRate * defaultNoOfDays;
        }

    }

}
~~~
