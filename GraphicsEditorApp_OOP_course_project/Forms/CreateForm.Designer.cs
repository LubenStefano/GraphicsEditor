namespace GraphicsEditorApp_OOP_course_project
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.createShapeLabel = new System.Windows.Forms.Label();
            this.chooseShapeLabel = new System.Windows.Forms.Label();
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.xValueLabel = new System.Windows.Forms.Label();
            this.yValueLabel = new System.Windows.Forms.Label();
            this.shapeColorLabel = new System.Windows.Forms.Label();
            this.isFilledLabel = new System.Windows.Forms.Label();
            this.shapeColorComboBox = new System.Windows.Forms.ComboBox();
            this.xValueTextBox = new System.Windows.Forms.TextBox();
            this.yValueTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.cLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.isFilledCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createShapeLabel
            // 
            this.createShapeLabel.AutoSize = true;
            this.createShapeLabel.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createShapeLabel.Location = new System.Drawing.Point(289, 10);
            this.createShapeLabel.Name = "createShapeLabel";
            this.createShapeLabel.Size = new System.Drawing.Size(198, 38);
            this.createShapeLabel.TabIndex = 10;
            this.createShapeLabel.Text = "Create Shape";
            // 
            // chooseShapeLabel
            // 
            this.chooseShapeLabel.AutoSize = true;
            this.chooseShapeLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseShapeLabel.Location = new System.Drawing.Point(307, 64);
            this.chooseShapeLabel.Name = "chooseShapeLabel";
            this.chooseShapeLabel.Size = new System.Drawing.Size(156, 27);
            this.chooseShapeLabel.TabIndex = 11;
            this.chooseShapeLabel.Text = "Choose shape:";
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.BackColor = System.Drawing.Color.White;
            this.shapeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeComboBox.ForeColor = System.Drawing.Color.Silver;
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Circle",
            "Parallelogram",
            "Rhombus",
            "Trapezoid",
            "Triangle"});
            this.shapeComboBox.Location = new System.Drawing.Point(296, 94);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(178, 35);
            this.shapeComboBox.TabIndex = 1;
            this.shapeComboBox.SelectedIndexChanged += new System.EventHandler(this.shapeComboBox_SelectedIndexChanged);
            // 
            // xValueLabel
            // 
            this.xValueLabel.AutoSize = true;
            this.xValueLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValueLabel.Location = new System.Drawing.Point(93, 145);
            this.xValueLabel.Name = "xValueLabel";
            this.xValueLabel.Size = new System.Drawing.Size(148, 27);
            this.xValueLabel.TabIndex = 12;
            this.xValueLabel.Text = "Enter X value:";
            this.xValueLabel.Visible = false;
            // 
            // yValueLabel
            // 
            this.yValueLabel.AutoSize = true;
            this.yValueLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValueLabel.Location = new System.Drawing.Point(92, 226);
            this.yValueLabel.Name = "yValueLabel";
            this.yValueLabel.Size = new System.Drawing.Size(148, 27);
            this.yValueLabel.TabIndex = 13;
            this.yValueLabel.Text = "Enter Y value:";
            this.yValueLabel.Visible = false;
            // 
            // shapeColorLabel
            // 
            this.shapeColorLabel.AutoSize = true;
            this.shapeColorLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeColorLabel.Location = new System.Drawing.Point(64, 313);
            this.shapeColorLabel.Name = "shapeColorLabel";
            this.shapeColorLabel.Size = new System.Drawing.Size(211, 27);
            this.shapeColorLabel.TabIndex = 14;
            this.shapeColorLabel.Text = "Choose shape color:";
            this.shapeColorLabel.Visible = false;
            // 
            // isFilledLabel
            // 
            this.isFilledLabel.AutoSize = true;
            this.isFilledLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isFilledLabel.Location = new System.Drawing.Point(92, 417);
            this.isFilledLabel.Name = "isFilledLabel";
            this.isFilledLabel.Size = new System.Drawing.Size(125, 27);
            this.isFilledLabel.TabIndex = 15;
            this.isFilledLabel.Text = "Color filled:";
            this.isFilledLabel.Visible = false;
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
            this.shapeColorComboBox.Location = new System.Drawing.Point(45, 343);
            this.shapeColorComboBox.Name = "shapeColorComboBox";
            this.shapeColorComboBox.Size = new System.Drawing.Size(242, 35);
            this.shapeColorComboBox.TabIndex = 4;
            this.shapeColorComboBox.Visible = false;
            this.shapeColorComboBox.Leave += new System.EventHandler(this.shapeColorComboBox_Leave);
            // 
            // xValueTextBox
            // 
            this.xValueTextBox.Location = new System.Drawing.Point(45, 175);
            this.xValueTextBox.Name = "xValueTextBox";
            this.xValueTextBox.Size = new System.Drawing.Size(242, 41);
            this.xValueTextBox.TabIndex = 2;
            this.xValueTextBox.Visible = false;
            this.xValueTextBox.Leave += new System.EventHandler(this.xValueTextBox_Leave);
            // 
            // yValueTextBox
            // 
            this.yValueTextBox.Location = new System.Drawing.Point(45, 256);
            this.yValueTextBox.Name = "yValueTextBox";
            this.yValueTextBox.Size = new System.Drawing.Size(242, 41);
            this.yValueTextBox.TabIndex = 3;
            this.yValueTextBox.Visible = false;
            this.yValueTextBox.Leave += new System.EventHandler(this.yValueTextBox_Leave);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.Location = new System.Drawing.Point(566, 145);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(72, 27);
            this.aLabel.TabIndex = 16;
            this.aLabel.Text = "label1";
            this.aLabel.Visible = false;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(480, 175);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(242, 41);
            this.aTextBox.TabIndex = 6;
            this.aTextBox.Visible = false;
            this.aTextBox.Leave += new System.EventHandler(this.aTextBox_Leave);
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(480, 256);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(242, 41);
            this.bTextBox.TabIndex = 7;
            this.bTextBox.Visible = false;
            this.bTextBox.Leave += new System.EventHandler(this.bTextBox_Leave);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.Location = new System.Drawing.Point(566, 226);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(72, 27);
            this.bLabel.TabIndex = 17;
            this.bLabel.Text = "label1";
            this.bLabel.Visible = false;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(480, 343);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(242, 41);
            this.cTextBox.TabIndex = 8;
            this.cTextBox.Visible = false;
            this.cTextBox.Leave += new System.EventHandler(this.cTextBox_Leave);
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.Location = new System.Drawing.Point(566, 313);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(72, 27);
            this.cLabel.TabIndex = 18;
            this.cLabel.Text = "label1";
            this.cLabel.Visible = false;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(478, 404);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(243, 53);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create Shape";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // isFilledCheckBox
            // 
            this.isFilledCheckBox.AutoSize = true;
            this.isFilledCheckBox.Location = new System.Drawing.Point(218, 423);
            this.isFilledCheckBox.Name = "isFilledCheckBox";
            this.isFilledCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isFilledCheckBox.TabIndex = 5;
            this.isFilledCheckBox.UseVisualStyleBackColor = true;
            this.isFilledCheckBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GraphicsEditorApp_OOP_course_project.Properties.Resources.geometricshapesoutlinedsymbol_799631;
            this.pictureBox1.Location = new System.Drawing.Point(45, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 83);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.progressBar1.Location = new System.Drawing.Point(478, 454);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 10);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 501);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.isFilledCheckBox);
            this.Controls.Add(this.createButton);
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
            this.Controls.Add(this.shapeComboBox);
            this.Controls.Add(this.chooseShapeLabel);
            this.Controls.Add(this.createShapeLabel);
            this.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Shape";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createShapeLabel;
        private System.Windows.Forms.Label chooseShapeLabel;
        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.Label xValueLabel;
        private System.Windows.Forms.Label yValueLabel;
        private System.Windows.Forms.Label shapeColorLabel;
        private System.Windows.Forms.Label isFilledLabel;
        private System.Windows.Forms.ComboBox shapeColorComboBox;
        private System.Windows.Forms.TextBox xValueTextBox;
        private System.Windows.Forms.TextBox yValueTextBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.CheckBox isFilledCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

