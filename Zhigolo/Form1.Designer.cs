namespace Zhigolo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect = new System.Windows.Forms.Button();
            this.apiId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hashId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.auth = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.contactsBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.complActive = new System.Windows.Forms.CheckBox();
            this.chooseCompl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.milliBox = new System.Windows.Forms.TextBox();
            this.complimentsBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.methodOfSend = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.connect.Location = new System.Drawing.Point(61, 89);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(108, 31);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // apiId
            // 
            this.apiId.Location = new System.Drawing.Point(12, 63);
            this.apiId.Name = "apiId";
            this.apiId.Size = new System.Drawing.Size(100, 20);
            this.apiId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "API_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(116, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "HASH_ID";
            // 
            // hashId
            // 
            this.hashId.Location = new System.Drawing.Point(119, 63);
            this.hashId.Name = "hashId";
            this.hashId.Size = new System.Drawing.Size(100, 20);
            this.hashId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(270, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // phone
            // 
            this.phone.Enabled = false;
            this.phone.Location = new System.Drawing.Point(273, 63);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(108, 20);
            this.phone.TabIndex = 6;
            // 
            // auth
            // 
            this.auth.Enabled = false;
            this.auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.auth.Location = new System.Drawing.Point(337, 89);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(108, 31);
            this.auth.TabIndex = 5;
            this.auth.Text = "Auth";
            this.auth.UseVisualStyleBackColor = true;
            this.auth.Click += new System.EventHandler(this.auth_Click);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.start.Location = new System.Drawing.Point(692, 27);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(108, 31);
            this.start.TabIndex = 8;
            this.start.Text = "First Login";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(395, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code";
            // 
            // code
            // 
            this.code.Enabled = false;
            this.code.Location = new System.Drawing.Point(398, 63);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(108, 20);
            this.code.TabIndex = 9;
            // 
            // contactsBt
            // 
            this.contactsBt.Enabled = false;
            this.contactsBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.contactsBt.Location = new System.Drawing.Point(226, 306);
            this.contactsBt.Name = "contactsBt";
            this.contactsBt.Size = new System.Drawing.Size(297, 132);
            this.contactsBt.TabIndex = 11;
            this.contactsBt.Text = "Send Compliments()";
            this.contactsBt.UseVisualStyleBackColor = true;
            this.contactsBt.Click += new System.EventHandler(this.contactsBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(35, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Compliments dictionary";
            // 
            // complActive
            // 
            this.complActive.AutoSize = true;
            this.complActive.Enabled = false;
            this.complActive.Location = new System.Drawing.Point(15, 223);
            this.complActive.Name = "complActive";
            this.complActive.Size = new System.Drawing.Size(15, 14);
            this.complActive.TabIndex = 13;
            this.complActive.UseVisualStyleBackColor = true;
            // 
            // chooseCompl
            // 
            this.chooseCompl.Enabled = false;
            this.chooseCompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chooseCompl.Location = new System.Drawing.Point(12, 245);
            this.chooseCompl.Name = "chooseCompl";
            this.chooseCompl.Size = new System.Drawing.Size(88, 28);
            this.chooseCompl.TabIndex = 14;
            this.chooseCompl.Text = "Choose";
            this.chooseCompl.UseVisualStyleBackColor = true;
            this.chooseCompl.Click += new System.EventHandler(this.chooseCompl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label6.Location = new System.Drawing.Point(554, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Periodic of sending";
            // 
            // milliBox
            // 
            this.milliBox.Enabled = false;
            this.milliBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.milliBox.Location = new System.Drawing.Point(558, 331);
            this.milliBox.Name = "milliBox";
            this.milliBox.Size = new System.Drawing.Size(218, 23);
            this.milliBox.TabIndex = 17;
            // 
            // complimentsBox
            // 
            this.complimentsBox.Enabled = false;
            this.complimentsBox.Location = new System.Drawing.Point(12, 342);
            this.complimentsBox.Name = "complimentsBox";
            this.complimentsBox.ReadOnly = true;
            this.complimentsBox.Size = new System.Drawing.Size(100, 96);
            this.complimentsBox.TabIndex = 18;
            this.complimentsBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.methodOfSend});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // methodOfSend
            // 
            this.methodOfSend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameChoice,
            this.phoneChoice});
            this.methodOfSend.Name = "methodOfSend";
            this.methodOfSend.Size = new System.Drawing.Size(174, 20);
            this.methodOfSend.Text = "Method of sending messages";
            // 
            // usernameChoice
            // 
            this.usernameChoice.Checked = true;
            this.usernameChoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usernameChoice.Name = "usernameChoice";
            this.usernameChoice.Size = new System.Drawing.Size(108, 22);
            this.usernameChoice.Text = "Login";
            this.usernameChoice.Click += new System.EventHandler(this.usernameChoice_Click);
            // 
            // phoneChoice
            // 
            this.phoneChoice.Name = "phoneChoice";
            this.phoneChoice.Size = new System.Drawing.Size(108, 22);
            this.phoneChoice.Text = "Phone";
            this.phoneChoice.Click += new System.EventHandler(this.phoneChoice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(523, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Username";
            // 
            // userBox
            // 
            this.userBox.Enabled = false;
            this.userBox.Location = new System.Drawing.Point(526, 63);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(108, 20);
            this.userBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.complimentsBox);
            this.Controls.Add(this.milliBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chooseCompl);
            this.Controls.Add(this.complActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contactsBt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.code);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.auth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hashId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apiId);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox apiId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hashId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button auth;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Button contactsBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox complActive;
        private System.Windows.Forms.Button chooseCompl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox milliBox;
        private System.Windows.Forms.RichTextBox complimentsBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem methodOfSend;
        private System.Windows.Forms.ToolStripMenuItem usernameChoice;
        private System.Windows.Forms.ToolStripMenuItem phoneChoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userBox;
    }
}

