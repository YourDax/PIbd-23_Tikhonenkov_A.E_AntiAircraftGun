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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxStorageName = new System.Windows.Forms.TextBox();
            this.listBoxStorages = new System.Windows.Forms.ListBox();
            this.buttonAddCollection = new System.Windows.Forms.Button();
            this.buttonDelCollection = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonUpdateColletion = new System.Windows.Forms.Button();
            this.buttonDeleteZenit = new System.Windows.Forms.Button();
            this.buttonAddZenit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollection)).BeginInit();
            this.panelTools.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelTools.Controls.Add(this.panel1);
            this.panelTools.Controls.Add(this.maskedTextBoxNumber);
            this.panelTools.Controls.Add(this.buttonUpdateColletion);
            this.panelTools.Controls.Add(this.buttonDeleteZenit);
            this.panelTools.Controls.Add(this.buttonAddZenit);
            this.panelTools.Location = new System.Drawing.Point(729, 14);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(234, 568);
            this.panelTools.TabIndex = 1;
            this.panelTools.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxStorageName);
            this.panel1.Controls.Add(this.listBoxStorages);
            this.panel1.Controls.Add(this.buttonAddCollection);
            this.panel1.Controls.Add(this.buttonDelCollection);
            this.panel1.Location = new System.Drawing.Point(15, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 294);
            this.panel1.TabIndex = 8;
            this.panel1.Tag = "Наборы";
            // 
            // textBoxStorageName
            // 
            this.textBoxStorageName.Location = new System.Drawing.Point(12, 53);
            this.textBoxStorageName.Name = "textBoxStorageName";
            this.textBoxStorageName.Size = new System.Drawing.Size(193, 23);
            this.textBoxStorageName.TabIndex = 7;
            // 
            // listBoxStorages
            // 
            this.listBoxStorages.FormattingEnabled = true;
            this.listBoxStorages.ItemHeight = 15;
            this.listBoxStorages.Location = new System.Drawing.Point(12, 137);
            this.listBoxStorages.Name = "listBoxStorages";
            this.listBoxStorages.Size = new System.Drawing.Size(191, 94);
            this.listBoxStorages.TabIndex = 6;
            // 
            // buttonAddCollection
            // 
            this.buttonAddCollection.Location = new System.Drawing.Point(10, 92);
            this.buttonAddCollection.Name = "buttonAddCollection";
            this.buttonAddCollection.Size = new System.Drawing.Size(193, 40);
            this.buttonAddCollection.TabIndex = 5;
            this.buttonAddCollection.Text = "Добавить набор";
            this.buttonAddCollection.UseVisualStyleBackColor = true;
            this.buttonAddCollection.Click += new System.EventHandler(this.ButtonAddObject_Click);
            // 
            // buttonDelCollection
            // 
            this.buttonDelCollection.Location = new System.Drawing.Point(12, 249);
            this.buttonDelCollection.Name = "buttonDelCollection";
            this.buttonDelCollection.Size = new System.Drawing.Size(193, 40);
            this.buttonDelCollection.TabIndex = 4;
            this.buttonDelCollection.Text = "Удалить набор";
            this.buttonDelCollection.UseVisualStyleBackColor = true;
            this.buttonDelCollection.Click += new System.EventHandler(this.ButtonDelObject_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(23, 435);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(193, 23);
            this.maskedTextBoxNumber.TabIndex = 3;
            // 
            // buttonUpdateColletion
            // 
            this.buttonUpdateColletion.Location = new System.Drawing.Point(23, 525);
            this.buttonUpdateColletion.Name = "buttonUpdateColletion";
            this.buttonUpdateColletion.Size = new System.Drawing.Size(193, 40);
            this.buttonUpdateColletion.TabIndex = 2;
            this.buttonUpdateColletion.Text = "Обновить коллекцию";
            this.buttonUpdateColletion.UseVisualStyleBackColor = true;
            this.buttonUpdateColletion.Click += new System.EventHandler(this.ButtonUpdateCollection_Click);
            // 
            // buttonDeleteZenit
            // 
            this.buttonDeleteZenit.Location = new System.Drawing.Point(23, 464);
            this.buttonDeleteZenit.Name = "buttonDeleteZenit";
            this.buttonDeleteZenit.Size = new System.Drawing.Size(193, 40);
            this.buttonDeleteZenit.TabIndex = 1;
            this.buttonDeleteZenit.Text = "Удалить объект";
            this.buttonDeleteZenit.UseVisualStyleBackColor = true;
            this.buttonDeleteZenit.Click += new System.EventHandler(this.ButtonDeleteZenit_Click);
            // 
            // buttonAddZenit
            // 
            this.buttonAddZenit.Location = new System.Drawing.Point(23, 389);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxCollection;
        private Panel panelTools;
        private TextBox maskedTextBoxNumber;
        private Button buttonUpdateColletion;
        private Button buttonDeleteZenit;
        private Button buttonAddZenit;
        private Panel panel1;
        private TextBox textBoxStorageName;
        private ListBox listBoxStorages;
        private Button buttonAddCollection;
        private Button buttonDelCollection;
    }
}