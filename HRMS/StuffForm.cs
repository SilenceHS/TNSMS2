using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
        public void Renewgridpic(DataGridView DGrid)//更新grid里的图片
        {
            byte[] pic;
            try
            {
                //将数据库中的图片存入到字节数组中
                /*pic = (byte[])(datasetGrid.Tables[0].Rows[DGrid.CurrentCell.RowIndex][7]);
                MemoryStream ms = new MemoryStream(pic);  //将字节数组存入到二进制流中
                photoPictureBox.Image =   //二进制流Image控件中显示*/
                pic = (byte[])DGrid[7, DGrid.CurrentCell.RowIndex].Value;
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
                    //remarkTextBox.Text = DGrid[7, DGrid.CurrentCell.RowIndex].Value.ToString();
                    Renewgridpic(DGrid);
                    //nID = Convert.ToInt32(idTextBox.Text); //获取当前职位编号
                    picSelectButton.Enabled = true;
                    picDeleteButton.Enabled = true;
                    return DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();//返回当前职工的姓名
                }
                else
                {
                    //使用MyMeans公共类中的Clear_ Control()方法清空指定控件集中的相应控件
                    ClearTextBoxes();
                    nID = 0;
                    picSelectButton.Enabled = false;
                    picDeleteButton.Enabled = false;
                    return "";
                }
            }
            catch
            {
                ClearTextBoxes();
                picSelectButton.Enabled = false;
                picDeleteButton.Enabled = false;
                MessageBox.Show("找不到信息");
            }
            return "";
        }


        public StuffForm()
        {
            InitializeComponent();
        }
        public void Condition_Lookup(String StrValue)//查找用，更新源
        {
            DBAccess dbAccess = new DBAccess();
            if(StrValue=="ALL")//如果选择all，就直接获得所有
            {
                datasetGrid = dbAccess.GetDataset("select * from dbo.tb_Student", "dbo.tb_Student");
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
