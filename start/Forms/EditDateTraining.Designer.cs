namespace start.Forms
{
    partial class EditDateTraining
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
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 141);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 31;
            label2.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 135);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(121, 35);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(208, 94);
            checkedListBox1.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(5, 159);
            button1.Name = "button1";
            button1.Size = new Size(324, 23);
            button1.TabIndex = 27;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 35);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 26;
            label3.Text = "Спортсмены";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 25;
            label1.Text = "Тренер";
            // 
            // EditDateTraining
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 186);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditDateTraining";
            Text = "EditDateTraining";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label3;
        private Label label1;
    }
}