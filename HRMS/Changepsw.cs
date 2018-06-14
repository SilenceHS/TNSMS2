using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public class Changepsw:Form
    {
        User user = new User();
        private TextBox newpswtextBox;
        private TextBox newpsw2textBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox oldpswtextBox;
        public Changepsw(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        bool access()
        {
            try
            {
                DBAccess dba = new DBAccess();
                SqlConnection conn = dba.Getconnection();
                if (conn.State == ConnectionState.Open)//判断当前连接的状态
                {
                    //显示状态信息
                    SqlCommand sqlCommand = conn.CreateCommand();
                    //String SQLstr = "select * from dbo.tb_Login where Name='16211160112' and Password='16211160112'";
                    String SQLstr = "select ID ,Name, Position from dbo.tb_Login where ID='" + user.getid() + "' and Password='" + oldpswtextBox.Text + "';";
                    sqlCommand.CommandText = SQLstr;
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    bool bReader = dataReader.Read();
                    conn.Close();
                    conn.Dispose();
                    if (bReader)
                        return true;
                    else
                        return false;
                }
            }
            catch
            {
                MessageBox.Show("连接数据库失败");//出现异常弹出提示
                Application.Exit();
            }
            return false;
        }
        void change()
        {
            try
            {

                SqlConnection conn = DBAccess.GetConnection();
                if (conn.State == ConnectionState.Open)//判断当前连接的状态
                {
                    //显示状态信息
                    SqlCommand sqlCommand = conn.CreateCommand();
                    String SQLstr = " UPDATE dbo.tb_Login SET Password = '"+ newpswtextBox.Text+ "' WHERE ID = '" + user.getid() + "';";
                    sqlCommand.CommandText = SQLstr;
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    MessageBox.Show("修改成功！");
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("连接数据库失败");//出现异常弹出提示
                Application.Exit();
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changepsw));
            this.oldpswtextBox = new System.Windows.Forms.TextBox();
            this.newpswtextBox = new System.Windows.Forms.TextBox();
            this.newpsw2textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldpswtextBox
            // 
            this.oldpswtextBox.Location = new System.Drawing.Point(112, 30);
            this.oldpswtextBox.Name = "oldpswtextBox";
            this.oldpswtextBox.PasswordChar = '*';
            this.oldpswtextBox.Size = new System.Drawing.Size(115, 21);
            this.oldpswtextBox.TabIndex = 0;
            // 
            // newpswtextBox
            // 
            this.newpswtextBox.Location = new System.Drawing.Point(113, 84);
            this.newpswtextBox.Name = "newpswtextBox";
            this.newpswtextBox.PasswordChar = '*';
            this.newpswtextBox.Size = new System.Drawing.Size(114, 21);
            this.newpswtextBox.TabIndex = 1;
            // 
            // newpsw2textBox
            // 
            this.newpsw2textBox.Location = new System.Drawing.Point(112, 138);
            this.newpsw2textBox.Name = "newpsw2textBox";
            this.newpsw2textBox.PasswordChar = '*';
            this.newpsw2textBox.Size = new System.Drawing.Size(114, 21);
            this.newpsw2textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "请再次输入";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(40, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(185, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Changepsw
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newpsw2textBox);
            this.Controls.Add(this.newpswtextBox);
            this.Controls.Add(this.oldpswtextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Changepsw";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(access())
            {
                if (newpswtextBox.Text != newpsw2textBox.Text)
                    MessageBox.Show("两次密码不一致！");
                else
                {
                    change();
                    this.Close();
                }
                    
            }
            else
            {
                MessageBox.Show("原密码不正确！");
            }
        }
    }
}
