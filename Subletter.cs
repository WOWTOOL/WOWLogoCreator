// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Subletter
// Assembly: Axxa`s Wow Logo Creator v1.2, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3199C0A8-7792-4FE1-8122-460CFE3FEFA3
// Assembly location: C:\Users\hands\Desktop\Axxa`s Wow Logo Creator v1.2.exe

using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  internal class Subletter
  {
    private string letter;
    private Image img;
    private bool passed;

    public Subletter(string letter, int type)
    {
      this.letter = letter.ToLower();
      this.passed = true;
      try
      {
        this.img = Image.FromFile(Application.StartupPath + "\\subletters\\" + type.ToString() + "\\" + letter + ".png");
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
      Artist.DrawImage(this.img, new Point(x + offsetX, y));
    }

    public int GetWidth()
    {
      if (this.passed)
        return this.img.Width;
      return 0;
    }

    public bool isL()
    {
      return this.letter == "l";
    }
  }
}
