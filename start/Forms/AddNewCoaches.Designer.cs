namespace start
{
    partial class AddNewCoaches
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
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(9, 70);
            button1.Name = "button1";
            button1.Size = new Size(324, 23);
            button1.TabIndex = 15;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 44);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 14;
            label3.Text = "Вид спорта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 18);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 12;
            label1.Text = "ФИО";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 15);
            textBox1.MaxLength = 60;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Иван Гречишкин";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 9;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Футбол", "Баскетбол", "Волейбол", "Шаурмист", "Арбуз" });
            comboBox1.Location = new Point(125, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 16;
            // 
            // AddNewCoaches
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 104);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewCoaches";
            Text = "AddNewCoaches";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}