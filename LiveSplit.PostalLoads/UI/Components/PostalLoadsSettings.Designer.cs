namespace LiveSplit.UI.Components
{
    partial class PostalLoadsSettings
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkGenAutoReset = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkGenWeekRuns = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkGenAutoStart = new System.Windows.Forms.CheckBox();
            this.chkGenAutoSplit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapBindingSource)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.groupBox1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(7, 7);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(462, 542);
            this.tlpMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chkGenAutoReset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkGenAutoStart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkGenAutoSplit, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 102);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chkGenAutoReset
            // 
            this.chkGenAutoReset.AutoSize = true;
            this.chkGenAutoReset.Checked = true;
            this.chkGenAutoReset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenAutoReset.Location = new System.Drawing.Point(3, 3);
            this.chkGenAutoReset.Name = "chkGenAutoReset";
            this.chkGenAutoReset.Size = new System.Drawing.Size(102, 17);
            this.chkGenAutoReset.TabIndex = 6;
            this.chkGenAutoReset.Text = "Auto Reset Run";
            this.chkGenAutoReset.UseVisualStyleBackColor = true;
            this.chkGenAutoReset.CheckedChanged += new System.EventHandler(this.chkGenAutoReset_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.chkGenWeekRuns, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(119, 23);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // chkGenWeekRuns
            // 
            this.chkGenWeekRuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGenWeekRuns.AutoSize = true;
            this.chkGenWeekRuns.Checked = true;
            this.chkGenWeekRuns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenWeekRuns.Location = new System.Drawing.Point(33, 3);
            this.chkGenWeekRuns.Name = "chkGenWeekRuns";
            this.chkGenWeekRuns.Size = new System.Drawing.Size(83, 17);
            this.chkGenWeekRuns.TabIndex = 8;
            this.chkGenWeekRuns.Text = "Week Runs";
            this.chkGenWeekRuns.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "└─";
            // 
            // chkGenAutoStart
            // 
            this.chkGenAutoStart.AutoSize = true;
            this.chkGenAutoStart.Checked = true;
            this.chkGenAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenAutoStart.Location = new System.Drawing.Point(3, 57);
            this.chkGenAutoStart.Name = "chkGenAutoStart";
            this.chkGenAutoStart.Size = new System.Drawing.Size(96, 17);
            this.chkGenAutoStart.TabIndex = 11;
            this.chkGenAutoStart.Text = "Auto Start Run";
            this.chkGenAutoStart.UseVisualStyleBackColor = true;
            // 
            // chkGenAutoSplit
            // 
            this.chkGenAutoSplit.AutoSize = true;
            this.chkGenAutoSplit.Checked = true;
            this.chkGenAutoSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenAutoSplit.Location = new System.Drawing.Point(3, 81);
            this.chkGenAutoSplit.Name = "chkGenAutoSplit";
            this.chkGenAutoSplit.Size = new System.Drawing.Size(71, 17);
            this.chkGenAutoSplit.TabIndex = 10;
            this.chkGenAutoSplit.Text = "Auto Split";
            this.chkGenAutoSplit.UseVisualStyleBackColor = true;
            // 
            // PostalLoadsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tlpMain);
            this.Name = "PostalLoadsSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(476, 556);
            ((System.ComponentModel.ISupportInitialize)(this.mapBindingSource)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mapBindingSource;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkGenAutoReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkGenWeekRuns;
        private System.Windows.Forms.CheckBox chkGenAutoStart;
        private System.Windows.Forms.CheckBox chkGenAutoSplit;
    }
}
