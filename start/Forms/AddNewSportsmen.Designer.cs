namespace start
{
    partial class AddNewSportsmen
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
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 17);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Иван Гречишкин Константинович";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 75);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "79998887766";
            textBox4.Size = new Size(208, 23);
            textBox4.TabIndex = 3;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 20);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 5;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 47);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 6;
            label2.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 78);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 7;
            label3.Text = "Телефон родителя";
            // 
            // button1
            // 
            button1.Location = new Point(10, 134);
            button1.Name = "button1";
            button1.Size = new Size(324, 23);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddNewSportsmen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 167);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewSportsmen";
            Text = "AddNewSportsmen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}