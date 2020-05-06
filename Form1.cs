// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Form1
// Assembly: Axxa`s Wow Logo Creator v1.2, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3199C0A8-7792-4FE1-8122-460CFE3FEFA3
// Assembly location: C:\Users\hands\Desktop\Axxa`s Wow Logo Creator v1.2.exe

using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
  public class Form1 : Form
  {
    private Bitmap let;
    private Bitmap sublet;
    private Bitmap bmp;
    private List<Letter> letters;
    private List<Subletter> subletter;
    private Image im;
    private bool adjustable;
    private int adjustableType;
    private int subtextID;
    private IContainer components;
    private PictureBox pictureBox1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabControl tabControl2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private Label label1;
    private PictureBox pictureBox9;
    private PictureBox pictureBox10;
    private PictureBox pictureBox11;
    private PictureBox pictureBox12;
    private PictureBox pictureBox13;
    private PictureBox pictureBox14;
    private PictureBox pictureBox15;
    private Label label2;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private PictureBox pictureBox6;
    private PictureBox pictureBox7;
    private PictureBox pictureBox8;
    private PictureBox pictureBox18;
    private PictureBox pictureBox17;
    private PictureBox pictureBox16;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label19;
    private Label label18;
    private Label label17;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label13;
    private Label label12;
    private Label label11;
    private Label label10;
    private Button button1;
    private Button button2;
    private CheckBox checkBox1;
    private TextBox textBox2;
    private Label label21;
    private TextBox textBox1;
    private Label label20;
    private Label label23;
    private NumericUpDown numericUpDown2;
    private Label label22;
    private NumericUpDown numericUpDown1;
    private CheckBox checkBox4;
    private CheckBox checkBox5;
    private CheckBox checkBox3;
    private CheckBox checkBox2;
    private HScrollBar hScrollBar1;
    private HScrollBar hScrollBar2;
    private VScrollBar vScrollBar2;
    private VScrollBar vScrollBar1;
    private Label label24;
    private CheckBox checkBox6;
    private Label label25;
    private ColorDialog colorDialog1;
    private TabPage tabPage5;
    private Label label26;
    private Label label27;
    private PictureBox pictureBox19;
    private TrackBar trackBar1;
    private Label label28;
    private TrackBar trackBar4;
    private Label label31;
    private TrackBar trackBar3;
    private Label label30;
    private TrackBar trackBar2;
    private Label label29;
    private Button button3;
    private Timer timer1;
    private CheckBox checkBox7;
    private ComboBox comboBox1;
    private Label label32;
    private Label label33;
    private SaveFileDialog saveFileDialog1;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.comboBox1.Text = "Custom";
      this.adjustableType = 0;
      this.subtextID = 3;
      this.let = new Bitmap(1, 1);
      this.sublet = new Bitmap(1, 1);
      this.adjustable = false;
      this.im = (Image) Resources.cataclysm;
      this.Draw();
    }

    public Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
    {
      Bitmap bitmap = new Bitmap(nWidth, nHeight);
      using (Graphics graphics = Graphics.FromImage((Image) bitmap))
        graphics.DrawImage((Image) b, 0, 0, nWidth, nHeight);
      return bitmap;
    }

    private void tbc(object sender, MouseEventArgs e)
    {
      this.checkBox6.Enabled = true;
      this.checkBox4.Enabled = true;
      this.checkBox5.Enabled = true;
      this.subtextID = 1;
      if (this.checkBox6.Checked)
        this.DrawSubText();
      this.PerformClick(sender as PictureBox);
      this.textBox2.Enabled = true;
    }

    private void wotlk(object sender, MouseEventArgs e)
    {
      this.checkBox6.Enabled = true;
      this.checkBox4.Enabled = true;
      this.checkBox5.Enabled = true;
      this.subtextID = 2;
      if (this.checkBox6.Checked)
        this.DrawSubText();
      this.PerformClick(sender as PictureBox);
      this.textBox2.Enabled = true;
    }

    private void cataclysm(object sender, MouseEventArgs e)
    {
      this.checkBox6.Enabled = true;
      this.checkBox4.Enabled = true;
      this.checkBox5.Enabled = true;
      this.subtextID = 3;
      if (this.checkBox6.Checked)
        this.DrawSubText();
      this.PerformClick(sender as PictureBox);
      this.textBox2.Enabled = true;
    }

    private void PerformClick(PictureBox pic)
    {
      this.adjustable = false;
      this.comboBox1.Enabled = false;
      this.trackBar1.Enabled = false;
      this.trackBar2.Enabled = false;
      this.trackBar3.Enabled = false;
      this.trackBar4.Enabled = false;
      this.checkBox1.Enabled = true;
      this.button3.Enabled = false;
      if (this.checkBox6.Checked)
        this.DrawSubText();
      this.im = pic.BackgroundImage;
      this.Draw();
    }

    private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
    {
      this.PerformClick(sender as PictureBox);
      this.checkBox4.Enabled = false;
      this.checkBox4.Checked = false;
      this.checkBox5.Enabled = false;
      this.checkBox5.Checked = false;
      this.checkBox6.Enabled = false;
      this.checkBox6.Checked = false;
      this.textBox2.Enabled = false;
      this.button3.Enabled = false;
      this.textBox2.Text = "";
    }

    private void pictureBox19_Click(object sender, EventArgs e)
    {
      this.im = (Image) Resources.brown;
      this.adjustable = true;
      this.button3.Enabled = true;
      this.checkBox4.Enabled = false;
      this.checkBox4.Checked = false;
      this.checkBox5.Enabled = false;
      this.checkBox5.Checked = false;
      this.comboBox1.Enabled = true;
      this.comboBox1.Text = "Brown";
      this.checkBox1.Checked = true;
      this.checkBox1.Enabled = false;
      this.trackBar1.Enabled = true;
      this.trackBar2.Enabled = true;
      this.trackBar3.Enabled = true;
      this.trackBar4.Enabled = true;
      this.checkBox6.Enabled = false;
      this.checkBox6.Checked = false;
      this.textBox2.Enabled = false;
      this.textBox2.Text = "";
      this.Draw();
    }

    private void DrawText()
    {
      this.letters = new List<Letter>();
      int num1 = 1;
      int num2 = 0;
      for (int index = 0; index < this.textBox1.Text.Length; ++index)
      {
        Letter letter = this.textBox1.Text[index] != ' ' ? (char.IsLower(this.textBox1.Text[index]) || this.textBox1.Text[index] == '\'' ? new Letter(this.textBox1.Text[index].ToString(), 70) : new Letter(this.textBox1.Text[index].ToString(), 90)) : new Letter("space", 90);
        num1 += Convert.ToInt32((double) letter.GetWidth() * 0.9);
        num2 = letter.GetWidth();
        this.letters.Add(letter);
      }
      this.let = new Bitmap(num1 + Convert.ToInt32((double) num2 * 0.1), 145);
      int num3 = 1;
      using (Graphics Artist = Graphics.FromImage((Image) this.let))
      {
        foreach (Letter letter in this.letters)
        {
          letter.Draw(Convert.ToInt32((double) num3 * 0.9), 0, Artist, 0, 0);
          num3 += letter.GetWidth();
        }
      }
      if (!this.checkBox2.Checked)
        return;
      this.let = this.ResizeBitmap(this.let, Convert.ToInt32(this.numericUpDown1.Value), 145);
    }

    private void DrawSubText()
    {
      this.subletter = new List<Subletter>();
      bool flag = false;
      int num1 = 1;
      int num2 = 0;
      double num3 = 0.0;
      switch (this.subtextID)
      {
        case 1:
          num3 = 1.0;
          break;
        case 2:
          num3 = 1.0;
          break;
        case 3:
          num3 = 0.6;
          break;
      }
      for (int index = 0; index < this.textBox2.Text.Length; ++index)
      {
        Subletter subletter = this.textBox2.Text[index] != ' ' ? new Subletter(this.textBox2.Text[index].ToString(), this.subtextID) : new Subletter("space", this.subtextID);
        if (this.subtextID != 3 && flag)
        {
          num1 -= 18;
          flag = false;
        }
        if (subletter.isL())
          flag = true;
        num1 += Convert.ToInt32((double) subletter.GetWidth() * num3);
        num2 = subletter.GetWidth();
        this.subletter.Add(subletter);
      }
      this.sublet = new Bitmap(num1 + Convert.ToInt32((double) num2 * (1.0 - num3)), 60);
      int num4 = 1;
      using (Graphics Artist = Graphics.FromImage((Image) this.sublet))
      {
        foreach (Subletter subletter in this.subletter)
        {
          subletter.Draw(Convert.ToInt32((double) num4 * num3), 0, Artist, 0, 0);
          if (subletter.isL() && this.subtextID != 3)
            num4 += 30;
          else
            num4 += Convert.ToInt32(subletter.GetWidth());
        }
      }
      if (!this.checkBox5.Checked)
        return;
      this.sublet = this.ResizeBitmap(this.sublet, Convert.ToInt32(this.numericUpDown2.Value), 60);
    }

    private void Draw()
    {
      this.bmp = new Bitmap(800, 490);
      using (Graphics graphics1 = Graphics.FromImage((Image) this.bmp))
      {
        if (!this.checkBox1.Checked)
          graphics1.Clear(this.colorDialog1.Color);
        else
          this.pictureBox1.BackgroundImage = (Image) Resources.transparent;
        if (this.adjustable)
        {
          this.pictureBox1.BackgroundImage = (Image) Resources.transparent;
          Bitmap bitmap = new Bitmap(800, 490);
          using (Graphics graphics2 = Graphics.FromImage((Image) bitmap))
          {
            graphics2.DrawImage(this.im, 0, 0);
                        //bitmap = new SaturationCorrection(Convert.ToDouble(this.trackBar2.Value) / 100.0).Apply(((FilterColorToColor) new HueModifier(this.trackBar1.Value)).Apply(bitmap));
                        //bitmap = new ContrastCorrection(Convert.ToDouble(this.trackBar4.Value) / 100.0).Apply(new BrightnessCorrection(Convert.ToDouble(this.trackBar3.Value) / 300.0).Apply(bitmap));
                        bitmap = new BrightnessCorrection(this.trackBar3.Value).Apply(bitmap);
                        bitmap = new ContrastCorrection(this.trackBar4.Value).Apply(bitmap);
                        bitmap = new HueModifier(this.trackBar1.Value).Apply(bitmap);
                        bitmap = new SaturationCorrection(Convert.ToInt32(this.trackBar2.Value / 100.0)).Apply(bitmap);
                    
                    }
          graphics1.DrawImage((Image) bitmap, 0, 0);
          if (this.adjustableType == 0)
            graphics1.DrawImage((Image) Resources.Transparency2, -4, -37);
          else
            graphics1.DrawImage((Image) Resources.ClassicTransparency, 0, 0);
          this.bmp.MakeTransparent(this.bmp.GetPixel(1, 1));
          using (Graphics graphics2 = Graphics.FromImage((Image) this.bmp))
          {
            if (this.checkBox7.Checked)
              graphics2.DrawImage((Image) Resources.ColorPreserver21, -4, -37);
            else if (this.adjustableType == 0)
              graphics2.DrawImage((Image) Resources.ColorPreserver2, -4, -37);
            else
              graphics2.DrawImage((Image) Resources.ClassicColorPreserver, -2, -34);
            if (!this.checkBox3.Checked)
              graphics2.DrawImage((Image) this.let, new Point(400 - this.let.Width / 2 - 10, 160));
            else
              graphics2.DrawImage((Image) this.let, new Point(Convert.ToInt32(this.hScrollBar2.Value), Convert.ToInt32(this.vScrollBar1.Value)));
          }
        }
        else
        {
          graphics1.DrawImage(this.im, 0, 0);
          if (this.checkBox6.Checked)
          {
            Image image = Image.FromFile(Application.StartupPath + "\\subletters\\" + (object) this.subtextID + "\\logo.png");
            if (!this.checkBox4.Checked)
            {
              switch (this.subtextID)
              {
                case 1:
                  graphics1.DrawImage(image, new Point(98, 327));
                  graphics1.DrawImage((Image) this.sublet, new Point(400 - this.sublet.Width / 2, 344));
                  break;
                case 2:
                  graphics1.DrawImage(image, new Point(90, 322));
                  graphics1.DrawImage((Image) this.sublet, new Point(400 - this.sublet.Width / 2, 324));
                  break;
                case 3:
                  graphics1.DrawImage(image, new Point(83, 304));
                  graphics1.DrawImage((Image) this.sublet, new Point(400 - this.sublet.Width / 2, 324));
                  break;
              }
            }
            else
            {
              switch (this.subtextID)
              {
                case 1:
                  graphics1.DrawImage(image, new Point(98, 327));
                  break;
                case 2:
                  graphics1.DrawImage(image, new Point(90, 322));
                  break;
                case 3:
                  graphics1.DrawImage(image, new Point(83, 304));
                  break;
              }
              graphics1.DrawImage((Image) this.sublet, new Point(this.hScrollBar1.Value, this.vScrollBar2.Value));
            }
          }
          if (!this.checkBox3.Checked)
            graphics1.DrawImage((Image) this.let, new Point(400 - this.let.Width / 2 - 10, 160));
          else
            graphics1.DrawImage((Image) this.let, new Point(Convert.ToInt32(this.hScrollBar2.Value), Convert.ToInt32(this.vScrollBar1.Value)));
        }
      }
      this.pictureBox1.Image = (Image) this.bmp;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      this.DrawText();
      this.Draw();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      this.DrawSubText();
      this.Draw();
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox2.Checked)
        this.numericUpDown1.Enabled = true;
      else
        this.numericUpDown1.Enabled = false;
      this.DrawText();
      this.Draw();
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      this.DrawText();
      this.Draw();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.Draw();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.checkBox1.Checked)
        this.button1.Enabled = true;
      else
        this.button1.Enabled = false;
      this.Draw();
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      this.Draw();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.Draw();
    }

    private void trackBar1_MouseDown(object sender, MouseEventArgs e)
    {
      this.timer1.Enabled = true;
    }

    private void trackBar1_MouseUp(object sender, MouseEventArgs e)
    {
      this.timer1.Enabled = false;
    }

    private void checkBox7_CheckedChanged(object sender, EventArgs e)
    {
      this.Draw();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.adjustable)
        return;
      switch (this.comboBox1.Text)
      {
        case "Custom":
          this.im = (Image) Resources.brown;
          this.adjustableType = 0;
          this.checkBox7.Enabled = true;
          this.checkBox7.Checked = true;
          break;
        case "Classic":
          this.im = (Image) Resources.classic;
          this.checkBox7.Enabled = false;
          this.checkBox7.Checked = false;
          this.adjustableType = 1;
          break;
      }
      this.Draw();
    }

    private void trackBar3_Scroll(object sender, EventArgs e)
    {
      this.Draw();
    }

    private void trackBar4_Scroll(object sender, EventArgs e)
    {
      this.Draw();
    }

    private void hScrollBar2_ValueChanged(object sender, EventArgs e)
    {
      this.Draw();
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        this.vScrollBar1.Value = 160;
        this.hScrollBar2.Value = 400 - this.let.Width / 2 - 10;
      }
      catch
      {
      }
      if (this.checkBox3.Checked)
      {
        this.vScrollBar1.Enabled = true;
        this.hScrollBar2.Enabled = true;
      }
      else
      {
        this.vScrollBar1.Enabled = false;
        this.hScrollBar2.Enabled = false;
      }
      this.Draw();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.trackBar1.Value = 0;
      this.trackBar2.Value = 0;
      this.trackBar3.Value = 0;
      this.trackBar4.Value = 0;
      this.Draw();
    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox5.Checked)
        this.numericUpDown2.Enabled = true;
      else
        this.numericUpDown2.Enabled = false;
      this.DrawSubText();
      this.Draw();
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
      this.DrawSubText();
      this.Draw();
    }

    private void checkBox6_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox6.Checked)
      {
        this.DrawSubText();
        this.textBox2.Enabled = true;
      }
      else
      {
        this.DrawSubText();
        this.textBox2.Enabled = false;
      }
      this.Draw();
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        this.vScrollBar2.Value = 324;
        this.hScrollBar1.Value = 400 - this.sublet.Width / 2;
      }
      catch
      {
      }
      if (this.checkBox4.Checked)
      {
        this.vScrollBar2.Enabled = true;
        this.hScrollBar1.Enabled = true;
      }
      else
      {
        this.vScrollBar2.Enabled = false;
        this.hScrollBar1.Enabled = false;
      }
      this.Draw();
    }

    private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      this.DrawSubText();
      this.Draw();
    }

    private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
    {
      this.DrawSubText();
      this.Draw();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.bmp.Save(this.saveFileDialog1.FileName, ImageFormat.Png);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label31 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label30 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label29 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label23 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(799, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(206, 491);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Controls.Add(this.pictureBox8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(198, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Official-like";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(8, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 50;
            this.label9.Text = "Cataclysm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(102, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "WOTLK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(8, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 48;
            this.label7.Text = "TBC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(102, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Classic Toxic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Classic Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(102, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Classic Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Classic Blue";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(11, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 51);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cataclysm);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tbc;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(11, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 51);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbc);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.wotlk;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(105, 247);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 51);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wotlk);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.classic_red;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(11, 166);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(88, 51);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.classic_toxic;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(105, 166);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(88, 51);
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.classic;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(11, 85);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(88, 51);
            this.pictureBox7.TabIndex = 33;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(105, 85);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(88, 51);
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "   These logos are based on official ones, comes in highest resolutions. Some of " +
    "these supports subtext option.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox18);
            this.tabPage2.Controls.Add(this.pictureBox17);
            this.tabPage2.Controls.Add(this.pictureBox16);
            this.tabPage2.Controls.Add(this.pictureBox9);
            this.tabPage2.Controls.Add(this.pictureBox10);
            this.tabPage2.Controls.Add(this.pictureBox11);
            this.tabPage2.Controls.Add(this.pictureBox12);
            this.tabPage2.Controls.Add(this.pictureBox13);
            this.tabPage2.Controls.Add(this.pictureBox14);
            this.tabPage2.Controls.Add(this.pictureBox15);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(198, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(102, 391);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 18);
            this.label19.TabIndex = 54;
            this.label19.Text = "Warcraft #2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(8, 391);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 18);
            this.label18.TabIndex = 53;
            this.label18.Text = "Warcraft #1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(102, 310);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 18);
            this.label17.TabIndex = 52;
            this.label17.Text = "Gay";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(8, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 18);
            this.label16.TabIndex = 51;
            this.label16.Text = "Lava";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(102, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 18);
            this.label15.TabIndex = 50;
            this.label15.Text = "Green";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(8, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 18);
            this.label14.TabIndex = 49;
            this.label14.Text = "Yellow";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(102, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 18);
            this.label13.TabIndex = 48;
            this.label13.Text = "Red";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(8, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 18);
            this.label12.TabIndex = 47;
            this.label12.Text = "Frost";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(102, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 46;
            this.label11.Text = "Cyan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(8, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Brown";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "   These logos are totaly custom. Their resolution isnt as big as official ones, " +
    "but for smaller images, it will do.";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.warcraft2;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox18.Location = new System.Drawing.Point(105, 409);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(88, 51);
            this.pictureBox18.TabIndex = 35;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.warcraft1;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox17.Location = new System.Drawing.Point(11, 409);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(88, 51);
            this.pictureBox17.TabIndex = 33;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.gay;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox16.Location = new System.Drawing.Point(105, 328);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(88, 51);
            this.pictureBox16.TabIndex = 31;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.lava;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(11, 328);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(88, 51);
            this.pictureBox9.TabIndex = 29;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.yellow;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Location = new System.Drawing.Point(11, 247);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(88, 51);
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.green;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Location = new System.Drawing.Point(105, 247);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(88, 51);
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.frost;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Location = new System.Drawing.Point(11, 166);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(88, 51);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.red;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Location = new System.Drawing.Point(105, 166);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(88, 51);
            this.pictureBox13.TabIndex = 21;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.brown;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox14.Location = new System.Drawing.Point(11, 85);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(88, 51);
            this.pictureBox14.TabIndex = 19;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cyan;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Location = new System.Drawing.Point(105, 85);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(88, 51);
            this.pictureBox15.TabIndex = 17;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.comboBox1);
            this.tabPage5.Controls.Add(this.checkBox7);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.trackBar4);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.trackBar3);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.trackBar2);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.trackBar1);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.pictureBox19);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(198, 462);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Adjustable";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 204);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 16);
            this.label32.TabIndex = 61;
            this.label32.Text = "Based on:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Custom",
            "Classic"});
            this.comboBox1.Location = new System.Drawing.Point(81, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 24);
            this.comboBox1.TabIndex = 60;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox7.Location = new System.Drawing.Point(6, 415);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(175, 20);
            this.checkBox7.TabIndex = 59;
            this.checkBox7.Text = "Put shadow under logo";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 6.25F);
            this.button3.Location = new System.Drawing.Point(6, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 19);
            this.button3.TabIndex = 58;
            this.button3.Text = "Reset to default";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trackBar4
            // 
            this.trackBar4.Enabled = false;
            this.trackBar4.Location = new System.Drawing.Point(72, 379);
            this.trackBar4.Maximum = 200;
            this.trackBar4.Minimum = -200;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(117, 56);
            this.trackBar4.TabIndex = 57;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            this.trackBar4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 389);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 16);
            this.label31.TabIndex = 56;
            this.label31.Text = "Contrast:";
            // 
            // trackBar3
            // 
            this.trackBar3.Enabled = false;
            this.trackBar3.Location = new System.Drawing.Point(72, 328);
            this.trackBar3.Maximum = 150;
            this.trackBar3.Minimum = -150;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(117, 56);
            this.trackBar3.TabIndex = 55;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            this.trackBar3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 338);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 16);
            this.label30.TabIndex = 54;
            this.label30.Text = "Brightnes:";
            // 
            // trackBar2
            // 
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new System.Drawing.Point(72, 277);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = -100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(117, 56);
            this.trackBar2.TabIndex = 53;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 287);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 16);
            this.label29.TabIndex = 52;
            this.label29.Text = "Saturation:";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(72, 226);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Minimum = -180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(117, 56);
            this.trackBar1.TabIndex = 51;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 236);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 16);
            this.label28.TabIndex = 50;
            this.label28.Text = "Hue:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(3, 86);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 18);
            this.label27.TabIndex = 49;
            this.label27.Text = "Adjustable logo";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ColorPreserver21;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox19.Location = new System.Drawing.Point(6, 104);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(183, 91);
            this.pictureBox19.TabIndex = 48;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Click += new System.EventHandler(this.pictureBox19_Click);
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.Location = new System.Drawing.Point(3, 3);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(195, 88);
            this.label26.TabIndex = 16;
            this.label26.Text = resources.GetString("label26.Text");
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 490);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1005, 127);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.checkBox6);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.hScrollBar1);
            this.tabPage3.Controls.Add(this.hScrollBar2);
            this.tabPage3.Controls.Add(this.vScrollBar2);
            this.tabPage3.Controls.Add(this.vScrollBar1);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.checkBox4);
            this.tabPage3.Controls.Add(this.checkBox5);
            this.tabPage3.Controls.Add(this.checkBox3);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(997, 98);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "General";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label33.Location = new System.Drawing.Point(114, 49);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(162, 16);
            this.label33.TabIndex = 19;
            this.label33.Text = "| [ = ofthe | ! = the | ] = of";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox6.Location = new System.Drawing.Point(60, 48);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(74, 20);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "Enable";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(539, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(365, 16);
            this.label24.TabIndex = 17;
            this.label24.Text = "Use these scrollbars to adjust position of text (if enabled)";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar1.Enabled = false;
            this.hScrollBar1.Location = new System.Drawing.Point(536, 62);
            this.hScrollBar1.Maximum = 800;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(455, 38);
            this.hScrollBar1.TabIndex = 16;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar2.Enabled = false;
            this.hScrollBar2.Location = new System.Drawing.Point(536, 4);
            this.hScrollBar2.Maximum = 800;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(455, 38);
            this.hScrollBar2.TabIndex = 15;
            this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vScrollBar2.Enabled = false;
            this.vScrollBar2.Location = new System.Drawing.Point(517, 54);
            this.vScrollBar2.Maximum = 490;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(19, 46);
            this.vScrollBar2.TabIndex = 13;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            this.vScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vScrollBar1.Enabled = false;
            this.vScrollBar1.Location = new System.Drawing.Point(517, 4);
            this.vScrollBar1.Maximum = 490;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 46);
            this.vScrollBar1.TabIndex = 12;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(442, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 16);
            this.label23.TabIndex = 11;
            this.label23.Text = "Size:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(445, 74);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 23);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(442, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 16);
            this.label22.TabIndex = 9;
            this.label22.Text = "Size:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(445, 31);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 23);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.Location = new System.Drawing.Point(280, 77);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(197, 20);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Forced position of sub text";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.Location = new System.Drawing.Point(280, 59);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(172, 20);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Forced size of sub text";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.Location = new System.Drawing.Point(280, 33);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(204, 20);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Forced position of main text";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Location = new System.Drawing.Point(280, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(179, 20);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Forced size of main text";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(6, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(3, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 19);
            this.label21.TabIndex = 2;
            this.label21.Text = "Subtext";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(3, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Main Text";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(997, 98);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.Location = new System.Drawing.Point(3, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(968, 318);
            this.label25.TabIndex = 0;
            this.label25.Text = resources.GetString("label25.Text");
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 6.25F);
            this.button1.Location = new System.Drawing.Point(884, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Background Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 6.25F);
            this.button2.Location = new System.Drawing.Point(799, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 6.25F);
            this.checkBox1.Location = new System.Drawing.Point(722, 494);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 18);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Transparent";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 490);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG Image|*.png";
            this.saveFileDialog1.Title = "Select where would you like to have your logo saved.";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 617);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Axxa\'s World of Warcraft Logo Creator v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
