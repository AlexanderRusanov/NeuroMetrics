namespace MyMetrProj
{
    partial class From1
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
            this.evklButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.carryingTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modButton = new System.Windows.Forms.Button();
            this.kanButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // evklButton
            // 
            this.evklButton.Location = new System.Drawing.Point(249, 26);
            this.evklButton.Name = "evklButton";
            this.evklButton.Size = new System.Drawing.Size(152, 35);
            this.evklButton.TabIndex = 0;
            this.evklButton.Text = "Расчитать методом Эвклида";
            this.evklButton.UseVisualStyleBackColor = true;
            this.evklButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Грузоподъемность";
            // 
            // carryingTextBox
            // 
            this.carryingTextBox.Location = new System.Drawing.Point(157, 28);
            this.carryingTextBox.Name = "carryingTextBox";
            this.carryingTextBox.Size = new System.Drawing.Size(34, 20);
            this.carryingTextBox.TabIndex = 2;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(157, 69);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(34, 20);
            this.speedTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Скорость";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(157, 108);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(34, 20);
            this.costTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стоимость";
            // 
            // capaTextBox
            // 
            this.capaTextBox.Location = new System.Drawing.Point(157, 149);
            this.capaTextBox.Name = "capaTextBox";
            this.capaTextBox.Size = new System.Drawing.Size(34, 20);
            this.capaTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вместимость";
            // 
            // modButton
            // 
            this.modButton.Location = new System.Drawing.Point(249, 81);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(152, 35);
            this.modButton.TabIndex = 9;
            this.modButton.Text = "Расчитать методом суммы модулей разности";
            this.modButton.UseVisualStyleBackColor = true;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // kanButton
            // 
            this.kanButton.Location = new System.Drawing.Point(249, 136);
            this.kanButton.Name = "kanButton";
            this.kanButton.Size = new System.Drawing.Size(152, 35);
            this.kanButton.TabIndex = 10;
            this.kanButton.Text = "Расчитать методом Канберра";
            this.kanButton.UseVisualStyleBackColor = true;
            this.kanButton.Click += new System.EventHandler(this.kanButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(437, 92);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(37, 13);
            this.answerLabel.TabIndex = 12;
            this.answerLabel.Text = "Ответ";
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 197);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kanButton);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.capaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carryingTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evklButton);
            this.MaximizeBox = false;
            this.Name = "From1";
            this.Text = "Метрики";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button evklButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox carryingTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Button kanButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label answerLabel;
    }
}

