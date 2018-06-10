namespace HRMS
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.资料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.资料查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitbutton = new System.Windows.Forms.Button();
            this.changepswbutton = new System.Windows.Forms.Button();
            this.relogbutton = new System.Windows.Forms.Button();
            this.mainbutton = new System.Windows.Forms.Button();
            this.gradebutton = new System.Windows.Forms.Button();
            this.coursebutton = new System.Windows.Forms.Button();
            this.userStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 资料管理ToolStripMenuItem
            // 
            this.资料管理ToolStripMenuItem.Name = "资料管理ToolStripMenuItem";
            this.资料管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.资料管理ToolStripMenuItem.Text = "成绩查询";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新登录ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新登录ToolStripMenuItem.Text = "重新登录";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 信息ToolStripMenuItem
            // 
            this.信息ToolStripMenuItem.Name = "信息ToolStripMenuItem";
            this.信息ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.信息ToolStripMenuItem.Text = "信息";
            // 
            // 资料查询ToolStripMenuItem
            // 
            this.资料查询ToolStripMenuItem.Name = "资料查询ToolStripMenuItem";
            this.资料查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.资料查询ToolStripMenuItem.Text = "学生信息查询";
            this.资料查询ToolStripMenuItem.Click += new System.EventHandler(this.资料查询ToolStripMenuItem_Click);
            // 
            // 人事管理ToolStripMenuItem
            // 
            this.人事管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.资料查询ToolStripMenuItem,
            this.资料管理ToolStripMenuItem});
            this.人事管理ToolStripMenuItem.Name = "人事管理ToolStripMenuItem";
            this.人事管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.人事管理ToolStripMenuItem.Text = "学生管理";
            // 
            // userStatusStrip
            // 
            this.userStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.userStatusStrip.Location = new System.Drawing.Point(0, 497);
            this.userStatusStrip.Name = "userStatusStrip";
            this.userStatusStrip.Size = new System.Drawing.Size(844, 22);
            this.userStatusStrip.TabIndex = 4;
            this.userStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.人事管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // quitbutton
            // 
            this.quitbutton.BackColor = System.Drawing.Color.Transparent;
            this.quitbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitbutton.Location = new System.Drawing.Point(714, 218);
            this.quitbutton.Margin = new System.Windows.Forms.Padding(0);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(110, 110);
            this.quitbutton.TabIndex = 6;
            this.quitbutton.Text = "6";
            this.quitbutton.UseVisualStyleBackColor = false;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            this.quitbutton.MouseEnter += new System.EventHandler(this.quitbutton_MouseEnter);
            this.quitbutton.MouseLeave += new System.EventHandler(this.quitbutton_MouseLeave);
            // 
            // changepswbutton
            // 
            this.changepswbutton.BackColor = System.Drawing.Color.Transparent;
            this.changepswbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changepswbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changepswbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changepswbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepswbutton.Location = new System.Drawing.Point(432, 218);
            this.changepswbutton.Margin = new System.Windows.Forms.Padding(0);
            this.changepswbutton.Name = "changepswbutton";
            this.changepswbutton.Size = new System.Drawing.Size(110, 110);
            this.changepswbutton.TabIndex = 7;
            this.changepswbutton.Text = "4";
            this.changepswbutton.UseVisualStyleBackColor = false;
            this.changepswbutton.Click += new System.EventHandler(this.changepswbutton_Click);
            this.changepswbutton.MouseEnter += new System.EventHandler(this.changepswbutton_MouseEnter);
            this.changepswbutton.MouseLeave += new System.EventHandler(this.changepswbutton_MouseLeave);
            // 
            // relogbutton
            // 
            this.relogbutton.BackColor = System.Drawing.Color.Transparent;
            this.relogbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.relogbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.relogbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.relogbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.relogbutton.Location = new System.Drawing.Point(573, 218);
            this.relogbutton.Name = "relogbutton";
            this.relogbutton.Size = new System.Drawing.Size(110, 110);
            this.relogbutton.TabIndex = 8;
            this.relogbutton.Text = "5";
            this.relogbutton.UseVisualStyleBackColor = false;
            this.relogbutton.Click += new System.EventHandler(this.relogbutton_Click);
            this.relogbutton.MouseEnter += new System.EventHandler(this.relogbutton_MouseEnter);
            this.relogbutton.MouseLeave += new System.EventHandler(this.relogbutton_MouseLeave);
            // 
            // mainbutton
            // 
            this.mainbutton.BackColor = System.Drawing.Color.Transparent;
            this.mainbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mainbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mainbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainbutton.Location = new System.Drawing.Point(9, 218);
            this.mainbutton.Margin = new System.Windows.Forms.Padding(0);
            this.mainbutton.Name = "mainbutton";
            this.mainbutton.Size = new System.Drawing.Size(110, 110);
            this.mainbutton.TabIndex = 9;
            this.mainbutton.Text = "1";
            this.mainbutton.UseVisualStyleBackColor = false;
            this.mainbutton.Click += new System.EventHandler(this.mainbutton_Click);
            this.mainbutton.MouseEnter += new System.EventHandler(this.mainbutton_MouseEnter);
            this.mainbutton.MouseLeave += new System.EventHandler(this.mainbutton_MouseLeave);
            // 
            // gradebutton
            // 
            this.gradebutton.BackColor = System.Drawing.Color.Transparent;
            this.gradebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gradebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gradebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.gradebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradebutton.Location = new System.Drawing.Point(150, 218);
            this.gradebutton.Margin = new System.Windows.Forms.Padding(0);
            this.gradebutton.Name = "gradebutton";
            this.gradebutton.Size = new System.Drawing.Size(110, 110);
            this.gradebutton.TabIndex = 10;
            this.gradebutton.Text = "2";
            this.gradebutton.UseVisualStyleBackColor = false;
            this.gradebutton.Click += new System.EventHandler(this.gradebutton_Click);
            this.gradebutton.MouseEnter += new System.EventHandler(this.gradebutton_MouseEnter);
            this.gradebutton.MouseLeave += new System.EventHandler(this.gradebutton_MouseLeave);
            // 
            // coursebutton
            // 
            this.coursebutton.BackColor = System.Drawing.Color.Transparent;
            this.coursebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.coursebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.coursebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.coursebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursebutton.Location = new System.Drawing.Point(291, 218);
            this.coursebutton.Name = "coursebutton";
            this.coursebutton.Size = new System.Drawing.Size(110, 110);
            this.coursebutton.TabIndex = 11;
            this.coursebutton.Text = "3";
            this.coursebutton.UseVisualStyleBackColor = false;
            this.coursebutton.Click += new System.EventHandler(this.coursebutton_Click);
            this.coursebutton.MouseEnter += new System.EventHandler(this.coursebutton_MouseEnter);
            this.coursebutton.MouseLeave += new System.EventHandler(this.coursebutton_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 519);
            this.Controls.Add(this.coursebutton);
            this.Controls.Add(this.gradebutton);
            this.Controls.Add(this.mainbutton);
            this.Controls.Add(this.relogbutton);
            this.Controls.Add(this.changepswbutton);
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.userStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.userStatusStrip.ResumeLayout(false);
            this.userStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem 资料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 资料查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip userStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.Button quitbutton;
        private System.Windows.Forms.Button changepswbutton;
        private System.Windows.Forms.Button relogbutton;
        private System.Windows.Forms.Button mainbutton;
        private System.Windows.Forms.Button gradebutton;
        private System.Windows.Forms.Button coursebutton;
    }
}

