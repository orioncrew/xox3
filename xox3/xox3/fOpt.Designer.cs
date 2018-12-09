namespace xox3
{
    partial class fOpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOpt));
            this.rbCompX = new System.Windows.Forms.RadioButton();
            this.rbHumanX = new System.Windows.Forms.RadioButton();
            this.rbCompO = new System.Windows.Forms.RadioButton();
            this.rbHumanO = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStartO = new System.Windows.Forms.RadioButton();
            this.rbStartX = new System.Windows.Forms.RadioButton();
            this.btOptClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbO = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbX = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbO)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCompX
            // 
            this.rbCompX.AutoSize = true;
            this.rbCompX.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCompX.Location = new System.Drawing.Point(20, 93);
            this.rbCompX.Name = "rbCompX";
            this.rbCompX.Size = new System.Drawing.Size(194, 43);
            this.rbCompX.TabIndex = 1;
            this.rbCompX.Text = "Компьютер";
            this.rbCompX.UseVisualStyleBackColor = true;
            // 
            // rbHumanX
            // 
            this.rbHumanX.AutoSize = true;
            this.rbHumanX.Checked = true;
            this.rbHumanX.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHumanX.Location = new System.Drawing.Point(20, 44);
            this.rbHumanX.Name = "rbHumanX";
            this.rbHumanX.Size = new System.Drawing.Size(148, 43);
            this.rbHumanX.TabIndex = 0;
            this.rbHumanX.TabStop = true;
            this.rbHumanX.Text = "Человек";
            this.rbHumanX.UseVisualStyleBackColor = true;
            this.rbHumanX.CheckedChanged += new System.EventHandler(this.rbHumanX_CheckedChanged);
            // 
            // rbCompO
            // 
            this.rbCompO.AutoSize = true;
            this.rbCompO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbCompO.Checked = true;
            this.rbCompO.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCompO.Location = new System.Drawing.Point(15, 93);
            this.rbCompO.Name = "rbCompO";
            this.rbCompO.Size = new System.Drawing.Size(194, 43);
            this.rbCompO.TabIndex = 1;
            this.rbCompO.TabStop = true;
            this.rbCompO.Text = "Компьютер";
            this.rbCompO.UseVisualStyleBackColor = false;
            // 
            // rbHumanO
            // 
            this.rbHumanO.AutoSize = true;
            this.rbHumanO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbHumanO.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHumanO.Location = new System.Drawing.Point(15, 44);
            this.rbHumanO.Name = "rbHumanO";
            this.rbHumanO.Size = new System.Drawing.Size(148, 43);
            this.rbHumanO.TabIndex = 0;
            this.rbHumanO.Text = "Человек";
            this.rbHumanO.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rbStartO);
            this.groupBox1.Controls.Add(this.rbStartX);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Первый ход";
            // 
            // rbStartO
            // 
            this.rbStartO.AutoSize = true;
            this.rbStartO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbStartO.Location = new System.Drawing.Point(281, 44);
            this.rbStartO.Name = "rbStartO";
            this.rbStartO.Size = new System.Drawing.Size(148, 43);
            this.rbStartO.TabIndex = 1;
            this.rbStartO.Text = "Игрок О";
            this.rbStartO.UseVisualStyleBackColor = false;
            // 
            // rbStartX
            // 
            this.rbStartX.AutoSize = true;
            this.rbStartX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbStartX.Checked = true;
            this.rbStartX.Location = new System.Drawing.Point(33, 44);
            this.rbStartX.Name = "rbStartX";
            this.rbStartX.Size = new System.Drawing.Size(146, 43);
            this.rbStartX.TabIndex = 0;
            this.rbStartX.TabStop = true;
            this.rbStartX.Text = "Игрок Х";
            this.rbStartX.UseVisualStyleBackColor = false;
            this.rbStartX.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btOptClose
            // 
            this.btOptClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btOptClose.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOptClose.Location = new System.Drawing.Point(141, 375);
            this.btOptClose.Name = "btOptClose";
            this.btOptClose.Size = new System.Drawing.Size(185, 46);
            this.btOptClose.TabIndex = 5;
            this.btOptClose.Text = "Закрыть";
            this.btOptClose.UseVisualStyleBackColor = false;
            this.btOptClose.Click += new System.EventHandler(this.btOptClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbO);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(15, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сложность";
            // 
            // tbO
            // 
            this.tbO.Location = new System.Drawing.Point(10, 27);
            this.tbO.Name = "tbO";
            this.tbO.Size = new System.Drawing.Size(164, 56);
            this.tbO.TabIndex = 0;
            this.tbO.Value = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbX);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(20, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сложность";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(14, 27);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(165, 56);
            this.tbX.TabIndex = 0;
            this.tbX.Value = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.rbHumanX);
            this.groupBox4.Controls.Add(this.rbCompX);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 242);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Игрок Х";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.rbHumanO);
            this.groupBox5.Controls.Add(this.rbCompO);
            this.groupBox5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(246, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(224, 242);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Игрок О";
            // 
            // fOpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::xox3.Properties.Resources.blue_curves_Abstract_art_design_wallpaper_medium;
            this.ClientSize = new System.Drawing.Size(482, 433);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btOptClose);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fOpt";
            this.Text = "Насройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbO)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCompX;
        private System.Windows.Forms.RadioButton rbHumanX;
        private System.Windows.Forms.RadioButton rbCompO;
        private System.Windows.Forms.RadioButton rbHumanO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStartO;
        private System.Windows.Forms.RadioButton rbStartX;
        private System.Windows.Forms.Button btOptClose;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TrackBar tbO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tbX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}