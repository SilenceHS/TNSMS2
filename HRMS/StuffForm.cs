using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class StuffForm : Form
    {
        DataSet datasetGrid = null;
        int nID;
        string PreSelect;//用于记录之前查找的条件
        string PreString;//用于记录之前查找的语句
        int PreGridSelect=0;//用于记录之前选中的行数
        public void ClearTextBoxes()//清除显示
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            sexTextBox.Text = "";
            phoneTextBox.Text = "";
            positionTextBox.Text = "";
            addressTextBox.Text = "";
            emailTextBox.Text = "";
            remarkTextBox.Text = "";
            currentTextBox.Text = "";
            photoPictureBox.Image = null;
            picSelectButton.Enabled = false;
            picDeleteButton.Enabled = false;
            setadcbuttonfalse();
        }
        public void setadcbuttonfalse()//将删改按钮变成不可用
        {
           // stuaddbutton.BackgroundImage = null;
           // stuaddbutton.Enabled = false;
            deletestubutton.BackgroundImage = null;
            deletestubutton.Enabled = false;
            changestubutton.BackgroundImage = null;
            changestubutton.Enabled = false;
            repswbutton.BackgroundImage = null;
            repswbutton.Enabled = false;
        }
        public void setadcbuttontrue()//将删改按钮变成可用
        {
            //stuaddbutton.BackgroundImage = Image.FromFile("add.png");
            deletestubutton.BackgroundImage = Image.FromFile("delete.png");
            changestubutton.BackgroundImage = Image.FromFile("change.png");
            repswbutton.BackgroundImage = Image.FromFile("repsw.png");
            //stuaddbutton.Enabled = true;
            deletestubutton.Enabled = true;
            changestubutton.Enabled = true;
            repswbutton.Enabled = true;
        }
        public void Renewgridpic(DataGridView DGrid)//更新grid里的图片
        {
            byte[] pic;
            try
            {
                pic = (byte[])DGrid[8, DGrid.CurrentCell.RowIndex].Value;
                MemoryStream ms = new MemoryStream(pic);  //将字节数组存入到二进制流中
                photoPictureBox.Image = Image.FromStream(ms); 
            }
            catch (Exception exp)
            {
                photoPictureBox.Image = null;//当出现错误时，将Image控件清空
            }
        }
        public String Grid_Info(DataGridView DGrid)//更新下方显示用
        {
            try
            {
                currentTextBox.Text = DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();
                if (DGrid.RowCount > 0)
                {
                    idTextBox.Text = DGrid[0, DGrid.CurrentCell.RowIndex].Value.ToString();
                    nameTextBox.Text = DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();
                    sexTextBox.Text = DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
                    phoneTextBox.Text = DGrid[4, DGrid.CurrentCell.RowIndex].Value.ToString();
                    positionTextBox.Text = DGrid[3, DGrid.CurrentCell.RowIndex].Value.ToString();
                    addressTextBox.Text = DGrid[5, DGrid.CurrentCell.RowIndex].Value.ToString();
                    emailTextBox.Text = DGrid[6, DGrid.CurrentCell.RowIndex].Value.ToString(); 
                    Renewgridpic(DGrid);
                    remarkTextBox.Text = DGrid[7, DGrid.CurrentCell.RowIndex].Value.ToString();
                    //nID = Convert.ToInt32(idTextBox.Text); //获取当前职位编号
                    picSelectButton.Enabled = true;
                    picDeleteButton.Enabled = true;
                    setadcbuttontrue();
                    return DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();//返回当前职工的姓名
                }
                else
                {
                    //使用MyMeans公共类中的Clear_ Control()方法清空指定控件集中的相应控件
                    ClearTextBoxes();
                    nID = 0;
                    picSelectButton.Enabled = false;
                    picDeleteButton.Enabled = false;
                    setadcbuttonfalse();
                    return "";
                }
            }
            catch
            {
                ClearTextBoxes();
                picSelectButton.Enabled = false;
                picDeleteButton.Enabled = false;
                setadcbuttonfalse();
                MessageBox.Show("找不到信息");
            }
            return "";
        }


        public StuffForm()
        {
            InitializeComponent();
            /* stuaddbutton.Enabled = false;
             deletestubutton.Enabled = false;
             changestubutton.Enabled = false;*/
            stuaddbutton.BackgroundImage = Image.FromFile("add.png");
            searchButton.BackgroundImage = Image.FromFile("search.png");
        }
        public void Condition_Lookup(String StrValue)//查找用，更新源
        {
            DBAccess dbAccess = new DBAccess();
            if(StrValue=="ALL")//如果选择all，就直接获得所有
            {
                datasetGrid = dbAccess.GetDataset("select * from dbo.tb_Student", "dbo.tb_Student");
                //datasetGrid = dbAccess.GetDataset("select 学号,姓名,性别,职位,电话,地址,Email,备注,照片 from dbo.tb_Student", "dbo.tb_Student");
                dataGridView1.DataSource = datasetGrid.Tables[0];
                //currentTextBox.Text = Grid_Info(dataGridView1);
                //valueTextBox.Text = "";
                /*dataGridView1.ClearSelection();
                dataGridView1.Rows[PreGridSelect].Selected = true;
                Renewgridpic(dataGridView1);*/
            }
            else
            {
                datasetGrid = dbAccess.GetDataset("select * from dbo.tb_Student where " + PreSelect + "='" + PreString + "'", "dbo.tb_Student");
                //datasetGrid = dbAccess.GetDataset("select 学号,姓名,性别,职位,电话,地址,Email,备注,照片 from dbo.tb_Student where " + PreSelect + "='" + PreString + "'", "dbo.tb_Student");
                dataGridView1.DataSource = datasetGrid.Tables[0];
              /*currentTextBox.Text = Grid_Info(dataGridView1);
                valueTextBox.Text = "";
                dataGridView1.ClearSelection();
                dataGridView1.Rows[PreGridSelect].Selected = true;
                Renewgridpic(dataGridView1);*/
            }
            


        }
        private void searchButton_Click(object sender, EventArgs e)//点击搜索按钮
        {
            String StrValue = null;
            try
            {
                StrValue = fieldComboBox.SelectedItem.ToString();
                PreString = valueTextBox.Text.ToString();//保存上次的输入
                PreSelect = fieldComboBox.SelectedItem.ToString();//保存上次的搜索条件
            }
          catch
            {
                ClearTextBoxes();
                dataGridView1.ClearSelection();
                dataGridView1.DataSource = null;
                MessageBox.Show("未设置查找条件！！！！！");
                return;
            }
            try
            {
                Condition_Lookup(StrValue);
                Grid_Info(dataGridView1);
            }
            catch
            {
                ClearTextBoxes();
                dataGridView1.ClearSelection();
                dataGridView1.DataSource = null;
                MessageBox.Show("ID输入不正确！");
                return;
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid_Info(dataGridView1);//当点击了Grid里面的条目，使用该函数更新下方信息显示
            PreGridSelect = dataGridView1.CurrentCell.RowIndex;
            picSelectButton.Enabled = true;
            picDeleteButton.Enabled = true;
            setadcbuttontrue();
        }
        
        private void picSelectButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
            string file = null;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
                byte[] imgBytesIn = SaveImage(file);
                Modules m = new Modules();
                m.SaveImage(dataGridView1[0, PreGridSelect].Value.ToString(), imgBytesIn);
                /*********/
                /*
                DBAccess dbAccess = new DBAccess();
                datasetGrid = dbAccess.GetDataset("select * from dbo.tb_StuffBasic", "dbo.tb_StuffBasic");
                dataGridView1.DataSource = datasetGrid.Tables[0];
                */
                Condition_Lookup(PreSelect);//更新数据源
                /*dataGridView1.ClearSelection();//清空选中
                dataGridView1.Rows[PreGridSelect].Selected = true;//重新选中*/
                ClearTextBoxes();
                //Renewgridpic(dataGridView1);
                dataGridView1.ClearSelection();
                ShowImgByByte(imgBytesIn);
                MessageBox.Show("修改图片成功！");
            }
        }

        public byte[] SaveImage(String path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read); //将图片以文件流的形式进行保存
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);  //将流读入到字节数组中
            return imgBytesIn;
        }

        public void ShowImgByByte(byte[] imgBytesIn)//将图片展示在右侧
        {
            MemoryStream ms = new MemoryStream(imgBytesIn);
            photoPictureBox.Image = Image.FromStream(ms);

        }

        private void fieldComboBox_SelectedIndexChanged(object sender, EventArgs e)//当选择ALL选项时，输入框不可输入
        {
            if(fieldComboBox.SelectedItem.ToString()=="ALL")
            {
                valueTextBox.Text = "";
                valueTextBox.Enabled = false;
            }
                
            else
                valueTextBox.Enabled = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClearTextBoxes();
            dataGridView1.ClearSelection();
        }

        private void picDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Modules m = new Modules();
                m.DeleteImage(dataGridView1[0, PreGridSelect].Value.ToString());
                Condition_Lookup(PreSelect);
                ClearTextBoxes();
                dataGridView1.ClearSelection();
                MessageBox.Show("删除成功");
            }
        }

        private void stuaddbutton_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.ShowDialog();
        }

        private void stuaddbutton_MouseEnter(object sender, EventArgs e)
        {
            stuaddbutton.BackgroundImage = Image.FromFile("add2.png");
        }

        private void stuaddbutton_MouseLeave(object sender, EventArgs e)
        {
            stuaddbutton.BackgroundImage = Image.FromFile("add.png");
        }

        private void deletestubutton_Click(object sender, EventArgs e)
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
                        String SQLstr = "DELETE FROM dbo.tb_Student where 学号='" + dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString() + "';" + "DELETE FROM dbo.tb_Login where ID='" + dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString() + "';";
                        sqlCommand.CommandText = SQLstr;
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        conn.Close();
                        conn.Dispose();
                        MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Condition_Lookup(PreSelect);
                        ClearTextBoxes();
                        dataGridView1.ClearSelection();
                    }
                    catch
                    {
                        MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void deletestubutton_MouseEnter(object sender, EventArgs e)
        {
            deletestubutton.BackgroundImage = Image.FromFile("delete2.png");
        }

        private void deletestubutton_MouseLeave(object sender, EventArgs e)
        {
            deletestubutton.BackgroundImage = Image.FromFile("delete.png");
        }

        private void changestubutton_Click(object sender, EventArgs e)
        {
            Updatestu update = new Updatestu(dataGridView1);
            update.ShowDialog();
            Condition_Lookup(PreSelect);
            ClearTextBoxes();
            dataGridView1.ClearSelection();
        }

        private void changestubutton_MouseEnter(object sender, EventArgs e)
        {
            changestubutton.BackgroundImage = Image.FromFile("change2.png");
        }

        private void changestubutton_MouseLeave(object sender, EventArgs e)
        {
            changestubutton.BackgroundImage = Image.FromFile("change.png");
        }

        private void searchButton_MouseEnter(object sender, EventArgs e)
        {
            searchButton.BackgroundImage = Image.FromFile("search2.png");
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.BackgroundImage = Image.FromFile("search.png");
        }

        private void repswbutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认重置密码为123456吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    SqlConnection conn = DBAccess.GetConnection();
                    if (conn.State == ConnectionState.Open)//判断当前连接的状态
                    {
                        //显示状态信息
                        SqlCommand sqlCommand = conn.CreateCommand();
                        String SQLstr = " UPDATE dbo.tb_Login SET Password = '123456' WHERE ID = '" + dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString() + "';";
                        sqlCommand.CommandText = SQLstr;
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        conn.Close();
                        conn.Dispose();
                        MessageBox.Show("重置成功！新密码为123456", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("连接数据库失败");//出现异常弹出提示
                    Application.Exit();
                }
            }
        }

        private void repswbutton_MouseEnter(object sender, EventArgs e)
        {
            repswbutton.BackgroundImage = Image.FromFile("repsw2.png");
        }

        private void repswbutton_MouseLeave(object sender, EventArgs e)
        {
            repswbutton.BackgroundImage = Image.FromFile("repsw.png");
        }









        /* private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             Grid_Info(dataGridView1);//当点击了Grid里面的条目，使用该函数更新下方信息显示
             PreGridSelect = dataGridView1.CurrentCell.RowIndex;
         }
         */
        /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             Grid_Info(dataGridView1);//当点击了Grid里面的条目，使用该函数更新下方信息显示
             PreGridSelect = dataGridView1.CurrentCell.RowIndex;
         }*/
    }
}
