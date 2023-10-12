namespace AntiAircraftGun
{
    partial class FormAntiAirCraftGunCollection
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
            this.pictureBoxCollection = new System.Windows.Forms.PictureBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonUpdateColletion = new System.Windows.Forms.Button();
            this.buttonDeleteZenit = new System.Windows.Forms.Button();
            this.buttonAddZenit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollection)).BeginInit();
            this.panelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCollection
            // 
            this.pictureBoxCollection.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCollection.Name = "pictureBoxCollection";
            this.pictureBoxCollection.Size = new System.Drawing.Size(711, 571);
            this.pictureBoxCollection.TabIndex = 0;
            this.pictureBoxCollection.TabStop = false;
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.textBox);
            this.panelTools.Controls.Add(this.buttonUpdateColletion);
            this.panelTools.Controls.Add(this.buttonDeleteZenit);
            this.panelTools.Controls.Add(this.buttonAddZenit);
            this.panelTools.Location = new System.Drawing.Point(729, 14);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(234, 568);
            this.panelTools.TabIndex = 1;
            this.panelTools.Tag = "";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(23, 164);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(193, 23);
            this.textBox.TabIndex = 3;
            // 
            // buttonUpdateColletion
            // 
            this.buttonUpdateColletion.Location = new System.Drawing.Point(23, 263);
            this.buttonUpdateColletion.Name = "buttonUpdateColletion";
            this.buttonUpdateColletion.Size = new System.Drawing.Size(193, 40);
            this.buttonUpdateColletion.TabIndex = 2;
            this.buttonUpdateColletion.Text = "Обновить коллекцию";
            this.buttonUpdateColletion.UseVisualStyleBackColor = true;
            this.buttonUpdateColletion.Click += new System.EventHandler(this.ButtonUpdateCollection_Click);
            // 
            // buttonDeleteZenit
            // 
            this.buttonDeleteZenit.Location = new System.Drawing.Point(23, 193);
            this.buttonDeleteZenit.Name = "buttonDeleteZenit";
            this.buttonDeleteZenit.Size = new System.Drawing.Size(193, 40);
            this.buttonDeleteZenit.TabIndex = 1;
            this.buttonDeleteZenit.Text = "Удалить объект";
            this.buttonDeleteZenit.UseVisualStyleBackColor = true;
            this.buttonDeleteZenit.Click += new System.EventHandler(this.ButtonDeleteZenit_Click);
            // 
            // buttonAddZenit
            // 
            this.buttonAddZenit.Location = new System.Drawing.Point(23, 32);
            this.buttonAddZenit.Name = "buttonAddZenit";
            this.buttonAddZenit.Size = new System.Drawing.Size(193, 40);
            this.buttonAddZenit.TabIndex = 0;
            this.buttonAddZenit.Text = "Добавить объект";
            this.buttonAddZenit.UseVisualStyleBackColor = true;
            this.buttonAddZenit.Click += new System.EventHandler(this.ButtonAddZenit_Click);
            // 
            // FormAntiAirCraftGunCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 595);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.pictureBoxCollection);
            this.Name = "FormAntiAirCraftGunCollection";
            this.Text = "FormAntiAirCraftGunCollection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollection)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxCollection;
        private Panel panelTools;
        private TextBox textBox;
        private Button buttonUpdateColletion;
        private Button buttonDeleteZenit;
        private Button buttonAddZenit;
    }
}