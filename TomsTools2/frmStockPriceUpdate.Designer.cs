namespace TomsTools2
{
    partial class frmStockPriceUpdate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockPriceUpdate));
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.order_databaseDataSet = new TomsTools2.order_databaseDataSet();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new TomsTools2.order_databaseDataSetTableAdapters.supplierTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.grpIncreaseDecrease = new System.Windows.Forms.GroupBox();
            this.rdoIncrease = new System.Windows.Forms.RadioButton();
            this.rdoDecrease = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.grpIncreaseDecrease.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DataSource = this.supplierBindingSource;
            this.cmbSupplier.DisplayMember = "NAME";
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(127, 21);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(298, 21);
            this.cmbSupplier.TabIndex = 0;
            this.cmbSupplier.ValueMember = "id";
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(127, 125);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(59, 20);
            this.txtPercentage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Percentage:";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(127, 49);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(298, 20);
            this.txtKeyword.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(348, 124);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // order_databaseDataSet
            // 
            this.order_databaseDataSet.DataSetName = "order_databaseDataSet";
            this.order_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.order_databaseDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock containing word:";
            // 
            // grpIncreaseDecrease
            // 
            this.grpIncreaseDecrease.Controls.Add(this.rdoDecrease);
            this.grpIncreaseDecrease.Controls.Add(this.rdoIncrease);
            this.grpIncreaseDecrease.Location = new System.Drawing.Point(127, 76);
            this.grpIncreaseDecrease.Name = "grpIncreaseDecrease";
            this.grpIncreaseDecrease.Size = new System.Drawing.Size(298, 42);
            this.grpIncreaseDecrease.TabIndex = 7;
            this.grpIncreaseDecrease.TabStop = false;
            this.grpIncreaseDecrease.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoIncrease
            // 
            this.rdoIncrease.AutoSize = true;
            this.rdoIncrease.Checked = true;
            this.rdoIncrease.Location = new System.Drawing.Point(7, 14);
            this.rdoIncrease.Name = "rdoIncrease";
            this.rdoIncrease.Size = new System.Drawing.Size(66, 17);
            this.rdoIncrease.TabIndex = 0;
            this.rdoIncrease.TabStop = true;
            this.rdoIncrease.Text = "Increase";
            this.rdoIncrease.UseVisualStyleBackColor = true;
            // 
            // rdoDecrease
            // 
            this.rdoDecrease.AutoSize = true;
            this.rdoDecrease.Location = new System.Drawing.Point(87, 15);
            this.rdoDecrease.Name = "rdoDecrease";
            this.rdoDecrease.Size = new System.Drawing.Size(71, 17);
            this.rdoDecrease.TabIndex = 1;
            this.rdoDecrease.Text = "Decrease";
            this.rdoDecrease.UseVisualStyleBackColor = true;
            // 
            // frmStockPriceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 166);
            this.Controls.Add(this.grpIncreaseDecrease);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.cmbSupplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockPriceUpdate";
            this.Text = "Batch Stock Price Adjustment";
            this.Load += new System.EventHandler(this.frmStockPriceUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.grpIncreaseDecrease.ResumeLayout(false);
            this.grpIncreaseDecrease.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSubmit;
        private order_databaseDataSet order_databaseDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private order_databaseDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpIncreaseDecrease;
        private System.Windows.Forms.RadioButton rdoDecrease;
        private System.Windows.Forms.RadioButton rdoIncrease;
    }
}