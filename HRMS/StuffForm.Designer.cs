namespace HRMS
{
    partial class StuffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picDeleteButton = new System.Windows.Forms.Button();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSelectButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remarkTextBox = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.Label();
            this.sexTextBox = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.Label();
            this.stuaddbutton = new System.Windows.Forms.Button();
            this.deletestubutton = new System.Windows.Forms.Button();
            this.changestubutton = new System.Windows.Forms.Button();
            this.repswbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.valueTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fieldComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 69);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类查询";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(574, 14);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(50, 50);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(407, 26);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(141, 21);
            this.valueTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "查询条件：";
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.FormattingEnabled = true;
            this.fieldComboBox.Items.AddRange(new object[] {
            "ALL",
            "学号",
            "姓名",
            "性别",
            "职位",
            "电话",
            "地址",
            "Email"});
            this.fieldComboBox.Location = new System.Drawing.Point(115, 26);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(151, 20);
            this.fieldComboBox.TabIndex = 1;
            this.fieldComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询类型：";
            // 
            // picDeleteButton
            // 
            this.picDeleteButton.Enabled = false;
            this.picDeleteButton.Location = new System.Drawing.Point(1007, 274);
            this.picDeleteButton.Name = "picDeleteButton";
            this.picDeleteButton.Size = new System.Drawing.Size(94, 23);
            this.picDeleteButton.TabIndex = 22;
            this.picDeleteButton.Text = "删除图片";
            this.picDeleteButton.UseVisualStyleBackColor = true;
            this.picDeleteButton.Click += new System.EventHandler(this.picDeleteButton_Click);
            // 
            // currentTextBox
            // 
            this.currentTextBox.Location = new System.Drawing.Point(893, 38);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.ReadOnly = true;
            this.currentTextBox.Size = new System.Drawing.Size(179, 21);
            this.currentTextBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(891, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "当前学生：";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.photoPictureBox.Location = new System.Drawing.Point(893, 75);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(179, 179);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 17;
            this.photoPictureBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 605);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 620);
            this.panel1.TabIndex = 16;
            // 
            // picSelectButton
            // 
            this.picSelectButton.Enabled = false;
            this.picSelectButton.Location = new System.Drawing.Point(868, 274);
            this.picSelectButton.Name = "picSelectButton";
            this.picSelectButton.Size = new System.Drawing.Size(94, 23);
            this.picSelectButton.TabIndex = 21;
            this.picSelectButton.Text = "选择图片";
            this.picSelectButton.UseVisualStyleBackColor = true;
            this.picSelectButton.Click += new System.EventHandler(this.picSelectButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "学号：";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(143, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "职位：";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(143, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "姓名：";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "地址：";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "性别：";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "邮件：";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(143, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "电话：";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(143, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "备注：";
            // 
            // idTextBox
            // 
            this.idTextBox.AutoSize = true;
            this.idTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idTextBox.Location = new System.Drawing.Point(39, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(0, 17);
            this.idTextBox.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remarkTextBox);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.addressTextBox);
            this.panel2.Controls.Add(this.positionTextBox);
            this.panel2.Controls.Add(this.phoneTextBox);
            this.panel2.Controls.Add(this.sexTextBox);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(868, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 199);
            this.panel2.TabIndex = 19;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.AutoSize = true;
            this.remarkTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remarkTextBox.Location = new System.Drawing.Point(178, 140);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(0, 17);
            this.remarkTextBox.TabIndex = 20;
            // 
            // emailTextBox
            // 
            this.emailTextBox.AutoSize = true;
            this.emailTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailTextBox.Location = new System.Drawing.Point(39, 142);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(0, 17);
            this.emailTextBox.TabIndex = 19;
            // 
            // addressTextBox
            // 
            this.addressTextBox.AutoSize = true;
            this.addressTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addressTextBox.Location = new System.Drawing.Point(39, 52);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(0, 17);
            this.addressTextBox.TabIndex = 18;
            // 
            // positionTextBox
            // 
            this.positionTextBox.AutoSize = true;
            this.positionTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.positionTextBox.Location = new System.Drawing.Point(179, 98);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(0, 17);
            this.positionTextBox.TabIndex = 17;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.AutoSize = true;
            this.phoneTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneTextBox.Location = new System.Drawing.Point(179, 51);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(0, 17);
            this.phoneTextBox.TabIndex = 16;
            // 
            // sexTextBox
            // 
            this.sexTextBox.AutoSize = true;
            this.sexTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sexTextBox.Location = new System.Drawing.Point(38, 98);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(0, 17);
            this.sexTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoSize = true;
            this.nameTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTextBox.Location = new System.Drawing.Point(179, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(0, 17);
            this.nameTextBox.TabIndex = 14;
            // 
            // stuaddbutton
            // 
            this.stuaddbutton.BackColor = System.Drawing.Color.Transparent;
            this.stuaddbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stuaddbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stuaddbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stuaddbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stuaddbutton.Location = new System.Drawing.Point(900, 505);
            this.stuaddbutton.Margin = new System.Windows.Forms.Padding(0);
            this.stuaddbutton.Name = "stuaddbutton";
            this.stuaddbutton.Size = new System.Drawing.Size(70, 70);
            this.stuaddbutton.TabIndex = 23;
            this.stuaddbutton.UseVisualStyleBackColor = false;
            this.stuaddbutton.Click += new System.EventHandler(this.stuaddbutton_Click);
            this.stuaddbutton.MouseEnter += new System.EventHandler(this.stuaddbutton_MouseEnter);
            this.stuaddbutton.MouseLeave += new System.EventHandler(this.stuaddbutton_MouseLeave);
            // 
            // deletestubutton
            // 
            this.deletestubutton.BackColor = System.Drawing.Color.Transparent;
            this.deletestubutton.Enabled = false;
            this.deletestubutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deletestubutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deletestubutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deletestubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletestubutton.Location = new System.Drawing.Point(1031, 505);
            this.deletestubutton.Margin = new System.Windows.Forms.Padding(0);
            this.deletestubutton.Name = "deletestubutton";
            this.deletestubutton.Size = new System.Drawing.Size(70, 70);
            this.deletestubutton.TabIndex = 24;
            this.deletestubutton.UseVisualStyleBackColor = false;
            this.deletestubutton.Click += new System.EventHandler(this.deletestubutton_Click);
            this.deletestubutton.MouseEnter += new System.EventHandler(this.deletestubutton_MouseEnter);
            this.deletestubutton.MouseLeave += new System.EventHandler(this.deletestubutton_MouseLeave);
            // 
            // changestubutton
            // 
            this.changestubutton.BackColor = System.Drawing.Color.Transparent;
            this.changestubutton.Enabled = false;
            this.changestubutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changestubutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changestubutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changestubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changestubutton.Location = new System.Drawing.Point(900, 601);
            this.changestubutton.Margin = new System.Windows.Forms.Padding(0);
            this.changestubutton.Name = "changestubutton";
            this.changestubutton.Size = new System.Drawing.Size(70, 70);
            this.changestubutton.TabIndex = 25;
            this.changestubutton.UseVisualStyleBackColor = false;
            this.changestubutton.Click += new System.EventHandler(this.changestubutton_Click);
            this.changestubutton.MouseEnter += new System.EventHandler(this.changestubutton_MouseEnter);
            this.changestubutton.MouseLeave += new System.EventHandler(this.changestubutton_MouseLeave);
            // 
            // repswbutton
            // 
            this.repswbutton.BackColor = System.Drawing.Color.Transparent;
            this.repswbutton.Enabled = false;
            this.repswbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.repswbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.repswbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.repswbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repswbutton.Location = new System.Drawing.Point(1031, 602);
            this.repswbutton.Margin = new System.Windows.Forms.Padding(0);
            this.repswbutton.Name = "repswbutton";
            this.repswbutton.Size = new System.Drawing.Size(70, 70);
            this.repswbutton.TabIndex = 26;
            this.repswbutton.UseVisualStyleBackColor = false;
            this.repswbutton.Click += new System.EventHandler(this.repswbutton_Click);
            this.repswbutton.MouseEnter += new System.EventHandler(this.repswbutton_MouseEnter);
            this.repswbutton.MouseLeave += new System.EventHandler(this.repswbutton_MouseLeave);
            // 
            // StuffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 705);
            this.Controls.Add(this.repswbutton);
            this.Controls.Add(this.changestubutton);
            this.Controls.Add(this.deletestubutton);
            this.Controls.Add(this.stuaddbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picDeleteButton);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picSelectButton);
            this.Name = "StuffForm";
            this.Text = "StuffForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button picDeleteButton;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button picSelectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label idTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label remarkTextBox;
        private System.Windows.Forms.Label emailTextBox;
        private System.Windows.Forms.Label addressTextBox;
        private System.Windows.Forms.Label positionTextBox;
        private System.Windows.Forms.Label phoneTextBox;
        private System.Windows.Forms.Label sexTextBox;
        private System.Windows.Forms.Label nameTextBox;
        private System.Windows.Forms.Button stuaddbutton;
        private System.Windows.Forms.Button deletestubutton;
        private System.Windows.Forms.Button changestubutton;
        private System.Windows.Forms.Button repswbutton;
    }
}