namespace NumberEaterProject.Panels
{
    partial class CheckPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPanel));
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxChT = new System.Windows.Forms.TextBox();
            this.textBoxChN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRead
            // 
            this.textBoxRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRead.Font = new System.Drawing.Font("Post Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRead.Location = new System.Drawing.Point(354, 215);
            this.textBoxRead.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.Size = new System.Drawing.Size(80, 36);
            this.textBoxRead.TabIndex = 0;
            this.textBoxRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRead_KeyDown);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(525, 447);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBoxChT
            // 
            this.textBoxChT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChT.Font = new System.Drawing.Font("Post Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChT.Location = new System.Drawing.Point(184, 115);
            this.textBoxChT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChT.Name = "textBoxChT";
            this.textBoxChT.Size = new System.Drawing.Size(154, 36);
            this.textBoxChT.TabIndex = 1;
            this.textBoxChT.Text = "Если Х=";
            // 
            // textBoxChN
            // 
            this.textBoxChN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChN.Font = new System.Drawing.Font("Post Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChN.Location = new System.Drawing.Point(279, 115);
            this.textBoxChN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChN.Name = "textBoxChN";
            this.textBoxChN.Size = new System.Drawing.Size(59, 36);
            this.textBoxChN.TabIndex = 2;
            this.textBoxChN.Text = "-153";
            this.textBoxChN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.textBoxChN);
            this.Controls.Add(this.textBoxChT);
            this.Controls.Add(this.textBoxRead);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckPanel";
            this.Size = new System.Drawing.Size(525, 447);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxChT;
        private System.Windows.Forms.TextBox textBoxChN;
    }
}
