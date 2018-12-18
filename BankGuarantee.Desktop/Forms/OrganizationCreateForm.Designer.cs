namespace BankGuarantee.Desktop.Forms
{
    partial class OrganizationCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationCreateForm));
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ogrnTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.founderComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chiefComboBox = new System.Windows.Forms.ComboBox();
            this.foundedYearTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(138, 227);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(238, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(182, 93);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Учредитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Юридический адрес";
            // 
            // ogrnTextBox
            // 
            this.ogrnTextBox.Location = new System.Drawing.Point(26, 144);
            this.ogrnTextBox.Name = "ogrnTextBox";
            this.ogrnTextBox.Size = new System.Drawing.Size(100, 20);
            this.ogrnTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Год основания";
            // 
            // innTextBox
            // 
            this.innTextBox.Location = new System.Drawing.Point(27, 94);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(100, 20);
            this.innTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ОГРН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ИНН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(26, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(417, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // founderComboBox
            // 
            this.founderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.founderComboBox.FormattingEnabled = true;
            this.founderComboBox.Location = new System.Drawing.Point(322, 144);
            this.founderComboBox.Name = "founderComboBox";
            this.founderComboBox.Size = new System.Drawing.Size(121, 21);
            this.founderComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Директор";
            // 
            // chiefComboBox
            // 
            this.chiefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chiefComboBox.FormattingEnabled = true;
            this.chiefComboBox.Location = new System.Drawing.Point(322, 94);
            this.chiefComboBox.Name = "chiefComboBox";
            this.chiefComboBox.Size = new System.Drawing.Size(121, 21);
            this.chiefComboBox.TabIndex = 15;
            // 
            // foundedYearTextBox
            // 
            this.foundedYearTextBox.Location = new System.Drawing.Point(182, 144);
            this.foundedYearTextBox.Name = "foundedYearTextBox";
            this.foundedYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.foundedYearTextBox.TabIndex = 12;
            // 
            // OrganizationCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 281);
            this.Controls.Add(this.chiefComboBox);
            this.Controls.Add(this.founderComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.foundedYearTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ogrnTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.innTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganizationCreateForm";
            this.Text = "Новая организация";
            this.Load += new System.EventHandler(this.OrganizationCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ogrnTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox founderComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chiefComboBox;
        private System.Windows.Forms.TextBox foundedYearTextBox;
    }
}