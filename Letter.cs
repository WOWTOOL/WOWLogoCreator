// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Letter
// Assembly: Axxa`s Wow Logo Creator v1.2, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3199C0A8-7792-4FE1-8122-460CFE3FEFA3
// Assembly location: C:\Users\hands\Desktop\Axxa`s Wow Logo Creator v1.2.exe

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  internal class Letter
  {
    private string letter;
    private Image img;
    private bool passed;

    public Letter(string letter, int scale)
    {
      this.letter = letter.ToLower();
      this.passed = true;
      try
      {
        if (scale != 100)
          this.img = Letter.ScaleByPercent(Image.FromFile(Application.StartupPath + "\\letters\\" + letter + ".png"), scale);
        else
          this.img = Image.FromFile(Application.StartupPath + "\\letters\\" + letter + ".png");
      }
      catch
      {
        this.passed = false;
      }
    }

    public void Draw(int x, int y, Graphics Artist, int offsetX, int offsetY)
    {
      if (!this.passed)
        return;
      if (this.letter == "'")
        Artist.DrawImage(this.img, new Point(x + offsetX, y + offsetY + 30));
      else if (this.img.Height == 130)
        Artist.DrawImage(this.img, new Point(x + offsetX, y + offsetY + (145 - this.img.Height)));
      else
        Artist.DrawImage(this.img, new Point(x + offsetX, y + offsetY + (140 - this.img.Height)));
    }

    public int GetWidth()
    {
      if (this.passed)
        return this.img.Width;
      return 0;
    }

    private static Image ScaleByPercent(Image imgPhoto, int Percent)
    {
      float num = (float) Percent / 100f;
      int width1 = imgPhoto.Width;
      int height1 = imgPhoto.Height;
      int x1 = 0;
      int y1 = 0;
      int x2 = 0;
      int y2 = 0;
      int width2 = (int) ((double) width1 * (double) num);
      int height2 = (int) ((double) height1 * (double) num);
      Bitmap bitmap = new Bitmap(width2, height2, PixelFormat.Format32bppArgb);
      bitmap.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
      graphics.DrawImage(imgPhoto, new Rectangle(x2, y2, width2, height2), new Rectangle(x1, y1, width1, height1), GraphicsUnit.Pixel);
      graphics.Dispose();
      return (Image) bitmap;
    }
  }
}
