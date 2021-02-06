using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace LaughtersHundredImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sEditImgPath = "";
        int MouseDownX = 0;
        int MouseDownY = 0;
        bool MouseDrapFlag = false;
        double ReSizeRate = 1;
        int ImgX = 0;
        int ImgY = 0;
        int A2Width = 6480;
        int A2Height = 4860;
        int A2Square = 540;
        Bitmap HundredBmap;
        string palettesPath = "c:\\LaughtersHundredImg";
        string palettesPath2 = "c:\\LaughtersHundredImg\\Title";
        int iRotateTimes = 0;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                var fileStream = openFileDialog1.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                txtFileUrl.Text = filePath;
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            sEditImgPath = txtFileUrl.Text;
            pbImgLeft.Load(txtFileUrl.Text);
            Bitmap b = new Bitmap(sEditImgPath);
            ReSizeRate = 1;
            ImgX = 0;
            ImgY = 0;
            pbImgLeft.Focus();
            //label1.Text = "ReSizeRate:" + ReSizeRate + ",ImgX:" + ImgX + ",ImgY:" + ImgY;
        }
        private void ScaleImage(int MouseX, int MouseY, double Rate)
        {
            try
            {
                Bitmap pBmp = new Bitmap(sEditImgPath);
                ReSizeRate = ReSizeRate * Rate;
                ImgX = MouseX - Convert.ToInt32(Math.Round((MouseX - ImgX) * Rate, 0));
                ImgY = MouseY - Convert.ToInt32(Math.Round((MouseY - ImgY) * Rate, 0));
                Bitmap tmpBmp = new Bitmap(300, 300);
                Graphics g = Graphics.FromImage(tmpBmp);
                g.DrawImage(pBmp,
                            new Rectangle(ImgX, ImgY, Convert.ToInt32(Math.Round(pBmp.Width * ReSizeRate, 0)), Convert.ToInt32(Math.Round(pBmp.Height * ReSizeRate, 0))),
                            new Rectangle(0, 0, pBmp.Width, pBmp.Height),
                            GraphicsUnit.Pixel
                            );
                pbImgLeft.Image = tmpBmp;
                g.Dispose();
                //label1.Text = "ReSizeRate:" + ReSizeRate + ",ImgX:" + ImgX + ",ImgY:" + ImgY + ",Rate:" + Rate + ",pBmp.Width:" + pBmp.Width + ",pBmp.Height:" + pBmp.Height + ",CalW:" + Convert.ToInt32(Math.Round(pBmp.Width * ReSizeRate, 0)) + ",CALH:" + Convert.ToInt32(Math.Round(pBmp.Height * ReSizeRate, 0));

            }
            catch (Exception ex) { }
        }
        private Bitmap MoveImage(int MouseX, int MouseY)
        {
            try
            {
                Bitmap pBmp = new Bitmap(sEditImgPath);
                Bitmap tmpBmp = new Bitmap(300, 300);
                Graphics g = Graphics.FromImage(tmpBmp);
                g.DrawImage(pBmp,
                            new Rectangle(ImgX + (MouseX - MouseDownX), ImgY + (MouseY - MouseDownY), Convert.ToInt32(Math.Round(pBmp.Width * ReSizeRate, 0)), Convert.ToInt32(Math.Round(pBmp.Height * ReSizeRate, 0))),
                            new Rectangle(0, 0, pBmp.Width, pBmp.Height),
                            GraphicsUnit.Pixel
                            );
                pbImgLeft.Image = tmpBmp;
                g.Dispose();
                //label1.Text = "ReSizeRate:" + ReSizeRate + ",ImgX:" + ImgX + ",ImgY:" + ImgY + ",pBmp.Width:" + pBmp.Width + ",pBmp.Height:" + pBmp.Height + ",CalW:" + Convert.ToInt32(Math.Round(pBmp.Width * ReSizeRate, 0)) + ",CALH:" + Convert.ToInt32(Math.Round(pBmp.Height * ReSizeRate, 0));
                return tmpBmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Bitmap pBmp = new Bitmap(sEditImgPath);
            //    Bitmap tmpBmp = new Bitmap(300, 300);
            //    int x, y = 0;
            //    RotateImg(pBmp,(0-ImgX)/ReSizeRate* pBmp.Width)
            //    Graphics g = Graphics.FromImage(tmpBmp);
            //    g.DrawImage(pBmp,
            //                new Rectangle(0, 0, Convert.ToInt32(Math.Round(pBmp.Width * ReSizeRate, 0)), Convert.ToInt32(Math.Round(pBmp.Height * ReSizeRate, 0))),
            //                new Rectangle(0, 0, pBmp.Width, pBmp.Height),
            //                GraphicsUnit.Pixel
            //                );
            //    pbImgLeft.Image = tmpBmp;
            //    g.Dispose();
            //    //label1.Text = "ReSizeRate:" + ReSizeRate + ",ImgX:" + ImgX + ",ImgY:" + ImgY + ",pBmp.Width:" + pBmp.Width + ",pBmp.Height:" + pBmp.Height + ",CalW:" + Convert.ToInt32(Math.Round(pBmp.Width * ReSizeRate, 0)) + ",CALH:" + Convert.ToInt32(Math.Round(pBmp.Height * ReSizeRate, 0));

            //}
            //catch (Exception ex)
            //{

            //}
        }
        private Bitmap RotateImg(Bitmap Bmp, ref int x, ref int y)
        {
            x = 0 - (Bmp.Height - 300 - y);
            y = 0 - (Bmp.Width - 300 - x);
            CalNextRotateTimes();
            //iRotateTimes
            if (iRotateTimes == 1)
            {
                Bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (iRotateTimes == 2)
            {
                Bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (iRotateTimes == 3)
            {
                Bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            return Bmp;
        }
        private void CalNextRotateTimes()
        {
            if (iRotateTimes == 3) iRotateTimes = 0;
            else iRotateTimes++;
        }
        private void btnSizeBig_Click(object sender, EventArgs e)
        {
            ScaleImage(150, 150, 1.1);
        }
        private void btnSizeSmaller_Click(object sender, EventArgs e)
        {
            ScaleImage(150, 150, 0.9);
        }
        private void pbImgLeft_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ScaleImage(e.X, e.Y, 1.1);
            }
            else if (e.Delta < 0)
            {
                ScaleImage(e.X, e.Y, 0.9);
            }
        }
        private void pbImgLeft_MouseDown(object sender, MouseEventArgs e)
        {
            pbImgLeft.Focus();
            MouseDownX = e.X;
            MouseDownY = e.Y;
            MouseDrapFlag = true;
        }
        private void pbImgLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDrapFlag)
            {
                MoveImage(e.X, e.Y);
            }
            //label2.Text = "x:" + e.X + ",y:" + e.Y;
        }
        private void pbImgLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseDrapFlag)
            {
                MoveImage(e.X, e.Y);
                ImgX = ImgX + (e.X - MouseDownX);
                ImgY = ImgY + (e.Y - MouseDownY);
                //label2.Text = "UP_x:" + ImgX + ",y:" + ImgY;
            }
            MouseDrapFlag = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap pBmp = new Bitmap(sEditImgPath);
                Bitmap tmpBmp = new Bitmap(A2Square, A2Square);
                Graphics tmpG = Graphics.FromImage(tmpBmp);
                tmpG.DrawImage(pBmp,
                               new Rectangle(Convert.ToInt32(Math.Round(Convert.ToDouble(ImgX) * A2Square / 300.0, 0)),
                                             Convert.ToInt32(Math.Round(Convert.ToDouble(ImgY) * A2Square / 300.0, 0)),
                                             Convert.ToInt32(Math.Round(Convert.ToDouble(pBmp.Width) * ReSizeRate * A2Square / 300.0, 0)),
                                             Convert.ToInt32(Math.Round(Convert.ToDouble(pBmp.Height) * ReSizeRate * A2Square / 300.0, 0))),
                               new Rectangle(0,
                                             0,
                                             pBmp.Width, pBmp.Height),
                               GraphicsUnit.Pixel);
                Bitmap GBitMap = new Bitmap(A2Square, A2Square, tmpG);
                //label1.Text = "ReSizeRate:" + ReSizeRate + ",X:" + Convert.ToInt32(Math.Round(Convert.ToDouble(ImgX) * A2Square / 300.0, 0)) + ",Y:" + Convert.ToInt32(Math.Round(Convert.ToDouble(ImgY) * A2Square / 300.0, 0));
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                string curDir;
                curDir = GetImgStoragePath(palettesPath);//Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\Image");
                saveFileDialog1.InitialDirectory = curDir;

                saveFileDialog1.Filter = "JPG File|*.jpg";
                saveFileDialog1.Title = "儲存影像檔";
                saveFileDialog1.FilterIndex = 3;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveJpeg(saveFileDialog1.FileName, tmpBmp, 85);
                }
                tmpG.Dispose();
            }
            catch (Exception ex) { }
        }
        private void saveJpeg(string path, Bitmap img, long quality)
        {
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, quality);
            ImageCodecInfo jpegCodec = this.getEncoderInfo("image/png");
            if (jpegCodec == null) return;
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            img.Save(path, jpegCodec, encoderParams);
        }
        private ImageCodecInfo getEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];
            return null;
        }
        private void btnChoose100Img_Click(object sender, EventArgs e)
        {
            if (TryParseInt(lblPicCount.Text.Trim(), 0) == 0) return;
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;
                openFileDialog2.InitialDirectory = GetImgStoragePath(palettesPath2);//Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\Image");
                openFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog2.FilterIndex = 2;
                openFileDialog2.RestoreDirectory = true;
                openFileDialog2.Multiselect = true;

                //基準座標(留白邊)
                //double BaseX = 17.79;
                //double BaseY = 23.99;
                //double BigBaseX = 208;
                //double BigBaseY = 280.5;
                //int BaseWH = 47;
                int BigBaseWH = A2Square;
                int TitleH = TryParseInt(txtTitleH.Text, 0);
                int TitleW = TryParseInt(txtTitleW.Text, 0);
                int ImgH = TryParseInt(txtImgH.Text, 0);
                int ImgW = TryParseInt(txtImgW.Text, 0);
                int BeginTitleW = (int)(Math.Floor((ImgW - TitleW) / 2.0));
                int BeginTitleH = (int)(Math.Floor((ImgH - TitleH) / 2.0));
                lblMsg.Text = "";
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog2.FileNames.Length > TryParseInt(lblPicCount.Text, 100)) lblMsg.Text = "選取" + openFileDialog2.FileNames.Length + "張圖片，將以前" + lblPicCount.Text + "張顯示!";
                    else lblMsg.Text = "選取" + openFileDialog2.FileNames.Length + "張圖片";
                    HundredBmap = new Bitmap(A2Square * ImgW, A2Square * ImgH, PixelFormat.Format32bppArgb);

                    HundredBmap.MakeTransparent();
                    Graphics g = Graphics.FromImage(HundredBmap);
                    g.Clear(Color.Transparent);
                    int idx = 0;
                    int idxTitleH = 1;

                    for (int i = 0; i < openFileDialog2.FileNames.Length; i++)
                    {
                        if (i == (BeginTitleH * ImgW + BeginTitleW + BeginTitleW * (idxTitleH - 1) + (ImgW - BeginTitleW - TitleW) * (idxTitleH - 1)) && idxTitleH <= TitleH)
                        {
                            idx += TitleW;
                            idxTitleH++;
                        }
                        Bitmap pBmp = new Bitmap(openFileDialog2.FileNames[i]);
                        g.DrawImage(pBmp,
                                    new Rectangle(Convert.ToInt32(Math.Round((BigBaseWH * ((i + idx) % (decimal)ImgW)), 0)),
                                                  Convert.ToInt32(Math.Round((BigBaseWH * Math.Floor((i + idx) / (decimal)ImgW)), 0)),
                                                  A2Square, A2Square),
                                    new Rectangle(0, 0, pBmp.Width, pBmp.Height),
                                    GraphicsUnit.Pixel
                                    );
                        if (i == TryParseInt(lblPicCount.Text, 100) - 1) break;
                    }
                    //ChkExistsTitleImg();
                    //Bitmap pBmpTitle = new Bitmap(palettesPath2 + "\\Title.jpg");
                    //g.DrawImage(pBmpTitle,
                    //                new Rectangle(Convert.ToInt32(Math.Round((BigBaseWH * 4.0), 0)), Convert.ToInt32(Math.Round((BigBaseWH * 3.0), 0)), A2Square * 4, A2Square * 2),
                    //                new Rectangle(0, 0, pBmpTitle.Width, pBmpTitle.Height),
                    //                GraphicsUnit.Pixel
                    //                );
                    Bitmap bTitle = new Bitmap(A2Square * TryParseInt(txtTitleW.Text, 0), A2Square * TryParseInt(txtTitleH.Text, 0));
                    Graphics gTitle = Graphics.FromImage(bTitle);
                    bTitle.MakeTransparent();
                    gTitle.Clear(Color.White);
                    Font font1 = new Font("微軟正黑體", 120, FontStyle.Bold, GraphicsUnit.Pixel);
                    Rectangle rect1 = new Rectangle(0, 0, A2Square * TryParseInt(txtTitleW.Text, 0), A2Square * TryParseInt(txtTitleH.Text, 0));
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    gTitle.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    Font goodFont = FindFont(gTitle, txtShowTitleStr.Text, rect1.Size, font1);
                    gTitle.DrawString(txtShowTitleStr.Text, goodFont, Brushes.Gray, rect1, stringFormat);
                    g.DrawImage(bTitle,
                                    new Rectangle((int)(A2Square * Math.Floor((TryParseInt(txtImgW.Text, 0) - TryParseInt(txtTitleW.Text, 0)) / 2.0)),
                                                  (int)(A2Square * Math.Floor((TryParseInt(txtImgH.Text, 0) - TryParseInt(txtTitleH.Text, 0)) / 2.0)),
                                                  A2Square * TryParseInt(txtTitleW.Text, 0),
                                                  A2Square * TryParseInt(txtTitleH.Text, 0)),
                                    rect1,
                                    GraphicsUnit.Pixel
                                    );
                    pictureBox1.Image = HundredBmap;

                }
            }
            catch (Exception ex)
            {
                //    lblMsg.Text = ex.ToString();
            }
        }
        private Font FindFont(System.Drawing.Graphics g, string longString, Size Room, Font PreferedFont)
        {
            // you should perform some scale functions!!!
            string[] ArrStr = Regex.Split(longString, "\r\n", RegexOptions.IgnoreCase);

            SizeF RealSize = g.MeasureString(longString, PreferedFont);

            float HeightScaleRatio = Room.Height / RealSize.Height;
            float WidthScaleRatio = Room.Width / RealSize.Width;

            float ScaleRatio = (HeightScaleRatio < WidthScaleRatio)
               ? ScaleRatio = HeightScaleRatio
               : ScaleRatio = WidthScaleRatio;

            float ScaleFontSize = PreferedFont.Size * ScaleRatio;

            return new Font(PreferedFont.FontFamily, ScaleFontSize);
        }

        private void BtnExportImgA2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string curDir;
            curDir = "c:\\";//GetImgStoragePath(palettesPath);//Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
            saveFileDialog1.InitialDirectory = curDir;

            saveFileDialog1.Filter = "PNG File|*.png";
            saveFileDialog1.Title = "儲存影像檔";
            saveFileDialog1.FilterIndex = 3;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveJpeg(saveFileDialog1.FileName, HundredBmap, 100);
            }
        }
        private string GetImgStoragePath(string sPalettesPath)
        {
            try
            {
                if (!Directory.Exists(sPalettesPath))
                {
                    Directory.CreateDirectory(sPalettesPath);
                }
            }
            catch (Exception ex)
            {

            }
            return palettesPath;
        }
        private void ChkExistsTitleImg()
        {
            try
            {
                if (!Directory.Exists(palettesPath2))
                {
                    Directory.CreateDirectory(palettesPath2);
                }
                if (!File.Exists(palettesPath2 + "\\Title.jpg"))
                {
                    //Bitmap bTitle = new Bitmap(@"../../Resources/Title.jpg");
                    Bitmap bTitle = new Bitmap(Properties.Resources.Title);
                    saveJpeg(palettesPath2 + "\\Title.jpg", bTitle, 100);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtImgW_TextChanged(object sender, EventArgs e)
        {
            ReCalPicCount();
        }

        private void txtImgH_TextChanged(object sender, EventArgs e)
        {
            ReCalPicCount();
        }

        private void txtTitleW_TextChanged(object sender, EventArgs e)
        {
            ReCalPicCount();
        }

        private void txtTitleH_TextChanged(object sender, EventArgs e)
        {
            ReCalPicCount();
        }
        private void ReCalPicCount()
        {
            int imgW = TryParseInt(txtImgW.Text, 0);
            int imgH = TryParseInt(txtImgH.Text, 0);
            int TitleW = TryParseInt(txtTitleW.Text, 0);
            int TitleH = TryParseInt(txtTitleH.Text, 0);
            if (chkImgAndTitle(imgW, imgH, TitleW, TitleH))
            {
                lblPicCount.Text = (imgW * imgH - TitleW * TitleH).ToString();
                lblMsg.Text = "";
            }
            else
            {
                lblPicCount.Text = "--";
                lblMsg.Text = "圖片張數錯誤，圖片寬高不足包裹文字";
            }
        }
        private bool chkImgAndTitle(int imgW, int imgH, int TitleW, int TitleH)
        {
            if ((imgW - 2) < TitleW) return false;
            else if ((imgH - 2) < TitleH) return false;
            else return true;
        }
        private int TryParseInt(string str, int def)
        {
            int ret = def;
            bool Success = Int32.TryParse(str.Trim().Replace(",", ""), out ret);
            return ret;
        }
    }
}
