namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.district_cb = new System.Windows.Forms.ComboBox();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.sub_B = new System.Windows.Forms.Button();
            this.genGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.no_text = new System.Windows.Forms.TextBox();
            this.insert_but = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.check_btn = new System.Windows.Forms.Button();
            this.show_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sub_C = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.forei_text = new System.Windows.Forms.TextBox();
            this.insert_forei = new System.Windows.Forms.Button();
            this.genGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // district_cb
            // 
            this.district_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.district_cb.FormattingEnabled = true;
            this.district_cb.Items.AddRange(new object[] {
            "A 臺北市",
            "B 臺中市",
            "C 基隆市",
            "D 臺南市",
            "E 高雄市",
            "F 新北市",
            "G 宜蘭縣",
            "H 桃園市",
            "I 嘉義市",
            "J 新竹縣",
            "K 苗栗縣",
            "M 南投縣",
            "N 彰化縣",
            "O 新竹市 ",
            "P 雲林縣 ",
            "Q 嘉義縣 ",
            "T 屏東縣 ",
            "U 花蓮縣",
            "V 臺東縣",
            "W 金門縣 ",
            "X 澎湖縣 ",
            "Z 連江縣",
            "L 臺中縣",
            "R 臺南縣",
            "S 高雄縣",
            "Y 陽明山"});
            this.district_cb.Location = new System.Drawing.Point(12, 46);
            this.district_cb.Name = "district_cb";
            this.district_cb.Size = new System.Drawing.Size(121, 20);
            this.district_cb.TabIndex = 0;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(6, 34);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(47, 16);
            this.rb_1.TabIndex = 1;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "BOY";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(6, 75);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(50, 16);
            this.rb_2.TabIndex = 2;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "GIRL";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // sub_B
            // 
            this.sub_B.Location = new System.Drawing.Point(149, 155);
            this.sub_B.Name = "sub_B";
            this.sub_B.Size = new System.Drawing.Size(75, 23);
            this.sub_B.TabIndex = 3;
            this.sub_B.Text = "產生";
            this.sub_B.UseVisualStyleBackColor = true;
            this.sub_B.Click += new System.EventHandler(this.button4_Click);
            // 
            // genGroup
            // 
            this.genGroup.Controls.Add(this.rb_2);
            this.genGroup.Controls.Add(this.rb_1);
            this.genGroup.Location = new System.Drawing.Point(149, 8);
            this.genGroup.Name = "genGroup";
            this.genGroup.Size = new System.Drawing.Size(75, 95);
            this.genGroup.TabIndex = 4;
            this.genGroup.TabStop = false;
            this.genGroup.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "產生身份證";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "驗證身份證";
            // 
            // no_text
            // 
            this.no_text.Location = new System.Drawing.Point(26, 155);
            this.no_text.MaxLength = 10;
            this.no_text.Name = "no_text";
            this.no_text.Size = new System.Drawing.Size(100, 22);
            this.no_text.TabIndex = 9;
            // 
            // insert_but
            // 
            this.insert_but.Location = new System.Drawing.Point(149, 192);
            this.insert_but.Name = "insert_but";
            this.insert_but.Size = new System.Drawing.Size(75, 23);
            this.insert_but.TabIndex = 10;
            this.insert_but.Text = "驗證";
            this.insert_but.UseVisualStyleBackColor = true;
            this.insert_but.Click += new System.EventHandler(this.insert_but_Click);
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(149, 316);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(75, 23);
            this.new_btn.TabIndex = 13;
            this.new_btn.Text = "產生";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(149, 287);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 12;
            this.check_btn.Text = "驗證";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // show_text
            // 
            this.show_text.Location = new System.Drawing.Point(14, 287);
            this.show_text.MaxLength = 8;
            this.show_text.Name = "show_text";
            this.show_text.Size = new System.Drawing.Size(100, 22);
            this.show_text.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "產生統一編號";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "產生統一證號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "地區";
            // 
            // sub_C
            // 
            this.sub_C.Location = new System.Drawing.Point(386, 155);
            this.sub_C.Name = "sub_C";
            this.sub_C.Size = new System.Drawing.Size(75, 23);
            this.sub_C.TabIndex = 17;
            this.sub_C.Text = "產生";
            this.sub_C.UseVisualStyleBackColor = true;
            this.sub_C.Click += new System.EventHandler(this.sub_C_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_4);
            this.groupBox1.Controls.Add(this.rb_3);
            this.groupBox1.Location = new System.Drawing.Point(260, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 95);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Location = new System.Drawing.Point(6, 75);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(83, 16);
            this.rb_4.TabIndex = 2;
            this.rb_4.TabStop = true;
            this.rb_4.Text = "陸港澳人士";
            this.rb_4.UseVisualStyleBackColor = true;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(6, 34);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(71, 16);
            this.rb_3.TabIndex = 1;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "外籍人士";
            this.rb_3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "驗證統一證號";
            // 
            // forei_text
            // 
            this.forei_text.Location = new System.Drawing.Point(260, 155);
            this.forei_text.MaxLength = 10;
            this.forei_text.Name = "forei_text";
            this.forei_text.Size = new System.Drawing.Size(100, 22);
            this.forei_text.TabIndex = 20;
            // 
            // insert_forei
            // 
            this.insert_forei.Location = new System.Drawing.Point(386, 192);
            this.insert_forei.Name = "insert_forei";
            this.insert_forei.Size = new System.Drawing.Size(75, 23);
            this.insert_forei.TabIndex = 21;
            this.insert_forei.Text = "驗證";
            this.insert_forei.UseVisualStyleBackColor = true;
            this.insert_forei.Click += new System.EventHandler(this.insert_forei_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(486, 360);
            this.Controls.Add(this.insert_forei);
            this.Controls.Add(this.forei_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sub_C);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.show_text);
            this.Controls.Add(this.insert_but);
            this.Controls.Add(this.no_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.district_cb);
            this.Controls.Add(this.genGroup);
            this.Controls.Add(this.sub_B);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.genGroup.ResumeLayout(false);
            this.genGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox district_cb;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.Button sub_B;
        private System.Windows.Forms.GroupBox genGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox no_text;
        private System.Windows.Forms.Button insert_but;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.TextBox show_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sub_C;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_4;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox forei_text;
        private System.Windows.Forms.Button insert_forei;
    }
}

