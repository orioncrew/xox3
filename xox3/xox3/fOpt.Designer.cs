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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clbX = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игрок Х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(304, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игрок О";
            // 
            // clbX
            // 
            this.clbX.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbX.FormattingEnabled = true;
            this.clbX.Items.AddRange(new object[] {
            "Человек",
            "Компьютер"});
            this.clbX.Location = new System.Drawing.Point(64, 110);
            this.clbX.Name = "clbX";
            this.clbX.Size = new System.Drawing.Size(191, 84);
            this.clbX.TabIndex = 2;
            // 
            // fOpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::xox3.Properties.Resources.blue_curves_Abstract_art_design_wallpaper_medium;
            this.ClientSize = new System.Drawing.Size(512, 433);
            this.Controls.Add(this.clbX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fOpt";
            this.Text = "Насройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbX;
    }
}