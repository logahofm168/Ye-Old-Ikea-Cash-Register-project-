using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ye_Old_Ikea__Cash_Register_project_
{
    public partial class Form1 : Form
    {
        // global variables
        double shelfPrice = 24.99;
        int numOfShelves = 0;
        double tablePrice = 49.99;
        int numOfTables = 0;
        double chairPrice = 25.99;
        int numOfChairs = 0;

        double taxRate = 0.13;
        double sudtotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;
        double tendered = 0;
        double change = 0;

        double shel = 0;
        double tab = 0;
        double cha = 0;

        double tend = 0;
        double endPayment = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void yeTable_Click(object sender, EventArgs e)
        {

        }

        private void tital_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void subtotalLable_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numberOfShelvesLable_Click(object sender, EventArgs e)
        {

        }

        private void calcuButton_Click(object sender, EventArgs e)
        {
            try
            {
                //gets input
                numOfShelves = Convert.ToInt32(shelvesInput.Text);
                numOfTables = Convert.ToInt32(tableInput.Text);
                numOfChairs = Convert.ToInt32(chairsInput.Text);

                //calculate values
                shel = shelfPrice * numOfShelves;
                tab = tablePrice * numOfTables;
                cha = chairPrice * numOfChairs;

                sudtotal = shel + tab + cha;
                taxAmount = sudtotal * taxRate;
                totalPrice = sudtotal + taxAmount;

                //display output 
                sudtotalOutPut.Text = $"{sudtotal.ToString("$.00")}";
                taxAmountOutPut.Text = $"{taxAmount.ToString("C")}";
                totalOutPut.Text = $"{totalPrice.ToString("C")}";
            }
            catch
            {
                sudtotalOutPut.Text = $"Issue error";
                taxAmountOutPut.Text = $"Issue error";
                totalOutPut.Text = $"Issue error";
            }


        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tend = Convert.ToInt32(tenderedInput.Text);

                endPayment = tend - totalPrice;

                changeOutPut.Text = $"{endPayment.ToString("C")}";
            }
            catch
            {
                changeOutPut.Text = $"Issue error";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Refresh();
            Thread.Sleep(400);

            OutPutLable.Text = $"                                YE OLD IKEA";

            Refresh();
            Thread.Sleep(500);

            OutPutLable.Text += $"\n\n\n Description..................................................Price";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n Ye Olden Shelf  X{numOfShelves}                                   ${shelfPrice}";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n Ye Olden Table  X{numOfTables}                                  ${tablePrice}";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n Ye Olden Chair  X{numOfChairs}                                  ${chairPrice}";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n            ....................................................             ";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n Sudtotal                                                  {sudtotal.ToString("C")}";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n Tax Amount                                           {taxAmount.ToString("C")}";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n Total Price                                             {totalPrice.ToString("C")}";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n            ....................................................             ";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n Tendered Used                                       ${tend}";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n Change Back                                          {endPayment.ToString("C")}";

            Refresh();
            Thread.Sleep(800);

            OutPutLable.Text += $"\n            ....................................................             ";

            OutPutLable.Text += $"\n           Thank For Shoping At Ye Olden Ikea";

        }
    }

}