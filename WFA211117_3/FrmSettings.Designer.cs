namespace WFA211117_3
{
    partial class FrmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudMagassag = new System.Windows.Forms.NumericUpDown();
            this.nudDbAkna = new System.Windows.Forms.NumericUpDown();
            this.nudScale = new System.Windows.Forms.NumericUpDown();
            this.nudSzelesseg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagassag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDbAkna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzelesseg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.nudMagassag);
            this.groupBox1.Controls.Add(this.nudDbAkna);
            this.groupBox1.Controls.Add(this.nudScale);
            this.groupBox1.Controls.Add(this.nudSzelesseg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(257, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beállítások";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 206);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(243, 57);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Játék indítása!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // nudMagassag
            // 
            this.nudMagassag.Location = new System.Drawing.Point(124, 67);
            this.nudMagassag.Name = "nudMagassag";
            this.nudMagassag.Size = new System.Drawing.Size(73, 26);
            this.nudMagassag.TabIndex = 1;
            this.nudMagassag.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudDbAkna
            // 
            this.nudDbAkna.Location = new System.Drawing.Point(124, 117);
            this.nudDbAkna.Name = "nudDbAkna";
            this.nudDbAkna.Size = new System.Drawing.Size(73, 26);
            this.nudDbAkna.TabIndex = 1;
            this.nudDbAkna.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudScale
            // 
            this.nudScale.Location = new System.Drawing.Point(124, 159);
            this.nudScale.Name = "nudScale";
            this.nudScale.Size = new System.Drawing.Size(73, 26);
            this.nudScale.TabIndex = 1;
            this.nudScale.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudSzelesseg
            // 
            this.nudSzelesseg.Location = new System.Drawing.Point(17, 67);
            this.nudSzelesseg.Name = "nudSzelesseg";
            this.nudSzelesseg.Size = new System.Drawing.Size(73, 26);
            this.nudSzelesseg.TabIndex = 1;
            this.nudSzelesseg.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Képarány:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aknák száma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pálya mérete:";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 341);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagassag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDbAkna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzelesseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudMagassag;
        private System.Windows.Forms.NumericUpDown nudDbAkna;
        private System.Windows.Forms.NumericUpDown nudScale;
        private System.Windows.Forms.NumericUpDown nudSzelesseg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}