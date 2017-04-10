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
            this.massRadioButton = new System.Windows.Forms.RadioButton();
            this.velocityRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.variablesGroupBox = new System.Windows.Forms.GroupBox();
            this.goGroupBox = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.modeGroupBox.SuspendLayout();
            this.variablesGroupBox.SuspendLayout();
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
            this.titleLabel.Size = new System.Drawing.Size(500, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PHYS 252 - Simulation of Time Variation";
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.Controls.Add(this.velocityRadioButton);
            this.modeGroupBox.Controls.Add(this.massRadioButton);
            this.modeGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.modeGroupBox.Location = new System.Drawing.Point(29, 92);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Size = new System.Drawing.Size(289, 70);
            this.modeGroupBox.TabIndex = 1;
            this.modeGroupBox.TabStop = false;
            this.modeGroupBox.Text = "Step 1: Pick mode";
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
            // velocityRadioButton
            // 
            this.velocityRadioButton.AutoSize = true;
            this.velocityRadioButton.Location = new System.Drawing.Point(121, 23);
            this.velocityRadioButton.Name = "velocityRadioButton";
            this.velocityRadioButton.Size = new System.Drawing.Size(99, 30);
            this.velocityRadioButton.TabIndex = 1;
            this.velocityRadioButton.TabStop = true;
            this.velocityRadioButton.Text = "Velocity";
            this.velocityRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 34);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 34);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 34);
            this.textBox3.TabIndex = 4;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.heightLabel.Location = new System.Drawing.Point(179, 40);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(55, 20);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.weightLabel.Location = new System.Drawing.Point(178, 70);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(59, 20);
            this.weightLabel.TabIndex = 6;
            this.weightLabel.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.label3.Location = new System.Drawing.Point(179, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // variablesGroupBox
            // 
            this.variablesGroupBox.Controls.Add(this.label4);
            this.variablesGroupBox.Controls.Add(this.textBox5);
            this.variablesGroupBox.Controls.Add(this.textBox2);
            this.variablesGroupBox.Controls.Add(this.label3);
            this.variablesGroupBox.Controls.Add(this.textBox1);
            this.variablesGroupBox.Controls.Add(this.weightLabel);
            this.variablesGroupBox.Controls.Add(this.textBox3);
            this.variablesGroupBox.Controls.Add(this.heightLabel);
            this.variablesGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.variablesGroupBox.Location = new System.Drawing.Point(29, 182);
            this.variablesGroupBox.Name = "variablesGroupBox";
            this.variablesGroupBox.Size = new System.Drawing.Size(289, 199);
            this.variablesGroupBox.TabIndex = 8;
            this.variablesGroupBox.TabStop = false;
            this.variablesGroupBox.Text = "Step 2: Fill in necessary info";
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
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultsTextBox);
            this.resultsGroupBox.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.resultsGroupBox.Location = new System.Drawing.Point(358, 92);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(305, 289);
            this.resultsGroupBox.TabIndex = 10;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Step 4: View Results   ";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(7, 34);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(292, 249);
            this.resultsTextBox.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(23, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 34);
            this.textBox5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.label4.Location = new System.Drawing.Point(178, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 15F);
            this.groupBox1.Location = new System.Drawing.Point(358, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 5: Hit \"Reset Simulation\"";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(69, 33);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(177, 30);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Reset Simulation";
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 508);
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
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            this.variablesGroupBox.ResumeLayout(false);
            this.variablesGroupBox.PerformLayout();
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
        private System.Windows.Forms.RadioButton velocityRadioButton;
        private System.Windows.Forms.RadioButton massRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox variablesGroupBox;
        private System.Windows.Forms.GroupBox goGroupBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label creditLabel;
    }
}

