namespace LabControl
{
    partial class UserColorControl
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
            this.components = new System.ComponentModel.Container();
            this.colorNumberBoxRed = new LabControl.ColorNumberBox(this.components);
            this.colorNumberBoxGreen = new LabControl.ColorNumberBox(this.components);
            this.colorNumberBoxBlue = new LabControl.ColorNumberBox(this.components);
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.radioButtonDec = new System.Windows.Forms.RadioButton();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // colorNumberBoxRed
            // 
            this.colorNumberBoxRed.DecFormat = true;
            this.colorNumberBoxRed.Location = new System.Drawing.Point(70, 9);
            this.colorNumberBoxRed.Name = "colorNumberBoxRed";
            this.colorNumberBoxRed.Size = new System.Drawing.Size(42, 20);
            this.colorNumberBoxRed.TabIndex = 0;
            this.colorNumberBoxRed.Text = "255";
            this.colorNumberBoxRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colorNumberBoxGreen
            // 
            this.colorNumberBoxGreen.DecFormat = true;
            this.colorNumberBoxGreen.Location = new System.Drawing.Point(70, 35);
            this.colorNumberBoxGreen.Name = "colorNumberBoxGreen";
            this.colorNumberBoxGreen.Size = new System.Drawing.Size(42, 20);
            this.colorNumberBoxGreen.TabIndex = 1;
            this.colorNumberBoxGreen.Text = "255";
            this.colorNumberBoxGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colorNumberBoxBlue
            // 
            this.colorNumberBoxBlue.DecFormat = true;
            this.colorNumberBoxBlue.Location = new System.Drawing.Point(70, 61);
            this.colorNumberBoxBlue.Name = "colorNumberBoxBlue";
            this.colorNumberBoxBlue.Size = new System.Drawing.Size(42, 20);
            this.colorNumberBoxBlue.TabIndex = 2;
            this.colorNumberBoxBlue.Text = "255";
            this.colorNumberBoxBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(12, 12);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(52, 13);
            this.labelRed.TabIndex = 3;
            this.labelRed.Text = "Красный";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(12, 38);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(52, 13);
            this.labelGreen.TabIndex = 4;
            this.labelGreen.Text = "Зелёный";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(12, 64);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(38, 13);
            this.labelBlue.TabIndex = 5;
            this.labelBlue.Text = "Синий";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 134);
            this.panel1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonHex);
            this.splitContainer1.Panel1.Controls.Add(this.labelRed);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonDec);
            this.splitContainer1.Panel1.Controls.Add(this.colorNumberBoxRed);
            this.splitContainer1.Panel1.Controls.Add(this.colorNumberBoxGreen);
            this.splitContainer1.Panel1.Controls.Add(this.labelBlue);
            this.splitContainer1.Panel1.Controls.Add(this.colorNumberBoxBlue);
            this.splitContainer1.Panel1.Controls.Add(this.labelGreen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxColor);
            this.splitContainer1.Size = new System.Drawing.Size(264, 134);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 0;
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Location = new System.Drawing.Point(66, 98);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(44, 17);
            this.radioButtonHex.TabIndex = 8;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonDec
            // 
            this.radioButtonDec.AutoSize = true;
            this.radioButtonDec.Location = new System.Drawing.Point(15, 98);
            this.radioButtonDec.Name = "radioButtonDec";
            this.radioButtonDec.Size = new System.Drawing.Size(45, 17);
            this.radioButtonDec.TabIndex = 7;
            this.radioButtonDec.TabStop = true;
            this.radioButtonDec.Text = "Dec";
            this.radioButtonDec.UseVisualStyleBackColor = true;
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxColor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(132, 134);
            this.pictureBoxColor.TabIndex = 0;
            this.pictureBoxColor.TabStop = false;
            // 
            // UserColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "UserColorControl";
            this.Size = new System.Drawing.Size(264, 134);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ColorNumberBox colorNumberBoxRed;
        private ColorNumberBox colorNumberBoxGreen;
        private ColorNumberBox colorNumberBoxBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.RadioButton radioButtonDec;
        private System.Windows.Forms.RadioButton radioButtonHex;
    }
}
