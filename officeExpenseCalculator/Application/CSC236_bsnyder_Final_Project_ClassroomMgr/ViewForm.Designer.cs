namespace CSC236_bsnyder_Final_Project_ClassroomMgr
{
    partial class ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.getClassroomButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.OfficeDataListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.masterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getClassroomButton
            // 
            this.getClassroomButton.BackColor = System.Drawing.Color.SeaGreen;
            this.getClassroomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.getClassroomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getClassroomButton.ForeColor = System.Drawing.Color.White;
            this.getClassroomButton.Location = new System.Drawing.Point(126, 356);
            this.getClassroomButton.Name = "getClassroomButton";
            this.getClassroomButton.Size = new System.Drawing.Size(95, 50);
            this.getClassroomButton.TabIndex = 0;
            this.getClassroomButton.Text = "Get First Office";
            this.getClassroomButton.UseVisualStyleBackColor = false;
            this.getClassroomButton.Click += new System.EventHandler(this.getClassroomButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.SeaGreen;
            this.previousButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.ForeColor = System.Drawing.Color.White;
            this.previousButton.Location = new System.Drawing.Point(25, 356);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(95, 50);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "< Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.SeaGreen;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(227, 356);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(95, 50);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // OfficeDataListBox
            // 
            this.OfficeDataListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficeDataListBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.OfficeDataListBox.FormattingEnabled = true;
            this.OfficeDataListBox.ItemHeight = 20;
            this.OfficeDataListBox.Location = new System.Drawing.Point(26, 136);
            this.OfficeDataListBox.Name = "OfficeDataListBox";
            this.OfficeDataListBox.Size = new System.Drawing.Size(432, 204);
            this.OfficeDataListBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 81);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filieToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filieToolStripMenuItem
            // 
            this.filieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.filieToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.filieToolStripMenuItem.Name = "filieToolStripMenuItem";
            this.filieToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.filieToolStripMenuItem.Text = "File";
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addClassToolStripMenuItem.Text = "Add Classroom";
            this.addClassToolStripMenuItem.Click += new System.EventHandler(this.addClassToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.SeaGreen;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.exitToolStripMenuItem1.Text = "Close Form";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
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
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.creditToolStripMenuItem.Text = "Credits";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(24, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 23);
            this.label7.TabIndex = 63;
            this.label7.Text = "VIEW VIEW VIEW VIEW";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(367, 356);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(91, 50);
            this.closeButton.TabIndex = 64;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // masterLabel
            // 
            this.masterLabel.BackColor = System.Drawing.Color.Transparent;
            this.masterLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.masterLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.masterLabel.Location = new System.Drawing.Point(15, 27);
            this.masterLabel.Name = "masterLabel";
            this.masterLabel.Size = new System.Drawing.Size(279, 102);
            this.masterLabel.TabIndex = 65;
            this.masterLabel.Text = "Office";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSC236_bsnyder_Final_Project_ClassroomMgr.Properties.Resources.grid12_4transparentDARK;
            this.ClientSize = new System.Drawing.Size(482, 429);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.OfficeDataListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.masterLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.getClassroomButton);
            this.Name = "ViewForm";
            this.Text = "View Classroom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getClassroomButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ListBox OfficeDataListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label masterLabel;
    }
}