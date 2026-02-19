namespace start
{
    partial class CheckActiveChild
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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(9, 35);
            button1.Name = "button1";
            button1.Size = new Size(324, 23);
            button1.TabIndex = 31;
            button1.Text = "Искать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 9);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 30;
            label3.Text = "Спортсмен";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 35;
            // 
            // CheckActiveChild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 65);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Name = "CheckActiveChild";
            Text = "CheckActiveChild";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
    }
}