namespace GraphicsEditorForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createShapeLabel = new System.Windows.Forms.Label();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mousePositionInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.createShapeButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.infoStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createShapeLabel
            // 
            this.createShapeLabel.AutoSize = true;
            this.createShapeLabel.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createShapeLabel.Location = new System.Drawing.Point(14, 38);
            this.createShapeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.createShapeLabel.Name = "createShapeLabel";
            this.createShapeLabel.Size = new System.Drawing.Size(116, 38);
            this.createShapeLabel.TabIndex = 1;
            this.createShapeLabel.Text = "Shapes";
            // 
            // undoButton
            // 
            this.undoButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoButton.Location = new System.Drawing.Point(624, 0);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(68, 38);
            this.undoButton.TabIndex = 2;
            this.undoButton.Text = "⬅";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redoButton.Location = new System.Drawing.Point(698, 0);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(68, 38);
            this.redoButton.TabIndex = 3;
            this.redoButton.Text = "➡";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(11, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 486);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // infoStatusStrip
            // 
            this.infoStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mousePositionInfo,
            this.toolStripStatusLabel});
            this.infoStatusStrip.Location = new System.Drawing.Point(0, 583);
            this.infoStatusStrip.Name = "infoStatusStrip";
            this.infoStatusStrip.Size = new System.Drawing.Size(1008, 22);
            this.infoStatusStrip.TabIndex = 5;
            // 
            // mousePositionInfo
            // 
            this.mousePositionInfo.Name = "mousePositionInfo";
            this.mousePositionInfo.Size = new System.Drawing.Size(10, 17);
            this.mousePositionInfo.Text = " ";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel.Text = " ";
            // 
            // createShapeButton
            // 
            this.createShapeButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createShapeButton.Location = new System.Drawing.Point(419, 0);
            this.createShapeButton.Name = "createShapeButton";
            this.createShapeButton.Size = new System.Drawing.Size(145, 38);
            this.createShapeButton.TabIndex = 6;
            this.createShapeButton.Text = "create shape";
            this.createShapeButton.UseVisualStyleBackColor = true;
            this.createShapeButton.Click += new System.EventHandler(this.createShapeButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(261, 1);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(36, 38);
            this.colorButton.TabIndex = 7;
            this.colorButton.Text = "🎨";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // brushButton
            // 
            this.brushButton.Location = new System.Drawing.Point(177, 1);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(36, 38);
            this.brushButton.TabIndex = 8;
            this.brushButton.Text = "🖌️";
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // penButton
            // 
            this.penButton.Location = new System.Drawing.Point(135, 1);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(36, 38);
            this.penButton.TabIndex = 9;
            this.penButton.Text = "✏️";
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(51, 1);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(36, 38);
            this.selectButton.TabIndex = 11;
            this.selectButton.Text = "⛶";
            this.selectButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(93, 1);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(36, 38);
            this.eraseButton.TabIndex = 12;
            this.eraseButton.Text = "🧽";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillButton.Location = new System.Drawing.Point(219, 1);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(36, 38);
            this.fillButton.TabIndex = 13;
            this.fillButton.Text = "🪣";
            this.fillButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 29);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsJSONToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsJSONToolStripMenuItem
            // 
            this.saveAsJSONToolStripMenuItem.Name = "saveAsJSONToolStripMenuItem";
            this.saveAsJSONToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.saveAsJSONToolStripMenuItem.Text = "Save as JSON";
            this.saveAsJSONToolStripMenuItem.Click += new System.EventHandler(this.saveAsJSONToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.saveAsToolStripMenuItem.Text = "Save as IMAGE";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openJSONToolStripMenuItem,
            this.openImageToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openJSONToolStripMenuItem
            // 
            this.openJSONToolStripMenuItem.Name = "openJSONToolStripMenuItem";
            this.openJSONToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.openJSONToolStripMenuItem.Text = "Open JSON";
            this.openJSONToolStripMenuItem.Click += new System.EventHandler(this.openJSONToolStripMenuItem_Click);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.openImageToolStripMenuItem.Text = "Open Image (png)";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Checked = true;
            this.toolsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStatisticsToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // openStatisticsToolStripMenuItem
            // 
            this.openStatisticsToolStripMenuItem.Name = "openStatisticsToolStripMenuItem";
            this.openStatisticsToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.openStatisticsToolStripMenuItem.Text = "Open Statistics";
            this.openStatisticsToolStripMenuItem.Click += new System.EventHandler(this.openStatisticsToolStripMenuItem_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.redoButton);
            this.toolsPanel.Controls.Add(this.selectButton);
            this.toolsPanel.Controls.Add(this.eraseButton);
            this.toolsPanel.Controls.Add(this.fillButton);
            this.toolsPanel.Controls.Add(this.colorPictureBox);
            this.toolsPanel.Controls.Add(this.penButton);
            this.toolsPanel.Controls.Add(this.colorButton);
            this.toolsPanel.Controls.Add(this.brushButton);
            this.toolsPanel.Controls.Add(this.createShapeButton);
            this.toolsPanel.Controls.Add(this.undoButton);
            this.toolsPanel.Location = new System.Drawing.Point(226, 34);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(769, 42);
            this.toolsPanel.TabIndex = 15;
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BackColor = System.Drawing.Color.Black;
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPictureBox.Location = new System.Drawing.Point(303, 11);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(23, 23);
            this.colorPictureBox.TabIndex = 10;
            this.colorPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 605);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.infoStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createShapeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic Editor";
            this.infoStatusStrip.ResumeLayout(false);
            this.infoStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createShapeLabel;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip infoStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel mousePositionInfo;
        private System.Windows.Forms.Button createShapeButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button brushButton;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStatisticsToolStripMenuItem;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}