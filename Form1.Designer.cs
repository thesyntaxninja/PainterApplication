namespace PainterApplication
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
            this.Canvas = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.largeButton = new System.Windows.Forms.RadioButton();
            this.mediumButton = new System.Windows.Forms.RadioButton();
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blackButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Canvas.Location = new System.Drawing.Point(229, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(514, 527);
            this.Canvas.TabIndex = 5;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.largeButton);
            this.groupBox2.Controls.Add(this.mediumButton);
            this.groupBox2.Controls.Add(this.smallButton);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(9, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size:";
            // 
            // largeButton
            // 
            this.largeButton.AutoSize = true;
            this.largeButton.Location = new System.Drawing.Point(60, 85);
            this.largeButton.Name = "largeButton";
            this.largeButton.Size = new System.Drawing.Size(52, 17);
            this.largeButton.TabIndex = 6;
            this.largeButton.TabStop = true;
            this.largeButton.Text = "Large";
            this.largeButton.UseVisualStyleBackColor = true;
            this.largeButton.CheckedChanged += new System.EventHandler(this.largeButton_CheckedChanged);
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Location = new System.Drawing.Point(60, 60);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(62, 17);
            this.mediumButton.TabIndex = 5;
            this.mediumButton.TabStop = true;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.CheckedChanged += new System.EventHandler(this.mediumButton_CheckedChanged);
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Location = new System.Drawing.Point(60, 35);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(50, 17);
            this.smallButton.TabIndex = 4;
            this.smallButton.TabStop = true;
            this.smallButton.Text = "Small";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.CheckedChanged += new System.EventHandler(this.smallButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.blackButton);
            this.groupBox1.Controls.Add(this.greenButton);
            this.groupBox1.Controls.Add(this.blueButton);
            this.groupBox1.Controls.Add(this.redButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color:";
            // 
            // blackButton
            // 
            this.blackButton.AutoSize = true;
            this.blackButton.Location = new System.Drawing.Point(57, 97);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(52, 17);
            this.blackButton.TabIndex = 3;
            this.blackButton.TabStop = true;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.CheckedChanged += new System.EventHandler(this.blackButton_CheckedChanged);
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(57, 72);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(54, 17);
            this.greenButton.TabIndex = 2;
            this.greenButton.TabStop = true;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.CheckedChanged += new System.EventHandler(this.greenButton_CheckedChanged);
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(57, 47);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(46, 17);
            this.blueButton.TabIndex = 1;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.CheckedChanged += new System.EventHandler(this.blueButton_CheckedChanged);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(57, 22);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 17);
            this.redButton.TabIndex = 0;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.redButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(770, 570);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Painter Application";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton largeButton;
        private System.Windows.Forms.RadioButton mediumButton;
        private System.Windows.Forms.RadioButton smallButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton blackButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton redButton;
    }
}

