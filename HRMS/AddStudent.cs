using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class AddStudent:Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public TextBox IDtextBox;
        public TextBox NametextBox;
        public TextBox PositiontextBox;
        public TextBox PhonetextBox;
        public TextBox AddresstextBox;
        public TextBox EmailtextBox;
        public TextBox textBox;
        public Button ybutton;
        public ComboBox SexcomboBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button nbutton;

        public AddStudent()
        {
            InitializeComponent();
            SexcomboBox.SelectedIndex= SexcomboBox.Items.IndexOf("男");
        }
        private bool exist()
        {
            try
            {
                SqlConnection conn = DBAccess.GetConnection();
                if (conn.State == ConnectionState.Open)//判断当前连接的状态
                {
                    //显示状态信息
                    SqlCommand sqlCommand = conn.CreateCommand();
                    String SQLstr = "select ID from dbo.tb_Login where ID='" + IDtextBox.Text + "' or Name='" + NametextBox.Text + "';";
                    sqlCommand.CommandText = SQLstr;
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    bool bReader = dataReader.Read();
                    conn.Close();
                    conn.Dispose();
                    if (bReader)
                        return false;
                    else
                        return true;
                }
            }
            catch
            {
                MessageBox.Show("连接数据库失败");//出现异常弹出提示
                Application.Exit();
            }
            return false;
        }
    
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PositiontextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SexcomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nbutton = new System.Windows.Forms.Button();
            this.ybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "职位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "电话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "班级";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "备注";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(75, 16);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(100, 21);
            this.IDtextBox.TabIndex = 8;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(269, 16);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 21);
            this.NametextBox.TabIndex = 9;
            // 
            // PositiontextBox
            // 
            this.PositiontextBox.Location = new System.Drawing.Point(269, 62);
            this.PositiontextBox.Name = "PositiontextBox";
            this.PositiontextBox.Size = new System.Drawing.Size(100, 21);
            this.PositiontextBox.TabIndex = 11;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(75, 109);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(100, 21);
            this.PhonetextBox.TabIndex = 12;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(269, 109);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(100, 21);
            this.AddresstextBox.TabIndex = 13;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(75, 163);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(100, 21);
            this.EmailtextBox.TabIndex = 14;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(269, 163);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 21);
            this.textBox.TabIndex = 15;
            // 
            // SexcomboBox
            // 
            this.SexcomboBox.FormattingEnabled = true;
            this.SexcomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.SexcomboBox.Location = new System.Drawing.Point(75, 62);
            this.SexcomboBox.Name = "SexcomboBox";
            this.SexcomboBox.Size = new System.Drawing.Size(100, 20);
            this.SexcomboBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(26, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(25, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(221, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(36, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "带*号是必填项";
            // 
            // nbutton
            // 
            this.nbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nbutton.Image = ((System.Drawing.Image)(resources.GetObject("nbutton.Image")));
            this.nbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nbutton.Location = new System.Drawing.Point(269, 245);
            this.nbutton.Name = "nbutton";
            this.nbutton.Size = new System.Drawing.Size(66, 33);
            this.nbutton.TabIndex = 17;
            this.nbutton.Text = "取消";
            this.nbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nbutton.UseVisualStyleBackColor = true;
            this.nbutton.Click += new System.EventHandler(this.nbutton_Click);
            // 
            // ybutton
            // 
            this.ybutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ybutton.Image = ((System.Drawing.Image)(resources.GetObject("ybutton.Image")));
            this.ybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ybutton.Location = new System.Drawing.Point(85, 245);
            this.ybutton.Name = "ybutton";
            this.ybutton.Size = new System.Drawing.Size(66, 33);
            this.ybutton.TabIndex = 16;
            this.ybutton.Text = "确定";
            this.ybutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ybutton.UseVisualStyleBackColor = true;
            this.ybutton.Click += new System.EventHandler(this.ybutton_Click);
            // 
            // AddStudent
            // 
            this.ClientSize = new System.Drawing.Size(411, 310);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SexcomboBox);
            this.Controls.Add(this.nbutton);
            this.Controls.Add(this.ybutton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.PhonetextBox);
            this.Controls.Add(this.PositiontextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void ybutton_Click(object sender, EventArgs e)
        {
            if(IDtextBox.Text!=string.Empty&& NametextBox.Text!=string.Empty&& EmailtextBox.Text!=string.Empty)
            {
                if (exist())
                {
                    try
                    {

                        SqlConnection conn = DBAccess.GetConnection();
                        if (conn.State == ConnectionState.Open)//判断当前连接的状态
                        {
                            //显示状态信息
                            SqlCommand sqlCommand = conn.CreateCommand();
                            String SQLstr = "INSERT INTO dbo.tb_Login values ('" + IDtextBox.Text + "','" +
                                NametextBox.Text + "','123456','Student','" + EmailtextBox.Text +
                                "');INSERT INTO dbo.tb_Student values('" + IDtextBox.Text + "','" +
                                NametextBox.Text + "','" + SexcomboBox.Text + "','" +
                                PositiontextBox.Text + "','" + PhonetextBox.Text + "','" + AddresstextBox.Text +
                                "','" + EmailtextBox.Text + "','" + textBox.Text + "',NULL);";
                            sqlCommand.CommandText = SQLstr;
                            SqlDataReader dataReader = sqlCommand.ExecuteReader();
                            MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            conn.Dispose();
                            this.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("添加失败！");//出现异常弹出提示
                    }
                }
                else
                {
                    MessageBox.Show("已存在,请不要重复添加！");
                }
            }
         else
            {
                MessageBox.Show("请填写带*选项");
            }
        }
    }
}
