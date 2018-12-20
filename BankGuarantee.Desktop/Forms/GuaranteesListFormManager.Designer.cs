namespace BankGuarantee.Desktop.Forms
{
    partial class GuaranteesListFormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuaranteesListFormManager));
            this.guaranteeDataGridView = new System.Windows.Forms.DataGridView();
            this.guaranteesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankGuaranteeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankGuaranteeDataSet = new BankGuarantee.Desktop.DbIntegration.BankGuaranteeDataSet();
            this.createButton = new System.Windows.Forms.Button();
            this.guaranteesTableAdapter = new BankGuarantee.Desktop.DbIntegration.BankGuaranteeDataSetTableAdapters.GuaranteesTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGuaranteeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGuaranteeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guaranteeDataGridView
            // 
            this.guaranteeDataGridView.AllowUserToAddRows = false;
            this.guaranteeDataGridView.AllowUserToDeleteRows = false;
            this.guaranteeDataGridView.AutoGenerateColumns = false;
            this.guaranteeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guaranteeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.startDateDataGridViewTextBoxColumn,
            this.Name,
            this.Amount,
            this.daysDataGridViewTextBoxColumn,
            this.ViewButton});
            this.guaranteeDataGridView.DataSource = this.guaranteesBindingSource;
            this.guaranteeDataGridView.Location = new System.Drawing.Point(13, 12);
            this.guaranteeDataGridView.Name = "guaranteeDataGridView";
            this.guaranteeDataGridView.ReadOnly = true;
            this.guaranteeDataGridView.Size = new System.Drawing.Size(787, 342);
            this.guaranteeDataGridView.TabIndex = 0;
            this.guaranteeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guaranteeDataGridView_CellClick);
            // 
            // guaranteesBindingSource
            // 
            this.guaranteesBindingSource.DataMember = "Guarantees";
            this.guaranteesBindingSource.DataSource = this.bankGuaranteeDataSetBindingSource;
            // 
            // bankGuaranteeDataSetBindingSource
            // 
            this.bankGuaranteeDataSetBindingSource.DataSource = this.bankGuaranteeDataSet;
            this.bankGuaranteeDataSetBindingSource.Position = 0;
            // 
            // bankGuaranteeDataSet
            // 
            this.bankGuaranteeDataSet.DataSetName = "BankGuaranteeDataSet";
            this.bankGuaranteeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(333, 386);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // guaranteesTableAdapter
            // 
            this.guaranteesTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.FillWeight = 80F;
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Банковская гарантия";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 320;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Сумма";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Продолжительность (дней)";
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.ReadOnly = true;
            this.daysDataGridViewTextBoxColumn.Width = 120;
            // 
            // ViewButton
            // 
            this.ViewButton.HeaderText = "Просмотр";
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.ReadOnly = true;
            this.ViewButton.Text = "Открыть";
            this.ViewButton.UseColumnTextForButtonValue = true;
            // 
            // GuaranteesListFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.guaranteeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Text = "Список гарантий";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuaranteesListFormManager_FormClosed);
            this.Load += new System.EventHandler(this.GuaranteesListFormManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guaranteeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGuaranteeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGuaranteeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView guaranteeDataGridView;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.BindingSource bankGuaranteeDataSetBindingSource;
        private DbIntegration.BankGuaranteeDataSet bankGuaranteeDataSet;
        private System.Windows.Forms.BindingSource guaranteesBindingSource;
        private DbIntegration.BankGuaranteeDataSetTableAdapters.GuaranteesTableAdapter guaranteesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewButton;
    }
}