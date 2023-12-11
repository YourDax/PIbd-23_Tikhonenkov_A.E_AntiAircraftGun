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
            this.ButtonSortByColor = new System.Windows.Forms.Button();
            this.ButtonSortByType = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxStorageName = new System.Windows.Forms.TextBox();
            this.listBoxStorages = new System.Windows.Forms.ListBox();
            this.buttonAddCollection = new System.Windows.Forms.Button();
            this.buttonDelCollection = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonUpdateColletion = new System.Windows.Forms.Button();
            this.buttonDeleteZenit = new System.Windows.Forms.Button();
            this.buttonAddZenit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollection)).BeginInit();
            this.panelTools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCollection
            // 
            this.pictureBoxCollection.Location = new System.Drawing.Point(12, 50);
            this.pictureBoxCollection.Name = "pictureBoxCollection";
            this.pictureBoxCollection.Size = new System.Drawing.Size(711, 571);
            this.pictureBoxCollection.TabIndex = 0;
            this.pictureBoxCollection.TabStop = false;
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.ButtonSortByColor);
            this.panelTools.Controls.Add(this.ButtonSortByType);
            this.panelTools.Controls.Add(this.panel1);
            this.panelTools.Controls.Add(this.maskedTextBoxNumber);
            this.panelTools.Controls.Add(this.buttonUpdateColletion);
            this.panelTools.Controls.Add(this.buttonDeleteZenit);
            this.panelTools.Controls.Add(this.buttonAddZenit);
            this.panelTools.Location = new System.Drawing.Point(729, 50);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(234, 568);
            this.panelTools.TabIndex = 1;
            this.panelTools.Tag = "";
            // 
            // ButtonSortByColor
            // 
            this.ButtonSortByColor.Location = new System.Drawing.Point(25, 344);
            this.ButtonSortByColor.Name = "ButtonSortByColor";
            this.ButtonSortByColor.Size = new System.Drawing.Size(193, 35);
            this.ButtonSortByColor.TabIndex = 10;
            this.ButtonSortByColor.Text = "Сортировка по цвету";
            this.ButtonSortByColor.UseVisualStyleBackColor = true;
            this.ButtonSortByColor.Click += new System.EventHandler(this.ButtonSortByColor_Click);
            // 
            // ButtonSortByType
            // 
            this.ButtonSortByType.Location = new System.Drawing.Point(27, 303);
            this.ButtonSortByType.Name = "ButtonSortByType";
            this.ButtonSortByType.Size = new System.Drawing.Size(193, 35);
            this.ButtonSortByType.TabIndex = 9;
            this.ButtonSortByType.Text = "Сортировка по типу";
            this.ButtonSortByType.UseVisualStyleBackColor = true;
            this.ButtonSortByType.Click += new System.EventHandler(this.ButtonSortByType_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxStorageName);
            this.panel1.Controls.Add(this.listBoxStorages);
            this.panel1.Controls.Add(this.buttonAddCollection);
            this.panel1.Controls.Add(this.buttonDelCollection);
            this.panel1.Location = new System.Drawing.Point(15, 3);
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
            this.listBoxStorages.SelectedIndexChanged += new System.EventHandler(this.ListBoxObjects_SelectedIndexChanged);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "File";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormAntiAirCraftGunCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 633);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.pictureBoxCollection);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAntiAirCraftGunCollection";
            this.Text = "FormAntiAirCraftGunCollection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCollection)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button ButtonSortByColor;
        private Button ButtonSortByType;
    }
}