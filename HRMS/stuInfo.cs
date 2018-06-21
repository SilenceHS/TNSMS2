using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class stuInfo:Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label name;
        private Label ID;
        private Label sex;
        private Label position;
        private Label phone;
        private Label Class;
        private Label Email;
        private Label remark;
        private Button button2;
        private PictureBox pictureBox1;
        public stuInfo(User user)
        {
            InitializeComponent();
            DBAccess dbAccess = new DBAccess();
            DataSet datasetGrid=dbAccess.GetDataset("select * from dbo.tb_Student where 学号='"+user.getid()+"'", "dbo.tb_Student");
            DataRow mDr = datasetGrid.Tables[0].Rows[0];
            DataColumn mDc1 = datasetGrid.Tables[0].Columns[0];
            DataColumn mDc2 = datasetGrid.Tables[0].Columns[1];
            DataColumn mDc3 = datasetGrid.Tables[0].Columns[2];
            DataColumn mDc4 = datasetGrid.Tables[0].Columns[3];
            DataColumn mDc5 = datasetGrid.Tables[0].Columns[4];
            DataColumn mDc6 = datasetGrid.Tables[0].Columns[5];
            DataColumn mDc7 = datasetGrid.Tables[0].Columns[6];
            DataColumn mDc8 = datasetGrid.Tables[0].Columns[7];
            DataColumn mDc9 = datasetGrid.Tables[0].Columns[8];
            name.Text = mDr[mDc2].ToString();
            ID.Text = mDr[mDc1].ToString();
            sex.Text = mDr[mDc3].ToString();
            position.Text= mDr[mDc4].ToString();
            phone.Text= mDr[mDc5].ToString();
            Class.Text= mDr[mDc6].ToString();
            Email.Text=mDr[mDc7].ToString();
            remark .Text= mDr[mDc8].ToString();
          
            try
            {
                byte[] imgBytesIn = (byte[])mDr[mDc9];
                MemoryStream ms = new MemoryStream(imgBytesIn);  //将字节数组存入到二进制流中
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch (Exception exp)
            {
                pictureBox1.Image = null;//当出现错误时，将Image控件清空
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stuInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.remark = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "职位：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "班级：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "备注：";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(47, 205);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 12);
            this.name.TabIndex = 9;
            this.name.Text = "label9";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(47, 237);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(47, 12);
            this.ID.TabIndex = 10;
            this.ID.Text = "label10";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(261, 21);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(47, 12);
            this.sex.TabIndex = 11;
            this.sex.Text = "label11";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(261, 55);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(47, 12);
            this.position.TabIndex = 12;
            this.position.Text = "label12";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(261, 89);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(47, 12);
            this.phone.TabIndex = 13;
            this.phone.Text = "label13";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(261, 123);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(47, 12);
            this.Class.TabIndex = 14;
            this.Class.Text = "label14";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(261, 157);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 12);
            this.Email.TabIndex = 15;
            this.Email.Text = "label15";
            // 
            // remark
            // 
            this.remark.AutoSize = true;
            this.remark.Location = new System.Drawing.Point(261, 191);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(47, 12);
            this.remark.TabIndex = 16;
            this.remark.Text = "label16";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(319, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "返回";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stuInfo
            // 
            this.ClientSize = new System.Drawing.Size(399, 290);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.position);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "stuInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
