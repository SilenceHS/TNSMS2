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
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.picDeleteButton = new System.Windows.Forms.Button();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSelectButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.Location = new System.Drawing.Point(614, 55);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(100, 21);
            this.remarkTextBox.TabIndex = 12;
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
            this.groupBox1.Size = new System.Drawing.Size(825, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类查询";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(661, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(140, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(407, 20);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(141, 21);
            this.valueTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 23);
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
            this.fieldComboBox.Location = new System.Drawing.Point(106, 20);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(151, 20);
            this.fieldComboBox.TabIndex = 1;
            this.fieldComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询类型：";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(614, 17);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 21);
            this.phoneTextBox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remarkTextBox);
            this.panel2.Controls.Add(this.phoneTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.sexTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addressTextBox);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.positionTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.delButton);
            this.panel2.Controls.Add(this.modifyButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Location = new System.Drawing.Point(11, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 123);
            this.panel2.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(573, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "备注";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(573, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "电话";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(453, 55);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 21);
            this.emailTextBox.TabIndex = 11;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Location = new System.Drawing.Point(453, 17);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(100, 21);
            this.sexTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(412, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "邮件";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(412, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "性别";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(294, 55);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 21);
            this.addressTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(294, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(253, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "地址";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(253, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "姓名";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(134, 55);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 21);
            this.positionTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(93, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "职位";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(134, 17);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 21);
            this.idTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(93, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "学号";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(442, 96);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(523, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(361, 97);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 17;
            this.delButton.Text = "删除";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(280, 97);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 16;
            this.modifyButton.Text = "修改";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(199, 97);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // picDeleteButton
            // 
            this.picDeleteButton.Enabled = false;
            this.picDeleteButton.Location = new System.Drawing.Point(900, 317);
            this.picDeleteButton.Name = "picDeleteButton";
            this.picDeleteButton.Size = new System.Drawing.Size(152, 23);
            this.picDeleteButton.TabIndex = 22;
            this.picDeleteButton.Text = "删除图片";
            this.picDeleteButton.UseVisualStyleBackColor = true;
            this.picDeleteButton.Click += new System.EventHandler(this.picDeleteButton_Click);
            // 
            // currentTextBox
            // 
            this.currentTextBox.Location = new System.Drawing.Point(886, 38);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.ReadOnly = true;
            this.currentTextBox.Size = new System.Drawing.Size(179, 21);
            this.currentTextBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(884, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "当前学生：";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.photoPictureBox.Location = new System.Drawing.Point(886, 75);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 311);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 314);
            this.panel1.TabIndex = 16;
            // 
            // picSelectButton
            // 
            this.picSelectButton.Enabled = false;
            this.picSelectButton.Location = new System.Drawing.Point(900, 277);
            this.picSelectButton.Name = "picSelectButton";
            this.picSelectButton.Size = new System.Drawing.Size(152, 23);
            this.picSelectButton.TabIndex = 21;
            this.picSelectButton.Text = "选择图片";
            this.picSelectButton.UseVisualStyleBackColor = true;
            this.picSelectButton.Click += new System.EventHandler(this.picSelectButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StuffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 538);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button picDeleteButton;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button picSelectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}