namespace start
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl = new TabControl();
            tabClients = new TabPage();
            sportsmensView = new DataGridView();
            tabDishes = new TabPage();
            coachesView = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            AddSportsmen = new ToolStripMenuItem();
            добавиToolStripMenuItem = new ToolStripMenuItem();
            AddTraining = new ToolStripMenuItem();
            прогульщикиToolStripMenuItem = new ToolStripMenuItem();
            посещаемостьПоТренерамToolStripMenuItem = new ToolStripMenuItem();
            активностьРебёнкаToolStripMenuItem = new ToolStripMenuItem();
            splitContainer = new SplitContainer();
            mainView = new DataGridView();
            tabControl.SuspendLayout();
            tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sportsmensView).BeginInit();
            tabDishes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coachesView).BeginInit();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainView).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Controls.Add(tabClients);
            tabControl.Controls.Add(tabDishes);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 142);
            tabControl.TabIndex = 0;
            // 
            // tabClients
            // 
            tabClients.Controls.Add(sportsmensView);
            tabClients.Location = new Point(4, 4);
            tabClients.Margin = new Padding(2);
            tabClients.Name = "tabClients";
            tabClients.Padding = new Padding(2);
            tabClients.Size = new Size(792, 114);
            tabClients.TabIndex = 0;
            tabClients.Text = "Спортсмены";
            tabClients.UseVisualStyleBackColor = true;
            // 
            // sportsmensView
            // 
            sportsmensView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sportsmensView.Dock = DockStyle.Fill;
            sportsmensView.Location = new Point(2, 2);
            sportsmensView.Margin = new Padding(2);
            sportsmensView.Name = "sportsmensView";
            sportsmensView.RowHeadersWidth = 62;
            sportsmensView.Size = new Size(788, 110);
            sportsmensView.TabIndex = 0;
            // 
            // tabDishes
            // 
            tabDishes.Controls.Add(coachesView);
            tabDishes.Location = new Point(4, 4);
            tabDishes.Margin = new Padding(2);
            tabDishes.Name = "tabDishes";
            tabDishes.Padding = new Padding(2);
            tabDishes.Size = new Size(792, 114);
            tabDishes.TabIndex = 1;
            tabDishes.Text = "Тренера";
            tabDishes.UseVisualStyleBackColor = true;
            // 
            // coachesView
            // 
            coachesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coachesView.Dock = DockStyle.Fill;
            coachesView.Location = new Point(2, 2);
            coachesView.Margin = new Padding(2);
            coachesView.Name = "coachesView";
            coachesView.RowHeadersWidth = 62;
            coachesView.Size = new Size(788, 110);
            coachesView.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 25);
            toolStrip.TabIndex = 3;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { AddSportsmen, добавиToolStripMenuItem, AddTraining, прогульщикиToolStripMenuItem, посещаемостьПоТренерамToolStripMenuItem, активностьРебёнкаToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(57, 22);
            toolStripDropDownButton1.Text = " Меню";
            // 
            // AddSportsmen
            // 
            AddSportsmen.Name = "AddSportsmen";
            AddSportsmen.Size = new Size(231, 22);
            AddSportsmen.Text = "Добавить спортсмена";
            AddSportsmen.Click += AddSportsmen_Click;
            // 
            // добавиToolStripMenuItem
            // 
            добавиToolStripMenuItem.Name = "добавиToolStripMenuItem";
            добавиToolStripMenuItem.Size = new Size(231, 22);
            добавиToolStripMenuItem.Text = "Добавить Тренера";
            добавиToolStripMenuItem.Click += AddCouches_Click;
            // 
            // AddTraining
            // 
            AddTraining.Name = "AddTraining";
            AddTraining.Size = new Size(231, 22);
            AddTraining.Text = "Фиксация посещения";
            AddTraining.Click += AddTraining_Click;
            // 
            // прогульщикиToolStripMenuItem
            // 
            прогульщикиToolStripMenuItem.Name = "прогульщикиToolStripMenuItem";
            прогульщикиToolStripMenuItem.Size = new Size(231, 22);
            прогульщикиToolStripMenuItem.Text = "Прогульщики";
            прогульщикиToolStripMenuItem.Click += CheckTrainingPple_Click;
            // 
            // посещаемостьПоТренерамToolStripMenuItem
            // 
            посещаемостьПоТренерамToolStripMenuItem.Name = "посещаемостьПоТренерамToolStripMenuItem";
            посещаемостьПоТренерамToolStripMenuItem.Size = new Size(231, 22);
            посещаемостьПоТренерамToolStripMenuItem.Text = "Посещаемость по тренерам";
            посещаемостьПоТренерамToolStripMenuItem.Click += CheckTrainingCouches_Click;
            // 
            // активностьРебёнкаToolStripMenuItem
            // 
            активностьРебёнкаToolStripMenuItem.Name = "активностьРебёнкаToolStripMenuItem";
            активностьРебёнкаToolStripMenuItem.Size = new Size(231, 22);
            активностьРебёнкаToolStripMenuItem.Text = "Активность ребёнка";
            активностьРебёнкаToolStripMenuItem.Click += CheckActiveChild_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 25);
            splitContainer.Margin = new Padding(2);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(mainView);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tabControl);
            splitContainer.Size = new Size(800, 425);
            splitContainer.SplitterDistance = 281;
            splitContainer.SplitterWidth = 2;
            splitContainer.TabIndex = 4;
            // 
            // mainView
            // 
            mainView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainView.Dock = DockStyle.Fill;
            mainView.Location = new Point(0, 0);
            mainView.Margin = new Padding(2);
            mainView.Name = "mainView";
            mainView.RowHeadersWidth = 62;
            mainView.Size = new Size(800, 281);
            mainView.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer);
            Controls.Add(toolStrip);
            Name = "MainForm";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sportsmensView).EndInit();
            tabDishes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coachesView).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem прогульщикиToolStripMenuItem;
        private ToolStripMenuItem посещаемостьЬтренераToolStripMenuItem;
        private TabControl tabControl;
        private TabPage tabClients;
        private DataGridView sportsmensView;
        private TabPage tabDishes;
        private DataGridView coachesView;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem AddSportsmen;
        private ToolStripMenuItem AddClientToolStripMenuItem;
        private ToolStripMenuItem AddTraining;
        private SplitContainer splitContainer;
        private DataGridView mainView;
        private ToolStripMenuItem посещаемостьПоТренерамToolStripMenuItem;
        private ToolStripMenuItem активностьРебёнкаToolStripMenuItem;
        private ToolStripMenuItem добавиToolStripMenuItem;
    }
}
