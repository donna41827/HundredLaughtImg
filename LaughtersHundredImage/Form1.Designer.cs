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
            this.btnRotate = new System.Windows.Forms.Button();
            this.txtShowTitleStr = new System.Windows.Forms.TextBox();
            this.lblTitleTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImgW = new System.Windows.Forms.TextBox();
            this.txtImgH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitleW = new System.Windows.Forms.TextBox();
            this.txtTitleH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPicCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.pbImgLeft.Margin = new System.Windows.Forms.Padding(5);
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
            this.txtFileUrl.Margin = new System.Windows.Forms.Padding(5);
            this.txtFileUrl.Name = "txtFileUrl";
            this.txtFileUrl.Size = new System.Drawing.Size(173, 31);
            this.txtFileUrl.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(277, 16);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnSizeBig.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnSizeSmaller.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
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
            this.pictureBox1.Location = new System.Drawing.Point(396, 168);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnChoose100Img
            // 
            this.btnChoose100Img.Location = new System.Drawing.Point(865, 36);
            this.btnChoose100Img.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose100Img.Name = "btnChoose100Img";
            this.btnChoose100Img.Size = new System.Drawing.Size(131, 39);
            this.btnChoose100Img.TabIndex = 10;
            this.btnChoose100Img.Text = "選取圖片";
            this.btnChoose100Img.UseVisualStyleBackColor = true;
            this.btnChoose100Img.Click += new System.EventHandler(this.btnChoose100Img_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // BtnExportImgA2
            // 
            this.BtnExportImgA2.Location = new System.Drawing.Point(865, 81);
            this.BtnExportImgA2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportImgA2.Name = "BtnExportImgA2";
            this.BtnExportImgA2.Size = new System.Drawing.Size(131, 39);
            this.BtnExportImgA2.TabIndex = 11;
            this.BtnExportImgA2.Text = "匯出圖檔";
            this.BtnExportImgA2.UseVisualStyleBackColor = true;
            this.BtnExportImgA2.Click += new System.EventHandler(this.BtnExportImgA2_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(592, 134);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 20);
            this.lblMsg.TabIndex = 12;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(143, 378);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 39);
            this.btnRotate.TabIndex = 13;
            this.btnRotate.Text = "旋轉";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // txtShowTitleStr
            // 
            this.txtShowTitleStr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtShowTitleStr.Location = new System.Drawing.Point(587, 36);
            this.txtShowTitleStr.Multiline = true;
            this.txtShowTitleStr.Name = "txtShowTitleStr";
            this.txtShowTitleStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowTitleStr.Size = new System.Drawing.Size(271, 84);
            this.txtShowTitleStr.TabIndex = 14;
            this.txtShowTitleStr.Text = "碧湖愛笑百笑圖";
            // 
            // lblTitleTxt
            // 
            this.lblTitleTxt.AutoSize = true;
            this.lblTitleTxt.Location = new System.Drawing.Point(585, 13);
            this.lblTitleTxt.Name = "lblTitleTxt";
            this.lblTitleTxt.Size = new System.Drawing.Size(174, 20);
            this.lblTitleTxt.TabIndex = 15;
            this.lblTitleTxt.Text = "中央區塊顯示文字:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "相片張數:(寬x高)";
            // 
            // txtImgW
            // 
            this.txtImgW.Location = new System.Drawing.Point(396, 35);
            this.txtImgW.Name = "txtImgW";
            this.txtImgW.Size = new System.Drawing.Size(46, 31);
            this.txtImgW.TabIndex = 17;
            this.txtImgW.Text = "12";
            this.txtImgW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtImgW.TextChanged += new System.EventHandler(this.txtImgW_TextChanged);
            // 
            // txtImgH
            // 
            this.txtImgH.Location = new System.Drawing.Point(469, 35);
            this.txtImgH.Name = "txtImgH";
            this.txtImgH.Size = new System.Drawing.Size(46, 31);
            this.txtImgH.TabIndex = 17;
            this.txtImgH.Text = "9";
            this.txtImgH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtImgH.TextChanged += new System.EventHandler(this.txtImgH_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "中央文字張數:(寬x高)";
            // 
            // txtTitleW
            // 
            this.txtTitleW.Location = new System.Drawing.Point(396, 92);
            this.txtTitleW.Name = "txtTitleW";
            this.txtTitleW.Size = new System.Drawing.Size(46, 31);
            this.txtTitleW.TabIndex = 17;
            this.txtTitleW.Text = "4";
            this.txtTitleW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitleW.TextChanged += new System.EventHandler(this.txtTitleW_TextChanged);
            // 
            // txtTitleH
            // 
            this.txtTitleH.Location = new System.Drawing.Point(469, 92);
            this.txtTitleH.Name = "txtTitleH";
            this.txtTitleH.Size = new System.Drawing.Size(46, 31);
            this.txtTitleH.TabIndex = 17;
            this.txtTitleH.Text = "2";
            this.txtTitleH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitleH.TextChanged += new System.EventHandler(this.txtTitleH_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "圖片共";
            // 
            // lblPicCount
            // 
            this.lblPicCount.AutoSize = true;
            this.lblPicCount.Location = new System.Drawing.Point(465, 134);
            this.lblPicCount.Name = "lblPicCount";
            this.lblPicCount.Size = new System.Drawing.Size(36, 20);
            this.lblPicCount.TabIndex = 20;
            this.lblPicCount.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "張";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 617);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPicCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitleH);
            this.Controls.Add(this.txtImgH);
            this.Controls.Add(this.txtTitleW);
            this.Controls.Add(this.txtImgW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitleTxt);
            this.Controls.Add(this.txtShowTitleStr);
            this.Controls.Add(this.btnRotate);
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
        private Button btnRotate;
        private TextBox txtShowTitleStr;
        private Label lblTitleTxt;
        private Label label3;
        private TextBox txtImgW;
        private TextBox txtImgH;
        private Label label4;
        private Label label5;
        private TextBox txtTitleW;
        private TextBox txtTitleH;
        private Label label6;
        private Label label7;
        private Label lblPicCount;
        private Label label8;
    }
}

