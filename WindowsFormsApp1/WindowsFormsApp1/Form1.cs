using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double P = 100000;
        double N = 1;
        double R = 1;


        public Form1()
        {
            InitializeComponent();
            Calculate();
            loanAmount.Text = Convert.ToString(P);
            rOI.Text = Convert.ToString(R);
            loanTenure.Text = Convert.ToString(N);
        }

        private bool IsValidAmount(String amount)
        {
            var isNumeric = double.TryParse(amount, out double n);
            return isNumeric;
        }

        private void loanAmount_TextChanged(object sender, EventArgs e)
        {
            numValidation1.Text = " ";
            if (IsValidAmount(loanAmount.Text))
            {
                P = Convert.ToDouble(loanAmount.Text);
                if (P >= 100000 && P <= 100000000)
                {
                    hScrollBar1.Value = (int)P;
                    Calculate();
                }
                else
                {
                    if (P < 100000)
                    {
                        numValidation1.Text = "Enter amount greater than 100,000";
                    }
                    if (P > 100000000)
                    {
                        numValidation1.Text = "Enter amount less than 10,00,00,000";
                    }
                }
            }
            else
            {
                if (!IsValidAmount(loanAmount.Text))
                {
                    loanAmount.Text = " ";
                    numValidation1.Text = "Enter numeric value";
                    principalAmount.Text = " ";
                    monthlyEMI.Text = " ";
                    totalInterest.Text = " ";
                    totalAmount.Text = " ";
                }
            }
        }

        private void loanTenure_TextChanged(object sender, EventArgs e)
        {
            numValidation3.Text = " ";
            if (IsValidAmount(loanTenure.Text))
            {

                N = Convert.ToDouble(loanTenure.Text);
                double N1 = (N * 12);
                hScrollBar4.Value = (int)N;
                Calculate();
                //totalInterest.Text = N1.ToString();
            }
            else
            {
                if (!IsValidAmount(loanTenure.Text))
                {
                    loanTenure.Text = " ";
                    numValidation3.Text = "Enter numeric value";
                    principalAmount.Text = " ";
                    monthlyEMI.Text = " ";
                    totalInterest.Text = " ";
                    totalAmount.Text = " ";
                }
            }

        }

        public void Calculate()
        {

            double R1 = (R / 12) / 100;
            double N1 = (N * 12);
            double EMI;
            double power = Math.Pow(1 + R1, N1);
            EMI = (P * R1 * power) / (power - 1);
            double EMI2 = Math.Round(EMI, 1);
            double TotalAmount = Math.Round(EMI2 * N1, 1);
            double TotalInterest = Math.Round(TotalAmount - P, 1);

            principalAmount.Text = P.ToString();
            monthlyEMI.Text = EMI2.ToString();
            totalInterest.Text = TotalInterest.ToString();
            totalAmount.Text = TotalAmount.ToString();

            //Chart
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0}", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Principal Amount",
                    Values = new ChartValues<double> {P},
                    PushOut = 3,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Interest Amount",
                    Values = new ChartValues<double> {TotalInterest},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void rOI_ValueChanged(object sender, EventArgs e)
        {
            R = Convert.ToDouble(rOI.Text);
            if (R<1)
            {
                rOI.Text = "1";
                R = 1;
            }
            double R1 = (R / 12) / 100;
            hScrollBar2.Value = (int)R;
            Calculate();

        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            loanAmount.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            rOI.Text = hScrollBar2.Value.ToString();
        }


        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            loanTenure.Text = hScrollBar4.Value.ToString();
        }
    }
}
