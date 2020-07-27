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
            this.metircRadioButton = new System.Windows.Forms.RadioButton();
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.myHeightLabel = new System.Windows.Forms.Label();
            this.myWeightlabel = new System.Windows.Forms.Label();
            this.meterslabel = new System.Windows.Forms.Label();
            this.kglabel = new System.Windows.Forms.Label();
            this.inputMyHeightTextBox = new System.Windows.Forms.TextBox();
            this.inputMyWeightTextBox = new System.Windows.Forms.TextBox();
            this.BMIScaleTextBox = new System.Windows.Forms.TextBox();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.calculatorBMIButton = new System.Windows.Forms.Button();
            this.BMLScalelabel = new System.Windows.Forms.Label();
            this.ResultPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMIInfoPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
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
            this.BMIInfoPanel.Controls.Add(this.inputMyHeightTextBox, 1, 2);
            this.BMIInfoPanel.Controls.Add(this.inputMyWeightTextBox, 1, 4);
            this.BMIInfoPanel.Location = new System.Drawing.Point(-1, 46);
            this.BMIInfoPanel.Name = "BMIInfoPanel";
            this.BMIInfoPanel.RowCount = 5;
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIInfoPanel.Size = new System.Drawing.Size(320, 200);
            this.BMIInfoPanel.TabIndex = 1;
            // 
            // metircRadioButton
            // 
            this.metircRadioButton.ForeColor = System.Drawing.Color.DimGray;
            this.metircRadioButton.Location = new System.Drawing.Point(163, 3);
            this.metircRadioButton.Name = "metircRadioButton";
            this.metircRadioButton.Size = new System.Drawing.Size(138, 34);
            this.metircRadioButton.TabIndex = 2;
            this.metircRadioButton.TabStop = true;
            this.metircRadioButton.Text = "Metric";
            this.metircRadioButton.UseVisualStyleBackColor = true;
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
            // myHeightLabel
            // 
            this.myHeightLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.myHeightLabel.ForeColor = System.Drawing.Color.Transparent;
            this.myHeightLabel.Location = new System.Drawing.Point(3, 40);
            this.myHeightLabel.Name = "myHeightLabel";
            this.myHeightLabel.Size = new System.Drawing.Size(154, 40);
            this.myHeightLabel.TabIndex = 3;
            this.myHeightLabel.Text = "My Height";
            // 
            // myWeightlabel
            // 
            this.myWeightlabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.myWeightlabel.ForeColor = System.Drawing.Color.Transparent;
            this.myWeightlabel.Location = new System.Drawing.Point(3, 120);
            this.myWeightlabel.Name = "myWeightlabel";
            this.myWeightlabel.Size = new System.Drawing.Size(154, 39);
            this.myWeightlabel.TabIndex = 5;
            this.myWeightlabel.Text = "My Weight";
            // 
            // meterslabel
            // 
            this.meterslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meterslabel.ForeColor = System.Drawing.Color.Silver;
            this.meterslabel.Location = new System.Drawing.Point(163, 40);
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
            this.kglabel.Location = new System.Drawing.Point(163, 120);
            this.kglabel.Name = "kglabel";
            this.kglabel.Size = new System.Drawing.Size(138, 34);
            this.kglabel.TabIndex = 7;
            this.kglabel.Text = "KG";
            this.kglabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.kglabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputMyHeightTextBox
            // 
            this.inputMyHeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputMyHeightTextBox.Location = new System.Drawing.Point(163, 83);
            this.inputMyHeightTextBox.Name = "inputMyHeightTextBox";
            this.inputMyHeightTextBox.Size = new System.Drawing.Size(138, 46);
            this.inputMyHeightTextBox.TabIndex = 8;
            this.inputMyHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputMyHeightTextBox.TextChanged += new System.EventHandler(this.myHeightTextBox_TextChanged);
            // 
            // inputMyWeightTextBox
            // 
            this.inputMyWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputMyWeightTextBox.Location = new System.Drawing.Point(163, 163);
            this.inputMyWeightTextBox.Name = "inputMyWeightTextBox";
            this.inputMyWeightTextBox.Size = new System.Drawing.Size(138, 46);
            this.inputMyWeightTextBox.TabIndex = 9;
            this.inputMyWeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMIScaleTextBox
            // 
            this.BMIScaleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultPanel.SetColumnSpan(this.BMIScaleTextBox, 2);
            this.BMIScaleTextBox.Enabled = false;
            this.BMIScaleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIScaleTextBox.Location = new System.Drawing.Point(3, 115);
            this.BMIScaleTextBox.Multiline = true;
            this.BMIScaleTextBox.Name = "BMIScaleTextBox";
            this.BMIScaleTextBox.Size = new System.Drawing.Size(295, 53);
            this.BMIScaleTextBox.TabIndex = 3;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultPanel.SetColumnSpan(this.BMIResultTextBox, 2);
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.Location = new System.Drawing.Point(0, 43);
            this.BMIResultTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(318, 46);
            this.BMIResultTextBox.TabIndex = 2;
            this.BMIResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BMIResultTextBox.TextChanged += new System.EventHandler(this.BMIResultTextBox_TextChanged);
            // 
            // calculatorBMIButton
            // 
            this.calculatorBMIButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.calculatorBMIButton.FlatAppearance.BorderSize = 0;
            this.calculatorBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorBMIButton.ForeColor = System.Drawing.Color.White;
            this.calculatorBMIButton.Location = new System.Drawing.Point(3, 3);
            this.calculatorBMIButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.calculatorBMIButton.Name = "calculatorBMIButton";
            this.calculatorBMIButton.Size = new System.Drawing.Size(156, 37);
            this.calculatorBMIButton.TabIndex = 0;
            this.calculatorBMIButton.Text = "CALCULATOR";
            this.calculatorBMIButton.UseVisualStyleBackColor = false;
            this.calculatorBMIButton.Click += new System.EventHandler(this.calculatorBMIButton_Click);
            // 
            // BMLScalelabel
            // 
            this.BMLScalelabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ResultPanel.SetColumnSpan(this.BMLScalelabel, 2);
            this.BMLScalelabel.ForeColor = System.Drawing.Color.White;
            this.BMLScalelabel.Location = new System.Drawing.Point(3, 69);
            this.BMLScalelabel.Name = "BMLScalelabel";
            this.BMLScalelabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BMLScalelabel.Size = new System.Drawing.Size(312, 39);
            this.BMLScalelabel.TabIndex = 1;
            this.BMLScalelabel.Text = "BMI SCALE";
            this.BMLScalelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultPanel
            // 
            this.ResultPanel.ColumnCount = 2;
            this.ResultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultPanel.Controls.Add(this.calculatorBMIButton, 0, 0);
            this.ResultPanel.Controls.Add(this.BMIScaleTextBox, 0, 3);
            this.ResultPanel.Controls.Add(this.BMLScalelabel, 0, 2);
            this.ResultPanel.Controls.Add(this.BMIResultTextBox, 0, 1);
            this.ResultPanel.Controls.Add(this.ResetButton, 1, 0);
            this.ResultPanel.Location = new System.Drawing.Point(2, 251);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.RowCount = 4;
            this.ResultPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ResultPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ResultPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ResultPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.ResultPanel.Size = new System.Drawing.Size(318, 175);
            this.ResultPanel.TabIndex = 4;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(159, 3);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(139, 37);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.BMIInfoPanel);
            this.Controls.Add(this.BMICalculatorLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculatorForm";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load_1);
            this.BMIInfoPanel.ResumeLayout(false);
            this.BMIInfoPanel.PerformLayout();
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox inputMyHeightTextBox;
        private System.Windows.Forms.TextBox inputMyWeightTextBox;
        private System.Windows.Forms.TextBox BMIScaleTextBox;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.Button calculatorBMIButton;
        private System.Windows.Forms.Label BMLScalelabel;
        private System.Windows.Forms.TableLayoutPanel ResultPanel;
        private System.Windows.Forms.Button ResetButton;
    }
}

