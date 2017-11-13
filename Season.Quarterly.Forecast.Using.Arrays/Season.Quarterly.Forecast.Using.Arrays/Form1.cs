using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Season.Quarterly.Forecast.Using.Arrays
{
    public partial class Form1 : Form
    {
        double avgSalesPerYear, forecastSales, season1ForecastRate, season2ForecastRate,
              season3ForecastRate, season4ForecastRate, avgSeason1, avgSeason2, avgSeason3, avgSeason4, season1Forecast,
              season2Forecast, season3Forecast, season4Forecast;

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avgSalesPerYear = double.Parse(textBox1.Text);
            forecastSales = double.Parse(textBox14.Text);

            double[] year1 = new double[4];
            year1[0] = double.Parse(textBox2.Text);
            year1[1] = double.Parse(textBox3.Text);
            year1[2] = double.Parse(textBox4.Text);
            year1[3] = double.Parse(textBox5.Text);

            double[] year2 = new double[4];
            year2[0] = double.Parse(textBox6.Text);
            year2[1] = double.Parse(textBox7.Text);
            year2[2] = double.Parse(textBox8.Text);
            year2[3] = double.Parse(textBox9.Text);

            avgSeason1 = (year1[0] + year2[0]) / 2;
            season1ForecastRate = avgSeason1 / avgSalesPerYear;
            season1Forecast = season1ForecastRate * forecastSales;
            textBox10.Text = season1Forecast.ToString();

            avgSeason2 = (year1[1] + year2[1]) / 2;
            season2ForecastRate = avgSeason2 / avgSalesPerYear;
            season2Forecast = season2ForecastRate * forecastSales;
            textBox11.Text = season2Forecast.ToString();

            avgSeason3 = (year1[2] + year2[2]) / 2;
            season3ForecastRate = avgSeason3 / avgSalesPerYear;
            season3Forecast = season3ForecastRate * forecastSales;
            textBox12.Text = season3Forecast.ToString();

            avgSeason4 = (year1[3] + year2[3]) / 2;
            season4ForecastRate = avgSeason4 / avgSalesPerYear;
            season4Forecast = season4ForecastRate * forecastSales;
            textBox13.Text = season4Forecast.ToString();

        }
    }
}
