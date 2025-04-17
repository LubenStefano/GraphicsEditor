namespace GraphicsEditorApp_OOP_course_project
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
            this.createShapeButton = new System.Windows.Forms.Button();
            this.infoStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // createShapeLabel
            // 
            this.createShapeLabel.AutoSize = true;
            this.createShapeLabel.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createShapeLabel.Location = new System.Drawing.Point(15, 9);
            this.createShapeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.createShapeLabel.Name = "createShapeLabel";
            this.createShapeLabel.Size = new System.Drawing.Size(116, 38);
            this.createShapeLabel.TabIndex = 1;
            this.createShapeLabel.Text = "Shapes";
            // 
            // undoButton
            // 
            this.undoButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoButton.Location = new System.Drawing.Point(854, 9);
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
            this.redoButton.Location = new System.Drawing.Point(928, 9);
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
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 486);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // infoStatusStrip
            // 
            this.infoStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mousePositionInfo});
            this.infoStatusStrip.Location = new System.Drawing.Point(0, 563);
            this.infoStatusStrip.Name = "infoStatusStrip";
            this.infoStatusStrip.Size = new System.Drawing.Size(1008, 22);
            this.infoStatusStrip.TabIndex = 5;
            // 
            // mousePositionInfo
            // 
            this.mousePositionInfo.Name = "mousePositionInfo";
            this.mousePositionInfo.Size = new System.Drawing.Size(107, 17);
            this.mousePositionInfo.Text = "mousePositionInfo";
            // 
            // createShapeButton
            // 
            this.createShapeButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createShapeButton.Location = new System.Drawing.Point(659, 9);
            this.createShapeButton.Name = "createShapeButton";
            this.createShapeButton.Size = new System.Drawing.Size(145, 38);
            this.createShapeButton.TabIndex = 6;
            this.createShapeButton.Text = "create shape";
            this.createShapeButton.UseVisualStyleBackColor = true;
            this.createShapeButton.Click += new System.EventHandler(this.createShapeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 585);
            this.Controls.Add(this.createShapeButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.infoStatusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.createShapeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic Editor";
            this.infoStatusStrip.ResumeLayout(false);
            this.infoStatusStrip.PerformLayout();
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
    }
}