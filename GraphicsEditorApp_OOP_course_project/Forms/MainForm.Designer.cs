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
            this.colorButton = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.infoStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
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
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(509, 9);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(36, 38);
            this.colorButton.TabIndex = 7;
            this.colorButton.Text = "🎨";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // brushButton
            // 
            this.brushButton.Location = new System.Drawing.Point(467, 9);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(36, 38);
            this.brushButton.TabIndex = 8;
            this.brushButton.Text = "🖌️";
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // penButton
            // 
            this.penButton.Location = new System.Drawing.Point(425, 9);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(36, 38);
            this.penButton.TabIndex = 9;
            this.penButton.Text = "✏️";
            this.penButton.UseVisualStyleBackColor = true;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BackColor = System.Drawing.Color.Black;
            this.colorPictureBox.Location = new System.Drawing.Point(551, 12);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(32, 32);
            this.colorPictureBox.TabIndex = 10;
            this.colorPictureBox.TabStop = false;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(341, 9);
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
            this.eraseButton.Location = new System.Drawing.Point(383, 9);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(36, 38);
            this.eraseButton.TabIndex = 12;
            this.eraseButton.Text = "🧽";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 585);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.colorPictureBox);
            this.Controls.Add(this.penButton);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.colorButton);
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
    }
}