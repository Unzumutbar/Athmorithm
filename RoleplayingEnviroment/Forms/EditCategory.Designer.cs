namespace Atmorithm.Forms
{
    partial class EditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategory));
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.buttonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBottom = new System.Windows.Forms.MenuStrip();
            this.buttonReassignCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.menuStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxCategories, 2);
            this.listBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(3, 29);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(288, 186);
            this.listBoxCategories.TabIndex = 3;
            this.listBoxCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCategories_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxCategories, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 218);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(44, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonDelete,
            this.buttonNeu});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(294, 24);
            this.menuStripTop.TabIndex = 2;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonDelete.Image = global::Atmorithm.Properties.Resources.minus;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(79, 20);
            this.buttonDelete.Text = "Löschen";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonNeu
            // 
            this.buttonNeu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonNeu.Image = ((System.Drawing.Image)(resources.GetObject("buttonNeu.Image")));
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(97, 20);
            this.buttonNeu.Text = "Hinzufügen";
            this.buttonNeu.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // menuStripBottom
            // 
            this.menuStripBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonReassignCategories});
            this.menuStripBottom.Location = new System.Drawing.Point(0, 242);
            this.menuStripBottom.Name = "menuStripBottom";
            this.menuStripBottom.Size = new System.Drawing.Size(294, 24);
            this.menuStripBottom.TabIndex = 3;
            this.menuStripBottom.Text = "menuStrip2";
            // 
            // buttonReassignCategories
            // 
            this.buttonReassignCategories.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonReassignCategories.Image = global::Atmorithm.Properties.Resources.pricetags;
            this.buttonReassignCategories.Name = "buttonReassignCategories";
            this.buttonReassignCategories.Size = new System.Drawing.Size(189, 20);
            this.buttonReassignCategories.Text = "Alle Kategorien neu zuweisen";
            this.buttonReassignCategories.Click += new System.EventHandler(this.buttonReassignCategories_Click);
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 266);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStripTop);
            this.Controls.Add(this.menuStripBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "EditCategory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kategorie hinzufügen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.menuStripBottom.ResumeLayout(false);
            this.menuStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem buttonNeu;
        private System.Windows.Forms.MenuStrip menuStripBottom;
        private System.Windows.Forms.ToolStripMenuItem buttonReassignCategories;
    }
}