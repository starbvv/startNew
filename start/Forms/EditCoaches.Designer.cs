namespace start.Forms
{
    partial class EditCoaches
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Футбол", "Баскетбол", "Волейбол", "Шаурмист", "Арбуз" });
            comboBox1.Location = new Point(124, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(8, 61);
            button1.Name = "button1";
            button1.Size = new Size(324, 23);
            button1.TabIndex = 20;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 35);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 19;
            label3.Text = "Вид спорта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 18;
            label1.Text = "ФИО";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Иван Гречишкин";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 17;
            // 
            // EditCoaches
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 89);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditCoaches";
            Text = "EditCoaches";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
    }
}