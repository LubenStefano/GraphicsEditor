namespace GraphicsEditorApp_OOP_course_project
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
            this.IsFilledCheckBox = new System.Windows.Forms.CheckBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.TextBoxC = new System.Windows.Forms.TextBox();
            this.cLabel = new System.Windows.Forms.Label();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.YvalueTextBox = new System.Windows.Forms.TextBox();
            this.XvalueTextBox = new System.Windows.Forms.TextBox();
            this.ShapeColorComboBox = new System.Windows.Forms.ComboBox();
            this.IsFilledLabel = new System.Windows.Forms.Label();
            this.ShapeColorLabel = new System.Windows.Forms.Label();
            this.YvalueLabel = new System.Windows.Forms.Label();
            this.XvalueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editShapeLabel
            // 
            this.editShapeLabel.AutoSize = true;
            this.editShapeLabel.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editShapeLabel.Location = new System.Drawing.Point(324, 9);
            this.editShapeLabel.Name = "editShapeLabel";
            this.editShapeLabel.Size = new System.Drawing.Size(162, 38);
            this.editShapeLabel.TabIndex = 1;
            this.editShapeLabel.Text = "Edit Shape";
            // 
            // IsFilledCheckBox
            // 
            this.IsFilledCheckBox.AutoSize = true;
            this.IsFilledCheckBox.Location = new System.Drawing.Point(243, 340);
            this.IsFilledCheckBox.Name = "IsFilledCheckBox";
            this.IsFilledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.IsFilledCheckBox.TabIndex = 33;
            this.IsFilledCheckBox.UseVisualStyleBackColor = true;
            this.IsFilledCheckBox.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(503, 322);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(243, 49);
            this.EditButton.TabIndex = 32;
            this.EditButton.Text = "Edit Shape";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // TextBoxC
            // 
            this.TextBoxC.Location = new System.Drawing.Point(505, 266);
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.Size = new System.Drawing.Size(242, 29);
            this.TextBoxC.TabIndex = 31;
            this.TextBoxC.Visible = false;
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
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(505, 185);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(242, 29);
            this.TextBoxB.TabIndex = 29;
            this.TextBoxB.Visible = false;
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
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(505, 110);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(242, 29);
            this.TextBoxA.TabIndex = 27;
            this.TextBoxA.Visible = false;
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
            // YvalueTextBox
            // 
            this.YvalueTextBox.Location = new System.Drawing.Point(70, 185);
            this.YvalueTextBox.Name = "YvalueTextBox";
            this.YvalueTextBox.Size = new System.Drawing.Size(242, 29);
            this.YvalueTextBox.TabIndex = 25;
            this.YvalueTextBox.Visible = false;
            // 
            // XvalueTextBox
            // 
            this.XvalueTextBox.Location = new System.Drawing.Point(70, 110);
            this.XvalueTextBox.Name = "XvalueTextBox";
            this.XvalueTextBox.Size = new System.Drawing.Size(242, 29);
            this.XvalueTextBox.TabIndex = 24;
            this.XvalueTextBox.Visible = false;
            // 
            // ShapeColorComboBox
            // 
            this.ShapeColorComboBox.BackColor = System.Drawing.Color.White;
            this.ShapeColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeColorComboBox.ForeColor = System.Drawing.Color.Silver;
            this.ShapeColorComboBox.FormattingEnabled = true;
            this.ShapeColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Pink",
            "Purple"});
            this.ShapeColorComboBox.Location = new System.Drawing.Point(70, 266);
            this.ShapeColorComboBox.Name = "ShapeColorComboBox";
            this.ShapeColorComboBox.Size = new System.Drawing.Size(242, 32);
            this.ShapeColorComboBox.TabIndex = 23;
            this.ShapeColorComboBox.Visible = false;
            // 
            // IsFilledLabel
            // 
            this.IsFilledLabel.AutoSize = true;
            this.IsFilledLabel.Location = new System.Drawing.Point(117, 334);
            this.IsFilledLabel.Name = "IsFilledLabel";
            this.IsFilledLabel.Size = new System.Drawing.Size(103, 24);
            this.IsFilledLabel.TabIndex = 22;
            this.IsFilledLabel.Text = "Color filled:";
            this.IsFilledLabel.Visible = false;
            // 
            // ShapeColorLabel
            // 
            this.ShapeColorLabel.AutoSize = true;
            this.ShapeColorLabel.Location = new System.Drawing.Point(89, 238);
            this.ShapeColorLabel.Name = "ShapeColorLabel";
            this.ShapeColorLabel.Size = new System.Drawing.Size(185, 24);
            this.ShapeColorLabel.TabIndex = 21;
            this.ShapeColorLabel.Text = "Choose shape color:";
            this.ShapeColorLabel.Visible = false;
            // 
            // YvalueLabel
            // 
            this.YvalueLabel.AutoSize = true;
            this.YvalueLabel.Location = new System.Drawing.Point(117, 157);
            this.YvalueLabel.Name = "YvalueLabel";
            this.YvalueLabel.Size = new System.Drawing.Size(127, 24);
            this.YvalueLabel.TabIndex = 20;
            this.YvalueLabel.Text = "Enter Y value:";
            this.YvalueLabel.Visible = false;
            // 
            // XvalueLabel
            // 
            this.XvalueLabel.AutoSize = true;
            this.XvalueLabel.Location = new System.Drawing.Point(118, 82);
            this.XvalueLabel.Name = "XvalueLabel";
            this.XvalueLabel.Size = new System.Drawing.Size(129, 24);
            this.XvalueLabel.TabIndex = 19;
            this.XvalueLabel.Text = "Enter X value:";
            this.XvalueLabel.Visible = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 453);
            this.Controls.Add(this.IsFilledCheckBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TextBoxC);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.TextBoxA);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.YvalueTextBox);
            this.Controls.Add(this.XvalueTextBox);
            this.Controls.Add(this.ShapeColorComboBox);
            this.Controls.Add(this.IsFilledLabel);
            this.Controls.Add(this.ShapeColorLabel);
            this.Controls.Add(this.YvalueLabel);
            this.Controls.Add(this.XvalueLabel);
            this.Controls.Add(this.editShapeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic Editor Edit Shape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editShapeLabel;
        private System.Windows.Forms.CheckBox IsFilledCheckBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox TextBoxC;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox YvalueTextBox;
        private System.Windows.Forms.TextBox XvalueTextBox;
        private System.Windows.Forms.ComboBox ShapeColorComboBox;
        private System.Windows.Forms.Label IsFilledLabel;
        private System.Windows.Forms.Label ShapeColorLabel;
        private System.Windows.Forms.Label YvalueLabel;
        private System.Windows.Forms.Label XvalueLabel;
    }
}