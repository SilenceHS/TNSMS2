using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class AddClass:Form
    {
        private TextBox ClasstextBox;
        private Button button1;
        private Button button2;
        private Label label1;
        public AddClass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClass));
            this.label1 = new System.Windows.Forms.Label();
            this.ClasstextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入课程名";
            // 
            // ClasstextBox
            // 
            this.ClasstextBox.Location = new System.Drawing.Point(115, 32);
            this.ClasstextBox.Name = "ClasstextBox";
            this.ClasstextBox.Size = new System.Drawing.Size(157, 21);
            this.ClasstextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(42, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "确认";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(177, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddClass
            // 
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClasstextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ClasstextBox.Text=="")
            {
                MessageBox.Show("请输入课程名称！");
                return;
            }
            try
            {
                string sql = "insert into dbo.[dbo.tb_Course] values('" + ClasstextBox.Text + "');";
                DBAccess dba = new DBAccess();
                dba.GetSQLCommand(sql);
                MessageBox.Show("插入成功！");
                this.Close();
            }
            catch
            {
                MessageBox.Show("插入失败，请检查是否重复插入！");
            }

        }
    }
}
