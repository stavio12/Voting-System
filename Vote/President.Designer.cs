namespace Vote
{
    partial class President
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(President));
            this.indexNo = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.RadioButton();
            this.C2 = new System.Windows.Forms.RadioButton();
            this.C3 = new System.Windows.Forms.RadioButton();
            this.C4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // indexNo
            // 
            this.indexNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexNo.Location = new System.Drawing.Point(78, 8);
            this.indexNo.Name = "indexNo";
            this.indexNo.Size = new System.Drawing.Size(192, 22);
            this.indexNo.TabIndex = 42;
            this.indexNo.Text = "Index Number";
            this.indexNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(404, 493);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(137, 32);
            this.nextBtn.TabIndex = 32;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(362, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(226, 25);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "President Candidate";
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Image = ((System.Drawing.Image)(resources.GetObject("C1.Image")));
            this.C1.Location = new System.Drawing.Point(40, 70);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(314, 168);
            this.C1.TabIndex = 43;
            this.C1.TabStop = true;
            this.C1.UseVisualStyleBackColor = true;
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Image = ((System.Drawing.Image)(resources.GetObject("C2.Image")));
            this.C2.Location = new System.Drawing.Point(579, 70);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(314, 168);
            this.C2.TabIndex = 44;
            this.C2.TabStop = true;
            this.C2.UseVisualStyleBackColor = true;
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.Image = ((System.Drawing.Image)(resources.GetObject("C3.Image")));
            this.C3.Location = new System.Drawing.Point(40, 334);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(314, 168);
            this.C3.TabIndex = 45;
            this.C3.TabStop = true;
            this.C3.UseVisualStyleBackColor = true;
            // 
            // C4
            // 
            this.C4.AutoSize = true;
            this.C4.Image = ((System.Drawing.Image)(resources.GetObject("C4.Image")));
            this.C4.Location = new System.Drawing.Point(589, 325);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(314, 168);
            this.C4.TabIndex = 46;
            this.C4.TabStop = true;
            this.C4.UseVisualStyleBackColor = true;
            // 
            // President
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 537);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.indexNo);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.Label1);
            this.Name = "President";
            this.Text = "President";
            this.Load += new System.EventHandler(this.President_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox indexNo;
        internal System.Windows.Forms.Button nextBtn;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RadioButton C1;
        internal System.Windows.Forms.RadioButton C2;
        internal System.Windows.Forms.RadioButton C3;
        internal System.Windows.Forms.RadioButton C4;
    }
}

