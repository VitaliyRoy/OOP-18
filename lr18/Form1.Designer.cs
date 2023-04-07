namespace lr18
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_sorted_array = new System.Windows.Forms.TextBox();
            this.txt_sum_elements = new System.Windows.Forms.TextBox();
            this.txt_multiplication = new System.Windows.Forms.TextBox();
            this.txt_source_array = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.txt_rows = new System.Windows.Forms.TextBox();
            this.txt_cols = new System.Windows.Forms.TextBox();
            this.txt_array = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_result1 = new System.Windows.Forms.TextBox();
            this.txt_result2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_sorted_array);
            this.tabPage1.Controls.Add(this.txt_sum_elements);
            this.tabPage1.Controls.Add(this.txt_multiplication);
            this.tabPage1.Controls.Add(this.txt_source_array);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_sorted_array
            // 
            this.txt_sorted_array.Location = new System.Drawing.Point(6, 134);
            this.txt_sorted_array.Name = "txt_sorted_array";
            this.txt_sorted_array.Size = new System.Drawing.Size(395, 20);
            this.txt_sorted_array.TabIndex = 4;
            // 
            // txt_sum_elements
            // 
            this.txt_sum_elements.Location = new System.Drawing.Point(6, 95);
            this.txt_sum_elements.Name = "txt_sum_elements";
            this.txt_sum_elements.Size = new System.Drawing.Size(132, 20);
            this.txt_sum_elements.TabIndex = 3;
            // 
            // txt_multiplication
            // 
            this.txt_multiplication.Location = new System.Drawing.Point(6, 69);
            this.txt_multiplication.Name = "txt_multiplication";
            this.txt_multiplication.Size = new System.Drawing.Size(132, 20);
            this.txt_multiplication.TabIndex = 2;
            // 
            // txt_source_array
            // 
            this.txt_source_array.Location = new System.Drawing.Point(6, 32);
            this.txt_source_array.Name = "txt_source_array";
            this.txt_source_array.Size = new System.Drawing.Size(395, 20);
            this.txt_source_array.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_result2);
            this.tabPage2.Controls.Add(this.txt_result1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_array);
            this.tabPage2.Controls.Add(this.txt_cols);
            this.tabPage2.Controls.Add(this.txt_rows);
            this.tabPage2.Controls.Add(this.checkButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть елементи вашого масиву через пробіл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добуток елементів масиву з парними номерами";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сума елементів масиву, розташованих між першим і останнім нульовими елементами";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Відсортований масив";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(19, 312);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "ОК";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // rowsTextBox
            // 
            this.txt_rows.Location = new System.Drawing.Point(19, 55);
            this.txt_rows.Name = "rowsTextBox";
            this.txt_rows.Size = new System.Drawing.Size(64, 20);
            this.txt_rows.TabIndex = 1;
            // 
            // colsTextBox
            // 
            this.txt_cols.Location = new System.Drawing.Point(19, 98);
            this.txt_cols.Name = "colsTextBox";
            this.txt_cols.Size = new System.Drawing.Size(64, 20);
            this.txt_cols.TabIndex = 2;
            // 
            // outputTextBox
            // 
            this.txt_array.Location = new System.Drawing.Point(19, 124);
            this.txt_array.Multiline = true;
            this.txt_array.Name = "outputTextBox";
            this.txt_array.Size = new System.Drawing.Size(248, 171);
            this.txt_array.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Введіть кількість рядків масиву";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Введіть кількість стовпців масиву";
            // 
            // txt_result1
            // 
            this.txt_result1.Location = new System.Drawing.Point(334, 124);
            this.txt_result1.Multiline = true;
            this.txt_result1.Name = "txt_result1";
            this.txt_result1.Size = new System.Drawing.Size(360, 48);
            this.txt_result1.TabIndex = 6;
            // 
            // txt_result2
            // 
            this.txt_result2.Location = new System.Drawing.Point(334, 208);
            this.txt_result2.Multiline = true;
            this.txt_result2.Name = "txt_result2";
            this.txt_result2.Size = new System.Drawing.Size(360, 48);
            this.txt_result2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_sorted_array;
        private System.Windows.Forms.TextBox txt_sum_elements;
        private System.Windows.Forms.TextBox txt_multiplication;
        private System.Windows.Forms.TextBox txt_source_array;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox txt_array;
        private System.Windows.Forms.TextBox txt_cols;
        private System.Windows.Forms.TextBox txt_rows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_result2;
        private System.Windows.Forms.TextBox txt_result1;
    }
}

