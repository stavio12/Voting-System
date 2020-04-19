namespace login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.index = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.LGbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // index
            // 
            this.index.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index.Location = new System.Drawing.Point(656, 187);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(192, 22);
            this.index.TabIndex = 1;
            this.index.Text = "Username/Email";
            this.index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(656, 300);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(192, 22);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LGbtn
            // 
            this.LGbtn.Location = new System.Drawing.Point(684, 377);
            this.LGbtn.Name = "LGbtn";
            this.LGbtn.Size = new System.Drawing.Size(134, 31);
            this.LGbtn.TabIndex = 3;
            this.LGbtn.Text = "Login";
            this.LGbtn.UseVisualStyleBackColor = true;
            this.LGbtn.Click += new System.EventHandler(this.LGbtn_Click);
            // 
            // LoginForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 499);
            this.Controls.Add(this.LGbtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.index);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button loginBtn;
        internal System.Windows.Forms.TextBox PasswordText;
        internal System.Windows.Forms.TextBox usernameText;
        internal System.Windows.Forms.TextBox index;
        internal System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button LGbtn;
    }
}