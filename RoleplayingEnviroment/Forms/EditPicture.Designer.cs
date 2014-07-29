namespace Atmorithm.Forms
{
    partial class EditPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPicture));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkBoxAllowRandomSelect = new System.Windows.Forms.CheckBox();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFileName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAllowRandomSelect, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datei";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategorie";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bild";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileName.Location = new System.Drawing.Point(61, 30);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(230, 20);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.TabStop = false;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(61, 56);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(230, 21);
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxName
            // 
            this.comboBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(61, 3);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(230, 21);
            this.comboBoxName.TabIndex = 1;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_DropDownClosed);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Atmorithm.Properties.Resources.emptyImage;
            this.pictureBox.Location = new System.Drawing.Point(61, 106);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // checkBoxAllowRandomSelect
            // 
            this.checkBoxAllowRandomSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAllowRandomSelect.AutoSize = true;
            this.checkBoxAllowRandomSelect.Location = new System.Drawing.Point(61, 83);
            this.checkBoxAllowRandomSelect.Name = "checkBoxAllowRandomSelect";
            this.checkBoxAllowRandomSelect.Size = new System.Drawing.Size(166, 17);
            this.checkBoxAllowRandomSelect.TabIndex = 6;
            this.checkBoxAllowRandomSelect.Text = "Bild ist in Slideshow verfügbar";
            this.checkBoxAllowRandomSelect.UseVisualStyleBackColor = true;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "Hintergrund.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNeu,
            this.buttonSave,
            this.buttonDelete});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonNeu
            // 
            this.buttonNeu.Image = ((System.Drawing.Image)(resources.GetObject("buttonNeu.Image")));
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(57, 20);
            this.buttonNeu.Text = "Neu";
            this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSave.Image = global::Atmorithm.Properties.Resources.checkmark;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 20);
            this.buttonSave.Text = "Speichern";
            this.buttonSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonDelete.Image = global::Atmorithm.Properties.Resources.minus;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(79, 20);
            this.buttonDelete.Text = "Löschen";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // EditPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditPicture";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bilder bearbeiten";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buttonNeu;
        private System.Windows.Forms.ToolStripMenuItem buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem buttonSave;
        private System.Windows.Forms.CheckBox checkBoxAllowRandomSelect;
    }
}