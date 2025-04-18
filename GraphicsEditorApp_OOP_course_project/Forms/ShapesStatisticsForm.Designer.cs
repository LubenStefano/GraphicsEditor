namespace GraphicsEditorApp_OOP_course_project.Forms
{
    partial class ShapesStatisticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shapesStatisticsLabel = new System.Windows.Forms.Label();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.mostUsedShapePanel = new System.Windows.Forms.Panel();
            this.mostUsedShapeTextBox = new System.Windows.Forms.TextBox();
            this.mostUsedShapeLabel = new System.Windows.Forms.Label();
            this.mostUsedColorPanel = new System.Windows.Forms.Panel();
            this.mostUsedColorTextBox = new System.Windows.Forms.TextBox();
            this.mostUsedColorLabel = new System.Windows.Forms.Label();
            this.totalShapesPanel = new System.Windows.Forms.Panel();
            this.totalShapesTextBox = new System.Windows.Forms.TextBox();
            this.totalShapesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapesDataGridView = new System.Windows.Forms.DataGridView();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageAreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mostUsedColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderbyComboBox = new System.Windows.Forms.ComboBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.dashboardPanel.SuspendLayout();
            this.mostUsedShapePanel.SuspendLayout();
            this.mostUsedColorPanel.SuspendLayout();
            this.totalShapesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shapesStatisticsLabel
            // 
            this.shapesStatisticsLabel.AutoSize = true;
            this.shapesStatisticsLabel.Location = new System.Drawing.Point(12, 12);
            this.shapesStatisticsLabel.Name = "shapesStatisticsLabel";
            this.shapesStatisticsLabel.Size = new System.Drawing.Size(181, 27);
            this.shapesStatisticsLabel.TabIndex = 0;
            this.shapesStatisticsLabel.Text = "Shapes Statistics";
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.White;
            this.dashboardPanel.Controls.Add(this.dashboardLabel);
            this.dashboardPanel.Controls.Add(this.mostUsedShapePanel);
            this.dashboardPanel.Controls.Add(this.mostUsedColorPanel);
            this.dashboardPanel.Controls.Add(this.totalShapesPanel);
            this.dashboardPanel.Location = new System.Drawing.Point(199, 12);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(754, 185);
            this.dashboardPanel.TabIndex = 1;
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.AutoSize = true;
            this.dashboardLabel.Location = new System.Drawing.Point(313, 15);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(119, 27);
            this.dashboardLabel.TabIndex = 3;
            this.dashboardLabel.Text = "Dashboard";
            // 
            // mostUsedShapePanel
            // 
            this.mostUsedShapePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mostUsedShapePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mostUsedShapePanel.Controls.Add(this.mostUsedShapeTextBox);
            this.mostUsedShapePanel.Controls.Add(this.mostUsedShapeLabel);
            this.mostUsedShapePanel.Location = new System.Drawing.Point(503, 55);
            this.mostUsedShapePanel.Name = "mostUsedShapePanel";
            this.mostUsedShapePanel.Size = new System.Drawing.Size(239, 117);
            this.mostUsedShapePanel.TabIndex = 2;
            // 
            // mostUsedShapeTextBox
            // 
            this.mostUsedShapeTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mostUsedShapeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostUsedShapeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mostUsedShapeTextBox.Enabled = false;
            this.mostUsedShapeTextBox.Font = new System.Drawing.Font("Sans Serif Collection", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostUsedShapeTextBox.ForeColor = System.Drawing.Color.Black;
            this.mostUsedShapeTextBox.Location = new System.Drawing.Point(21, -2);
            this.mostUsedShapeTextBox.Name = "mostUsedShapeTextBox";
            this.mostUsedShapeTextBox.ReadOnly = true;
            this.mostUsedShapeTextBox.Size = new System.Drawing.Size(197, 99);
            this.mostUsedShapeTextBox.TabIndex = 7;
            this.mostUsedShapeTextBox.TabStop = false;
            this.mostUsedShapeTextBox.Text = "Circle";
            this.mostUsedShapeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mostUsedShapeLabel
            // 
            this.mostUsedShapeLabel.AutoSize = true;
            this.mostUsedShapeLabel.BackColor = System.Drawing.Color.Transparent;
            this.mostUsedShapeLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostUsedShapeLabel.Location = new System.Drawing.Point(52, 92);
            this.mostUsedShapeLabel.Name = "mostUsedShapeLabel";
            this.mostUsedShapeLabel.Size = new System.Drawing.Size(136, 21);
            this.mostUsedShapeLabel.TabIndex = 5;
            this.mostUsedShapeLabel.Text = "most used shape";
            // 
            // mostUsedColorPanel
            // 
            this.mostUsedColorPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mostUsedColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mostUsedColorPanel.Controls.Add(this.mostUsedColorTextBox);
            this.mostUsedColorPanel.Controls.Add(this.mostUsedColorLabel);
            this.mostUsedColorPanel.Location = new System.Drawing.Point(258, 55);
            this.mostUsedColorPanel.Name = "mostUsedColorPanel";
            this.mostUsedColorPanel.Size = new System.Drawing.Size(239, 117);
            this.mostUsedColorPanel.TabIndex = 1;
            // 
            // mostUsedColorTextBox
            // 
            this.mostUsedColorTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mostUsedColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostUsedColorTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mostUsedColorTextBox.Enabled = false;
            this.mostUsedColorTextBox.Font = new System.Drawing.Font("Sans Serif Collection", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostUsedColorTextBox.ForeColor = System.Drawing.Color.Black;
            this.mostUsedColorTextBox.Location = new System.Drawing.Point(45, -2);
            this.mostUsedColorTextBox.Name = "mostUsedColorTextBox";
            this.mostUsedColorTextBox.ReadOnly = true;
            this.mostUsedColorTextBox.Size = new System.Drawing.Size(154, 99);
            this.mostUsedColorTextBox.TabIndex = 6;
            this.mostUsedColorTextBox.TabStop = false;
            this.mostUsedColorTextBox.Text = "Blue";
            this.mostUsedColorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mostUsedColorLabel
            // 
            this.mostUsedColorLabel.AutoSize = true;
            this.mostUsedColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.mostUsedColorLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostUsedColorLabel.Location = new System.Drawing.Point(56, 92);
            this.mostUsedColorLabel.Name = "mostUsedColorLabel";
            this.mostUsedColorLabel.Size = new System.Drawing.Size(128, 21);
            this.mostUsedColorLabel.TabIndex = 5;
            this.mostUsedColorLabel.Text = "most used color";
            // 
            // totalShapesPanel
            // 
            this.totalShapesPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalShapesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalShapesPanel.Controls.Add(this.totalShapesTextBox);
            this.totalShapesPanel.Controls.Add(this.totalShapesLabel);
            this.totalShapesPanel.Location = new System.Drawing.Point(13, 55);
            this.totalShapesPanel.Name = "totalShapesPanel";
            this.totalShapesPanel.Size = new System.Drawing.Size(239, 117);
            this.totalShapesPanel.TabIndex = 0;
            // 
            // totalShapesTextBox
            // 
            this.totalShapesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalShapesTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.totalShapesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalShapesTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.totalShapesTextBox.Enabled = false;
            this.totalShapesTextBox.Font = new System.Drawing.Font("Sans Serif Collection", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShapesTextBox.ForeColor = System.Drawing.Color.Black;
            this.totalShapesTextBox.Location = new System.Drawing.Point(56, -2);
            this.totalShapesTextBox.Name = "totalShapesTextBox";
            this.totalShapesTextBox.ReadOnly = true;
            this.totalShapesTextBox.Size = new System.Drawing.Size(122, 99);
            this.totalShapesTextBox.TabIndex = 5;
            this.totalShapesTextBox.TabStop = false;
            this.totalShapesTextBox.Text = "8";
            this.totalShapesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalShapesLabel
            // 
            this.totalShapesLabel.AutoSize = true;
            this.totalShapesLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalShapesLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShapesLabel.Location = new System.Drawing.Point(68, 92);
            this.totalShapesLabel.Name = "totalShapesLabel";
            this.totalShapesLabel.Size = new System.Drawing.Size(90, 21);
            this.totalShapesLabel.TabIndex = 4;
            this.totalShapesLabel.Text = "total count";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GraphicsEditorApp_OOP_course_project.Properties.Resources.geometricshapesoutlinedsymbol_79963;
            this.pictureBox1.Location = new System.Drawing.Point(31, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "More Data";
            // 
            // shapesDataGridView
            // 
            this.shapesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shapesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.shapesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shapesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeColumn,
            this.usageColumn,
            this.averageAreaColumn,
            this.mostUsedColorColumn});
            this.shapesDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shapesDataGridView.Location = new System.Drawing.Point(7, 290);
            this.shapesDataGridView.Name = "shapesDataGridView";
            this.shapesDataGridView.Size = new System.Drawing.Size(963, 239);
            this.shapesDataGridView.TabIndex = 4;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Width = 230;
            // 
            // usageColumn
            // 
            this.usageColumn.HeaderText = "Usage";
            this.usageColumn.Name = "usageColumn";
            this.usageColumn.Width = 230;
            // 
            // averageAreaColumn
            // 
            this.averageAreaColumn.HeaderText = "Average Area";
            this.averageAreaColumn.Name = "averageAreaColumn";
            this.averageAreaColumn.Width = 230;
            // 
            // mostUsedColorColumn
            // 
            this.mostUsedColorColumn.HeaderText = "Most Used Color";
            this.mostUsedColorColumn.Name = "mostUsedColorColumn";
            this.mostUsedColorColumn.Width = 230;
            // 
            // orderbyComboBox
            // 
            this.orderbyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderbyComboBox.FormattingEnabled = true;
            this.orderbyComboBox.Items.AddRange(new object[] {
            "usage",
            "color",
            "avaragearea"});
            this.orderbyComboBox.Location = new System.Drawing.Point(116, 249);
            this.orderbyComboBox.Name = "orderbyComboBox";
            this.orderbyComboBox.Size = new System.Drawing.Size(151, 35);
            this.orderbyComboBox.TabIndex = 5;
            this.orderbyComboBox.SelectedIndexChanged += new System.EventHandler(this.orderbyComboBox_SelectedIndexChanged);
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(12, 252);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(98, 27);
            this.orderByLabel.TabIndex = 6;
            this.orderByLabel.Text = "order by:";
            // 
            // ShapesStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(975, 541);
            this.Controls.Add(this.orderByLabel);
            this.Controls.Add(this.orderbyComboBox);
            this.Controls.Add(this.shapesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.shapesStatisticsLabel);
            this.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ShapesStatisticsForm";
            this.Text = "ShapesStatisticsForm";
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.mostUsedShapePanel.ResumeLayout(false);
            this.mostUsedShapePanel.PerformLayout();
            this.mostUsedColorPanel.ResumeLayout(false);
            this.mostUsedColorPanel.PerformLayout();
            this.totalShapesPanel.ResumeLayout(false);
            this.totalShapesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shapesStatisticsLabel;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Panel mostUsedShapePanel;
        private System.Windows.Forms.Panel mostUsedColorPanel;
        private System.Windows.Forms.Panel totalShapesPanel;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.Label totalShapesLabel;
        private System.Windows.Forms.TextBox mostUsedShapeTextBox;
        private System.Windows.Forms.Label mostUsedShapeLabel;
        private System.Windows.Forms.TextBox mostUsedColorTextBox;
        private System.Windows.Forms.Label mostUsedColorLabel;
        private System.Windows.Forms.TextBox totalShapesTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView shapesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageAreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mostUsedColorColumn;
        private System.Windows.Forms.ComboBox orderbyComboBox;
        private System.Windows.Forms.Label orderByLabel;
    }
}