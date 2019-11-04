namespace Metro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.CBMember = new MetroFramework.Controls.MetroCheckBox();
            this.Signin_link = new MetroFramework.Controls.MetroLink();
            this.pB = new System.Windows.Forms.PictureBox();
            this.InBtn = new MetroFramework.Controls.MetroButton();
            this.RegBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(270, 169);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(341, 26);
            this.LoginTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // PassTB
            // 
            this.PassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTB.Location = new System.Drawing.Point(270, 221);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '•';
            this.PassTB.Size = new System.Drawing.Size(341, 26);
            this.PassTB.TabIndex = 2;
            // 
            // CBMember
            // 
            this.CBMember.AutoSize = true;
            this.CBMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBMember.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.CBMember.Location = new System.Drawing.Point(270, 266);
            this.CBMember.Name = "CBMember";
            this.CBMember.Size = new System.Drawing.Size(131, 19);
            this.CBMember.TabIndex = 4;
            this.CBMember.Text = "Запомнить меня";
            this.CBMember.UseSelectable = true;
            this.CBMember.CheckedChanged += new System.EventHandler(this.CBMember_CheckedChanged);
            // 
            // Signin_link
            // 
            this.Signin_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signin_link.Location = new System.Drawing.Point(392, 404);
            this.Signin_link.Name = "Signin_link";
            this.Signin_link.Size = new System.Drawing.Size(102, 23);
            this.Signin_link.TabIndex = 6;
            this.Signin_link.Text = "О программе";
            this.Signin_link.UseSelectable = true;
            this.Signin_link.Click += new System.EventHandler(this.Signin_link_Click);
            // 
            // pB
            // 
            this.pB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pB.Image = ((System.Drawing.Image)(resources.GetObject("pB.Image")));
            this.pB.InitialImage = null;
            this.pB.Location = new System.Drawing.Point(368, 46);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(111, 100);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB.TabIndex = 7;
            this.pB.TabStop = false;
            this.pB.WaitOnLoad = true;
            this.pB.Click += new System.EventHandler(this.pB_Click);
            // 
            // InBtn
            // 
            this.InBtn.Location = new System.Drawing.Point(270, 318);
            this.InBtn.Name = "InBtn";
            this.InBtn.Size = new System.Drawing.Size(149, 44);
            this.InBtn.TabIndex = 8;
            this.InBtn.Text = "Войти";
            this.InBtn.UseSelectable = true;
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(462, 318);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(149, 44);
            this.RegBtn.TabIndex = 9;
            this.RegBtn.Text = "Зарегистрироваться";
            this.RegBtn.UseSelectable = true;
            this.RegBtn.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.InBtn);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.Signin_link);
            this.Controls.Add(this.CBMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox LoginTB;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PassTB;
        public MetroFramework.Controls.MetroCheckBox CBMember;
        public MetroFramework.Controls.MetroLink Signin_link;
        private System.Windows.Forms.PictureBox pB;
        public MetroFramework.Controls.MetroButton InBtn;
        public MetroFramework.Controls.MetroButton RegBtn;
    }
}

