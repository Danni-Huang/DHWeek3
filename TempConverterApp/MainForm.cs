using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// pull in the proxy namespace
using TempConverterApp.TempConversion;

namespace TempConverterApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConvertTemp_Click(object sender, EventArgs e)
        {
            // first read the Fahr temp the user entered:
            string fahrTemp = txtFarhenheit.Text;

            // use our proxy object to do a conversions:
            string celsTemp = _tempConversionService.FahrenheitToCelsius(fahrTemp);

            double cels = double.Parse(celsTemp);

            // out put the result
            txtCelsius.Text = $"{cels:0.0}";

        }

        // create a ref to our service proxy as a private data field
        // because we have 2 endpoints we need to name 1 as we create this proxy:
        private TempConvertSoapClient _tempConversionService = new TempConvertSoapClient("TempConvertSoap");

        
    }
}
