﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class AddGrade:Form
    {
        public TextBox idtextBox;
        private Label label2;
        public ComboBox CoursecomboBox;
        private Label label3;
        public TextBox GradetextBox;
        public Button button1;
        public Button button2;
        private Label label1;

        public AddGrade()
        {
            InitializeComponent();
            string sql = "select * from dbo.[dbo.tb_Course]";
            DBAccess dbaccess = new DBAccess();
            CoursecomboBox.DataSource = dbaccess.GetDataset(sql, "dbo.[dbo.tb_Course]").Tables[0];
           CoursecomboBox.DisplayMember = "学科";
            CoursecomboBox.ValueMember = "学科";
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGrade));
            this.label1 = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CoursecomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GradetextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(94, 33);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(121, 21);
            this.idtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "学科";
            // 
            // CoursecomboBox
            // 
            this.CoursecomboBox.FormattingEnabled = true;
            this.CoursecomboBox.Location = new System.Drawing.Point(94, 91);
            this.CoursecomboBox.Name = "CoursecomboBox";
            this.CoursecomboBox.Size = new System.Drawing.Size(121, 20);
            this.CoursecomboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "成绩";
            // 
            // GradetextBox
            // 
            this.GradetextBox.Location = new System.Drawing.Point(94, 151);
            this.GradetextBox.Name = "GradetextBox";
            this.GradetextBox.Size = new System.Drawing.Size(121, 21);
            this.GradetextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(43, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "确认";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(184, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddGrade
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GradetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoursecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public virtual void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Exception ee = new Exception();
                float grade = float.Parse(GradetextBox.Text);
                if(grade<0||grade>100)
                {
                    throw ee;
                }
            }
            catch
            {
                MessageBox.Show("请输入0-100的有效数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBAccess dbaccess = new DBAccess();
            string sql = "select 姓名,班级 from dbo.tb_Student where 学号='"+ idtextBox.Text+ "';";
            try
            {
                DataSet datasetGrid = new DataSet();
                datasetGrid=dbaccess.GetDataset(sql, "dbo.tb_Student");
                if (datasetGrid.Tables.Count == 1 && datasetGrid.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("学号不存在！");
                    return;
                }
                DataRow mDr = datasetGrid.Tables[0].Rows[0];
                DataColumn mDc1 = datasetGrid.Tables[0].Columns[0];
                DataColumn mDc2 = datasetGrid.Tables[0].Columns[1];
                string Name = mDr[mDc1].ToString();
                string Class = mDr[mDc2].ToString();
                sql = "insert into dbo.tb_Grade values('" + idtextBox.Text + "','"+Name+"','"+ CoursecomboBox.Text+"',"+ GradetextBox.Text+",'"+Class+"');";
                dbaccess.GetSQLCommand(sql);
                MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("添加失败！请勿重复添加", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
