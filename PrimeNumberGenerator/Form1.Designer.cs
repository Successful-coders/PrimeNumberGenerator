namespace PrimeNumberGenerator
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
            this.checkPrimeButton = new System.Windows.Forms.Button();
            this.resulLabel = new System.Windows.Forms.Label();
            this.generatePrimeNumber = new System.Windows.Forms.Button();
            this.generatedNumberLabel = new System.Windows.Forms.Label();
            this.primeCheckLabel = new System.Windows.Forms.Label();
            this.checkedPrimeNumber = new System.Windows.Forms.NumericUpDown();
            this.leadtimeLabel = new System.Windows.Forms.Label();
            this.iterationCountLabel = new System.Windows.Forms.Label();
            this.leadtime = new System.Windows.Forms.Label();
            this.iterationCountForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkedPrimeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // checkPrimeButton
            // 
            this.checkPrimeButton.Location = new System.Drawing.Point(269, 86);
            this.checkPrimeButton.Name = "checkPrimeButton";
            this.checkPrimeButton.Size = new System.Drawing.Size(173, 23);
            this.checkPrimeButton.TabIndex = 1;
            this.checkPrimeButton.Text = "Проверить на простоту";
            this.checkPrimeButton.UseVisualStyleBackColor = true;
            this.checkPrimeButton.Click += new System.EventHandler(this.checkPrimeButton_Click);
            // 
            // resulLabel
            // 
            this.resulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulLabel.Location = new System.Drawing.Point(210, 12);
            this.resulLabel.Name = "resulLabel";
            this.resulLabel.Size = new System.Drawing.Size(100, 32);
            this.resulLabel.TabIndex = 2;
            this.resulLabel.Text = "Результат:";
            this.resulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // generatePrimeNumber
            // 
            this.generatePrimeNumber.Location = new System.Drawing.Point(12, 12);
            this.generatePrimeNumber.Name = "generatePrimeNumber";
            this.generatePrimeNumber.Size = new System.Drawing.Size(192, 32);
            this.generatePrimeNumber.TabIndex = 3;
            this.generatePrimeNumber.Text = "Сгенерировать простое число";
            this.generatePrimeNumber.UseVisualStyleBackColor = true;
            this.generatePrimeNumber.Click += new System.EventHandler(this.generatePrimeNumber_Click);
            // 
            // generatedNumberLabel
            // 
            this.generatedNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedNumberLabel.Location = new System.Drawing.Point(316, 12);
            this.generatedNumberLabel.Name = "generatedNumberLabel";
            this.generatedNumberLabel.Size = new System.Drawing.Size(100, 32);
            this.generatedNumberLabel.TabIndex = 4;
            this.generatedNumberLabel.Text = "4729";
            this.generatedNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // primeCheckLabel
            // 
            this.primeCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeCheckLabel.Location = new System.Drawing.Point(9, 124);
            this.primeCheckLabel.Name = "primeCheckLabel";
            this.primeCheckLabel.Size = new System.Drawing.Size(322, 23);
            this.primeCheckLabel.TabIndex = 5;
            this.primeCheckLabel.Text = "Число является простым!";
            this.primeCheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkedPrimeNumber
            // 
            this.checkedPrimeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedPrimeNumber.Location = new System.Drawing.Point(12, 86);
            this.checkedPrimeNumber.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.checkedPrimeNumber.Name = "checkedPrimeNumber";
            this.checkedPrimeNumber.Size = new System.Drawing.Size(251, 23);
            this.checkedPrimeNumber.TabIndex = 6;
            // 
            // leadtimeLabel
            // 
            this.leadtimeLabel.AutoSize = true;
            this.leadtimeLabel.Location = new System.Drawing.Point(382, 12);
            this.leadtimeLabel.Name = "leadtimeLabel";
            this.leadtimeLabel.Size = new System.Drawing.Size(108, 13);
            this.leadtimeLabel.TabIndex = 7;
            this.leadtimeLabel.Text = "Время выполнения:";
            // 
            // iterationCountLabel
            // 
            this.iterationCountLabel.AutoSize = true;
            this.iterationCountLabel.Location = new System.Drawing.Point(396, 31);
            this.iterationCountLabel.Name = "iterationCountLabel";
            this.iterationCountLabel.Size = new System.Drawing.Size(94, 13);
            this.iterationCountLabel.TabIndex = 8;
            this.iterationCountLabel.Text = "Кол-во итераций:";
            // 
            // leadtime
            // 
            this.leadtime.AutoSize = true;
            this.leadtime.Location = new System.Drawing.Point(497, 13);
            this.leadtime.Name = "leadtime";
            this.leadtime.Size = new System.Drawing.Size(40, 13);
            this.leadtime.TabIndex = 9;
            this.leadtime.Text = "0.067с";
            // 
            // iterationCountForm
            // 
            this.iterationCountForm.AutoSize = true;
            this.iterationCountForm.Location = new System.Drawing.Point(496, 31);
            this.iterationCountForm.Name = "iterationCountForm";
            this.iterationCountForm.Size = new System.Drawing.Size(25, 13);
            this.iterationCountForm.TabIndex = 10;
            this.iterationCountForm.Text = "428";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 172);
            this.Controls.Add(this.iterationCountForm);
            this.Controls.Add(this.leadtime);
            this.Controls.Add(this.iterationCountLabel);
            this.Controls.Add(this.leadtimeLabel);
            this.Controls.Add(this.checkedPrimeNumber);
            this.Controls.Add(this.primeCheckLabel);
            this.Controls.Add(this.generatedNumberLabel);
            this.Controls.Add(this.generatePrimeNumber);
            this.Controls.Add(this.resulLabel);
            this.Controls.Add(this.checkPrimeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.checkedPrimeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkPrimeButton;
        private System.Windows.Forms.Label resulLabel;
        private System.Windows.Forms.Button generatePrimeNumber;
        private System.Windows.Forms.Label generatedNumberLabel;
        private System.Windows.Forms.Label primeCheckLabel;
        private System.Windows.Forms.NumericUpDown checkedPrimeNumber;
        private System.Windows.Forms.Label leadtimeLabel;
        private System.Windows.Forms.Label iterationCountLabel;
        private System.Windows.Forms.Label leadtime;
        private System.Windows.Forms.Label iterationCountForm;
    }
}

