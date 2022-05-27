namespace MetinYazariBelirleme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUploadText = new System.Windows.Forms.Button();
            this.txtMetinYolu = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnYigitAktar = new System.Windows.Forms.Button();
            this.txtCumle = new System.Windows.Forms.TextBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.txtFrekans = new System.Windows.Forms.TextBox();
            this.btnHeap = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUploadText
            // 
            this.btnUploadText.Location = new System.Drawing.Point(386, 12);
            this.btnUploadText.Name = "btnUploadText";
            this.btnUploadText.Size = new System.Drawing.Size(94, 35);
            this.btnUploadText.TabIndex = 0;
            this.btnUploadText.Text = "Metin Yukle";
            this.btnUploadText.UseVisualStyleBackColor = true;
            this.btnUploadText.Click += new System.EventHandler(this.btnUploadText_Click);
            // 
            // txtMetinYolu
            // 
            this.txtMetinYolu.Location = new System.Drawing.Point(12, 17);
            this.txtMetinYolu.Name = "txtMetinYolu";
            this.txtMetinYolu.Size = new System.Drawing.Size(368, 27);
            this.txtMetinYolu.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnYigitAktar
            // 
            this.btnYigitAktar.Location = new System.Drawing.Point(313, 53);
            this.btnYigitAktar.Name = "btnYigitAktar";
            this.btnYigitAktar.Size = new System.Drawing.Size(167, 29);
            this.btnYigitAktar.TabIndex = 2;
            this.btnYigitAktar.Text = "Yığıta Aktar";
            this.btnYigitAktar.UseVisualStyleBackColor = true;
            this.btnYigitAktar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCumle
            // 
            this.txtCumle.Location = new System.Drawing.Point(12, 93);
            this.txtCumle.Multiline = true;
            this.txtCumle.Name = "txtCumle";
            this.txtCumle.Size = new System.Drawing.Size(468, 147);
            this.txtCumle.TabIndex = 3;
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(12, 262);
            this.txtKelime.Multiline = true;
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(262, 159);
            this.txtKelime.TabIndex = 4;
            // 
            // txtFrekans
            // 
            this.txtFrekans.Location = new System.Drawing.Point(293, 262);
            this.txtFrekans.Multiline = true;
            this.txtFrekans.Name = "txtFrekans";
            this.txtFrekans.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFrekans.Size = new System.Drawing.Size(187, 159);
            this.txtFrekans.TabIndex = 5;
            // 
            // btnHeap
            // 
            this.btnHeap.Enabled = false;
            this.btnHeap.Location = new System.Drawing.Point(12, 53);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(167, 29);
            this.btnHeap.TabIndex = 6;
            this.btnHeap.Text = "Heap Aktar";
            this.btnHeap.UseVisualStyleBackColor = true;
            this.btnHeap.Click += new System.EventHandler(this.btnHeap_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(313, 53);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(167, 29);
            this.btnHash.TabIndex = 7;
            this.btnHash.Text = "Hash Tablosu Çıkar";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 458);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnHeap);
            this.Controls.Add(this.txtFrekans);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.txtCumle);
            this.Controls.Add(this.btnYigitAktar);
            this.Controls.Add(this.txtMetinYolu);
            this.Controls.Add(this.btnUploadText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUploadText;
        private TextBox txtMetinYolu;
        private OpenFileDialog openFileDialog1;
        private Button btnYigitAktar;
        private TextBox txtCumle;
        private TextBox txtKelime;
        private TextBox txtFrekans;
        private Button btnHeap;
        private Button btnHash;
    }
}