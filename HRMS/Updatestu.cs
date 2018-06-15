using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    class Updatestu:AddStudent
    {
        public Updatestu(DataGridView DGrid)
        {
            IDtextBox.ReadOnly = true;
            IDtextBox.Text = DGrid[0, DGrid.CurrentCell.RowIndex].Value.ToString();
            NametextBox.Text = DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();
            SexcomboBox.Text = DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
            PositiontextBox.Text = DGrid[3, DGrid.CurrentCell.RowIndex].Value.ToString();
            PhonetextBox.Text = DGrid[4, DGrid.CurrentCell.RowIndex].Value.ToString();
            AddresstextBox.Text = DGrid[5, DGrid.CurrentCell.RowIndex].Value.ToString();
            EmailtextBox.Text = DGrid[6, DGrid.CurrentCell.RowIndex].Value.ToString();
            textBox.Text = DGrid[7, DGrid.CurrentCell.RowIndex].Value.ToString();
        }
        private void updt()
        {
            try
            {
                DBAccess dba = new DBAccess();
                SqlConnection conn = dba.Getconnection();
                if (conn.State == ConnectionState.Open)//判断当前连接的状态
                {
                    //显示状态信息
                    SqlCommand sqlCommand = conn.CreateCommand();
                    String SQLstr = " update dbo.tb_Student set 姓名='-1' where 学号='" +
                        IDtextBox.Text + "';update dbo.tb_Login set Name='" + NametextBox.Text +
                        "' where ID='" + IDtextBox.Text + "';update dbo.tb_Student set 学号='" + IDtextBox.Text + "',姓名='" +
                                NametextBox.Text + "',性别='" + SexcomboBox.Text + "',职位='" +
                                PositiontextBox.Text + "',电话='" + PhonetextBox.Text + "',班级='" + AddresstextBox.Text +
                                "',Email='" + EmailtextBox.Text + "',备注='" + textBox.Text + "' where 学号='" + IDtextBox.Text + "';";
                    sqlCommand.CommandText = SQLstr;
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    bool bReader = dataReader.Read();
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
        private bool access()
        {
            try
            {
                DBAccess dba = new DBAccess();
                SqlConnection conn = dba.Getconnection();
                if (conn.State == ConnectionState.Open)//判断当前连接的状态
                {
                    //显示状态信息
                    SqlCommand sqlCommand = conn.CreateCommand();
                    String SQLstr = " select 学号 from dbo.tb_Student where 学号 != '"+ IDtextBox.Text+ "' and(姓名 = '"+ NametextBox.Text+ "' or Email = '"+ EmailtextBox.Text+ "');";
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
        public override void ybutton_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text != string.Empty && NametextBox.Text != string.Empty && EmailtextBox.Text != string.Empty)
            {
                if(access())
                {
                    updt();
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("信息有重复！请检查");
                }
            }
            else
            {
                MessageBox.Show("请填写带*选项");
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Updatestu
            // 
            this.ClientSize = new System.Drawing.Size(411, 310);
            this.Name = "Updatestu";
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
