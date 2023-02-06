namespace Lab_2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbAmountOfShapes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnExecuteKMeansAlgorithm = new System.Windows.Forms.Button();
            this.btnExecuteMaximinsAlgorithm = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAmountOfShapes
            // 
            this.tbAmountOfShapes.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAmountOfShapes.Location = new System.Drawing.Point(11, 48);
            this.tbAmountOfShapes.Margin = new System.Windows.Forms.Padding(4);
            this.tbAmountOfShapes.Name = "tbAmountOfShapes";
            this.tbAmountOfShapes.Size = new System.Drawing.Size(259, 29);
            this.tbAmountOfShapes.TabIndex = 0;
            this.tbAmountOfShapes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL", 8.068965F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount of shapes:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(11, 82);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(259, 34);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(293, 16);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(739, 661);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // btnExecuteKMeansAlgorithm
            // 
            this.btnExecuteKMeansAlgorithm.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExecuteKMeansAlgorithm.Location = new System.Drawing.Point(9, 170);
            this.btnExecuteKMeansAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecuteKMeansAlgorithm.Name = "btnExecuteKMeansAlgorithm";
            this.btnExecuteKMeansAlgorithm.Size = new System.Drawing.Size(261, 40);
            this.btnExecuteKMeansAlgorithm.TabIndex = 4;
            this.btnExecuteKMeansAlgorithm.Text = "Execute K-Means algorithm";
            this.btnExecuteKMeansAlgorithm.UseVisualStyleBackColor = true;
            this.btnExecuteKMeansAlgorithm.Click += new System.EventHandler(this.btnExecuteKMeansAlgorithm_Click);
            // 
            // btnExecuteMaximinsAlgorithm
            // 
            this.btnExecuteMaximinsAlgorithm.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExecuteMaximinsAlgorithm.Location = new System.Drawing.Point(9, 124);
            this.btnExecuteMaximinsAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecuteMaximinsAlgorithm.Name = "btnExecuteMaximinsAlgorithm";
            this.btnExecuteMaximinsAlgorithm.Size = new System.Drawing.Size(261, 38);
            this.btnExecuteMaximinsAlgorithm.TabIndex = 5;
            this.btnExecuteMaximinsAlgorithm.Text = "Execute Maximin\'s algorithm";
            this.btnExecuteMaximinsAlgorithm.UseVisualStyleBackColor = true;
            this.btnExecuteMaximinsAlgorithm.Click += new System.EventHandler(this.btnExecuteMaximinsAlgorithm_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.btnExecuteMaximinsAlgorithm);
            this.gbSettings.Controls.Add(this.tbAmountOfShapes);
            this.gbSettings.Controls.Add(this.btnExecuteKMeansAlgorithm);
            this.gbSettings.Controls.Add(this.btnGenerate);
            this.gbSettings.Font = new System.Drawing.Font("JetBrains Mono NL", 9.931033F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSettings.Location = new System.Drawing.Point(4, 13);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(4);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(4);
            this.gbSettings.Size = new System.Drawing.Size(281, 661);
            this.gbSettings.TabIndex = 6;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maximin\'s";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox tbAmountOfShapes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnExecuteKMeansAlgorithm;
        private System.Windows.Forms.Button btnExecuteMaximinsAlgorithm;
        private System.Windows.Forms.GroupBox gbSettings;
    }
}