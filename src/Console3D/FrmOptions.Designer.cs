namespace Console3D
{
    partial class FrmOptions
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioStandard = new System.Windows.Forms.RadioButton();
            this.RadioMethod = new System.Windows.Forms.RadioButton();
            this.RadioStaticMethod = new System.Windows.Forms.RadioButton();
            this.RadioClass = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNamespace);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Namespace (for Class)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMethodName);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 57);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default Method Name";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(6, 19);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(499, 20);
            this.txtNamespace.TabIndex = 1;
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(6, 19);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(499, 20);
            this.txtMethodName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioClass);
            this.groupBox3.Controls.Add(this.RadioStaticMethod);
            this.groupBox3.Controls.Add(this.RadioMethod);
            this.groupBox3.Controls.Add(this.RadioStandard);
            this.groupBox3.Location = new System.Drawing.Point(12, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Build Type";
            // 
            // RadioStandard
            // 
            this.RadioStandard.AutoSize = true;
            this.RadioStandard.Location = new System.Drawing.Point(6, 19);
            this.RadioStandard.Name = "RadioStandard";
            this.RadioStandard.Size = new System.Drawing.Size(68, 17);
            this.RadioStandard.TabIndex = 0;
            this.RadioStandard.TabStop = true;
            this.RadioStandard.Text = "Standard";
            this.RadioStandard.UseVisualStyleBackColor = true;
            // 
            // RadioMethod
            // 
            this.RadioMethod.AutoSize = true;
            this.RadioMethod.Location = new System.Drawing.Point(80, 19);
            this.RadioMethod.Name = "RadioMethod";
            this.RadioMethod.Size = new System.Drawing.Size(61, 17);
            this.RadioMethod.TabIndex = 0;
            this.RadioMethod.TabStop = true;
            this.RadioMethod.Text = "Method";
            this.RadioMethod.UseVisualStyleBackColor = true;
            // 
            // RadioStaticMethod
            // 
            this.RadioStaticMethod.AutoSize = true;
            this.RadioStaticMethod.Location = new System.Drawing.Point(147, 19);
            this.RadioStaticMethod.Name = "RadioStaticMethod";
            this.RadioStaticMethod.Size = new System.Drawing.Size(91, 17);
            this.RadioStaticMethod.TabIndex = 0;
            this.RadioStaticMethod.TabStop = true;
            this.RadioStaticMethod.Text = "Static Method";
            this.RadioStaticMethod.UseVisualStyleBackColor = true;
            // 
            // RadioClass
            // 
            this.RadioClass.AutoSize = true;
            this.RadioClass.Location = new System.Drawing.Point(244, 19);
            this.RadioClass.Name = "RadioClass";
            this.RadioClass.Size = new System.Drawing.Size(50, 17);
            this.RadioClass.TabIndex = 0;
            this.RadioClass.TabStop = true;
            this.RadioClass.Text = "Class";
            this.RadioClass.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(367, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(12, 215);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 4;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 250);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioClass;
        private System.Windows.Forms.RadioButton RadioStaticMethod;
        private System.Windows.Forms.RadioButton RadioMethod;
        private System.Windows.Forms.RadioButton RadioStandard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnResetAll;
    }
}