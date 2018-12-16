using BankGuarantee.Desktop.DbIntegration;

namespace BankGuarantee.Desktop.Forms
{
    partial class GuaranteesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuaranteesListForm));
            this.guaranteesDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankGuaranteeDataSet = new BankGuarantee.Desktop.DbIntegration.BankGuaranteeDataSet();
            this.guaranteesTableAdapter = new BankGuarantee.Desktop.DbIntegration.BankGuaranteeDataSetTableAdapters.GuaranteesTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGuaranteeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guaranteesDataGridView
            // 
            this.guaranteesDataGridView.AllowUserToAddRows = false;
            this.guaranteesDataGridView.AllowUserToDeleteRows = false;
            this.guaranteesDataGridView.AllowUserToOrderColumns = true;
            this.guaranteesDataGridView.AutoGenerateColumns = false;
            this.guaranteesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guaranteesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StartDate,
            this.Name,
            this.Amount,
            this.Days,
            this.ViewColumn});
            this.guaranteesDataGridView.DataSource = this.bindingSource1;
            this.guaranteesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.guaranteesDataGridView.Name = "guaranteesDataGridView";
            this.guaranteesDataGridView.ReadOnly = true;
            this.guaranteesDataGridView.Size = new System.Drawing.Size(756, 354);
            this.guaranteesDataGridView.TabIndex = 0;
            this.guaranteesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guaranteesDataGridView_CellContentClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Guarantees";
            this.bindingSource1.DataSource = this.bankGuaranteeDataSet;
            // 
            // bankGuaranteeDataSet
            // 
            this.bankGuaranteeDataSet.DataSetName = "BankGuaranteeDataSet";
            this.bankGuaranteeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Начало";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Банковская гарантия";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 300;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Cумма";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Days
            // 
            this.Days.DataPropertyName = "Days";
            this.Days.HeaderText = "Продолжительность (дней)";
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            this.Days.Width = 120;
            // 
            // ViewColumn
            // 
            this.ViewColumn.HeaderText = "Просмотр";
            this.ViewColumn.Name = "ViewColumn";
            this.ViewColumn.ReadOnly = true;
            this.ViewColumn.Text = "Открыть";
            this.ViewColumn.UseColumnTextForButtonValue = true;
            this.ViewColumn.Width = 80;
            // 
            // GuaranteesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guaranteesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.Name = "GuaranteesListForm";
            this.Text = "Список гарантий";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuaranteesListForm_FormClosed);
            this.Load += new System.EventHandler(this.GuaranteesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guaranteesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGuaranteeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView guaranteesDataGridView;
        private System.Windows.Forms.BindingSource guaranteesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private BankGuaranteeDataSet bankGuaranteeDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DbIntegration.BankGuaranteeDataSetTableAdapters.GuaranteesTableAdapter guaranteesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewButtonColumn ViewColumn;
    }
}