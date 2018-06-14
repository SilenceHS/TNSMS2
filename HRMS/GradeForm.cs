using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class GradeForm:Form
    {
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel1;
        private DataGridView GradedataGridView;
        private Button Gradesearchbutton;
        private Button Gradeaddbutton;
        private Button Gradedeletebutton;
        private Label label1;
        string PreSelect;//用于记录之前查找的条件
        string PreString;//用于记录之前查找的语句
        DataSet datasetGrid = null;
        public GradeForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gradesearchbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GradedataGridView = new System.Windows.Forms.DataGridView();
            this.Gradeaddbutton = new System.Windows.Forms.Button();
            this.Gradedeletebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GradedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gradesearchbutton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类查询";
            // 
            // Gradesearchbutton
            // 
            this.Gradesearchbutton.BackColor = System.Drawing.Color.Transparent;
            this.Gradesearchbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Gradesearchbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Gradesearchbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Gradesearchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gradesearchbutton.Image = ((System.Drawing.Image)(resources.GetObject("Gradesearchbutton.Image")));
            this.Gradesearchbutton.Location = new System.Drawing.Point(408, 9);
            this.Gradesearchbutton.Margin = new System.Windows.Forms.Padding(0);
            this.Gradesearchbutton.Name = "Gradesearchbutton";
            this.Gradesearchbutton.Size = new System.Drawing.Size(51, 51);
            this.Gradesearchbutton.TabIndex = 4;
            this.Gradesearchbutton.UseVisualStyleBackColor = false;
            this.Gradesearchbutton.Click += new System.EventHandler(this.Gradesearchbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "查询条件";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALL",
            "学号",
            "姓名",
            "学科",
            "班级"});
            this.comboBox1.Location = new System.Drawing.Point(88, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询类型";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GradedataGridView);
            this.panel1.Location = new System.Drawing.Point(25, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 270);
            this.panel1.TabIndex = 1;
            // 
            // GradedataGridView
            // 
            this.GradedataGridView.AllowUserToAddRows = false;
            this.GradedataGridView.AllowUserToDeleteRows = false;
            this.GradedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradedataGridView.Location = new System.Drawing.Point(3, 3);
            this.GradedataGridView.MultiSelect = false;
            this.GradedataGridView.Name = "GradedataGridView";
            this.GradedataGridView.ReadOnly = true;
            this.GradedataGridView.RowTemplate.Height = 23;
            this.GradedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GradedataGridView.Size = new System.Drawing.Size(522, 266);
            this.GradedataGridView.TabIndex = 0;
            this.GradedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GradedataGridView_CellContentClick);
            // 
            // Gradeaddbutton
            // 
            this.Gradeaddbutton.BackColor = System.Drawing.Color.Transparent;
            this.Gradeaddbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Gradeaddbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Gradeaddbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Gradeaddbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gradeaddbutton.Image = ((System.Drawing.Image)(resources.GetObject("Gradeaddbutton.Image")));
            this.Gradeaddbutton.Location = new System.Drawing.Point(564, 87);
            this.Gradeaddbutton.Margin = new System.Windows.Forms.Padding(0);
            this.Gradeaddbutton.Name = "Gradeaddbutton";
            this.Gradeaddbutton.Size = new System.Drawing.Size(70, 70);
            this.Gradeaddbutton.TabIndex = 2;
            this.Gradeaddbutton.UseVisualStyleBackColor = false;
            this.Gradeaddbutton.Click += new System.EventHandler(this.Gradeaddbutton_Click);
            // 
            // Gradedeletebutton
            // 
            this.Gradedeletebutton.BackColor = System.Drawing.Color.Transparent;
            this.Gradedeletebutton.Enabled = false;
            this.Gradedeletebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Gradedeletebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Gradedeletebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Gradedeletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gradedeletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Gradedeletebutton.Image")));
            this.Gradedeletebutton.Location = new System.Drawing.Point(564, 179);
            this.Gradedeletebutton.Margin = new System.Windows.Forms.Padding(0);
            this.Gradedeletebutton.Name = "Gradedeletebutton";
            this.Gradedeletebutton.Size = new System.Drawing.Size(70, 70);
            this.Gradedeletebutton.TabIndex = 3;
            this.Gradedeletebutton.UseVisualStyleBackColor = false;
            this.Gradedeletebutton.Click += new System.EventHandler(this.Gradedeletebutton_Click);
            // 
            // GradeForm
            // 
            this.ClientSize = new System.Drawing.Size(659, 367);
            this.Controls.Add(this.Gradedeletebutton);
            this.Controls.Add(this.Gradeaddbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GradedataGridView)).EndInit();
            this.ResumeLayout(false);

        }


        public void Condition_Lookup(String StrValue)//查找用，更新源
        {
            DBAccess dbAccess = new DBAccess();
            if (StrValue == "ALL")//如果选择all，就直接获得所有
            {
                datasetGrid = dbAccess.GetDataset("select * from dbo.tb_Grade", "dbo.tb_Grade");
                GradedataGridView.DataSource = datasetGrid.Tables[0];
            }
            else
            {
                datasetGrid = dbAccess.GetDataset("select * from dbo.tb_Grade where " + PreSelect + "='" + PreString + "'", "dbo.tb_Grade");
                GradedataGridView.DataSource = datasetGrid.Tables[0];
            }



        }
        private void Gradesearchbutton_Click(object sender, EventArgs e)
        {
            String StrValue = null;
            try
            {
                StrValue = comboBox1.SelectedItem.ToString();
                PreString = textBox1.Text.ToString();//保存上次的输入
                PreSelect = comboBox1.SelectedItem.ToString();//保存上次的搜索条件
            }
            catch
            {
                Gradedeletebutton.Enabled = false;
                GradedataGridView.ClearSelection();
                GradedataGridView.DataSource = null;
                MessageBox.Show("未设置查找条件！！！！！");
                Gradedeletebutton.Enabled = false;
                return;
            }
            try
            {
                Condition_Lookup(StrValue);
                Gradedeletebutton.Enabled = true;
            }
            catch
            {
                Gradeaddbutton.Enabled = false;
                Gradedeletebutton.Enabled = false;
                GradedataGridView.ClearSelection();
                GradedataGridView.DataSource = null;
                MessageBox.Show("输入不正确！");
                Gradedeletebutton.Enabled = false;
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "ALL")
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
            }

            else
                textBox1.Enabled = true;
        }

        private void Gradeaddbutton_Click(object sender, EventArgs e)
        {
            AddGrade addgrade = new AddGrade();
            addgrade.ShowDialog();
            if(PreSelect==null)
            {
                return;
            }
            Condition_Lookup(PreSelect);
            Gradedeletebutton.Enabled = false;
            GradedataGridView.ClearSelection();

        }

        private void Gradedeletebutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                SqlConnection conn = DBAccess.GetConnection();
                //显示状态信息
                if (conn.State == ConnectionState.Open)//判断当前连接的状态
                {
                    try
                    {
                        SqlCommand sqlCommand = conn.CreateCommand();
                        String SQLstr = "DELETE FROM dbo.tb_Grade where 学号='" + GradedataGridView[0, GradedataGridView.CurrentCell.RowIndex].Value.ToString() + "' and 学科='" + GradedataGridView[2, GradedataGridView.CurrentCell.RowIndex].Value.ToString() + "';";
                        sqlCommand.CommandText = SQLstr;
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        conn.Close();
                        conn.Dispose();
                        MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Gradedeletebutton.Enabled = false;
                        Condition_Lookup(PreSelect);
                        GradedataGridView.ClearSelection();
                    }
                    catch
                    {
                        MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void GradedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Gradedeletebutton.Enabled = true;
        }
    }
}
