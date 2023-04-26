namespace Lab13_Individ
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
            this.btnRazdel = new System.Windows.Forms.Button();
            this.pct = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRazdel
            // 
            this.btnRazdel.Location = new System.Drawing.Point(115, 355);
            this.btnRazdel.Name = "btnRazdel";
            this.btnRazdel.Size = new System.Drawing.Size(112, 23);
            this.btnRazdel.TabIndex = 7;
            this.btnRazdel.Text = "Раздел по RGB";
            this.btnRazdel.UseVisualStyleBackColor = true;
            this.btnRazdel.Click += new System.EventHandler(this.btnRazdel_Click);
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(31, 12);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(280, 280);
            this.pct.TabIndex = 6;
            this.pct.TabStop = false;
            this.pct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pct_MouseDown);
            this.pct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct_MouseMove);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 355);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 387);
            this.Controls.Add(this.btnRazdel);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Индивидуальное задание, вариант 10";
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRazdel;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOpen;
    }
}

