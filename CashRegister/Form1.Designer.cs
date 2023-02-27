namespace CashRegister
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
            this.juniorLabel = new System.Windows.Forms.Label();
            this.doubleLabel = new System.Windows.Forms.Label();
            this.trippleLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.juniorInput = new System.Windows.Forms.TextBox();
            this.doubleInput = new System.Windows.Forms.TextBox();
            this.trippleInput = new System.Windows.Forms.TextBox();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.reciptLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // juniorLabel
            // 
            this.juniorLabel.AutoSize = true;
            this.juniorLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juniorLabel.Location = new System.Drawing.Point(32, 18);
            this.juniorLabel.Name = "juniorLabel";
            this.juniorLabel.Size = new System.Drawing.Size(109, 16);
            this.juniorLabel.TabIndex = 0;
            this.juniorLabel.Text = "Junior Whopper";
            // 
            // doubleLabel
            // 
            this.doubleLabel.AutoSize = true;
            this.doubleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleLabel.Location = new System.Drawing.Point(32, 50);
            this.doubleLabel.Name = "doubleLabel";
            this.doubleLabel.Size = new System.Drawing.Size(117, 16);
            this.doubleLabel.TabIndex = 1;
            this.doubleLabel.Text = "Double Whopper";
            // 
            // trippleLabel
            // 
            this.trippleLabel.AutoSize = true;
            this.trippleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trippleLabel.Location = new System.Drawing.Point(32, 81);
            this.trippleLabel.Name = "trippleLabel";
            this.trippleLabel.Size = new System.Drawing.Size(116, 16);
            this.trippleLabel.TabIndex = 2;
            this.trippleLabel.Text = "Tripple Whopper";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(32, 133);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(69, 16);
            this.subtotalLabel.TabIndex = 3;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(32, 165);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(32, 16);
            this.taxLabel.TabIndex = 4;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(32, 195);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 16);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total";
            this.totalLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(32, 223);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(67, 16);
            this.tenderedLabel.TabIndex = 6;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.Location = new System.Drawing.Point(32, 290);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(56, 16);
            this.ChangeLabel.TabIndex = 7;
            this.ChangeLabel.Text = "Change";
            // 
            // juniorInput
            // 
            this.juniorInput.Location = new System.Drawing.Point(147, 18);
            this.juniorInput.Name = "juniorInput";
            this.juniorInput.Size = new System.Drawing.Size(100, 20);
            this.juniorInput.TabIndex = 8;
            // 
            // doubleInput
            // 
            this.doubleInput.Location = new System.Drawing.Point(147, 50);
            this.doubleInput.Name = "doubleInput";
            this.doubleInput.Size = new System.Drawing.Size(100, 20);
            this.doubleInput.TabIndex = 9;
            this.doubleInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // trippleInput
            // 
            this.trippleInput.Location = new System.Drawing.Point(147, 81);
            this.trippleInput.Name = "trippleInput";
            this.trippleInput.Size = new System.Drawing.Size(100, 20);
            this.trippleInput.TabIndex = 10;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(147, 223);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 20);
            this.tenderedInput.TabIndex = 11;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(35, 107);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(158, 23);
            this.totalButton.TabIndex = 14;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(35, 249);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(158, 23);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(35, 316);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(158, 23);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "Print Receipt ";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(268, 316);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(257, 23);
            this.orderButton.TabIndex = 17;
            this.orderButton.Text = "New Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(148, 133);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 16);
            this.subtotalOutput.TabIndex = 18;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(140, 165);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 16);
            this.taxOutput.TabIndex = 19;
            this.taxOutput.Click += new System.EventHandler(this.taxOutput_Click);
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(140, 195);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 16);
            this.totalOutput.TabIndex = 20;
            // 
            // reciptLabel
            // 
            this.reciptLabel.BackColor = System.Drawing.Color.White;
            this.reciptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reciptLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptLabel.Location = new System.Drawing.Point(268, 17);
            this.reciptLabel.Name = "reciptLabel";
            this.reciptLabel.Size = new System.Drawing.Size(257, 288);
            this.reciptLabel.TabIndex = 21;
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(137, 289);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 16);
            this.changeOutput.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 349);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.reciptLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.trippleInput);
            this.Controls.Add(this.doubleInput);
            this.Controls.Add(this.juniorInput);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.trippleLabel);
            this.Controls.Add(this.doubleLabel);
            this.Controls.Add(this.juniorLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label juniorLabel;
        private System.Windows.Forms.Label doubleLabel;
        private System.Windows.Forms.Label trippleLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.TextBox juniorInput;
        private System.Windows.Forms.TextBox doubleInput;
        private System.Windows.Forms.TextBox trippleInput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label reciptLabel;
        private System.Windows.Forms.Label changeOutput;
    }
}

