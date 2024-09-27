namespace Ye_Old_Ikea__Cash_Register_project_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberOfShelvesLable = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shelvesInput = new System.Windows.Forms.TextBox();
            this.numberOfTableLable = new System.Windows.Forms.Label();
            this.numberOfChairsLable = new System.Windows.Forms.Label();
            this.chairsInput = new System.Windows.Forms.TextBox();
            this.tableInput = new System.Windows.Forms.TextBox();
            this.calcuButton = new System.Windows.Forms.Button();
            this.sudtotalLable = new System.Windows.Forms.Label();
            this.totalPriceLable = new System.Windows.Forms.Label();
            this.taxAmountLable = new System.Windows.Forms.Label();
            this.sudtotalOutPut = new System.Windows.Forms.Label();
            this.taxAmountOutPut = new System.Windows.Forms.Label();
            this.totalOutPut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenderedLable = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeLable = new System.Windows.Forms.Label();
            this.changeOutPut = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OutPutLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberOfShelvesLable
            // 
            this.numberOfShelvesLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberOfShelvesLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfShelvesLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numberOfShelvesLable.Location = new System.Drawing.Point(33, 110);
            this.numberOfShelvesLable.Name = "numberOfShelvesLable";
            this.numberOfShelvesLable.Size = new System.Drawing.Size(194, 21);
            this.numberOfShelvesLable.TabIndex = 1;
            this.numberOfShelvesLable.Text = "Number of ye olden shelves";
            this.numberOfShelvesLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numberOfShelvesLable.Click += new System.EventHandler(this.numberOfShelvesLable_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // shelvesInput
            // 
            this.shelvesInput.Location = new System.Drawing.Point(246, 110);
            this.shelvesInput.Multiline = true;
            this.shelvesInput.Name = "shelvesInput";
            this.shelvesInput.Size = new System.Drawing.Size(58, 21);
            this.shelvesInput.TabIndex = 3;
            this.shelvesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfTableLable
            // 
            this.numberOfTableLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberOfTableLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTableLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numberOfTableLable.Location = new System.Drawing.Point(34, 162);
            this.numberOfTableLable.Name = "numberOfTableLable";
            this.numberOfTableLable.Size = new System.Drawing.Size(194, 21);
            this.numberOfTableLable.TabIndex = 5;
            this.numberOfTableLable.Text = "Number of ye olden table";
            this.numberOfTableLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numberOfTableLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfChairsLable
            // 
            this.numberOfChairsLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberOfChairsLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfChairsLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numberOfChairsLable.Location = new System.Drawing.Point(34, 213);
            this.numberOfChairsLable.Name = "numberOfChairsLable";
            this.numberOfChairsLable.Size = new System.Drawing.Size(194, 21);
            this.numberOfChairsLable.TabIndex = 6;
            this.numberOfChairsLable.Text = "Number of ye olden chairs";
            this.numberOfChairsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numberOfChairsLable.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // chairsInput
            // 
            this.chairsInput.Location = new System.Drawing.Point(249, 213);
            this.chairsInput.Multiline = true;
            this.chairsInput.Name = "chairsInput";
            this.chairsInput.Size = new System.Drawing.Size(58, 21);
            this.chairsInput.TabIndex = 7;
            this.chairsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableInput
            // 
            this.tableInput.Location = new System.Drawing.Point(247, 162);
            this.tableInput.Multiline = true;
            this.tableInput.Name = "tableInput";
            this.tableInput.Size = new System.Drawing.Size(58, 21);
            this.tableInput.TabIndex = 8;
            this.tableInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcuButton
            // 
            this.calcuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calcuButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calcuButton.Location = new System.Drawing.Point(26, 261);
            this.calcuButton.Name = "calcuButton";
            this.calcuButton.Size = new System.Drawing.Size(279, 27);
            this.calcuButton.TabIndex = 9;
            this.calcuButton.Text = "Calculate Total";
            this.calcuButton.UseVisualStyleBackColor = false;
            this.calcuButton.Click += new System.EventHandler(this.calcuButton_Click);
            // 
            // sudtotalLable
            // 
            this.sudtotalLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sudtotalLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sudtotalLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sudtotalLable.Location = new System.Drawing.Point(33, 304);
            this.sudtotalLable.Name = "sudtotalLable";
            this.sudtotalLable.Size = new System.Drawing.Size(81, 22);
            this.sudtotalLable.TabIndex = 10;
            this.sudtotalLable.Text = "Sudtotal :";
            this.sudtotalLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sudtotalLable.Click += new System.EventHandler(this.subtotalLable_Click);
            // 
            // totalPriceLable
            // 
            this.totalPriceLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalPriceLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalPriceLable.Location = new System.Drawing.Point(33, 386);
            this.totalPriceLable.Name = "totalPriceLable";
            this.totalPriceLable.Size = new System.Drawing.Size(116, 23);
            this.totalPriceLable.TabIndex = 11;
            this.totalPriceLable.Text = "Total Price :";
            this.totalPriceLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxAmountLable
            // 
            this.taxAmountLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxAmountLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxAmountLable.Location = new System.Drawing.Point(33, 343);
            this.taxAmountLable.Name = "taxAmountLable";
            this.taxAmountLable.Size = new System.Drawing.Size(116, 24);
            this.taxAmountLable.TabIndex = 12;
            this.taxAmountLable.Text = "Tax  Amount :";
            this.taxAmountLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sudtotalOutPut
            // 
            this.sudtotalOutPut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sudtotalOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sudtotalOutPut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sudtotalOutPut.Location = new System.Drawing.Point(213, 304);
            this.sudtotalOutPut.Name = "sudtotalOutPut";
            this.sudtotalOutPut.Size = new System.Drawing.Size(81, 22);
            this.sudtotalOutPut.TabIndex = 13;
            this.sudtotalOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxAmountOutPut
            // 
            this.taxAmountOutPut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxAmountOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountOutPut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxAmountOutPut.Location = new System.Drawing.Point(214, 343);
            this.taxAmountOutPut.Name = "taxAmountOutPut";
            this.taxAmountOutPut.Size = new System.Drawing.Size(81, 22);
            this.taxAmountOutPut.TabIndex = 14;
            this.taxAmountOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.taxAmountOutPut.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalOutPut
            // 
            this.totalOutPut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutPut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalOutPut.Location = new System.Drawing.Point(214, 386);
            this.totalOutPut.Name = "totalOutPut";
            this.totalOutPut.Size = new System.Drawing.Size(81, 22);
            this.totalOutPut.TabIndex = 15;
            this.totalOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 10);
            this.label4.TabIndex = 16;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedLable
            // 
            this.tenderedLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenderedLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tenderedLable.Location = new System.Drawing.Point(33, 439);
            this.tenderedLable.Name = "tenderedLable";
            this.tenderedLable.Size = new System.Drawing.Size(97, 21);
            this.tenderedLable.TabIndex = 17;
            this.tenderedLable.Text = "Tendered :";
            this.tenderedLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeButton.Location = new System.Drawing.Point(26, 473);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(278, 30);
            this.changeButton.TabIndex = 19;
            this.changeButton.Text = "Calculate change ";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(216, 439);
            this.tenderedInput.Multiline = true;
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(79, 23);
            this.tenderedInput.TabIndex = 20;
            this.tenderedInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeLable
            // 
            this.changeLable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeLable.Location = new System.Drawing.Point(31, 518);
            this.changeLable.Name = "changeLable";
            this.changeLable.Size = new System.Drawing.Size(99, 23);
            this.changeLable.TabIndex = 21;
            this.changeLable.Text = "Change :";
            this.changeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeOutPut
            // 
            this.changeOutPut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutPut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeOutPut.Location = new System.Drawing.Point(216, 519);
            this.changeOutPut.Name = "changeOutPut";
            this.changeOutPut.Size = new System.Drawing.Size(81, 22);
            this.changeOutPut.TabIndex = 22;
            this.changeOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printButton.Location = new System.Drawing.Point(35, 552);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(257, 28);
            this.printButton.TabIndex = 23;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 93);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ye Olden Ikea";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutPutLable
            // 
            this.OutPutLable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OutPutLable.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutPutLable.Location = new System.Drawing.Point(332, 105);
            this.OutPutLable.Name = "OutPutLable";
            this.OutPutLable.Size = new System.Drawing.Size(351, 436);
            this.OutPutLable.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Ye_Old_Ikea__Cash_Register_project_.Properties.Resources.old_paper_texture_background_ucwuigpb57cktvxm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 592);
            this.Controls.Add(this.OutPutLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutPut);
            this.Controls.Add(this.changeLable);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalOutPut);
            this.Controls.Add(this.taxAmountOutPut);
            this.Controls.Add(this.sudtotalOutPut);
            this.Controls.Add(this.taxAmountLable);
            this.Controls.Add(this.totalPriceLable);
            this.Controls.Add(this.sudtotalLable);
            this.Controls.Add(this.calcuButton);
            this.Controls.Add(this.tableInput);
            this.Controls.Add(this.chairsInput);
            this.Controls.Add(this.numberOfChairsLable);
            this.Controls.Add(this.numberOfTableLable);
            this.Controls.Add(this.shelvesInput);
            this.Controls.Add(this.numberOfShelvesLable);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Ye Old Ikea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numberOfShelvesLable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox shelvesInput;
        private System.Windows.Forms.Label numberOfTableLable;
        private System.Windows.Forms.Label numberOfChairsLable;
        private System.Windows.Forms.TextBox chairsInput;
        private System.Windows.Forms.TextBox tableInput;
        private System.Windows.Forms.Button calcuButton;
        private System.Windows.Forms.Label sudtotalLable;
        private System.Windows.Forms.Label totalPriceLable;
        private System.Windows.Forms.Label taxAmountLable;
        private System.Windows.Forms.Label sudtotalOutPut;
        private System.Windows.Forms.Label taxAmountOutPut;
        private System.Windows.Forms.Label totalOutPut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tenderedLable;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeLable;
        private System.Windows.Forms.Label changeOutPut;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutPutLable;
    }
}

