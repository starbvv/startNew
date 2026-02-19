namespace start
{
    partial class CheckTrainingPple
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
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(129, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(208, 94);
            checkedListBox1.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(13, 170);
            button1.Name = "button1";
            button1.Size = new Size(324, 23);
            button1.TabIndex = 25;
            button1.Text = "Искать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 12);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 24;
            label3.Text = "Тренера";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 118);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 28;
            label1.Text = "1 Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(129, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(129, 141);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(208, 23);
            dateTimePicker2.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 147);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 30;
            label2.Text = "2 Дата";
            // 
            // CheckTrainingPple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 198);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Name = "CheckTrainingPple";
            Text = "CheckTrainingPple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button button1;
        private Label label3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
    }
}