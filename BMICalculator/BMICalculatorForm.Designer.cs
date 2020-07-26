namespace BMICalculator
{
    partial class BMICalculatorForm
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
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.BMIInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.metircRadioButton = new System.Windows.Forms.RadioButton();
            this.myHeightLabel = new System.Windows.Forms.Label();
            this.myWeightlabel = new System.Windows.Forms.Label();
            this.meterslabel = new System.Windows.Forms.Label();
            this.kglabel = new System.Windows.Forms.Label();
            this.myHeightTextBox = new System.Windows.Forms.TextBox();
            this.myWeightTextBox = new System.Windows.Forms.TextBox();
            this.resultLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.BMLScalelabel = new System.Windows.Forms.Label();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.BMIScaleTextBox1 = new System.Windows.Forms.TextBox();
            this.BMIInfoPanel.SuspendLayout();
            this.resultLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BMICalculatorLabel.ForeColor = System.Drawing.Color.Transparent;
            this.BMICalculatorLabel.Location = new System.Drawing.Point(0, 0);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.BMICalculatorLabel.Size = new System.Drawing.Size(320, 46);
            this.BMICalculatorLabel.TabIndex = 0;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            // 
            // BMIInfoPanel
            // 
            this.BMIInfoPanel.ColumnCount = 2;
            this.BMIInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMIInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMIInfoPanel.Controls.Add(this.metircRadioButton, 1, 0);
            this.BMIInfoPanel.Controls.Add(this.imperialRadioButton, 0, 0);
            this.BMIInfoPanel.Controls.Add(this.myHeightLabel, 0, 1);
            this.BMIInfoPanel.Controls.Add(this.myWeightlabel, 0, 3);
            this.BMIInfoPanel.Controls.Add(this.meterslabel, 1, 1);
            this.BMIInfoPanel.Controls.Add(this.kglabel, 1, 3);
            this.BMIInfoPanel.Controls.Add(this.myHeightTextBox, 1, 2);
            this.BMIInfoPanel.Controls.Add(this.myWeightTextBox, 1, 4);
            this.BMIInfoPanel.Location = new System.Drawing.Point(-1, 46);
            this.BMIInfoPanel.Name = "BMIInfoPanel";
            this.BMIInfoPanel.RowCount = 5;
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.Size = new System.Drawing.Size(303, 200);
            this.BMIInfoPanel.TabIndex = 1;
            // 
            // imperialRadioButton
            // 
            this.imperialRadioButton.ForeColor = System.Drawing.Color.DimGray;
            this.imperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.imperialRadioButton.Name = "imperialRadioButton";
            this.imperialRadioButton.Size = new System.Drawing.Size(145, 34);
            this.imperialRadioButton.TabIndex = 0;
            this.imperialRadioButton.TabStop = true;
            this.imperialRadioButton.Text = "Imperial";
            this.imperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // metircRadioButton
            // 
            this.metircRadioButton.ForeColor = System.Drawing.Color.DimGray;
            this.metircRadioButton.Location = new System.Drawing.Point(154, 3);
            this.metircRadioButton.Name = "metircRadioButton";
            this.metircRadioButton.Size = new System.Drawing.Size(138, 34);
            this.metircRadioButton.TabIndex = 2;
            this.metircRadioButton.TabStop = true;
            this.metircRadioButton.Text = "Metric";
            this.metircRadioButton.UseVisualStyleBackColor = true;
            // 
            // myHeightLabel
            // 
            this.myHeightLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.myHeightLabel.ForeColor = System.Drawing.Color.Transparent;
            this.myHeightLabel.Location = new System.Drawing.Point(3, 40);
            this.myHeightLabel.Name = "myHeightLabel";
            this.myHeightLabel.Size = new System.Drawing.Size(145, 34);
            this.myHeightLabel.TabIndex = 3;
            this.myHeightLabel.Text = "My Height";
            // 
            // myWeightlabel
            // 
            this.myWeightlabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.myWeightlabel.ForeColor = System.Drawing.Color.Transparent;
            this.myWeightlabel.Location = new System.Drawing.Point(3, 120);
            this.myWeightlabel.Name = "myWeightlabel";
            this.myWeightlabel.Size = new System.Drawing.Size(145, 34);
            this.myWeightlabel.TabIndex = 5;
            this.myWeightlabel.Text = "My Height";
            // 
            // meterslabel
            // 
            this.meterslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meterslabel.ForeColor = System.Drawing.Color.Silver;
            this.meterslabel.Location = new System.Drawing.Point(154, 40);
            this.meterslabel.Name = "meterslabel";
            this.meterslabel.Size = new System.Drawing.Size(138, 34);
            this.meterslabel.TabIndex = 6;
            this.meterslabel.Text = "Meters";
            this.meterslabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kglabel
            // 
            this.kglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kglabel.ForeColor = System.Drawing.Color.Silver;
            this.kglabel.Location = new System.Drawing.Point(154, 120);
            this.kglabel.Name = "kglabel";
            this.kglabel.Size = new System.Drawing.Size(138, 34);
            this.kglabel.TabIndex = 7;
            this.kglabel.Text = "KG";
            this.kglabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kglabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // myHeightTextBox
            // 
            this.myHeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myHeightTextBox.Location = new System.Drawing.Point(154, 83);
            this.myHeightTextBox.Name = "myHeightTextBox";
            this.myHeightTextBox.Size = new System.Drawing.Size(146, 46);
            this.myHeightTextBox.TabIndex = 8;
            this.myHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myWeightTextBox
            // 
            this.myWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myWeightTextBox.Location = new System.Drawing.Point(154, 163);
            this.myWeightTextBox.Name = "myWeightTextBox";
            this.myWeightTextBox.Size = new System.Drawing.Size(146, 46);
            this.myWeightTextBox.TabIndex = 9;
            this.myWeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultLayoutPanel
            // 
            this.resultLayoutPanel.ColumnCount = 1;
            this.resultLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resultLayoutPanel.Controls.Add(this.BMLScalelabel, 0, 2);
            this.resultLayoutPanel.Controls.Add(this.calculatorButton, 0, 0);
            this.resultLayoutPanel.Controls.Add(this.BMIResultTextBox, 0, 1);
            this.resultLayoutPanel.Controls.Add(this.BMIScaleTextBox1, 0, 3);
            this.resultLayoutPanel.Location = new System.Drawing.Point(-1, 238);
            this.resultLayoutPanel.Name = "resultLayoutPanel";
            this.resultLayoutPanel.RowCount = 4;
            this.resultLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resultLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.resultLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resultLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.resultLayoutPanel.Size = new System.Drawing.Size(303, 199);
            this.resultLayoutPanel.TabIndex = 2;
            // 
            // calculatorButton
            // 
            this.calculatorButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.calculatorButton.FlatAppearance.BorderSize = 0;
            this.calculatorButton.ForeColor = System.Drawing.Color.White;
            this.calculatorButton.Location = new System.Drawing.Point(3, 3);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(294, 43);
            this.calculatorButton.TabIndex = 0;
            this.calculatorButton.Text = "CALCULATOR";
            this.calculatorButton.UseVisualStyleBackColor = false;
            // 
            // BMLScalelabel
            // 
            this.BMLScalelabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BMLScalelabel.ForeColor = System.Drawing.Color.White;
            this.BMLScalelabel.Location = new System.Drawing.Point(3, 78);
            this.BMLScalelabel.Name = "BMLScalelabel";
            this.BMLScalelabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BMLScalelabel.Size = new System.Drawing.Size(294, 39);
            this.BMLScalelabel.TabIndex = 1;
            this.BMLScalelabel.Text = "BMI SCALE";
            this.BMLScalelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.Location = new System.Drawing.Point(0, 49);
            this.BMIResultTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(294, 46);
            this.BMIResultTextBox.TabIndex = 2;
            // 
            // BMIScaleTextBox1
            // 
            this.BMIScaleTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMIScaleTextBox1.Enabled = false;
            this.BMIScaleTextBox1.Location = new System.Drawing.Point(3, 130);
            this.BMIScaleTextBox1.Multiline = true;
            this.BMIScaleTextBox1.Name = "BMIScaleTextBox1";
            this.BMIScaleTextBox1.Size = new System.Drawing.Size(297, 53);
            this.BMIScaleTextBox1.TabIndex = 3;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.resultLayoutPanel);
            this.Controls.Add(this.BMIInfoPanel);
            this.Controls.Add(this.BMICalculatorLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculatorForm";
            this.BMIInfoPanel.ResumeLayout(false);
            this.BMIInfoPanel.PerformLayout();
            this.resultLayoutPanel.ResumeLayout(false);
            this.resultLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.TableLayoutPanel BMIInfoPanel;
        private System.Windows.Forms.RadioButton imperialRadioButton;
        private System.Windows.Forms.RadioButton metircRadioButton;
        private System.Windows.Forms.Label myHeightLabel;
        private System.Windows.Forms.Label myWeightlabel;
        private System.Windows.Forms.Label meterslabel;
        private System.Windows.Forms.Label kglabel;
        private System.Windows.Forms.TextBox myHeightTextBox;
        private System.Windows.Forms.TextBox myWeightTextBox;
        private System.Windows.Forms.TableLayoutPanel resultLayoutPanel;
        private System.Windows.Forms.Button calculatorButton;
        private System.Windows.Forms.Label BMLScalelabel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.TextBox BMIScaleTextBox1;
    }
}

