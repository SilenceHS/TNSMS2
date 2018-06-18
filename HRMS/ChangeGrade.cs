using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class ChangeGrade:AddGrade
    {
        public ChangeGrade(DataGridView DGrid)
        {
            idtextBox.ReadOnly = true;
            CoursecomboBox.Enabled = false;
            idtextBox.Text = DGrid[0, DGrid.CurrentCell.RowIndex].Value.ToString();
            CoursecomboBox.Text= DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
            GradetextBox.Text= DGrid[3, DGrid.CurrentCell.RowIndex].Value.ToString();
        }
        public override void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Exception ee=new Exception();
                float grade = float.Parse(GradetextBox.Text);
                if (grade < 0 || grade > 100)
                {
                    throw ee;
                }
            }
            catch
            {
                MessageBox.Show("请输入0-100的有效数字！");
                return;
            }
            
            try
            {
                string sql = "update dbo.tb_Grade set 成绩 = " + GradetextBox.Text + " where 学号 = " + idtextBox.Text + " and 学科 = '" + CoursecomboBox.Text + "'";
                DBAccess dba = new DBAccess();
                dba.GetSQLCommand(sql);
                MessageBox.Show("修改成功！");
                this.Close();
            }
            catch
            {
                MessageBox.Show("修改失败！");
            }
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ChangeGrade
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ChangeGrade";
            this.Text = "修改成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

}
