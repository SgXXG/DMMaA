namespace Lab4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.classesCountNnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vectorsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.elementsCountNumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.teachingButton = new System.Windows.Forms.Button();
            this.teachingResultTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getClassButton = new System.Windows.Forms.Button();
            this.classTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.classesCountNnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorsCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsCountNumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 9.931033F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число классов";
            // 
            // classesCountNnumericUpDown
            // 
            this.classesCountNnumericUpDown.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classesCountNnumericUpDown.Location = new System.Drawing.Point(591, 4);
            this.classesCountNnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.classesCountNnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.classesCountNnumericUpDown.Name = "classesCountNnumericUpDown";
            this.classesCountNnumericUpDown.Size = new System.Drawing.Size(160, 29);
            this.classesCountNnumericUpDown.TabIndex = 1;
            this.classesCountNnumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.classesCountNnumericUpDown.ValueChanged += new System.EventHandler(this.classesCountNnumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 9.931033F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число признаков объекта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 9.931033F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Число объектов в обучающей выборке для каждого класса";
            // 
            // vectorsCountNumericUpDown
            // 
            this.vectorsCountNumericUpDown.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vectorsCountNumericUpDown.Location = new System.Drawing.Point(591, 39);
            this.vectorsCountNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.vectorsCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vectorsCountNumericUpDown.Name = "vectorsCountNumericUpDown";
            this.vectorsCountNumericUpDown.Size = new System.Drawing.Size(160, 29);
            this.vectorsCountNumericUpDown.TabIndex = 4;
            this.vectorsCountNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // elementsCountNumericUpDown3
            // 
            this.elementsCountNumericUpDown3.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementsCountNumericUpDown3.Location = new System.Drawing.Point(591, 76);
            this.elementsCountNumericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.elementsCountNumericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.elementsCountNumericUpDown3.Name = "elementsCountNumericUpDown3";
            this.elementsCountNumericUpDown3.Size = new System.Drawing.Size(160, 29);
            this.elementsCountNumericUpDown3.TabIndex = 5;
            this.elementsCountNumericUpDown3.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // teachingButton
            // 
            this.teachingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teachingButton.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 9.931033F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachingButton.Location = new System.Drawing.Point(19, 112);
            this.teachingButton.Margin = new System.Windows.Forms.Padding(4);
            this.teachingButton.Name = "teachingButton";
            this.teachingButton.Size = new System.Drawing.Size(119, 45);
            this.teachingButton.TabIndex = 6;
            this.teachingButton.Text = "Обучение";
            this.teachingButton.UseVisualStyleBackColor = true;
            this.teachingButton.Click += new System.EventHandler(this.teachingButton_Click);
            // 
            // teachingResultTextBox
            // 
            this.teachingResultTextBox.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachingResultTextBox.Location = new System.Drawing.Point(371, 133);
            this.teachingResultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.teachingResultTextBox.Multiline = true;
            this.teachingResultTextBox.Name = "teachingResultTextBox";
            this.teachingResultTextBox.ReadOnly = true;
            this.teachingResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teachingResultTextBox.Size = new System.Drawing.Size(577, 601);
            this.teachingResultTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 11.7931F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(89, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Классификация";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 286);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 61);
            this.dataGridView1.TabIndex = 9;
            // 
            // getClassButton
            // 
            this.getClassButton.Enabled = false;
            this.getClassButton.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 11.7931F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getClassButton.Location = new System.Drawing.Point(63, 355);
            this.getClassButton.Margin = new System.Windows.Forms.Padding(4);
            this.getClassButton.Name = "getClassButton";
            this.getClassButton.Size = new System.Drawing.Size(205, 35);
            this.getClassButton.TabIndex = 10;
            this.getClassButton.Text = "Классифицировать";
            this.getClassButton.UseVisualStyleBackColor = true;
            this.getClassButton.Click += new System.EventHandler(this.getClassButton_Click);
            // 
            // classTextBox
            // 
            this.classTextBox.AcceptsReturn = true;
            this.classTextBox.BackColor = System.Drawing.Color.White;
            this.classTextBox.Enabled = false;
            this.classTextBox.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classTextBox.Location = new System.Drawing.Point(19, 398);
            this.classTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.classTextBox.Multiline = true;
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.ReadOnly = true;
            this.classTextBox.Size = new System.Drawing.Size(309, 336);
            this.classTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 748);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.getClassButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teachingResultTextBox);
            this.Controls.Add(this.teachingButton);
            this.Controls.Add(this.elementsCountNumericUpDown3);
            this.Controls.Add(this.vectorsCountNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classesCountNnumericUpDown);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("JetBrains Mono NL", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "МиАПР 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classesCountNnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorsCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsCountNumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown classesCountNnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown vectorsCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown elementsCountNumericUpDown3;
        private System.Windows.Forms.Button teachingButton;
        private System.Windows.Forms.TextBox teachingResultTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getClassButton;
        private System.Windows.Forms.TextBox classTextBox;
    }
}

