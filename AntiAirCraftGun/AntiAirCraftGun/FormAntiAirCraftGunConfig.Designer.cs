namespace AntiAircraftGun
{
    partial class FormAntiAirCraftGunConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.labelAdvanced = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.checkBoxRocket = new System.Windows.Forms.CheckBox();
            this.checkBoxRadar = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxObject = new System.Windows.Forms.PictureBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelAdditionalColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.allowPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).BeginInit();
            this.allowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxParameters);
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 306);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.labelAdvanced);
            this.groupBoxParameters.Controls.Add(this.labelBase);
            this.groupBoxParameters.Controls.Add(this.groupBoxColor);
            this.groupBoxParameters.Controls.Add(this.checkBoxRocket);
            this.groupBoxParameters.Controls.Add(this.checkBoxRadar);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.label1);
            this.groupBoxParameters.Location = new System.Drawing.Point(5, 3);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(566, 300);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // labelAdvanced
            // 
            this.labelAdvanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdvanced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdvanced.Location = new System.Drawing.Point(427, 217);
            this.labelAdvanced.Name = "labelAdvanced";
            this.labelAdvanced.Size = new System.Drawing.Size(88, 40);
            this.labelAdvanced.TabIndex = 8;
            this.labelAdvanced.Text = "Продвинутый";
            this.labelAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdvanced.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // labelBase
            // 
            this.labelBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBase.Location = new System.Drawing.Point(315, 217);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(88, 40);
            this.labelBase.TabIndex = 7;
            this.labelBase.Text = "Простой";
            this.labelBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Location = new System.Drawing.Point(287, 36);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(273, 151);
            this.groupBoxColor.TabIndex = 6;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(196, 83);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(50, 50);
            this.panelPurple.TabIndex = 2;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(140, 83);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(50, 50);
            this.panelBlack.TabIndex = 2;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(84, 83);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(50, 50);
            this.panelGray.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(28, 83);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(50, 50);
            this.panelWhite.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(196, 27);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(50, 50);
            this.panelYellow.TabIndex = 2;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(140, 27);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(50, 50);
            this.panelBlue.TabIndex = 2;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(84, 27);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(50, 50);
            this.panelGreen.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(28, 27);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(50, 50);
            this.panelRed.TabIndex = 0;
            // 
            // checkBoxRocket
            // 
            this.checkBoxRocket.AutoSize = true;
            this.checkBoxRocket.Location = new System.Drawing.Point(41, 229);
            this.checkBoxRocket.Name = "checkBoxRocket";
            this.checkBoxRocket.Size = new System.Drawing.Size(165, 19);
            this.checkBoxRocket.TabIndex = 5;
            this.checkBoxRocket.Text = "Признак наличия ракеты";
            this.checkBoxRocket.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadar
            // 
            this.checkBoxRadar.AutoSize = true;
            this.checkBoxRadar.Location = new System.Drawing.Point(41, 189);
            this.checkBoxRadar.Name = "checkBoxRadar";
            this.checkBoxRadar.Size = new System.Drawing.Size(164, 19);
            this.checkBoxRadar.TabIndex = 4;
            this.checkBoxRadar.Text = "Признак наличия радара";
            this.checkBoxRadar.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(128, 82);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(128, 36);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скорость";
            // 
            // pictureBoxObject
            // 
            this.pictureBoxObject.Location = new System.Drawing.Point(41, 85);
            this.pictureBoxObject.Name = "pictureBoxObject";
            this.pictureBoxObject.Size = new System.Drawing.Size(227, 141);
            this.pictureBoxObject.TabIndex = 1;
            this.pictureBoxObject.TabStop = false;
            // 
            // labelColor
            // 
            this.labelColor.AllowDrop = true;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(20, 24);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(120, 32);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "Цвет";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.colorLabel_DragDrop);
            this.labelColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.colorLabel_DragEnter);
            // 
            // labelAdditionalColor
            // 
            this.labelAdditionalColor.AllowDrop = true;
            this.labelAdditionalColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdditionalColor.Location = new System.Drawing.Point(169, 24);
            this.labelAdditionalColor.Name = "labelAdditionalColor";
            this.labelAdditionalColor.Size = new System.Drawing.Size(120, 32);
            this.labelAdditionalColor.TabIndex = 3;
            this.labelAdditionalColor.Text = "Доп.Цвет";
            this.labelAdditionalColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdditionalColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.addColorLabel_DragDrop);
            this.labelAdditionalColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.colorLabel_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(587, 278);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(164, 37);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(757, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(152, 37);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // allowPanel
            // 
            this.allowPanel.AllowDrop = true;
            this.allowPanel.Controls.Add(this.labelAdditionalColor);
            this.allowPanel.Controls.Add(this.labelColor);
            this.allowPanel.Controls.Add(this.pictureBoxObject);
            this.allowPanel.Location = new System.Drawing.Point(589, 9);
            this.allowPanel.Name = "allowPanel";
            this.allowPanel.Size = new System.Drawing.Size(316, 263);
            this.allowPanel.TabIndex = 6;
            this.allowPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.allowPanel_DragDrop);
            this.allowPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.allowPanel_DragEnter);
            // 
            // FormAntiAirCraftGunConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 327);
            this.Controls.Add(this.allowPanel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Name = "FormAntiAirCraftGunConfig";
            this.Text = "FormAntiAirCraftGunConfig";
            this.panel1.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).EndInit();
            this.allowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxParameters;
        private Label labelAdvanced;
        private Label labelBase;
        private GroupBox groupBoxColor;
        private Panel panelPurple;
        private Panel panelBlack;
        private Panel panelGray;
        private Panel panelWhite;
        private Panel panelYellow;
        private Panel panelBlue;
        private Panel panelGreen;
        private Panel panelRed;
        private CheckBox checkBoxRocket;
        private CheckBox checkBoxRadar;
        private NumericUpDown numericUpDownWeight;
        private NumericUpDown numericUpDownSpeed;
        private Label label2;
        private Label label1;
        private PictureBox pictureBoxObject;
        private Label labelColor;
        private Label labelAdditionalColor;
        private Button buttonAdd;
        private Button buttonCancel;
        private Panel allowPanel;
    }
}