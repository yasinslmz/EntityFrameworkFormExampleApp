namespace EfFrormExample
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddRoleGb = new System.Windows.Forms.GroupBox();
            this.AddUserGb = new System.Windows.Forms.GroupBox();
            this.RoleNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleSelectImageBtn = new System.Windows.Forms.Button();
            this.AddRoleBtn = new System.Windows.Forms.Button();
            this.RoleImg = new System.Windows.Forms.PictureBox();
            this.AddRoleMessageLbl = new System.Windows.Forms.Label();
            this.RoleStatusCb = new System.Windows.Forms.CheckBox();
            this.AddRoleGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRoleGb
            // 
            this.AddRoleGb.Controls.Add(this.RoleStatusCb);
            this.AddRoleGb.Controls.Add(this.AddRoleMessageLbl);
            this.AddRoleGb.Controls.Add(this.RoleImg);
            this.AddRoleGb.Controls.Add(this.AddRoleBtn);
            this.AddRoleGb.Controls.Add(this.RoleSelectImageBtn);
            this.AddRoleGb.Controls.Add(this.label1);
            this.AddRoleGb.Controls.Add(this.RoleNameTxt);
            this.AddRoleGb.Location = new System.Drawing.Point(67, 53);
            this.AddRoleGb.Name = "AddRoleGb";
            this.AddRoleGb.Size = new System.Drawing.Size(262, 475);
            this.AddRoleGb.TabIndex = 0;
            this.AddRoleGb.TabStop = false;
            this.AddRoleGb.Text = "Add Role";
            // 
            // AddUserGb
            // 
            this.AddUserGb.Location = new System.Drawing.Point(357, 53);
            this.AddUserGb.Name = "AddUserGb";
            this.AddUserGb.Size = new System.Drawing.Size(857, 475);
            this.AddUserGb.TabIndex = 1;
            this.AddUserGb.TabStop = false;
            this.AddUserGb.Text = "Add User";
            // 
            // RoleNameTxt
            // 
            this.RoleNameTxt.Location = new System.Drawing.Point(30, 67);
            this.RoleNameTxt.Name = "RoleNameTxt";
            this.RoleNameTxt.Size = new System.Drawing.Size(190, 26);
            this.RoleNameTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role Name";
            // 
            // RoleSelectImageBtn
            // 
            this.RoleSelectImageBtn.Location = new System.Drawing.Point(30, 112);
            this.RoleSelectImageBtn.Name = "RoleSelectImageBtn";
            this.RoleSelectImageBtn.Size = new System.Drawing.Size(190, 34);
            this.RoleSelectImageBtn.TabIndex = 2;
            this.RoleSelectImageBtn.Text = "Select Image";
            this.RoleSelectImageBtn.UseVisualStyleBackColor = true;
            this.RoleSelectImageBtn.Click += new System.EventHandler(this.RoleSelectImageBtn_Click);
            // 
            // AddRoleBtn
            // 
            this.AddRoleBtn.BackColor = System.Drawing.Color.Green;
            this.AddRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddRoleBtn.ForeColor = System.Drawing.Color.White;
            this.AddRoleBtn.Location = new System.Drawing.Point(30, 361);
            this.AddRoleBtn.Name = "AddRoleBtn";
            this.AddRoleBtn.Size = new System.Drawing.Size(190, 60);
            this.AddRoleBtn.TabIndex = 3;
            this.AddRoleBtn.Text = "Add Role";
            this.AddRoleBtn.UseVisualStyleBackColor = false;
            this.AddRoleBtn.Click += new System.EventHandler(this.AddRoleBtn_Click);
            // 
            // RoleImg
            // 
            this.RoleImg.BackColor = System.Drawing.Color.Gray;
            this.RoleImg.Location = new System.Drawing.Point(30, 152);
            this.RoleImg.Name = "RoleImg";
            this.RoleImg.Size = new System.Drawing.Size(190, 152);
            this.RoleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoleImg.TabIndex = 4;
            this.RoleImg.TabStop = false;
            // 
            // AddRoleMessageLbl
            // 
            this.AddRoleMessageLbl.AutoSize = true;
            this.AddRoleMessageLbl.Location = new System.Drawing.Point(30, 428);
            this.AddRoleMessageLbl.Name = "AddRoleMessageLbl";
            this.AddRoleMessageLbl.Size = new System.Drawing.Size(74, 20);
            this.AddRoleMessageLbl.TabIndex = 5;
            this.AddRoleMessageLbl.Text = "Message";
            // 
            // RoleStatusCb
            // 
            this.RoleStatusCb.AutoSize = true;
            this.RoleStatusCb.Location = new System.Drawing.Point(30, 320);
            this.RoleStatusCb.Name = "RoleStatusCb";
            this.RoleStatusCb.Size = new System.Drawing.Size(82, 24);
            this.RoleStatusCb.TabIndex = 6;
            this.RoleStatusCb.Text = "Status";
            this.RoleStatusCb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 660);
            this.Controls.Add(this.AddUserGb);
            this.Controls.Add(this.AddRoleGb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddRoleGb.ResumeLayout(false);
            this.AddRoleGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddRoleGb;
        private System.Windows.Forms.GroupBox AddUserGb;
        private System.Windows.Forms.PictureBox RoleImg;
        private System.Windows.Forms.Button AddRoleBtn;
        private System.Windows.Forms.Button RoleSelectImageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoleNameTxt;
        private System.Windows.Forms.Label AddRoleMessageLbl;
        private System.Windows.Forms.CheckBox RoleStatusCb;
    }
}

