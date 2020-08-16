namespace HomeWork7.Task2
{
    partial class formGuessNumber
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nudGuessNumber = new System.Windows.Forms.NumericUpDown();
            this.btnGuessNumber = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbGuessNumber = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessNumber)).BeginInit();
            this.gbGuessNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Угадайте число, загаданное компьютером от 1 до 100";
            // 
            // nudGuessNumber
            // 
            this.nudGuessNumber.Location = new System.Drawing.Point(42, 66);
            this.nudGuessNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuessNumber.Name = "nudGuessNumber";
            this.nudGuessNumber.Size = new System.Drawing.Size(93, 26);
            this.nudGuessNumber.TabIndex = 1;
            this.nudGuessNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuessNumber
            // 
            this.btnGuessNumber.Location = new System.Drawing.Point(166, 56);
            this.btnGuessNumber.Name = "btnGuessNumber";
            this.btnGuessNumber.Size = new System.Drawing.Size(109, 45);
            this.btnGuessNumber.TabIndex = 2;
            this.btnGuessNumber.Text = "Угадать";
            this.btnGuessNumber.UseVisualStyleBackColor = true;
            this.btnGuessNumber.Click += new System.EventHandler(this.btnGuessNumber_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(17, 125);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(432, 61);
            this.lblResult.TabIndex = 3;
            // 
            // gbGuessNumber
            // 
            this.gbGuessNumber.Controls.Add(this.label1);
            this.gbGuessNumber.Controls.Add(this.lblResult);
            this.gbGuessNumber.Controls.Add(this.nudGuessNumber);
            this.gbGuessNumber.Controls.Add(this.btnGuessNumber);
            this.gbGuessNumber.Location = new System.Drawing.Point(12, 12);
            this.gbGuessNumber.Name = "gbGuessNumber";
            this.gbGuessNumber.Size = new System.Drawing.Size(471, 206);
            this.gbGuessNumber.TabIndex = 4;
            this.gbGuessNumber.TabStop = false;
            // 
            // formGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 233);
            this.Controls.Add(this.gbGuessNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formGuessNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            ((System.ComponentModel.ISupportInitialize)(this.nudGuessNumber)).EndInit();
            this.gbGuessNumber.ResumeLayout(false);
            this.gbGuessNumber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudGuessNumber;
        private System.Windows.Forms.Button btnGuessNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox gbGuessNumber;
    }
}

