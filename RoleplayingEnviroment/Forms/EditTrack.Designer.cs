namespace Atmorithm.Forms
{
    partial class EditTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTrack));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxPictures = new System.Windows.Forms.ListBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.buttonClearPicture = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.openTrackDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFileName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 182);
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
            // textBoxFileName
            // 
            this.textBoxFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileName.Location = new System.Drawing.Point(61, 30);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(220, 20);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.TabStop = false;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.ItemHeight = 13;
            this.comboBoxCategory.Location = new System.Drawing.Point(61, 56);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(220, 21);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxName
            // 
            this.comboBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(61, 3);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(220, 21);
            this.comboBoxName.TabIndex = 0;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_DropDownClosed);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonLoadPicture, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClearPicture, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxPictures, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(61, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 90);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // listBoxPictures
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.listBoxPictures, 2);
            this.listBoxPictures.FormattingEnabled = true;
            this.listBoxPictures.Location = new System.Drawing.Point(3, 32);
            this.listBoxPictures.Name = "listBoxPictures";
            this.listBoxPictures.Size = new System.Drawing.Size(210, 56);
            this.listBoxPictures.TabIndex = 4;
            this.listBoxPictures.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPictures_MouseClick);
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLoadPicture.FlatAppearance.BorderSize = 0;
            this.buttonLoadPicture.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLoadPicture.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLoadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPicture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadPicture.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(70, 23);
            this.buttonLoadPicture.TabIndex = 2;
            this.buttonLoadPicture.Text = "Hinzufügen";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonAddPicture_Click);
            // 
            // buttonClearPicture
            // 
            this.buttonClearPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonClearPicture.FlatAppearance.BorderSize = 0;
            this.buttonClearPicture.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonClearPicture.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClearPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearPicture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearPicture.Location = new System.Drawing.Point(79, 3);
            this.buttonClearPicture.Name = "buttonClearPicture";
            this.buttonClearPicture.Size = new System.Drawing.Size(70, 23);
            this.buttonClearPicture.TabIndex = 3;
            this.buttonClearPicture.Text = "Entfernen";
            this.buttonClearPicture.UseVisualStyleBackColor = true;
            this.buttonClearPicture.Click += new System.EventHandler(this.buttonClearPicture_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Image = global::Atmorithm.Properties.Resources.emptyImage;
            this.pictureBox.Location = new System.Drawing.Point(287, 3);
            this.pictureBox.Name = "pictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox, 6);
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Bilder";
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "Hintergrund.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNeu,
            this.buttonSave,
            this.buttonDelete});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
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
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(79, 20);
            this.buttonDelete.Text = "Löschen";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // openTrackDialog
            // 
            this.openTrackDialog.FileName = "openFileDialog1";
            // 
            // EditTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 206);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTrack";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Track bearbeiten";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonClearPicture;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buttonNeu;
        private System.Windows.Forms.OpenFileDialog openTrackDialog;
        private System.Windows.Forms.ToolStripMenuItem buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem buttonSave;
        private System.Windows.Forms.ListBox listBoxPictures;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}