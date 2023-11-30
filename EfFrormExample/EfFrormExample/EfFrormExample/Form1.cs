using EfFrormExample.Entity;
using EfFrormExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfFrormExample
{
    public partial class Form1 : Form
    {
        RoleCrud roleCrud=new RoleCrud();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddRoleMessageLbl.Visible = false;
        }

        private void AddRoleBtn_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Name = RoleNameTxt.Text;
            role.IsStatus = RoleStatusCb.Checked;
            string RoleImage = "";
            string imagePath = @"C:\Users\Admin\Desktop\images\";
            string defaultImage = "emptyRole.jpg";
            try
            {
                string imageName = Guid.NewGuid() + ".jpg";
                if (RoleImg.Image != null)
                {
                    RoleImg.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                }
                RoleImage = imagePath + imageName;
            }
            catch
            {
                RoleImage = imagePath + defaultImage;
            }
            role.Image= RoleImage;
            AddRoleMessageLbl.Visible = true;
            AddRoleMessageLbl.Text= roleCrud.Add(role)?
                                    "Role Ekleme Başarılı":
                                    "Role Ekleme Başarısız";
        }

        private void RoleSelectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd= new OpenFileDialog();
            ofd.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RoleImg.ImageLocation = ofd.FileName;
                string name=ofd.FileName;
                string[] fileName = name.Split('\\');
                AddRoleMessageLbl.Visible = true;
                AddRoleMessageLbl.Text = fileName[fileName.Length-1];
            }
        }
    }
}
