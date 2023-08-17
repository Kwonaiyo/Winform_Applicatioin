namespace MainForms
{
    partial class New
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(151, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(320, 25);
            this.txtID.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(151, 113);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(320, 25);
            this.txtPW.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(151, 151);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(320, 25);
            this.txtMail.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(151, 191);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(320, 25);
            this.txtAddress.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름(필수)";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(64, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(62, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID(필수)";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(41, 118);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(109, 15);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "비밀번호(필수)";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(70, 154);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 15);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-Mail";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(77, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(37, 15);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "주소";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(157, 250);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 89);
            this.btnOK.TabIndex = 0;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "회원가입";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 89);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;

            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Name = "New";
            this.ShowIcon = false;
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.New_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}