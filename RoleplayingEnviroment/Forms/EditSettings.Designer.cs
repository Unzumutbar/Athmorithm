namespace Atmorithm.Forms
{
    partial class EditSettings
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.buttonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelDatabaseVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIntervall = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFading = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFadingTime = new System.Windows.Forms.TextBox();
            this.labelFadingActivated = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSave,
            this.buttonInfo});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(294, 24);
            this.menuStripTop.TabIndex = 2;
            this.menuStripTop.Text = "menuStrip1";
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
            // buttonInfo
            // 
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(40, 20);
            this.buttonInfo.Text = "Info";
            this.buttonInfo.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelDatabaseVersion});
            this.statusStrip.Location = new System.Drawing.Point(0, 128);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(294, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelDatabaseVersion
            // 
            this.labelDatabaseVersion.Name = "labelDatabaseVersion";
            this.labelDatabaseVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDatabaseVersion.Size = new System.Drawing.Size(113, 17);
            this.labelDatabaseVersion.Text = "Datenbankversion: ?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelFadingActivated, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxFading, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFadingTime, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIntervall, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 104);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minuten";
            // 
            // textBoxIntervall
            // 
            this.textBoxIntervall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIntervall.Location = new System.Drawing.Point(103, 3);
            this.textBoxIntervall.Name = "textBoxIntervall";
            this.textBoxIntervall.Size = new System.Drawing.Size(124, 20);
            this.textBoxIntervall.TabIndex = 2;
            this.textBoxIntervall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIntervall.TextChanged += new System.EventHandler(this.textBoxIntervall_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bildwechselrate";
            // 
            // checkBoxFading
            // 
            this.checkBoxFading.AutoSize = true;
            this.checkBoxFading.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxFading.Location = new System.Drawing.Point(103, 59);
            this.checkBoxFading.Name = "checkBoxFading";
            this.checkBoxFading.Size = new System.Drawing.Size(124, 14);
            this.checkBoxFading.TabIndex = 5;
            this.checkBoxFading.UseVisualStyleBackColor = true;
            this.checkBoxFading.CheckedChanged += new System.EventHandler(this.checkBoxFading_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "  Fading aktivieren";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sekunden";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "  Dauer";
            // 
            // textBoxFadingTime
            // 
            this.textBoxFadingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFadingTime.Location = new System.Drawing.Point(103, 79);
            this.textBoxFadingTime.Name = "textBoxFadingTime";
            this.textBoxFadingTime.Size = new System.Drawing.Size(124, 20);
            this.textBoxFadingTime.TabIndex = 3;
            this.textBoxFadingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxFadingTime.TextChanged += new System.EventHandler(this.textBoxFadingTime_TextChanged);
            // 
            // labelFadingActivated
            // 
            this.labelFadingActivated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFadingActivated.AutoSize = true;
            this.labelFadingActivated.Location = new System.Drawing.Point(233, 59);
            this.labelFadingActivated.Name = "labelFadingActivated";
            this.labelFadingActivated.Size = new System.Drawing.Size(58, 13);
            this.labelFadingActivated.TabIndex = 6;
            this.labelFadingActivated.Text = "Deaktiviert";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 2);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fade-In / Fade-Out";
            // 
            // EditSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 150);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "EditSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Einstellungen bearbeiten";
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelDatabaseVersion;
        private System.Windows.Forms.ToolStripMenuItem buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIntervall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem buttonInfo;
        private System.Windows.Forms.CheckBox checkBoxFading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFadingTime;
        private System.Windows.Forms.Label labelFadingActivated;
        private System.Windows.Forms.Label label7;
    }
}