namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SizeCb = new System.Windows.Forms.CheckBox();
            this.Img = new System.Windows.Forms.PictureBox();
            this.OpenDlg = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SizeCb);
            this.panel1.Controls.Add(this.OpenBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 100);
            this.panel1.TabIndex = 0;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 22);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(131, 23);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Открыть файл";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SizeCb
            // 
            this.SizeCb.AutoSize = true;
            this.SizeCb.Location = new System.Drawing.Point(223, 22);
            this.SizeCb.Name = "SizeCb";
            this.SizeCb.Size = new System.Drawing.Size(122, 17);
            this.SizeCb.TabIndex = 1;
            this.SizeCb.Text = "По размерам окна";
            this.SizeCb.UseVisualStyleBackColor = true;
            this.SizeCb.CheckedChanged += new System.EventHandler(this.SizeCb_CheckedChanged);
            // 
            // Img
            // 
            this.Img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Img.Location = new System.Drawing.Point(0, 100);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(514, 363);
            this.Img.TabIndex = 1;
            this.Img.TabStop = false;
            // 
            // OpenDlg
            // 
            this.OpenDlg.Filter = "Файлы с рисунками|*.jpg;*.jpeg;*.gif;*.bmp";
            this.OpenDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenDlg_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 463);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Просмотр рисунков";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox SizeCb;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.OpenFileDialog OpenDlg;
    }
}

