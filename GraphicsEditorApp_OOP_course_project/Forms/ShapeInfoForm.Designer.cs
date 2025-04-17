namespace GraphicsEditorApp_OOP_course_project
{
    partial class ShapeInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeInfoForm));
            this.shapePanel = new System.Windows.Forms.Panel();
            this.shapeInfoLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.coordinatesLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorFillLabel = new System.Windows.Forms.Label();
            this.sizesLabel = new System.Windows.Forms.Label();
            this.filledColorCheckBox = new System.Windows.Forms.CheckBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.coordinatesTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.shapeTypeTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapePanel
            // 
            this.shapePanel.BackColor = System.Drawing.Color.White;
            this.shapePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapePanel.Location = new System.Drawing.Point(25, 88);
            this.shapePanel.Margin = new System.Windows.Forms.Padding(6);
            this.shapePanel.Name = "shapePanel";
            this.shapePanel.Size = new System.Drawing.Size(341, 411);
            this.shapePanel.TabIndex = 0;
            // 
            // shapeInfoLabel
            // 
            this.shapeInfoLabel.AutoSize = true;
            this.shapeInfoLabel.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeInfoLabel.Location = new System.Drawing.Point(373, 9);
            this.shapeInfoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.shapeInfoLabel.Name = "shapeInfoLabel";
            this.shapeInfoLabel.Size = new System.Drawing.Size(160, 38);
            this.shapeInfoLabel.TabIndex = 1;
            this.shapeInfoLabel.Text = "Shape Info";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(493, 423);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(243, 51);
            this.editButton.TabIndex = 19;
            this.editButton.Text = "Edit Shape";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Enabled = false;
            this.areaLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(398, 101);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(178, 25);
            this.areaLabel.TabIndex = 18;
            this.areaLabel.Text = "Shape actual area:";
            // 
            // coordinatesLabel
            // 
            this.coordinatesLabel.AutoSize = true;
            this.coordinatesLabel.Enabled = false;
            this.coordinatesLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coordinatesLabel.Location = new System.Drawing.Point(398, 166);
            this.coordinatesLabel.Name = "coordinatesLabel";
            this.coordinatesLabel.Size = new System.Drawing.Size(183, 25);
            this.coordinatesLabel.TabIndex = 20;
            this.coordinatesLabel.Text = "Shape coordinates:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Enabled = false;
            this.colorLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(398, 243);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(122, 25);
            this.colorLabel.TabIndex = 21;
            this.colorLabel.Text = "Shape color:";
            // 
            // colorFillLabel
            // 
            this.colorFillLabel.AutoSize = true;
            this.colorFillLabel.Enabled = false;
            this.colorFillLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorFillLabel.Location = new System.Drawing.Point(398, 320);
            this.colorFillLabel.Name = "colorFillLabel";
            this.colorFillLabel.Size = new System.Drawing.Size(149, 25);
            this.colorFillLabel.TabIndex = 22;
            this.colorFillLabel.Text = "Shape color fill:";
            // 
            // sizesLabel
            // 
            this.sizesLabel.AutoSize = true;
            this.sizesLabel.Enabled = false;
            this.sizesLabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizesLabel.Location = new System.Drawing.Point(682, 101);
            this.sizesLabel.Name = "sizesLabel";
            this.sizesLabel.Size = new System.Drawing.Size(123, 25);
            this.sizesLabel.TabIndex = 23;
            this.sizesLabel.Text = "Shape sizes:";
            this.sizesLabel.Visible = false;
            // 
            // filledColorCheckBox
            // 
            this.filledColorCheckBox.AutoSize = true;
            this.filledColorCheckBox.Enabled = false;
            this.filledColorCheckBox.Location = new System.Drawing.Point(402, 348);
            this.filledColorCheckBox.Name = "filledColorCheckBox";
            this.filledColorCheckBox.Size = new System.Drawing.Size(75, 29);
            this.filledColorCheckBox.TabIndex = 24;
            this.filledColorCheckBox.Text = "filled";
            this.filledColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorTextBox
            // 
            this.colorTextBox.BackColor = System.Drawing.Color.White;
            this.colorTextBox.Enabled = false;
            this.colorTextBox.Location = new System.Drawing.Point(402, 271);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(174, 38);
            this.colorTextBox.TabIndex = 25;
            // 
            // coordinatesTextBox
            // 
            this.coordinatesTextBox.BackColor = System.Drawing.Color.White;
            this.coordinatesTextBox.Enabled = false;
            this.coordinatesTextBox.Location = new System.Drawing.Point(402, 194);
            this.coordinatesTextBox.Name = "coordinatesTextBox";
            this.coordinatesTextBox.ReadOnly = true;
            this.coordinatesTextBox.Size = new System.Drawing.Size(174, 38);
            this.coordinatesTextBox.TabIndex = 26;
            // 
            // areaTextBox
            // 
            this.areaTextBox.BackColor = System.Drawing.Color.White;
            this.areaTextBox.Enabled = false;
            this.areaTextBox.Location = new System.Drawing.Point(402, 132);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.ReadOnly = true;
            this.areaTextBox.Size = new System.Drawing.Size(174, 38);
            this.areaTextBox.TabIndex = 27;
            // 
            // aTextBox
            // 
            this.aTextBox.BackColor = System.Drawing.Color.White;
            this.aTextBox.Enabled = false;
            this.aTextBox.Location = new System.Drawing.Point(688, 169);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.ReadOnly = true;
            this.aTextBox.Size = new System.Drawing.Size(111, 38);
            this.aTextBox.TabIndex = 28;
            this.aTextBox.Visible = false;
            // 
            // bTextBox
            // 
            this.bTextBox.BackColor = System.Drawing.Color.White;
            this.bTextBox.Enabled = false;
            this.bTextBox.Location = new System.Drawing.Point(687, 236);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.ReadOnly = true;
            this.bTextBox.Size = new System.Drawing.Size(111, 38);
            this.bTextBox.TabIndex = 29;
            this.bTextBox.Visible = false;
            // 
            // cTextBox
            // 
            this.cTextBox.BackColor = System.Drawing.Color.White;
            this.cTextBox.Enabled = false;
            this.cTextBox.Location = new System.Drawing.Point(689, 297);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.ReadOnly = true;
            this.cTextBox.Size = new System.Drawing.Size(111, 38);
            this.cTextBox.TabIndex = 30;
            this.cTextBox.Visible = false;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Enabled = false;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel.Location = new System.Drawing.Point(685, 146);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(93, 18);
            this.aLabel.TabIndex = 31;
            this.aLabel.Text = "Shape sizes:";
            this.aLabel.Visible = false;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Enabled = false;
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bLabel.Location = new System.Drawing.Point(684, 214);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(93, 18);
            this.bLabel.TabIndex = 32;
            this.bLabel.Text = "Shape sizes:";
            this.bLabel.Visible = false;
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Enabled = false;
            this.cLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cLabel.Location = new System.Drawing.Point(686, 276);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(93, 18);
            this.cLabel.TabIndex = 33;
            this.cLabel.Text = "Shape sizes:";
            this.cLabel.Visible = false;
            // 
            // shapeTypeTextBox
            // 
            this.shapeTypeTextBox.BackColor = System.Drawing.Color.White;
            this.shapeTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapeTypeTextBox.Enabled = false;
            this.shapeTypeTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeTypeTextBox.ForeColor = System.Drawing.Color.Black;
            this.shapeTypeTextBox.Location = new System.Drawing.Point(25, 42);
            this.shapeTypeTextBox.Name = "shapeTypeTextBox";
            this.shapeTypeTextBox.ReadOnly = true;
            this.shapeTypeTextBox.Size = new System.Drawing.Size(162, 32);
            this.shapeTypeTextBox.TabIndex = 34;
            this.shapeTypeTextBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.Location = new System.Drawing.Point(493, 480);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(243, 51);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.Text = "Delete Shape";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ShapeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 547);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.shapeTypeTextBox);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.coordinatesTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.filledColorCheckBox);
            this.Controls.Add(this.sizesLabel);
            this.Controls.Add(this.colorFillLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.coordinatesLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.shapeInfoLabel);
            this.Controls.Add(this.shapePanel);
            this.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ShapeInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel shapePanel;
        private System.Windows.Forms.Label shapeInfoLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label coordinatesLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label colorFillLabel;
        private System.Windows.Forms.Label sizesLabel;
        private System.Windows.Forms.CheckBox filledColorCheckBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox coordinatesTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox shapeTypeTextBox;
        private System.Windows.Forms.Button deleteButton;
    }
}