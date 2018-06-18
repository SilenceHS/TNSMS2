using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class ClassForm:Form
    {
        DataSet datasetGrid = null;
        private DataGridView dataGridView1;
        private Button AddClassbutton;
        private Button DeleteClassbutton;
        private FlowLayoutPanel flowLayoutPanel1;
        public void Condition_Lookup()//更新源
        {
            DBAccess dbAccess = new DBAccess();
            datasetGrid = dbAccess.GetDataset("select * from dbo.[dbo.tb_Course]", "dbo.[dbo.tb_Course]");
            dataGridView1.DataSource = datasetGrid.Tables[0];
        }
        public ClassForm()
        {
            InitializeComponent();
            Condition_Lookup();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteClassbutton = new System.Windows.Forms.Button();
            this.AddClassbutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(120, 227);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(113, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // DeleteClassbutton
            // 
            this.DeleteClassbutton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteClassbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteClassbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteClassbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteClassbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteClassbutton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteClassbutton.Image")));
            this.DeleteClassbutton.Location = new System.Drawing.Point(156, 160);
            this.DeleteClassbutton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteClassbutton.Name = "DeleteClassbutton";
            this.DeleteClassbutton.Size = new System.Drawing.Size(70, 70);
            this.DeleteClassbutton.TabIndex = 2;
            this.DeleteClassbutton.UseVisualStyleBackColor = false;
            this.DeleteClassbutton.Click += new System.EventHandler(this.DeleteClassbutton_Click);
            // 
            // AddClassbutton
            // 
            this.AddClassbutton.BackColor = System.Drawing.Color.Transparent;
            this.AddClassbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddClassbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddClassbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddClassbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClassbutton.Image = ((System.Drawing.Image)(resources.GetObject("AddClassbutton.Image")));
            this.AddClassbutton.Location = new System.Drawing.Point(156, 34);
            this.AddClassbutton.Margin = new System.Windows.Forms.Padding(0);
            this.AddClassbutton.Name = "AddClassbutton";
            this.AddClassbutton.Size = new System.Drawing.Size(70, 70);
            this.AddClassbutton.TabIndex = 1;
            this.AddClassbutton.UseVisualStyleBackColor = false;
            this.AddClassbutton.Click += new System.EventHandler(this.AddClassbutton_Click);
            // 
            // ClassForm
            // 
            this.ClientSize = new System.Drawing.Size(258, 266);
            this.Controls.Add(this.DeleteClassbutton);
            this.Controls.Add(this.AddClassbutton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void AddClassbutton_Click(object sender, EventArgs e)
        {
            AddClass ac = new AddClass();
            ac.ShowDialog();
            Condition_Lookup();
        }

        private void DeleteClassbutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除课程吗？相应的学生成绩也会同时删除", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    string sql = "delete from dbo.tb_Grade where 学科 = '" + dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString() + "'; delete from dbo.[dbo.tb_Course] where 学科 = '" + dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString() + "';";
                    DBAccess dba = new DBAccess();
                    dba.GetSQLCommand(sql);
                    MessageBox.Show("删除成功！");
                }
                catch
                {
                    MessageBox.Show("删除失败");//出现异常弹出提示
                    Application.Exit();
                }
            }
            Condition_Lookup();
        }
    }
}
