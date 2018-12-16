namespace BankGuarantee.Desktop.Forms
{
    partial class GuaranteeCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuaranteeCreateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.organizationsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ogrnTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.founderTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chiefTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Срок";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // organizationsComboBox
            // 
            this.organizationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organizationsComboBox.FormattingEnabled = true;
            this.organizationsComboBox.Location = new System.Drawing.Point(73, 90);
            this.organizationsComboBox.Name = "organizationsComboBox";
            this.organizationsComboBox.Size = new System.Drawing.Size(121, 21);
            this.organizationsComboBox.TabIndex = 2;
            this.organizationsComboBox.SelectedIndexChanged += new System.EventHandler(this.organizationsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Организация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ИНН";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // innTextBox
            // 
            this.innTextBox.Location = new System.Drawing.Point(73, 142);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.ReadOnly = true;
            this.innTextBox.Size = new System.Drawing.Size(100, 20);
            this.innTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ОГРН";
            // 
            // ogrnTextBox
            // 
            this.ogrnTextBox.Location = new System.Drawing.Point(73, 189);
            this.ogrnTextBox.Name = "ogrnTextBox";
            this.ogrnTextBox.ReadOnly = true;
            this.ogrnTextBox.Size = new System.Drawing.Size(100, 20);
            this.ogrnTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Возраст компании";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(73, 235);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Юридический адрес";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(73, 285);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Учредитель";
            // 
            // founderTextBox
            // 
            this.founderTextBox.Location = new System.Drawing.Point(72, 332);
            this.founderTextBox.Name = "founderTextBox";
            this.founderTextBox.ReadOnly = true;
            this.founderTextBox.Size = new System.Drawing.Size(100, 20);
            this.founderTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Директор";
            // 
            // chiefTextBox
            // 
            this.chiefTextBox.Location = new System.Drawing.Point(73, 382);
            this.chiefTextBox.Name = "chiefTextBox";
            this.chiefTextBox.ReadOnly = true;
            this.chiefTextBox.Size = new System.Drawing.Size(100, 20);
            this.chiefTextBox.TabIndex = 1;
            // 
            // GuaranteeCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.organizationsComboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chiefTextBox);
            this.Controls.Add(this.founderTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ogrnTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.innTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuaranteeCreateForm";
            this.Text = "Создание банковской гарантии";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuaranteeCreateForm_FormClosed);
            this.Load += new System.EventHandler(this.GuaranteeCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox organizationsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ogrnTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox founderTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox chiefTextBox;
    }
}