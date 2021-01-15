using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
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
                lblMsg.Text = "";
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog2.FileNames.Length > 100) lblMsg.Text = "選取" + openFileDialog2.FileNames.Length + "張圖片，將以前100張顯示!";
                    else lblMsg.Text = "選取" + openFileDialog2.FileNames.Length + "張圖片";
                    HundredBmap = new Bitmap(A2Width, A2Height, PixelFormat.Format32bppArgb);

                    HundredBmap.MakeTransparent();
                    Graphics g = Graphics.FromImage(HundredBmap);
                    g.Clear(Color.Transparent);
                    int idx = 0;
                    for (int i = 0; i < openFileDialog2.FileNames.Length; i++)
                    {
                        if (i == 40) idx = 4;
                        else if (i == 48) idx = 8;  
                        Bitmap pBmp = new Bitmap(openFileDialog2.FileNames[i]);
                        g.DrawImage(pBmp,
                                    new Rectangle(Convert.ToInt32(Math.Round((BigBaseWH * ((i + idx) % 12.0)), 0)), Convert.ToInt32(Math.Round((BigBaseWH * Math.Floor((i + idx) / 12.0)), 0)), A2Square, A2Square),
                                    new Rectangle(0, 0, pBmp.Width, pBmp.Height),
                                    GraphicsUnit.Pixel
                                    );
                        if (i == 100) break;
                    }
                    ChkExistsTitleImg();
                    Bitmap pBmpTitle = new Bitmap(palettesPath2 + "\\Title.jpg");
                    g.DrawImage(pBmpTitle,
                                    new Rectangle(Convert.ToInt32(Math.Round((BigBaseWH * 4.0), 0)), Convert.ToInt32(Math.Round((BigBaseWH * 3.0), 0)), A2Square*4, A2Square*2),
                                    new Rectangle(0, 0, pBmpTitle.Width, pBmpTitle.Height),
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
    }
}
