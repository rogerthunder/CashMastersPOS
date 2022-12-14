using CashMastersPOS.Logic;
using CashMastersPOS.Models.Currencys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using TextBox = System.Windows.Forms.TextBox;

namespace CashMastersPOS
{
    public partial class CashMastersPOS : Form
    {
        public CashMastersPOS()
        {
            InitializeComponent();
        }
        //global variables
        double totalAmount = 0.0;
        string curencyType = "";

        /// <summary>
        /// Initializes the view for our visual interface, adding buttons depending on the type of currency in appconfig
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            curencyType = ConfigurationManager.AppSettings["CurrencyType"];

            switch (curencyType)
            {
                case "US":
                    this.Text += " - US";
                    US currentyType = new US();
                    Point newLoc = new Point(25, 110); // Set whatever you want for initial location

                    foreach (var elem in currentyType.USValues)
                    {
                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Size = new Size(40, 60);
                        b.Location = newLoc;
                        b.Text = elem.Value.ToString();
                        b.Click += new EventHandler(DinamicButton_Click);

                        newLoc.Offset(b.Width + 7, 0);
                        Controls.Add(b);
                    }
                    break;

                case "Mexico":
                    Mexico currentyTypeMex = new Mexico();
                    Point newLock = new Point(25, 110); // Set whatever you want for initial location

                    foreach (var elem in currentyTypeMex.MexicoValues)
                    {
                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Size = new Size(40, 60);
                        b.Location = newLock;
                        b.Text = elem.Value.ToString();
                        b.Click += new EventHandler(DinamicButton_Click);

                        newLock.Offset(b.Width + 7, 0);
                        Controls.Add(b);
                    }
                    this.Text += " - Mexico";
                    break;
            }

        }

        /// <summary>
        /// Gives funcionality to the buttons created, too resemble what bills and coins was payed with
        /// </summary>
        private void DinamicButton_Click(object sender, EventArgs e)
        {
            string buttonName = ((System.Windows.Forms.Button)sender).Text;
            if (!this.txtItemsPurchased.Text.Equals(""))
            {
                totalAmount += Convert.ToDouble(buttonName);
                txtTotalAmount.Text = totalAmount.ToString();

            }
            else {
                MessageBox.Show("Add amount first", "Warning");
                this.txtItemsPurchased.Focus();
            }


        }


        /// <summary>
        /// only lets numbers and 1 decimal per inputField
        /// </summary>
        private void txtItemsPurchased_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Excecutes the logic behind getting the change, depending on the currency type it will do the operation then
        /// set the change values into a string that the user can interpret in a label.
        /// </summary>
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (totalAmount < Convert.ToDouble(this.txtItemsPurchased.Text) )
            {
                MessageBox.Show("Need to pay more than the price of item(s) purchased", "Warning");
                this.txtItemsPurchased.Focus();
            }
            else
            {
                switch (curencyType)
                {
                   case "US":
                        var totalBought = Convert.ToDouble(this.txtItemsPurchased.Text);
                        var totalPayed = Convert.ToDouble(this.txtTotalAmount.Text);
                        var totalChangeToReturn = Math.Round(totalPayed - totalBought, 2);
                        //this.lblValuetoRetrun.Text;
                        //call logic

                        ProcessChange USOperation = new ProcessChange();
                        USOperation.calculateUS(Convert.ToDouble(this.txtItemsPurchased.Text), Convert.ToDouble(txtTotalAmount.Text));
                        var list = USOperation.USChange;
                        var message = USOperation.returnChangeBillsCoins();

                        this.lblValuetoRetrun.Text = message;

                        break;

                    case "Mexico":
                        var totalBoughtMex = Convert.ToDouble(this.txtItemsPurchased.Text);
                        var totalPayedMex = Convert.ToDouble(this.txtTotalAmount.Text);
                        var totalChangeToReturnMex = Math.Round(totalPayedMex - totalBoughtMex, 2);
                        //this.lblValuetoRetrun.Text;
                        //call logic

                        ProcessChange MexOperation = new ProcessChange();
                        MexOperation.calculateMex(Convert.ToDouble(this.txtItemsPurchased.Text), Convert.ToDouble(txtTotalAmount.Text));
                        var listMex = MexOperation.USChange;
                        var messageMex = MexOperation.returnChangeBillsCoinsMex();

                        this.lblValuetoRetrun.Text = messageMex;

                        break;
                }





            }
        }

        /// <summary>
        /// Clears the screens form.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtItemsPurchased.Text = string.Empty;
            this.txtTotalAmount.Text = string.Empty;
            this.lblValuetoRetrun.Text = string.Empty;
            this.txtItemsPurchased.Focus();
            this.totalAmount = 0.0;
        }
    }
}
