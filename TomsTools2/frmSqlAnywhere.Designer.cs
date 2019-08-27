namespace TomsTools2
{
    partial class frmSqlAnywhere
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
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOutput = new System.Windows.Forms.DataGridView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.presetStatementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slimlineSRItemsBoxSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatement
            // 
            this.txtStatement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatement.Location = new System.Drawing.Point(13, 60);
            this.txtStatement.Multiline = true;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(775, 116);
            this.txtStatement.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Statement Below:";
            // 
            // dgOutput
            // 
            this.dgOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutput.Location = new System.Drawing.Point(13, 217);
            this.dgOutput.Name = "dgOutput";
            this.dgOutput.Size = new System.Drawing.Size(775, 225);
            this.dgOutput.TabIndex = 2;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(713, 182);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetStatementsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // presetStatementsToolStripMenuItem
            // 
            this.presetStatementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slimlineSRItemsBoxSectionToolStripMenuItem});
            this.presetStatementsToolStripMenuItem.Name = "presetStatementsToolStripMenuItem";
            this.presetStatementsToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.presetStatementsToolStripMenuItem.Text = "Preset Statements";
            this.presetStatementsToolStripMenuItem.Click += new System.EventHandler(this.presetStatementsToolStripMenuItem_Click);
            // 
            // slimlineSRItemsBoxSectionToolStripMenuItem
            // 
            this.slimlineSRItemsBoxSectionToolStripMenuItem.Name = "slimlineSRItemsBoxSectionToolStripMenuItem";
            this.slimlineSRItemsBoxSectionToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.slimlineSRItemsBoxSectionToolStripMenuItem.Text = "Slimline SR Items + Box Section";
            this.slimlineSRItemsBoxSectionToolStripMenuItem.Click += new System.EventHandler(this.slimlineSRItemsBoxSectionToolStripMenuItem_Click);
            // 
            // frmSqlAnywhere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.dgOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatement);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSqlAnywhere";
            this.Text = "sqlAnywhere";
            ((System.ComponentModel.ISupportInitialize)(this.dgOutput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOutput;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem presetStatementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slimlineSRItemsBoxSectionToolStripMenuItem;
    }
}