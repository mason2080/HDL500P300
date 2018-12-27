namespace HLD500
{
    partial class SelectDevice
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHdl5000 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textPassWord = new System.Windows.Forms.TextBox();
            this.buttonP3000 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(24, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(335, 70);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHdl5000
            // 
            this.btnHdl5000.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHdl5000.Location = new System.Drawing.Point(24, 51);
            this.btnHdl5000.Name = "btnHdl5000";
            this.btnHdl5000.Size = new System.Drawing.Size(164, 70);
            this.btnHdl5000.TabIndex = 6;
            this.btnHdl5000.Text = "HDL5000";
            this.btnHdl5000.UseVisualStyleBackColor = true;
            this.btnHdl5000.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码";
            // 
            // textPassWord
            // 
            this.textPassWord.Location = new System.Drawing.Point(432, 94);
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.Size = new System.Drawing.Size(178, 21);
            this.textPassWord.TabIndex = 5;
            this.textPassWord.UseSystemPasswordChar = true;
            // 
            // buttonP3000
            // 
            this.buttonP3000.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonP3000.Location = new System.Drawing.Point(194, 51);
            this.buttonP3000.Name = "buttonP3000";
            this.buttonP3000.Size = new System.Drawing.Size(164, 70);
            this.buttonP3000.TabIndex = 6;
            this.buttonP3000.Text = "P3000";
            this.buttonP3000.UseVisualStyleBackColor = true;
            this.buttonP3000.Click += new System.EventHandler(this.buttonP3000_Click);
            // 
            // SelectDevice
            // 
            this.AcceptButton = this.btnHdl5000;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 250);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.buttonP3000);
            this.Controls.Add(this.btnHdl5000);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPassWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择设备";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHdl5000;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPassWord;
        private System.Windows.Forms.Button buttonP3000;
    }
}