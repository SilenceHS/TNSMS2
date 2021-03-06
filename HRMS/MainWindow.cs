﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class MainWindow : Form
    {
        User user = new User("-1","","");
        public void initimage()
        {
            quitbutton.BackgroundImage = Image.FromFile("exit.png");
            changepswbutton.BackgroundImage = Image.FromFile("changepsw.png");
            relogbutton.BackgroundImage = Image.FromFile("relog.png");
            mainbutton.BackgroundImage = Image.FromFile("main.png");
            gradebutton.BackgroundImage = Image.FromFile("grade.png");
            coursebutton.BackgroundImage = Image.FromFile("course.png");
            stuInfomationbutton.BackgroundImage = Image.FromFile("stuInfomation.png");
            stuGradebutton.BackgroundImage = Image.FromFile("stuGrade.png");
            mybutton.BackgroundImage = Image.FromFile("doge.png");
        }
        public void studentinit()//学生界面初始化
        {
            mainbutton.Visible = false;
            gradebutton.Visible = false;
            coursebutton.Visible = false;
            stuInfomationbutton.Visible = true;
            stuGradebutton.Visible = true;
            
        }
        public void teacherinit()//教师界面初始化
        {
            mainbutton.Visible = true;
            gradebutton.Visible = true;
            coursebutton.Visible = true;
            stuInfomationbutton.Visible = false;
            stuGradebutton.Visible = false;
        }
        public MainWindow()
        {
            LoginDialog LD = new LoginDialog(user);
            Application.Run(LD);
            if (user.getid() .Equals("-1"))
                this.Close();
            InitializeComponent();
            initimage();
            if (user.getposition()=="Teacher")
            {
                teacherinit();
            }
            if (user.getposition() == "Student")
            {
                studentinit();
            }
            toolStripStatusLabel1.Text = "当前用户：" + user.getname() + "  身份为：" + user.getposition();
        }
       private void 资料查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuffForm SF = new StuffForm();
            SF.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            user = new User("-1", "", "");
            LoginDialog LD = new LoginDialog(user);
            LD.ShowDialog();
            if (user.getid().Equals("-1"))
                this.Close();
            toolStripStatusLabel1.Text = "当前用户：" + user.getname()+"  身份为："+user.getposition();
            if(user.getposition()=="Student")
                studentinit();
            this.Show();
            
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitbutton_MouseEnter(object sender, EventArgs e)
        {
            quitbutton.BackgroundImage = Image.FromFile("exit2.png");
        }

        private void quitbutton_MouseLeave(object sender, EventArgs e)
        {
            quitbutton.BackgroundImage = Image.FromFile("exit.png");
        }

        private void changepswbutton_Click(object sender, EventArgs e)
        {
            Changepsw change = new Changepsw(user);
            change.ShowDialog();
        }

        private void changepswbutton_MouseEnter(object sender, EventArgs e)
        {
            changepswbutton.BackgroundImage = Image.FromFile("changepsw2.png");
        }

        private void changepswbutton_MouseLeave(object sender, EventArgs e)
        {
            changepswbutton.BackgroundImage = Image.FromFile("changepsw.png");
        }

        private void relogbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            user = new User("-1", "", "");
            LoginDialog LD = new LoginDialog(user);
            LD.ShowDialog();
            if (user.getid().Equals("-1"))
                this.Close();
            toolStripStatusLabel1.Text = "当前用户:" + user.getname();
            if (user.getposition() == "Student")
                studentinit();
            if (user.getposition() == "Teacher")
                teacherinit();
            this.Show();
        }

        private void relogbutton_MouseEnter(object sender, EventArgs e)
        {
            relogbutton.BackgroundImage = Image.FromFile("relog2.png");
        }

        private void relogbutton_MouseLeave(object sender, EventArgs e)
        {
            relogbutton.BackgroundImage = Image.FromFile("relog.png");
        }

        private void mainbutton_Click(object sender, EventArgs e)
        {
            StuffForm SF = new StuffForm();
            SF.ShowDialog();
        }

        private void mainbutton_MouseEnter(object sender, EventArgs e)
        {
            mainbutton.BackgroundImage = Image.FromFile("main2.png");
        }

        private void mainbutton_MouseLeave(object sender, EventArgs e)
        {
            mainbutton.BackgroundImage = Image.FromFile("main.png");
        }

        private void gradebutton_Click(object sender, EventArgs e)
        {
            GradeForm gradeForm = new GradeForm();
            gradeForm.ShowDialog();
        }

        private void gradebutton_MouseEnter(object sender, EventArgs e)
        {
            gradebutton.BackgroundImage = Image.FromFile("grade2.png");
        }

        private void gradebutton_MouseLeave(object sender, EventArgs e)
        {
            gradebutton.BackgroundImage = Image.FromFile("grade.png");
        }

        private void coursebutton_Click(object sender, EventArgs e)
        {
            ClassForm cf = new ClassForm();
            cf.ShowDialog();

        }

        private void coursebutton_MouseEnter(object sender, EventArgs e)
        {
            coursebutton.BackgroundImage = Image.FromFile("course2.png");
        }

        private void coursebutton_MouseLeave(object sender, EventArgs e)
        {
            coursebutton.BackgroundImage = Image.FromFile("course.png");
        }

        private void stuInfomationbutton_Click(object sender, EventArgs e)
        {
            stuInfo si = new stuInfo(user);
            si.ShowDialog();
        }

        private void stuInfomationbutton_MouseEnter(object sender, EventArgs e)
        {
            stuInfomationbutton.BackgroundImage = Image.FromFile("stuInfomation2.png");
        }

        private void stuInfomationbutton_MouseLeave(object sender, EventArgs e)
        {
            stuInfomationbutton.BackgroundImage = Image.FromFile("stuInfomation.png");
        }

        private void stuGradebutton_Click(object sender, EventArgs e)
        {
            StuGrade sg = new StuGrade(user);
            sg.ShowDialog();
        }

        private void stuGradebutton_MouseEnter(object sender, EventArgs e)
        {
            stuGradebutton.BackgroundImage = Image.FromFile("stuGrade2.png");
        }

        private void stuGradebutton_MouseLeave(object sender, EventArgs e)
        {
            stuGradebutton.BackgroundImage = Image.FromFile("stuGrade.png");
        }

        private void mybutton_MouseEnter(object sender, EventArgs e)
        {
            mybutton.BackgroundImage = Image.FromFile("doge2.png");
        }

        private void mybutton_MouseLeave(object sender, EventArgs e)
        {
            mybutton.BackgroundImage = Image.FromFile("doge.png");
        }

        private void mybutton_Click(object sender, EventArgs e)
        {
            myinfo mi = new myinfo();
            mi.ShowDialog();
        }
    }
}
