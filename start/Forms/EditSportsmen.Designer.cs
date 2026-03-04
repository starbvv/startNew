namespace start.Forms
{
    partial class EditSportsmen
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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 123);
            button1.Name = "button1";
            button1.Size = new Size(324, 23);
            button1.TabIndex = 15;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 14;
            label3.Text = "Телефон родителя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 36);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 13;
            label2.Text = "Дата рождения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 12;
            label1.Text = "ФИО";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(122, 64);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "79998887766";
            textBox4.Size = new Size(208, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Иван Гречишкин Константинович";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 9;
            // 
            // EditSportsmen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 153);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditSportsmen";
            Text = "EditSportsmen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox1;
    }
}