namespace HomeWork7.Task1
{
    partial class DoublerForm
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
            this.btnPlusCommand = new System.Windows.Forms.Button();
            this.btnMultyCommand = new System.Windows.Forms.Button();
            this.btnClearCommand = new System.Windows.Forms.Button();
            this.btnCancelCommand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTargetValue = new System.Windows.Forms.Label();
            this.lblCurrentText = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCommandCount = new System.Windows.Forms.Label();
            this.gbGameControls = new System.Windows.Forms.GroupBox();
            this.gbGameControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlusCommand
            // 
            this.btnPlusCommand.Location = new System.Drawing.Point(276, 33);
            this.btnPlusCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlusCommand.Name = "btnPlusCommand";
            this.btnPlusCommand.Size = new System.Drawing.Size(102, 35);
            this.btnPlusCommand.TabIndex = 0;
            this.btnPlusCommand.Text = "+1";
            this.btnPlusCommand.UseVisualStyleBackColor = true;
            this.btnPlusCommand.Click += new System.EventHandler(this.btnPlusCommand_Click);
            // 
            // btnMultyCommand
            // 
            this.btnMultyCommand.Location = new System.Drawing.Point(276, 78);
            this.btnMultyCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultyCommand.Name = "btnMultyCommand";
            this.btnMultyCommand.Size = new System.Drawing.Size(102, 35);
            this.btnMultyCommand.TabIndex = 0;
            this.btnMultyCommand.Text = "x2";
            this.btnMultyCommand.UseVisualStyleBackColor = true;
            this.btnMultyCommand.Click += new System.EventHandler(this.btnMultyCommand_Click);
            // 
            // btnClearCommand
            // 
            this.btnClearCommand.Location = new System.Drawing.Point(276, 123);
            this.btnClearCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearCommand.Name = "btnClearCommand";
            this.btnClearCommand.Size = new System.Drawing.Size(102, 35);
            this.btnClearCommand.TabIndex = 0;
            this.btnClearCommand.Text = "Сброс";
            this.btnClearCommand.UseVisualStyleBackColor = true;
            this.btnClearCommand.Click += new System.EventHandler(this.btnClearCommand_Click);
            // 
            // btnCancelCommand
            // 
            this.btnCancelCommand.Location = new System.Drawing.Point(276, 168);
            this.btnCancelCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelCommand.Name = "btnCancelCommand";
            this.btnCancelCommand.Size = new System.Drawing.Size(102, 35);
            this.btnCancelCommand.TabIndex = 0;
            this.btnCancelCommand.Text = "Отмена";
            this.btnCancelCommand.UseVisualStyleBackColor = true;
            this.btnCancelCommand.Click += new System.EventHandler(this.btnCancelCommand_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Используя команды справа нужно получить следующее значение:";
            // 
            // lblTargetValue
            // 
            this.lblTargetValue.AutoSize = true;
            this.lblTargetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTargetValue.Location = new System.Drawing.Point(113, 73);
            this.lblTargetValue.Name = "lblTargetValue";
            this.lblTargetValue.Size = new System.Drawing.Size(103, 20);
            this.lblTargetValue.TabIndex = 2;
            this.lblTargetValue.Text = "targetValue";
            // 
            // lblCurrentText
            // 
            this.lblCurrentText.Location = new System.Drawing.Point(31, 130);
            this.lblCurrentText.Name = "lblCurrentText";
            this.lblCurrentText.Size = new System.Drawing.Size(156, 24);
            this.lblCurrentText.TabIndex = 1;
            this.lblCurrentText.Text = "Текущее значение:";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentValue.Location = new System.Drawing.Point(183, 130);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(66, 20);
            this.lblCurrentValue.TabIndex = 2;
            this.lblCurrentValue.Text = "current";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Совершено действий:";
            // 
            // lblCommandCount
            // 
            this.lblCommandCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCommandCount.Location = new System.Drawing.Point(207, 154);
            this.lblCommandCount.Name = "lblCommandCount";
            this.lblCommandCount.Size = new System.Drawing.Size(62, 20);
            this.lblCommandCount.TabIndex = 3;
            this.lblCommandCount.Text = "command";
            // 
            // gbGameControls
            // 
            this.gbGameControls.Controls.Add(this.lblTargetValue);
            this.gbGameControls.Controls.Add(this.label1);
            this.gbGameControls.Controls.Add(this.lblCommandCount);
            this.gbGameControls.Controls.Add(this.btnPlusCommand);
            this.gbGameControls.Controls.Add(this.lblCurrentValue);
            this.gbGameControls.Controls.Add(this.btnMultyCommand);
            this.gbGameControls.Controls.Add(this.btnClearCommand);
            this.gbGameControls.Controls.Add(this.label2);
            this.gbGameControls.Controls.Add(this.btnCancelCommand);
            this.gbGameControls.Controls.Add(this.lblCurrentText);
            this.gbGameControls.Location = new System.Drawing.Point(12, 12);
            this.gbGameControls.Name = "gbGameControls";
            this.gbGameControls.Size = new System.Drawing.Size(398, 214);
            this.gbGameControls.TabIndex = 4;
            this.gbGameControls.TabStop = false;
            // 
            // DoublerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 240);
            this.Controls.Add(this.gbGameControls);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoublerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.gbGameControls.ResumeLayout(false);
            this.gbGameControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlusCommand;
        private System.Windows.Forms.Button btnMultyCommand;
        private System.Windows.Forms.Button btnClearCommand;
        private System.Windows.Forms.Button btnCancelCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTargetValue;
        private System.Windows.Forms.Label lblCurrentText;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCommandCount;
        private System.Windows.Forms.GroupBox gbGameControls;
    }
}

