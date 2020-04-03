namespace LiveSplit.PostalLoads
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
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.chkGenAutoStart = new System.Windows.Forms.CheckBox();
            this.chkGenAutoReset = new System.Windows.Forms.CheckBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbPL = new System.Windows.Forms.GroupBox();
            this.tlpPL = new System.Windows.Forms.TableLayoutPanel();
            this.labPLComingSoon = new System.Windows.Forms.Label();
            this.gbP2 = new System.Windows.Forms.GroupBox();
            this.tlpP2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkP2AutoSplit = new System.Windows.Forms.CheckBox();
            this.gbAW = new System.Windows.Forms.GroupBox();
            this.tlpAW = new System.Windows.Forms.TableLayoutPanel();
            this.labAWComingSoon = new System.Windows.Forms.Label();
            this.mapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbGeneral.SuspendLayout();
            this.tlpGeneral.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.gbPL.SuspendLayout();
            this.tlpPL.SuspendLayout();
            this.gbP2.SuspendLayout();
            this.tlpP2.SuspendLayout();
            this.gbAW.SuspendLayout();
            this.tlpAW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGeneral
            // 
            this.gbGeneral.AutoSize = true;
            this.gbGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbGeneral.Controls.Add(this.tlpGeneral);
            this.gbGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGeneral.Location = new System.Drawing.Point(3, 3);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(456, 65);
            this.gbGeneral.TabIndex = 5;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.AutoSize = true;
            this.tlpGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGeneral.BackColor = System.Drawing.Color.Transparent;
            this.tlpGeneral.ColumnCount = 1;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.Controls.Add(this.chkGenAutoStart, 0, 0);
            this.tlpGeneral.Controls.Add(this.chkGenAutoReset, 0, 1);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.Location = new System.Drawing.Point(3, 16);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.RowCount = 5;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGeneral.Size = new System.Drawing.Size(450, 46);
            this.tlpGeneral.TabIndex = 4;
            // 
            // chkGenAutoStart
            // 
            this.chkGenAutoStart.AutoSize = true;
            this.chkGenAutoStart.Checked = true;
            this.chkGenAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenAutoStart.Location = new System.Drawing.Point(3, 3);
            this.chkGenAutoStart.Name = "chkGenAutoStart";
            this.chkGenAutoStart.Size = new System.Drawing.Size(98, 17);
            this.chkGenAutoStart.TabIndex = 4;
            this.chkGenAutoStart.Text = "Automatic Start";
            this.chkGenAutoStart.UseVisualStyleBackColor = true;
            // 
            // chkGenAutoReset
            // 
            this.chkGenAutoReset.AutoSize = true;
            this.chkGenAutoReset.Checked = true;
            this.chkGenAutoReset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenAutoReset.Location = new System.Drawing.Point(3, 26);
            this.chkGenAutoReset.Name = "chkGenAutoReset";
            this.chkGenAutoReset.Size = new System.Drawing.Size(104, 17);
            this.chkGenAutoReset.TabIndex = 5;
            this.chkGenAutoReset.Text = "Automatic Reset";
            this.chkGenAutoReset.UseVisualStyleBackColor = true;
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gbPL, 0, 3);
            this.tlpMain.Controls.Add(this.gbP2, 0, 1);
            this.tlpMain.Controls.Add(this.gbGeneral, 0, 0);
            this.tlpMain.Controls.Add(this.gbAW, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(7, 7);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(462, 542);
            this.tlpMain.TabIndex = 0;
            // 
            // gbPL
            // 
            this.gbPL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbPL.Controls.Add(this.tlpPL);
            this.gbPL.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbPL.Location = new System.Drawing.Point(3, 228);
            this.gbPL.Name = "gbPL";
            this.gbPL.Size = new System.Drawing.Size(456, 69);
            this.gbPL.TabIndex = 7;
            this.gbPL.TabStop = false;
            this.gbPL.Text = "Paradise Lost";
            // 
            // tlpPL
            // 
            this.tlpPL.AutoSize = true;
            this.tlpPL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpPL.BackColor = System.Drawing.Color.Transparent;
            this.tlpPL.ColumnCount = 1;
            this.tlpPL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPL.Controls.Add(this.labPLComingSoon, 0, 4);
            this.tlpPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPL.Location = new System.Drawing.Point(3, 16);
            this.tlpPL.Name = "tlpPL";
            this.tlpPL.RowCount = 5;
            this.tlpPL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPL.Size = new System.Drawing.Size(450, 50);
            this.tlpPL.TabIndex = 4;
            // 
            // labPLComingSoon
            // 
            this.labPLComingSoon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPLComingSoon.AutoSize = true;
            this.labPLComingSoon.Location = new System.Drawing.Point(190, 18);
            this.labPLComingSoon.Name = "labPLComingSoon";
            this.labPLComingSoon.Size = new System.Drawing.Size(70, 13);
            this.labPLComingSoon.TabIndex = 9;
            this.labPLComingSoon.Text = "Coming Soon";
            this.labPLComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbP2
            // 
            this.gbP2.AutoSize = true;
            this.gbP2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbP2.Controls.Add(this.tlpP2);
            this.gbP2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbP2.Location = new System.Drawing.Point(3, 78);
            this.gbP2.Name = "gbP2";
            this.gbP2.Size = new System.Drawing.Size(456, 42);
            this.gbP2.TabIndex = 2;
            this.gbP2.TabStop = false;
            this.gbP2.Text = "Postal 2";
            // 
            // tlpP2
            // 
            this.tlpP2.AutoSize = true;
            this.tlpP2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpP2.BackColor = System.Drawing.Color.Transparent;
            this.tlpP2.ColumnCount = 1;
            this.tlpP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpP2.Controls.Add(this.chkP2AutoSplit, 0, 0);
            this.tlpP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpP2.Location = new System.Drawing.Point(3, 16);
            this.tlpP2.Name = "tlpP2";
            this.tlpP2.RowCount = 5;
            this.tlpP2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpP2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpP2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpP2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpP2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpP2.Size = new System.Drawing.Size(450, 23);
            this.tlpP2.TabIndex = 4;
            // 
            // chkP2AutoSplit
            // 
            this.chkP2AutoSplit.AutoSize = true;
            this.chkP2AutoSplit.Checked = true;
            this.chkP2AutoSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkP2AutoSplit.Location = new System.Drawing.Point(3, 3);
            this.chkP2AutoSplit.Name = "chkP2AutoSplit";
            this.chkP2AutoSplit.Size = new System.Drawing.Size(158, 17);
            this.chkP2AutoSplit.TabIndex = 4;
            this.chkP2AutoSplit.Text = "Split at the end of every day";
            this.chkP2AutoSplit.UseVisualStyleBackColor = true;
            // 
            // gbAW
            // 
            this.gbAW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbAW.BackColor = System.Drawing.SystemColors.Control;
            this.gbAW.Controls.Add(this.tlpAW);
            this.gbAW.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAW.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbAW.Location = new System.Drawing.Point(3, 153);
            this.gbAW.Name = "gbAW";
            this.gbAW.Size = new System.Drawing.Size(456, 69);
            this.gbAW.TabIndex = 6;
            this.gbAW.TabStop = false;
            this.gbAW.Text = "Apocalypse Weekend";
            // 
            // tlpAW
            // 
            this.tlpAW.AutoSize = true;
            this.tlpAW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpAW.BackColor = System.Drawing.Color.Transparent;
            this.tlpAW.ColumnCount = 1;
            this.tlpAW.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAW.Controls.Add(this.labAWComingSoon, 0, 4);
            this.tlpAW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAW.Location = new System.Drawing.Point(3, 16);
            this.tlpAW.Name = "tlpAW";
            this.tlpAW.RowCount = 5;
            this.tlpAW.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAW.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAW.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAW.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAW.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAW.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAW.Size = new System.Drawing.Size(450, 50);
            this.tlpAW.TabIndex = 4;
            // 
            // labAWComingSoon
            // 
            this.labAWComingSoon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labAWComingSoon.AutoSize = true;
            this.labAWComingSoon.Location = new System.Drawing.Point(190, 18);
            this.labAWComingSoon.Name = "labAWComingSoon";
            this.labAWComingSoon.Size = new System.Drawing.Size(70, 13);
            this.labAWComingSoon.TabIndex = 8;
            this.labAWComingSoon.Text = "Coming Soon";
            this.labAWComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapBindingSource
            // 
            this.mapBindingSource.AllowNew = true;
            this.mapBindingSource.DataSource = typeof(LiveSplit.PostalLoads.Map);
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
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.tlpGeneral.ResumeLayout(false);
            this.tlpGeneral.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.gbPL.ResumeLayout(false);
            this.gbPL.PerformLayout();
            this.tlpPL.ResumeLayout(false);
            this.tlpPL.PerformLayout();
            this.gbP2.ResumeLayout(false);
            this.gbP2.PerformLayout();
            this.tlpP2.ResumeLayout(false);
            this.tlpP2.PerformLayout();
            this.gbAW.ResumeLayout(false);
            this.gbAW.PerformLayout();
            this.tlpAW.ResumeLayout(false);
            this.tlpAW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.BindingSource mapBindingSource;
		private System.Windows.Forms.GroupBox gbGeneral;
		private System.Windows.Forms.TableLayoutPanel tlpGeneral;
		private System.Windows.Forms.CheckBox chkGenAutoStart;
		private System.Windows.Forms.CheckBox chkGenAutoReset;
		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.GroupBox gbPL;
		private System.Windows.Forms.GroupBox gbAW;
		private System.Windows.Forms.TableLayoutPanel tlpAW;
		private System.Windows.Forms.GroupBox gbP2;
		private System.Windows.Forms.TableLayoutPanel tlpP2;
		private System.Windows.Forms.CheckBox chkP2AutoSplit;
		private System.Windows.Forms.TableLayoutPanel tlpPL;
		private System.Windows.Forms.Label labPLComingSoon;
		private System.Windows.Forms.Label labAWComingSoon;
	}
}
