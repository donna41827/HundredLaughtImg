using System;
using System.Windows.Forms;

namespace LaughtersHundredImage
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbImgLeft = new System.Windows.Forms.PictureBox();
            this.txtFileUrl = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSizeBig = new System.Windows.Forms.Button();
            this.btnSizeSmaller = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChoose100Img = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.BtnExportImgA2 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbImgLeft
            // 
            this.pbImgLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgLeft.Location = new System.Drawing.Point(29, 68);
            this.pbImgLeft.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbImgLeft.Name = "pbImgLeft";
            this.pbImgLeft.Size = new System.Drawing.Size(300, 300);
            this.pbImgLeft.TabIndex = 0;
            this.pbImgLeft.TabStop = false;
            this.pbImgLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImgLeft_MouseDown);
            this.pbImgLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImgLeft_MouseMove);
            this.pbImgLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImgLeft_MouseUp);
            this.pbImgLeft.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pbImgLeft_MouseWheel);
            // 
            // txtFileUrl
            // 
            this.txtFileUrl.Location = new System.Drawing.Point(20, 20);
            this.txtFileUrl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFileUrl.Name = "txtFileUrl";
            this.txtFileUrl.Size = new System.Drawing.Size(173, 31);
            this.txtFileUrl.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(277, 16);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(60, 39);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(203, 16);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(64, 39);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSizeBig
            // 
            this.btnSizeBig.Location = new System.Drawing.Point(260, 378);
            this.btnSizeBig.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSizeBig.Name = "btnSizeBig";
            this.btnSizeBig.Size = new System.Drawing.Size(69, 39);
            this.btnSizeBig.TabIndex = 4;
            this.btnSizeBig.Text = "放大";
            this.btnSizeBig.UseVisualStyleBackColor = true;
            this.btnSizeBig.Click += new System.EventHandler(this.btnSizeBig_Click);
            // 
            // btnSizeSmaller
            // 
            this.btnSizeSmaller.Location = new System.Drawing.Point(29, 378);
            this.btnSizeSmaller.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSizeSmaller.Name = "btnSizeSmaller";
            this.btnSizeSmaller.Size = new System.Drawing.Size(70, 39);
            this.btnSizeSmaller.TabIndex = 5;
            this.btnSizeSmaller.Text = "縮小";
            this.btnSizeSmaller.UseVisualStyleBackColor = true;
            this.btnSizeSmaller.Click += new System.EventHandler(this.btnSizeSmaller_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 492);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 427);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "確認";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(396, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnChoose100Img
            // 
            this.btnChoose100Img.Location = new System.Drawing.Point(396, 15);
            this.btnChoose100Img.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoose100Img.Name = "btnChoose100Img";
            this.btnChoose100Img.Size = new System.Drawing.Size(70, 39);
            this.btnChoose100Img.TabIndex = 10;
            this.btnChoose100Img.Text = "選取";
            this.btnChoose100Img.UseVisualStyleBackColor = true;
            this.btnChoose100Img.Click += new System.EventHandler(this.btnChoose100Img_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // BtnExportImgA2
            // 
            this.BtnExportImgA2.Location = new System.Drawing.Point(474, 15);
            this.BtnExportImgA2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExportImgA2.Name = "BtnExportImgA2";
            this.BtnExportImgA2.Size = new System.Drawing.Size(131, 39);
            this.BtnExportImgA2.TabIndex = 11;
            this.BtnExportImgA2.Text = "產出A2圖檔";
            this.BtnExportImgA2.UseVisualStyleBackColor = true;
            this.BtnExportImgA2.Click += new System.EventHandler(this.BtnExportImgA2_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(614, 25);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 20);
            this.lblMsg.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 521);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.BtnExportImgA2);
            this.Controls.Add(this.btnChoose100Img);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSizeSmaller);
            this.Controls.Add(this.btnSizeBig);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtFileUrl);
            this.Controls.Add(this.pbImgLeft);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "百笑圖產生器";
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbImgLeft;
        private System.Windows.Forms.TextBox txtFileUrl;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSizeBig;
        private System.Windows.Forms.Button btnSizeSmaller;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private PictureBox pictureBox1;
        private Button btnChoose100Img;
        private OpenFileDialog openFileDialog2;
        private Button BtnExportImgA2;
        private Label lblMsg;
    }
}

