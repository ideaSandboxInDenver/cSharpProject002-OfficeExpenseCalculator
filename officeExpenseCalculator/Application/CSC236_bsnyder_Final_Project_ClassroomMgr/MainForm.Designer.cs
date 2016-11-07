namespace CSC236_bsnyder_Final_Project_ClassroomMgr
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.masterLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClassroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterLabel
            // 
            this.masterLabel.BackColor = System.Drawing.Color.Transparent;
            this.masterLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.masterLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.masterLabel.Location = new System.Drawing.Point(30, 100);
            this.masterLabel.Name = "masterLabel";
            this.masterLabel.Size = new System.Drawing.Size(406, 96);
            this.masterLabel.TabIndex = 0;
            this.masterLabel.Text = "Office Furniture Expense Calculator";
            this.masterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewClassesToolStripMenuItem,
            this.addClassesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 82);
            // 
            // viewClassesToolStripMenuItem
            // 
            this.viewClassesToolStripMenuItem.Name = "viewClassesToolStripMenuItem";
            this.viewClassesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewClassesToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.viewClassesToolStripMenuItem.Text = "View Classes";
            // 
            // addClassesToolStripMenuItem
            // 
            this.addClassesToolStripMenuItem.Name = "addClassesToolStripMenuItem";
            this.addClassesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.addClassesToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.addClassesToolStripMenuItem.Text = "Add Classes";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filieToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filieToolStripMenuItem
            // 
            this.filieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassroomToolStripMenuItem,
            this.viewClassroomToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.filieToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.filieToolStripMenuItem.Name = "filieToolStripMenuItem";
            this.filieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.filieToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.filieToolStripMenuItem.Text = "File";
            // 
            // addClassroomToolStripMenuItem
            // 
            this.addClassroomToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.addClassroomToolStripMenuItem.Name = "addClassroomToolStripMenuItem";
            this.addClassroomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.addClassroomToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addClassroomToolStripMenuItem.Text = "Add Office";
            this.addClassroomToolStripMenuItem.Click += new System.EventHandler(this.addClassroomToolStripMenuItem_Click);
            // 
            // viewClassroomToolStripMenuItem
            // 
            this.viewClassroomToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.viewClassroomToolStripMenuItem.Name = "viewClassroomToolStripMenuItem";
            this.viewClassroomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.viewClassroomToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.viewClassroomToolStripMenuItem.Text = "View Office";
            this.viewClassroomToolStripMenuItem.Click += new System.EventHandler(this.viewClassroomToolStripMenuItem_Click);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.closeFormToolStripMenuItem.Text = "Close Application";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddressLabel.Location = new System.Drawing.Point(31, 244);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(405, 38);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "SnyderLogic, 200 E. Main Street. Denver, CO 80207";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.instructionLabel.Location = new System.Drawing.Point(67, 195);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(333, 52);
            this.instructionLabel.TabIndex = 7;
            this.instructionLabel.Text = "Create offices and view expenses for your project.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSC236_bsnyder_Final_Project_ClassroomMgr.Properties.Resources.grid12_4transparentDARK;
            this.ClientSize = new System.Drawing.Size(466, 282);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.masterLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label masterLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.ToolStripMenuItem addClassroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClassroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
    }
}

