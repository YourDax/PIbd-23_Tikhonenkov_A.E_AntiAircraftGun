namespace AntiAircraftGun
{
	partial class FormAntiAirCraftGun
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBoxAntiAircraftGun = new System.Windows.Forms.PictureBox();
            this.CreateAdavancedAntiAirCraftGun = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.comboBoxStrategy = new System.Windows.Forms.ComboBox();
            this.CreateAntiAirCraftGun = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAntiAircraftGun)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAntiAircraftGun
            // 
            this.pictureBoxAntiAircraftGun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAntiAircraftGun.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAntiAircraftGun.Name = "pictureBoxAntiAircraftGun";
            this.pictureBoxAntiAircraftGun.Size = new System.Drawing.Size(1491, 628);
            this.pictureBoxAntiAircraftGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAntiAircraftGun.TabIndex = 0;
            this.pictureBoxAntiAircraftGun.TabStop = false;
            // 
            // CreateAdavancedAntiAirCraftGun
            // 
            this.CreateAdavancedAntiAirCraftGun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateAdavancedAntiAirCraftGun.Location = new System.Drawing.Point(32, 577);
            this.CreateAdavancedAntiAirCraftGun.Name = "CreateAdavancedAntiAirCraftGun";
            this.CreateAdavancedAntiAirCraftGun.Size = new System.Drawing.Size(183, 23);
            this.CreateAdavancedAntiAirCraftGun.TabIndex = 1;
            this.CreateAdavancedAntiAirCraftGun.Text = "Создать с дополнениями";
            this.CreateAdavancedAntiAirCraftGun.UseVisualStyleBackColor = true;
            this.CreateAdavancedAntiAirCraftGun.Click += new System.EventHandler(this.CreateAdvancedAintiAirCraftGun_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::AntiAircraftGun.Properties.Resources.strelkaLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(1265, 562);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::AntiAircraftGun.Properties.Resources.strelkaTop;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(1301, 526);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::AntiAircraftGun.Properties.Resources.strelkaRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(1337, 562);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::AntiAircraftGun.Properties.Resources.strelkaDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(1301, 562);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // comboBoxStrategy
            // 
            this.comboBoxStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStrategy.FormattingEnabled = true;
            this.comboBoxStrategy.Items.AddRange(new object[] {
            "Двигаться в центер ",
            "Двигаться в правый нижний угол"});
            this.comboBoxStrategy.Location = new System.Drawing.Point(1244, 28);
            this.comboBoxStrategy.Name = "comboBoxStrategy";
            this.comboBoxStrategy.Size = new System.Drawing.Size(170, 23);
            this.comboBoxStrategy.TabIndex = 6;

            // 
            // CreateAntiAirCraftGun
            // 
            this.CreateAntiAirCraftGun.Location = new System.Drawing.Point(221, 577);
            this.CreateAntiAirCraftGun.Name = "CreateAntiAirCraftGun";
            this.CreateAntiAirCraftGun.Size = new System.Drawing.Size(185, 23);
            this.CreateAntiAirCraftGun.TabIndex = 7;
            this.CreateAntiAirCraftGun.Text = "Создать обычный";
            this.CreateAntiAirCraftGun.UseVisualStyleBackColor = true;
            this.CreateAntiAirCraftGun.Click += new System.EventHandler(this.CreateAntiAirCraftGun_Click);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(1323, 61);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(75, 23);
            this.Step.TabIndex = 8;
            this.Step.Text = "Шаг";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.ButtonStep_Click);
            // 
            // FormAntiAirCraftGun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 628);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.CreateAntiAirCraftGun);
            this.Controls.Add(this.comboBoxStrategy);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.CreateAdavancedAntiAirCraftGun);
            this.Controls.Add(this.pictureBoxAntiAircraftGun);
            this.Name = "FormAntiAirCraftGun";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAntiAircraftGun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBoxAntiAircraftGun;
		private Button CreateAdavancedAntiAirCraftGun;
		private Button buttonLeft;
		private Button buttonUp;
		private Button buttonRight;
		private Button buttonDown;
        private ComboBox comboBoxStrategy;
        private Button CreateAntiAirCraftGun;
        private Button Step;
    }
}