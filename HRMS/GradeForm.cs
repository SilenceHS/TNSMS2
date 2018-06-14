using System;
using System.Collections.Generic;
using System.Data;
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
            this.groupBox1.Size = new System.Drawing.Size(490, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类查询";
            // 
            // Gradesearchbutton
            // 
            this.Gradesearchbutton.Location = new System.Drawing.Point(405, 23);
            this.Gradesearchbutton.Name = "Gradesearchbutton";
            this.Gradesearchbutton.Size = new System.Drawing.Size(61, 19);
            this.Gradesearchbutton.TabIndex = 4;
            this.Gradesearchbutton.Text = "button1";
            this.Gradesearchbutton.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(486, 270);
            this.panel1.TabIndex = 1;
            // 
            // GradedataGridView
            // 
            this.GradedataGridView.AllowUserToOrderColumns = true;
            this.GradedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradedataGridView.Location = new System.Drawing.Point(5, 6);
            this.GradedataGridView.Name = "GradedataGridView";
            this.GradedataGridView.RowTemplate.Height = 23;
            this.GradedataGridView.Size = new System.Drawing.Size(481, 263);
            this.GradedataGridView.TabIndex = 0;
            // 
            // Gradeaddbutton
            // 
            this.Gradeaddbutton.Location = new System.Drawing.Point(534, 112);
            this.Gradeaddbutton.Name = "Gradeaddbutton";
            this.Gradeaddbutton.Size = new System.Drawing.Size(56, 65);
            this.Gradeaddbutton.TabIndex = 2;
            this.Gradeaddbutton.Text = "button2";
            this.Gradeaddbutton.UseVisualStyleBackColor = true;
            // 
            // Gradedeletebutton
            // 
            this.Gradedeletebutton.Location = new System.Drawing.Point(537, 220);
            this.Gradedeletebutton.Name = "Gradedeletebutton";
            this.Gradedeletebutton.Size = new System.Drawing.Size(52, 77);
            this.Gradedeletebutton.TabIndex = 3;
            this.Gradedeletebutton.Text = "button3";
            this.Gradedeletebutton.UseVisualStyleBackColor = true;
            // 
            // GradeForm
            // 
            this.ClientSize = new System.Drawing.Size(607, 356);
            this.Controls.Add(this.Gradedeletebutton);
            this.Controls.Add(this.Gradeaddbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GradeForm";
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
                return;
            }
            try
            {
                Condition_Lookup(StrValue);
                //Grid_Info(dataGridView1);
            }
            catch
            {
                Gradeaddbutton.Enabled = false;
                Gradedeletebutton.Enabled = false;
                GradedataGridView.ClearSelection();
                GradedataGridView.DataSource = null;
                MessageBox.Show("输入不正确！");
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
    }
}
