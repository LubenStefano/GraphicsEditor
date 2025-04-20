namespace GraphicsEditorForms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.editShapeLabel = new System.Windows.Forms.Label();
            this.isFilledCheckBox = new System.Windows.Forms.CheckBox();
            this.editButton = new System.Windows.Forms.Button();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.cLabel = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.yValueTextBox = new System.Windows.Forms.TextBox();
            this.xValueTextBox = new System.Windows.Forms.TextBox();
            this.shapeColorComboBox = new System.Windows.Forms.ComboBox();
            this.isFilledLabel = new System.Windows.Forms.Label();
            this.shapeColorLabel = new System.Windows.Forms.Label();
            this.yValueLabel = new System.Windows.Forms.Label();
            this.xValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editShapeLabel
            // 
            this.editShapeLabel.AutoSize = true;
            this.editShapeLabel.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editShapeLabel.Location = new System.Drawing.Point(324, 9);
            this.editShapeLabel.Name = "editShapeLabel";
            this.editShapeLabel.Size = new System.Drawing.Size(162, 38);
            this.editShapeLabel.TabIndex = 10;
            this.editShapeLabel.Text = "Edit Shape";
            // 
            // isFilledCheckBox
            // 
            this.isFilledCheckBox.AutoSize = true;
            this.isFilledCheckBox.Location = new System.Drawing.Point(243, 340);
            this.isFilledCheckBox.Name = "isFilledCheckBox";
            this.isFilledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isFilledCheckBox.TabIndex = 4;
            this.isFilledCheckBox.UseVisualStyleBackColor = true;
            this.isFilledCheckBox.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(503, 322);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(243, 49);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit Shape";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(505, 266);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(242, 29);
            this.cTextBox.TabIndex = 7;
            this.cTextBox.Visible = false;
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(591, 238);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(60, 24);
            this.cLabel.TabIndex = 30;
            this.cLabel.Text = "label1";
            this.cLabel.Visible = false;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(505, 185);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(242, 29);
            this.bTextBox.TabIndex = 6;
            this.bTextBox.Visible = false;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(591, 157);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(60, 24);
            this.bLabel.TabIndex = 28;
            this.bLabel.Text = "label1";
            this.bLabel.Visible = false;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(505, 110);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(242, 29);
            this.aTextBox.TabIndex = 5;
            this.aTextBox.Visible = false;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(591, 82);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(60, 24);
            this.aLabel.TabIndex = 26;
            this.aLabel.Text = "label1";
            this.aLabel.Visible = false;
            // 
            // yValueTextBox
            // 
            this.yValueTextBox.Location = new System.Drawing.Point(70, 185);
            this.yValueTextBox.Name = "yValueTextBox";
            this.yValueTextBox.Size = new System.Drawing.Size(242, 29);
            this.yValueTextBox.TabIndex = 2;
            this.yValueTextBox.Visible = false;
            // 
            // xValueTextBox
            // 
            this.xValueTextBox.Location = new System.Drawing.Point(70, 110);
            this.xValueTextBox.Name = "xValueTextBox";
            this.xValueTextBox.Size = new System.Drawing.Size(242, 29);
            this.xValueTextBox.TabIndex = 1;
            this.xValueTextBox.Visible = false;
            // 
            // shapeColorComboBox
            // 
            this.shapeColorComboBox.BackColor = System.Drawing.Color.White;
            this.shapeColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeColorComboBox.ForeColor = System.Drawing.Color.Silver;
            this.shapeColorComboBox.FormattingEnabled = true;
            this.shapeColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Pink",
            "Purple"});
            this.shapeColorComboBox.Location = new System.Drawing.Point(70, 266);
            this.shapeColorComboBox.Name = "shapeColorComboBox";
            this.shapeColorComboBox.Size = new System.Drawing.Size(242, 32);
            this.shapeColorComboBox.TabIndex = 3;
            this.shapeColorComboBox.Visible = false;
            // 
            // isFilledLabel
            // 
            this.isFilledLabel.AutoSize = true;
            this.isFilledLabel.Location = new System.Drawing.Point(117, 334);
            this.isFilledLabel.Name = "isFilledLabel";
            this.isFilledLabel.Size = new System.Drawing.Size(103, 24);
            this.isFilledLabel.TabIndex = 22;
            this.isFilledLabel.Text = "Color filled:";
            this.isFilledLabel.Visible = false;
            // 
            // shapeColorLabel
            // 
            this.shapeColorLabel.AutoSize = true;
            this.shapeColorLabel.Location = new System.Drawing.Point(89, 238);
            this.shapeColorLabel.Name = "shapeColorLabel";
            this.shapeColorLabel.Size = new System.Drawing.Size(185, 24);
            this.shapeColorLabel.TabIndex = 21;
            this.shapeColorLabel.Text = "Choose shape color:";
            this.shapeColorLabel.Visible = false;
            // 
            // yValueLabel
            // 
            this.yValueLabel.AutoSize = true;
            this.yValueLabel.Location = new System.Drawing.Point(117, 157);
            this.yValueLabel.Name = "yValueLabel";
            this.yValueLabel.Size = new System.Drawing.Size(127, 24);
            this.yValueLabel.TabIndex = 20;
            this.yValueLabel.Text = "Enter Y value:";
            this.yValueLabel.Visible = false;
            // 
            // xValueLabel
            // 
            this.xValueLabel.AutoSize = true;
            this.xValueLabel.Location = new System.Drawing.Point(118, 82);
            this.xValueLabel.Name = "xValueLabel";
            this.xValueLabel.Size = new System.Drawing.Size(129, 24);
            this.xValueLabel.TabIndex = 19;
            this.xValueLabel.Text = "Enter X value:";
            this.xValueLabel.Visible = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 453);
            this.Controls.Add(this.isFilledCheckBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.yValueTextBox);
            this.Controls.Add(this.xValueTextBox);
            this.Controls.Add(this.shapeColorComboBox);
            this.Controls.Add(this.isFilledLabel);
            this.Controls.Add(this.shapeColorLabel);
            this.Controls.Add(this.yValueLabel);
            this.Controls.Add(this.xValueLabel);
            this.Controls.Add(this.editShapeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Shape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editShapeLabel;
        private System.Windows.Forms.CheckBox isFilledCheckBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox yValueTextBox;
        private System.Windows.Forms.TextBox xValueTextBox;
        private System.Windows.Forms.ComboBox shapeColorComboBox;
        private System.Windows.Forms.Label isFilledLabel;
        private System.Windows.Forms.Label shapeColorLabel;
        private System.Windows.Forms.Label yValueLabel;
        private System.Windows.Forms.Label xValueLabel;
    }
}