namespace PHYS252Project
{
    partial class mainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.modeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeRadioButton = new System.Windows.Forms.RadioButton();
            this.massRadioButton = new System.Windows.Forms.RadioButton();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.variablesGroupBox = new System.Windows.Forms.GroupBox();
            this.massNumeric = new System.Windows.Forms.NumericUpDown();
            this.velocityNumeric = new System.Windows.Forms.NumericUpDown();
            this.goGroupBox = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.modeGroupBox.SuspendLayout();
            this.variablesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityNumeric)).BeginInit();
            this.goGroupBox.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(82, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(484, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PHYS 252 - Simulation of Time Dilation";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.Controls.Add(this.timeRadioButton);
            this.modeGroupBox.Controls.Add(this.massRadioButton);
            this.modeGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.modeGroupBox.Location = new System.Drawing.Point(29, 92);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Size = new System.Drawing.Size(289, 70);
            this.modeGroupBox.TabIndex = 1;
            this.modeGroupBox.TabStop = false;
            this.modeGroupBox.Text = "Step 1: Pick mode";
            // 
            // timeRadioButton
            // 
            this.timeRadioButton.AutoSize = true;
            this.timeRadioButton.Location = new System.Drawing.Point(121, 23);
            this.timeRadioButton.Name = "timeRadioButton";
            this.timeRadioButton.Size = new System.Drawing.Size(72, 30);
            this.timeRadioButton.TabIndex = 1;
            this.timeRadioButton.TabStop = true;
            this.timeRadioButton.Text = "Time";
            this.timeRadioButton.UseVisualStyleBackColor = true;
            this.timeRadioButton.CheckedChanged += new System.EventHandler(this.velocityRadioButton_CheckedChanged);
            // 
            // massRadioButton
            // 
            this.massRadioButton.AutoSize = true;
            this.massRadioButton.Location = new System.Drawing.Point(6, 23);
            this.massRadioButton.Name = "massRadioButton";
            this.massRadioButton.Size = new System.Drawing.Size(71, 30);
            this.massRadioButton.TabIndex = 0;
            this.massRadioButton.TabStop = true;
            this.massRadioButton.Text = "Mass";
            this.massRadioButton.UseVisualStyleBackColor = true;
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.velocityLabel.Location = new System.Drawing.Point(166, 48);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(65, 20);
            this.velocityLabel.TabIndex = 5;
            this.velocityLabel.Text = "Velocity";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.massLabel.Location = new System.Drawing.Point(179, 88);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(40, 20);
            this.massLabel.TabIndex = 6;
            this.massLabel.Text = "Mass";
            // 
            // variablesGroupBox
            // 
            this.variablesGroupBox.Controls.Add(this.massNumeric);
            this.variablesGroupBox.Controls.Add(this.velocityNumeric);
            this.variablesGroupBox.Controls.Add(this.massLabel);
            this.variablesGroupBox.Controls.Add(this.velocityLabel);
            this.variablesGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.variablesGroupBox.Location = new System.Drawing.Point(29, 182);
            this.variablesGroupBox.Name = "variablesGroupBox";
            this.variablesGroupBox.Size = new System.Drawing.Size(289, 126);
            this.variablesGroupBox.TabIndex = 8;
            this.variablesGroupBox.TabStop = false;
            this.variablesGroupBox.Text = "Step 2: Fill in necessary info";
            // 
            // massNumeric
            // 
            this.massNumeric.DecimalPlaces = 2;
            this.massNumeric.Location = new System.Drawing.Point(20, 82);
            this.massNumeric.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.massNumeric.Name = "massNumeric";
            this.massNumeric.Size = new System.Drawing.Size(120, 34);
            this.massNumeric.TabIndex = 14;
            // 
            // velocityNumeric
            // 
            this.velocityNumeric.DecimalPlaces = 2;
            this.velocityNumeric.Location = new System.Drawing.Point(20, 42);
            this.velocityNumeric.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.velocityNumeric.Name = "velocityNumeric";
            this.velocityNumeric.Size = new System.Drawing.Size(120, 34);
            this.velocityNumeric.TabIndex = 13;
            // 
            // goGroupBox
            // 
            this.goGroupBox.Controls.Add(this.startButton);
            this.goGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.goGroupBox.Location = new System.Drawing.Point(29, 403);
            this.goGroupBox.Name = "goGroupBox";
            this.goGroupBox.Size = new System.Drawing.Size(289, 85);
            this.goGroupBox.TabIndex = 9;
            this.goGroupBox.TabStop = false;
            this.goGroupBox.Text = "Step 3: Hit \"Start Simulation\"";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(59, 33);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(155, 30);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Simulation";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultsTextBox);
            this.resultsGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.resultsGroupBox.Location = new System.Drawing.Point(358, 92);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(321, 289);
            this.resultsGroupBox.TabIndex = 10;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Step 4: View Results   ";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(7, 34);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(308, 249);
            this.resultsTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.groupBox1.Location = new System.Drawing.Point(358, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 5: Once completed, hit \"Reset\"";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(69, 33);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(177, 30);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.creditLabel.Location = new System.Drawing.Point(131, 57);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(394, 17);
            this.creditLabel.TabIndex = 12;
            this.creditLabel.Text = "By: Ashley Shea, Nicholas Mangopoulos, and Jacob Willinger";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 516);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.goGroupBox);
            this.Controls.Add(this.variablesGroupBox);
            this.Controls.Add(this.modeGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "mainForm";
            this.Text = "PHYS 252 - Simulation of Time Variation";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            this.variablesGroupBox.ResumeLayout(false);
            this.variablesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityNumeric)).EndInit();
            this.goGroupBox.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.RadioButton timeRadioButton;
        private System.Windows.Forms.RadioButton massRadioButton;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.GroupBox variablesGroupBox;
        private System.Windows.Forms.GroupBox goGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.NumericUpDown massNumeric;
        private System.Windows.Forms.NumericUpDown velocityNumeric;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

