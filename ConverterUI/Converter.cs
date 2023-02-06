using core_lab2.config;
using core_lab2.dao;
using core_lab2.dao.impl;
using core_lab2.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterUI
{
    public partial class Converter : Form
    {
        private ICurrencyDAO currencyDAO = new CurrencyDAOImpl();
        private IRatesDAO ratesDAO = new RatesDAOImpl();
        private IRatesDynamicDAO ratesDynamicDAO = new RatesDynamicDAOImpl();
        private HttpClientConfig config = HttpClientConfig.getInstance();

        public Converter()
        {
            InitializeComponent();
            fullComboBoxes();
        }

        private void buttonCurrencies_Click(object sender, EventArgs e)
        {
            var currencyList =
                Task.Run(() => currencyDAO.GetCurrencies(config.GetHttpClient())).Result;
            dataGridViewCurrencies.DataSource = currencyList;
            buttonCurrencies.Enabled = false;
        }

        private void buttonRates_Click(object sender, EventArgs e)
        {
            var rateList = 
                Task.Run(() => ratesDAO.GetRates(config.GetHttpClient())).Result;
            dataGridViewRates.DataSource = rateList;
            buttonRates.Enabled = false;
        }

        private void fullComboBoxes()
        {
            var rateList =
                Task.Run(() => ratesDAO.GetRates(config.GetHttpClient())).Result;
            foreach (var rate in rateList)
            {
                comboBoxCurrencyFrom.Items.Add(rate);
                comboBoxCurrencyTo.Items.Add(rate);
                comboBoxCurrency.Items.Add(rate);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Format("{0:0.00}", convertValue((Rate)comboBoxCurrencyFrom.SelectedItem,
                (Rate)comboBoxCurrencyTo.SelectedItem));
        }

        private void buttonConvCancel_Click(object sender, EventArgs e)
        {
            textBoxValue.Clear();
            comboBoxCurrencyFrom.SelectedIndex = -1;
            comboBoxCurrencyFrom.Text = "BYN(Белорусский рубль)";
            comboBoxCurrencyTo.SelectedIndex = -1;
            comboBoxCurrencyTo.Text = "BYN(Белорусский рубль)";
            textBoxResult.Clear();
        }

        private decimal convertValue(Rate fromCurrency, Rate toCurrency)
        {
            decimal result = 0;
            if (!decimal.TryParse(textBoxValue.Text, out decimal number)
                || string.IsNullOrEmpty(textBoxValue.Text))
            {
                MessageBox.Show("Enter valid value to convert!");
                return result;
            }

            var valueToConvert = decimal.Parse(textBoxValue.Text);
            if (fromCurrency == null)
            {
                result = decimal.Multiply(valueToConvert, toCurrency.Cur_Scale) / toCurrency.Cur_OfficialRate;
            }
            else if (toCurrency == null)
            {
                result = decimal.Multiply(valueToConvert, fromCurrency.Cur_OfficialRate) / fromCurrency.Cur_Scale;
            }
            else
            {
                result = decimal.Divide(
                    decimal.Multiply(valueToConvert, fromCurrency.Cur_OfficialRate), fromCurrency.Cur_Scale
                    ) / toCurrency.Cur_OfficialRate * toCurrency.Cur_Scale;
            }

            return result;
        }


        private void buttonDrawGraph_Click(object sender, EventArgs e)
        {
            drawGraph();
        }

        private void drawGraph()
        {
            Rate rate = comboBoxCurrency.SelectedItem as Rate;
            IEnumerable<RateShort> ratesShortList = null;
            try
            {
                ratesShortList = Task.Run(() => ratesDynamicDAO.GetRateShorts(config.GetHttpClient(),
                rate, dateTimePickerFrom.Value, dateTimePickerTo.Value)).Result;
            }
            catch(AggregateException e)
            {
                MessageBox.Show("You enter date that was before denomination!\nPlease enter date later than 1.7.2016");
            }
            chartCurRate.DataSource = ratesShortList;
            chartCurRate.DataBind();
        }

        private void buttonGraphCancel_Click(object sender, EventArgs e)
        {
            comboBoxCurrency.SelectedIndex = -1;
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;
        }
    }
}
