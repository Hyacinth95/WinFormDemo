﻿namespace WinFormDemo.Attribute
{
    partial class ChangeAttributeValue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAttributeSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentClass = new System.Windows.Forms.Label();
            this.comboBoxPropertySelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAttributeSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelCurrentClass);
            this.groupBox1.Controls.Add(this.comboBoxPropertySelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改现有特性值";
            // 
            // comboBoxAttributeSelect
            // 
            this.comboBoxAttributeSelect.FormattingEnabled = true;
            this.comboBoxAttributeSelect.Location = new System.Drawing.Point(105, 74);
            this.comboBoxAttributeSelect.Name = "comboBoxAttributeSelect";
            this.comboBoxAttributeSelect.Size = new System.Drawing.Size(271, 20);
            this.comboBoxAttributeSelect.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择特性：";
            // 
            // labelCurrentClass
            // 
            this.labelCurrentClass.AutoSize = true;
            this.labelCurrentClass.Location = new System.Drawing.Point(44, 23);
            this.labelCurrentClass.Name = "labelCurrentClass";
            this.labelCurrentClass.Size = new System.Drawing.Size(53, 12);
            this.labelCurrentClass.TabIndex = 2;
            this.labelCurrentClass.Text = "当前类：";
            // 
            // comboBoxPropertySelect
            // 
            this.comboBoxPropertySelect.FormattingEnabled = true;
            this.comboBoxPropertySelect.Location = new System.Drawing.Point(105, 47);
            this.comboBoxPropertySelect.Name = "comboBoxPropertySelect";
            this.comboBoxPropertySelect.Size = new System.Drawing.Size(271, 20);
            this.comboBoxPropertySelect.TabIndex = 1;
            this.comboBoxPropertySelect.SelectedValueChanged += new System.EventHandler(this.comboBoxPropertySelect_SelectedValueChanged);
            this.comboBoxPropertySelect.Click += new System.EventHandler(this.comboBoxPropertySelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择属性：";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加特性并设置值";
            // 
            // ChangeAttributeValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangeAttributeValue";
            this.Text = "ChangeAttributeValue";
            this.Load += new System.EventHandler(this.ChangeAttributeValue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCurrentClass;
        private System.Windows.Forms.ComboBox comboBoxPropertySelect;
        private System.Windows.Forms.ComboBox comboBoxAttributeSelect;
        private System.Windows.Forms.Label label2;
    }
}