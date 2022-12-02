namespace Assignment12_AlekseiPant
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtShiftNumber = new System.Windows.Forms.TextBox();
            this.txtHourlyPayRate = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.СlearButton = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(87, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shift number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(69, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hourly pay rate:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(200, 99);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // txtShiftNumber
            // 
            this.txtShiftNumber.Location = new System.Drawing.Point(200, 149);
            this.txtShiftNumber.Name = "txtShiftNumber";
            this.txtShiftNumber.Size = new System.Drawing.Size(120, 20);
            this.txtShiftNumber.TabIndex = 6;
            // 
            // txtHourlyPayRate
            // 
            this.txtHourlyPayRate.Location = new System.Drawing.Point(200, 199);
            this.txtHourlyPayRate.Name = "txtHourlyPayRate";
            this.txtHourlyPayRate.Size = new System.Drawing.Size(120, 20);
            this.txtHourlyPayRate.TabIndex = 7;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(245, 250);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 8;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayBtn);
            // 
            // СlearButton
            // 
            this.СlearButton.Location = new System.Drawing.Point(164, 250);
            this.СlearButton.Name = "СlearButton";
            this.СlearButton.Size = new System.Drawing.Size(75, 23);
            this.СlearButton.TabIndex = 9;
            this.СlearButton.Text = "Clear";
            this.СlearButton.UseVisualStyleBackColor = true;
            this.СlearButton.Click += new System.EventHandler(this.clearBtn);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(53, 300);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(267, 130);
            this.txtOutput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.СlearButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.txtHourlyPayRate);
            this.Controls.Add(this.txtShiftNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee and ProductionWorker Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtShiftNumber;
        private System.Windows.Forms.TextBox txtHourlyPayRate;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button СlearButton;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

