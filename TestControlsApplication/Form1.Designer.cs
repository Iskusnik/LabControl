﻿namespace TestControlsApplication
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
            this.components = new System.ComponentModel.Container();
            this.colorNumberBox1 = new LabControl.ColorNumberBox(this.components);
            this.userColorControl1 = new LabControl.UserColorControl();
            this.SuspendLayout();
            // 
            // colorNumberBox1
            // 
            this.colorNumberBox1.DecFormat = true;
            this.colorNumberBox1.Location = new System.Drawing.Point(523, 71);
            this.colorNumberBox1.Name = "colorNumberBox1";
            this.colorNumberBox1.Size = new System.Drawing.Size(100, 20);
            this.colorNumberBox1.TabIndex = 0;
            // 
            // userColorControl1
            // 
            this.userColorControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userColorControl1.ColorValue = System.Drawing.Color.Empty;
            this.userColorControl1.Location = new System.Drawing.Point(322, 135);
            this.userColorControl1.Name = "userColorControl1";
            this.userColorControl1.Size = new System.Drawing.Size(264, 134);
            this.userColorControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 493);
            this.Controls.Add(this.userColorControl1);
            this.Controls.Add(this.colorNumberBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabControl.ColorNumberBox colorNumberBox1;
        private LabControl.UserColorControl userColorControl1;
    }
}

