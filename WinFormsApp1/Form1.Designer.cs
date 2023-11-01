namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gr = new GroupBox();
            GasolinePayGroupBox = new GroupBox();
            GasolinePayGroupBoxLabel = new Label();
            gasStationTotalLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            AmountNumeric = new NumericUpDown();
            CountNumeric = new NumericUpDown();
            groupBox2 = new GroupBox();
            AmountRadioButton = new RadioButton();
            CountRadioButton = new RadioButton();
            PriceTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            GasolineComboBox = new ComboBox();
            label1 = new Label();
            MiniCafeGroupBox = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            groupbox5 = new GroupBox();
            label12 = new Label();
            MiniCafeTotalLabel = new Label();
            label8 = new Label();
            groupBox6 = new GroupBox();
            label13 = new Label();
            PayButton = new Button();
            TotalToPayLabel = new Label();
            gr.SuspendLayout();
            GasolinePayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).BeginInit();
            groupBox2.SuspendLayout();
            MiniCafeGroupBox.SuspendLayout();
            groupbox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // gr
            // 
            gr.Controls.Add(GasolinePayGroupBox);
            gr.Controls.Add(label5);
            gr.Controls.Add(label4);
            gr.Controls.Add(AmountNumeric);
            gr.Controls.Add(CountNumeric);
            gr.Controls.Add(groupBox2);
            gr.Controls.Add(PriceTextBox);
            gr.Controls.Add(label3);
            gr.Controls.Add(label2);
            gr.Controls.Add(GasolineComboBox);
            gr.Controls.Add(label1);
            gr.Location = new Point(12, 22);
            gr.Name = "gr";
            gr.Size = new Size(264, 326);
            gr.TabIndex = 0;
            gr.TabStop = false;
            gr.Text = "Автозаправка";
            // 
            // GasolinePayGroupBox
            // 
            GasolinePayGroupBox.Controls.Add(GasolinePayGroupBoxLabel);
            GasolinePayGroupBox.Controls.Add(gasStationTotalLabel);
            GasolinePayGroupBox.Location = new Point(8, 244);
            GasolinePayGroupBox.Name = "GasolinePayGroupBox";
            GasolinePayGroupBox.Size = new Size(233, 64);
            GasolinePayGroupBox.TabIndex = 10;
            GasolinePayGroupBox.TabStop = false;
            GasolinePayGroupBox.Text = "К оплате:";
            // 
            // GasolinePayGroupBoxLabel
            // 
            GasolinePayGroupBoxLabel.AutoSize = true;
            GasolinePayGroupBoxLabel.Location = new Point(132, 35);
            GasolinePayGroupBoxLabel.Name = "GasolinePayGroupBoxLabel";
            GasolinePayGroupBoxLabel.Size = new Size(29, 15);
            GasolinePayGroupBoxLabel.TabIndex = 11;
            GasolinePayGroupBoxLabel.Text = "грн.";
            // 
            // gasStationTotalLabel
            // 
            gasStationTotalLabel.AutoSize = true;
            gasStationTotalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            gasStationTotalLabel.Location = new Point(84, 19);
            gasStationTotalLabel.Name = "gasStationTotalLabel";
            gasStationTotalLabel.Size = new Size(22, 25);
            gasStationTotalLabel.TabIndex = 0;
            gasStationTotalLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 157);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 9;
            label5.Text = "л.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 192);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 8;
            label4.Text = "грн.";
            // 
            // AmountNumeric
            // 
            AmountNumeric.Enabled = false;
            AmountNumeric.Location = new Point(144, 187);
            AmountNumeric.Name = "AmountNumeric";
            AmountNumeric.Size = new Size(78, 23);
            AmountNumeric.TabIndex = 7;
            AmountNumeric.ValueChanged += AmountNumeric_ValueChanged;
            // 
            // CountNumeric
            // 
            CountNumeric.Location = new Point(144, 152);
            CountNumeric.Name = "CountNumeric";
            CountNumeric.Size = new Size(78, 23);
            CountNumeric.TabIndex = 6;
            CountNumeric.ValueChanged += CountNumeric_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AmountRadioButton);
            groupBox2.Controls.Add(CountRadioButton);
            groupBox2.Location = new Point(8, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(126, 93);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // AmountRadioButton
            // 
            AmountRadioButton.AutoSize = true;
            AmountRadioButton.Location = new Point(17, 53);
            AmountRadioButton.Name = "AmountRadioButton";
            AmountRadioButton.Size = new Size(63, 19);
            AmountRadioButton.TabIndex = 1;
            AmountRadioButton.Tag = "2";
            AmountRadioButton.Text = "Сумма";
            AmountRadioButton.UseVisualStyleBackColor = true;
            AmountRadioButton.CheckedChanged += CountOrPriceRadioButton_CheckedChanged;
            // 
            // CountRadioButton
            // 
            CountRadioButton.AutoSize = true;
            CountRadioButton.Checked = true;
            CountRadioButton.Location = new Point(17, 22);
            CountRadioButton.Name = "CountRadioButton";
            CountRadioButton.Size = new Size(90, 19);
            CountRadioButton.TabIndex = 0;
            CountRadioButton.TabStop = true;
            CountRadioButton.Tag = "1";
            CountRadioButton.Text = "Количество";
            CountRadioButton.UseVisualStyleBackColor = true;
            CountRadioButton.CheckedChanged += CountOrPriceRadioButton_CheckedChanged;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(71, 77);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.ReadOnly = true;
            PriceTextBox.Size = new Size(121, 23);
            PriceTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 81);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "грн.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 80);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Цена";
            // 
            // GasolineComboBox
            // 
            GasolineComboBox.FormattingEnabled = true;
            GasolineComboBox.Location = new Point(71, 38);
            GasolineComboBox.Name = "GasolineComboBox";
            GasolineComboBox.Size = new Size(121, 23);
            GasolineComboBox.TabIndex = 1;
            GasolineComboBox.SelectedIndexChanged += GasolineComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 41);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Бензин";
            // 
            // MiniCafeGroupBox
            // 
            MiniCafeGroupBox.Controls.Add(label7);
            MiniCafeGroupBox.Controls.Add(label6);
            MiniCafeGroupBox.Controls.Add(groupbox5);
            MiniCafeGroupBox.Location = new Point(311, 22);
            MiniCafeGroupBox.Name = "MiniCafeGroupBox";
            MiniCafeGroupBox.Size = new Size(264, 326);
            MiniCafeGroupBox.TabIndex = 1;
            MiniCafeGroupBox.TabStop = false;
            MiniCafeGroupBox.Text = "Мини-Кафе";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 28);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 20;
            label7.Text = "Количество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 28);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 19;
            label6.Text = "Цена";
            // 
            // groupbox5
            // 
            groupbox5.Controls.Add(label12);
            groupbox5.Controls.Add(MiniCafeTotalLabel);
            groupbox5.Controls.Add(label8);
            groupbox5.Location = new Point(8, 244);
            groupbox5.Name = "groupbox5";
            groupbox5.Size = new Size(233, 64);
            groupbox5.TabIndex = 10;
            groupbox5.TabStop = false;
            groupbox5.Text = "К оплате:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(138, 35);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 12;
            label12.Text = "грн.";
            // 
            // MiniCafeTotalLabel
            // 
            MiniCafeTotalLabel.AutoSize = true;
            MiniCafeTotalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MiniCafeTotalLabel.Location = new Point(100, 20);
            MiniCafeTotalLabel.Name = "MiniCafeTotalLabel";
            MiniCafeTotalLabel.Size = new Size(22, 25);
            MiniCafeTotalLabel.TabIndex = 2;
            MiniCafeTotalLabel.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(106, 19);
            label8.Name = "label8";
            label8.Size = new Size(22, 25);
            label8.TabIndex = 1;
            label8.Text = "0";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(PayButton);
            groupBox6.Controls.Add(TotalToPayLabel);
            groupBox6.Location = new Point(12, 368);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(564, 88);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Всего к оплате";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(299, 55);
            label13.Name = "label13";
            label13.Size = new Size(29, 15);
            label13.TabIndex = 13;
            label13.Text = "грн.";
            // 
            // PayButton
            // 
            PayButton.Location = new Point(8, 22);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(80, 49);
            PayButton.TabIndex = 3;
            PayButton.Text = "Оплатить";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // TotalToPayLabel
            // 
            TotalToPayLabel.AutoSize = true;
            TotalToPayLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalToPayLabel.Location = new Point(264, 33);
            TotalToPayLabel.Name = "TotalToPayLabel";
            TotalToPayLabel.Size = new Size(22, 25);
            TotalToPayLabel.TabIndex = 2;
            TotalToPayLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 472);
            Controls.Add(groupBox6);
            Controls.Add(MiniCafeGroupBox);
            Controls.Add(gr);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gr.ResumeLayout(false);
            gr.PerformLayout();
            GasolinePayGroupBox.ResumeLayout(false);
            GasolinePayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            MiniCafeGroupBox.ResumeLayout(false);
            MiniCafeGroupBox.PerformLayout();
            groupbox5.ResumeLayout(false);
            groupbox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gr;
        private TextBox PriceTextBox;
        private Label label3;
        private Label label2;
        private ComboBox GasolineComboBox;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton AmountRadioButton;
        private RadioButton CountRadioButton;
        private Label label5;
        private Label label4;
        private NumericUpDown AmountNumeric;
        private NumericUpDown CountNumeric;
        private GroupBox GasolinePayGroupBox;
        private GroupBox MiniCafeGroupBox;
        private Label label7;
        private Label label6;
        private GroupBox groupbox5;
        private Label GasolinePayGroupBoxLabel;
        private Label gasStationTotalLabel;
        private Label label12;
        private Label MiniCafeTotalLabel;
        private Label label8;
        private GroupBox groupBox6;
        private Label label13;
        private Button PayButton;
        private Label TotalToPayLabel;
    }
}