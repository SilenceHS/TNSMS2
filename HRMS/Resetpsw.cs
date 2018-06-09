using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public class Resetpsw : Form
    {
        private Label label1;
        private TextBox reidtextBox;
        private TextBox reemtextBox;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox renametextBox;
        private Button button2;
        private void resetpsw()
        {
            try
            {

                SqlConnection conn = DBAccess.GetConnection();
                if (conn.State == ConnectionState.Open)//判断当前连接的状态
                {
                    //显示状态信息
                    SqlCommand sqlCommand = conn.CreateCommand();    
                    String SQLstr = " UPDATE dbo.tb_Login SET Password = '123456' WHERE ID = '" + reidtextBox.Text + "';";
                    sqlCommand.CommandText = SQLstr;
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                }
            }
            catch
            {
                MessageBox.Show("连接数据库失败");//出现异常弹出提示
                Application.Exit();
            }
        }
        public Resetpsw()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resetpsw));
            this.label1 = new System.Windows.Forms.Label();
            this.reidtextBox = new System.Windows.Forms.TextBox();
            this.reemtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.renametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入ID/学号";
            // 
            // reidtextBox
            // 
            this.reidtextBox.Location = new System.Drawing.Point(108, 32);
            this.reidtextBox.Name = "reidtextBox";
            this.reidtextBox.Size = new System.Drawing.Size(133, 21);
            this.reidtextBox.TabIndex = 1;
            // 
            // reemtextBox
            // 
            this.reemtextBox.Location = new System.Drawing.Point(108, 143);
            this.reemtextBox.Name = "reemtextBox";
            this.reemtextBox.Size = new System.Drawing.Size(133, 21);
            this.reemtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入邮箱";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(36, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(179, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "请输入姓名";
            // 
            // renametextBox
            // 
            this.renametextBox.Location = new System.Drawing.Point(108, 86);
            this.renametextBox.Name = "renametextBox";
            this.renametextBox.Size = new System.Drawing.Size(133, 21);
            this.renametextBox.TabIndex = 7;
            // 
            // Resetpsw
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.renametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reemtextBox);
            this.Controls.Add(this.reidtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Resetpsw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重置密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection conn = DBAccess.GetConnection();
                if (conn.State == ConnectionState.Open)//判断当前连接的状态
                {
                    //显示状态信息
                    SqlCommand sqlCommand = conn.CreateCommand();
                    String SQLstr = "select ID from dbo.tb_Login where Name='" + renametextBox.Text + "' and Email='" + reemtextBox.Text + "' and ID='"+reidtextBox.Text+"';";
                    sqlCommand.CommandText = SQLstr;
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    bool bReader = dataReader.Read();
                    if (bReader)
                    {
                        string Id = dataReader.GetString(0).ToString();
                        MessageBox.Show("重置成功！\n当前密码改为：123456\n请及时更改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //user.SetUser(Id, Name, Position);
                        conn.Close();
                        conn.Dispose();
                        resetpsw();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户验证失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("连接数据库失败");//出现异常弹出提示
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
