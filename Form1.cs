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
            bitmap = new SaturationCorrection(Convert.ToDouble(this.trackBar2.Value) / 100.0).Apply(((FilterColorToColor) new HueModifier(this.trackBar1.Value)).Apply(bitmap));
            bitmap = new ContrastCorrection(Convert.ToDouble(this.trackBar4.Value) / 100.0).Apply(new BrightnessCorrection(Convert.ToDouble(this.trackBar3.Value) / 300.0).Apply(bitmap));
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
      this.trackBar4.Value = 100;
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.pictureBox2 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.pictureBox4 = new PictureBox();
      this.pictureBox5 = new PictureBox();
      this.pictureBox6 = new PictureBox();
      this.pictureBox7 = new PictureBox();
      this.pictureBox8 = new PictureBox();
      this.label1 = new Label();
      this.tabPage2 = new TabPage();
      this.label19 = new Label();
      this.label18 = new Label();
      this.label17 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.label13 = new Label();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label2 = new Label();
      this.pictureBox18 = new PictureBox();
      this.pictureBox17 = new PictureBox();
      this.pictureBox16 = new PictureBox();
      this.pictureBox9 = new PictureBox();
      this.pictureBox10 = new PictureBox();
      this.pictureBox11 = new PictureBox();
      this.pictureBox12 = new PictureBox();
      this.pictureBox13 = new PictureBox();
      this.pictureBox14 = new PictureBox();
      this.pictureBox15 = new PictureBox();
      this.tabPage5 = new TabPage();
      this.label32 = new Label();
      this.comboBox1 = new ComboBox();
      this.checkBox7 = new CheckBox();
      this.button3 = new Button();
      this.trackBar4 = new TrackBar();
      this.label31 = new Label();
      this.trackBar3 = new TrackBar();
      this.label30 = new Label();
      this.trackBar2 = new TrackBar();
      this.label29 = new Label();
      this.trackBar1 = new TrackBar();
      this.label28 = new Label();
      this.label27 = new Label();
      this.pictureBox19 = new PictureBox();
      this.label26 = new Label();
      this.tabControl2 = new TabControl();
      this.tabPage3 = new TabPage();
      this.label33 = new Label();
      this.checkBox6 = new CheckBox();
      this.label24 = new Label();
      this.hScrollBar1 = new HScrollBar();
      this.hScrollBar2 = new HScrollBar();
      this.vScrollBar2 = new VScrollBar();
      this.vScrollBar1 = new VScrollBar();
      this.label23 = new Label();
      this.numericUpDown2 = new NumericUpDown();
      this.label22 = new Label();
      this.numericUpDown1 = new NumericUpDown();
      this.checkBox4 = new CheckBox();
      this.checkBox5 = new CheckBox();
      this.checkBox3 = new CheckBox();
      this.checkBox2 = new CheckBox();
      this.textBox2 = new TextBox();
      this.label21 = new Label();
      this.textBox1 = new TextBox();
      this.label20 = new Label();
      this.tabPage4 = new TabPage();
      this.label25 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.checkBox1 = new CheckBox();
      this.colorDialog1 = new ColorDialog();
      this.timer1 = new Timer(this.components);
      this.pictureBox1 = new PictureBox();
      this.saveFileDialog1 = new SaveFileDialog();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox5).BeginInit();
      ((ISupportInitialize) this.pictureBox6).BeginInit();
      ((ISupportInitialize) this.pictureBox7).BeginInit();
      ((ISupportInitialize) this.pictureBox8).BeginInit();
      this.tabPage2.SuspendLayout();
      ((ISupportInitialize) this.pictureBox18).BeginInit();
      ((ISupportInitialize) this.pictureBox17).BeginInit();
      ((ISupportInitialize) this.pictureBox16).BeginInit();
      ((ISupportInitialize) this.pictureBox9).BeginInit();
      ((ISupportInitialize) this.pictureBox10).BeginInit();
      ((ISupportInitialize) this.pictureBox11).BeginInit();
      ((ISupportInitialize) this.pictureBox12).BeginInit();
      ((ISupportInitialize) this.pictureBox13).BeginInit();
      ((ISupportInitialize) this.pictureBox14).BeginInit();
      ((ISupportInitialize) this.pictureBox15).BeginInit();
      this.tabPage5.SuspendLayout();
      this.trackBar4.BeginInit();
      this.trackBar3.BeginInit();
      this.trackBar2.BeginInit();
      this.trackBar1.BeginInit();
      ((ISupportInitialize) this.pictureBox19).BeginInit();
      this.tabControl2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.numericUpDown2.BeginInit();
      this.numericUpDown1.BeginInit();
      this.tabPage4.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage5);
      this.tabControl1.Location = new Point(799, 0);
      this.tabControl1.Margin = new Padding(3, 4, 3, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(206, 491);
      this.tabControl1.TabIndex = 1;
      this.tabPage1.Controls.Add((Control) this.label9);
      this.tabPage1.Controls.Add((Control) this.label8);
      this.tabPage1.Controls.Add((Control) this.label7);
      this.tabPage1.Controls.Add((Control) this.label6);
      this.tabPage1.Controls.Add((Control) this.label5);
      this.tabPage1.Controls.Add((Control) this.label4);
      this.tabPage1.Controls.Add((Control) this.label3);
      this.tabPage1.Controls.Add((Control) this.pictureBox2);
      this.tabPage1.Controls.Add((Control) this.pictureBox3);
      this.tabPage1.Controls.Add((Control) this.pictureBox4);
      this.tabPage1.Controls.Add((Control) this.pictureBox5);
      this.tabPage1.Controls.Add((Control) this.pictureBox6);
      this.tabPage1.Controls.Add((Control) this.pictureBox7);
      this.tabPage1.Controls.Add((Control) this.pictureBox8);
      this.tabPage1.Controls.Add((Control) this.label1);
      this.tabPage1.Location = new Point(4, 23);
      this.tabPage1.Margin = new Padding(3, 4, 3, 4);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3, 4, 3, 4);
      this.tabPage1.Size = new Size(198, 464);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Official-like";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label9.Location = new Point(8, 310);
      this.label9.Name = "label9";
      this.label9.Size = new Size(67, 15);
      this.label9.TabIndex = 50;
      this.label9.Text = "Cataclysm";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label8.Location = new Point(102, 229);
      this.label8.Name = "label8";
      this.label8.Size = new Size(50, 15);
      this.label8.TabIndex = 49;
      this.label8.Text = "WOTLK";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label7.Location = new Point(8, 229);
      this.label7.Name = "label7";
      this.label7.Size = new Size(30, 15);
      this.label7.TabIndex = 48;
      this.label7.Text = "TBC";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label6.Location = new Point(102, 148);
      this.label6.Name = "label6";
      this.label6.Size = new Size(82, 15);
      this.label6.TabIndex = 47;
      this.label6.Text = "Classic Toxic";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label5.Location = new Point(8, 148);
      this.label5.Name = "label5";
      this.label5.Size = new Size(74, 15);
      this.label5.TabIndex = 46;
      this.label5.Text = "Classic Red";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label4.Location = new Point(102, 68);
      this.label4.Name = "label4";
      this.label4.Size = new Size(86, 15);
      this.label4.TabIndex = 45;
      this.label4.Text = "Classic Green";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label3.Location = new Point(8, 68);
      this.label3.Name = "label3";
      this.label3.Size = new Size(77, 15);
      this.label3.TabIndex = 44;
      this.label3.Text = "Classic Blue";
      this.pictureBox2.BackgroundImage = (Image) componentResourceManager.GetObject("pictureBox2.BackgroundImage");
      this.pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox2.Cursor = Cursors.Hand;
      this.pictureBox2.Location = new Point(11, 328);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(88, 51);
      this.pictureBox2.TabIndex = 43;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.MouseClick += new MouseEventHandler(this.cataclysm);
      this.pictureBox3.BackgroundImage = (Image) Resources.tbc;
      this.pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox3.Cursor = Cursors.Hand;
      this.pictureBox3.Location = new Point(11, 247);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(88, 51);
      this.pictureBox3.TabIndex = 41;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.MouseClick += new MouseEventHandler(this.tbc);
      this.pictureBox4.BackgroundImage = (Image) Resources.wotlk;
      this.pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox4.Cursor = Cursors.Hand;
      this.pictureBox4.Location = new Point(105, 247);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new Size(88, 51);
      this.pictureBox4.TabIndex = 39;
      this.pictureBox4.TabStop = false;
      this.pictureBox4.MouseClick += new MouseEventHandler(this.wotlk);
      this.pictureBox5.BackgroundImage = (Image) Resources.classic_red;
      this.pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox5.Cursor = Cursors.Hand;
      this.pictureBox5.Location = new Point(11, 166);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new Size(88, 51);
      this.pictureBox5.TabIndex = 37;
      this.pictureBox5.TabStop = false;
      this.pictureBox5.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox6.BackgroundImage = (Image) Resources.classic_toxic;
      this.pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox6.Cursor = Cursors.Hand;
      this.pictureBox6.Location = new Point(105, 166);
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.Size = new Size(88, 51);
      this.pictureBox6.TabIndex = 35;
      this.pictureBox6.TabStop = false;
      this.pictureBox6.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox7.BackgroundImage = (Image) Resources.classic;
      this.pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox7.Cursor = Cursors.Hand;
      this.pictureBox7.Location = new Point(11, 85);
      this.pictureBox7.Name = "pictureBox7";
      this.pictureBox7.Size = new Size(88, 51);
      this.pictureBox7.TabIndex = 33;
      this.pictureBox7.TabStop = false;
      this.pictureBox7.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox8.BackgroundImage = (Image) componentResourceManager.GetObject("pictureBox8.BackgroundImage");
      this.pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox8.Cursor = Cursors.Hand;
      this.pictureBox8.Location = new Point(105, 85);
      this.pictureBox8.Name = "pictureBox8";
      this.pictureBox8.Size = new Size(88, 51);
      this.pictureBox8.TabIndex = 31;
      this.pictureBox8.TabStop = false;
      this.pictureBox8.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.label1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.label1.Location = new Point(4, 4);
      this.label1.Name = "label1";
      this.label1.Size = new Size(195, 64);
      this.label1.TabIndex = 0;
      this.label1.Text = "   These logos are based on official ones, comes in highest resolutions. Some of these supports subtext option.";
      this.tabPage2.Controls.Add((Control) this.label19);
      this.tabPage2.Controls.Add((Control) this.label18);
      this.tabPage2.Controls.Add((Control) this.label17);
      this.tabPage2.Controls.Add((Control) this.label16);
      this.tabPage2.Controls.Add((Control) this.label15);
      this.tabPage2.Controls.Add((Control) this.label14);
      this.tabPage2.Controls.Add((Control) this.label13);
      this.tabPage2.Controls.Add((Control) this.label12);
      this.tabPage2.Controls.Add((Control) this.label11);
      this.tabPage2.Controls.Add((Control) this.label10);
      this.tabPage2.Controls.Add((Control) this.label2);
      this.tabPage2.Controls.Add((Control) this.pictureBox18);
      this.tabPage2.Controls.Add((Control) this.pictureBox17);
      this.tabPage2.Controls.Add((Control) this.pictureBox16);
      this.tabPage2.Controls.Add((Control) this.pictureBox9);
      this.tabPage2.Controls.Add((Control) this.pictureBox10);
      this.tabPage2.Controls.Add((Control) this.pictureBox11);
      this.tabPage2.Controls.Add((Control) this.pictureBox12);
      this.tabPage2.Controls.Add((Control) this.pictureBox13);
      this.tabPage2.Controls.Add((Control) this.pictureBox14);
      this.tabPage2.Controls.Add((Control) this.pictureBox15);
      this.tabPage2.Location = new Point(4, 23);
      this.tabPage2.Margin = new Padding(3, 4, 3, 4);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3, 4, 3, 4);
      this.tabPage2.Size = new Size(198, 464);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Custom";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label19.Location = new Point(102, 391);
      this.label19.Name = "label19";
      this.label19.Size = new Size(75, 15);
      this.label19.TabIndex = 54;
      this.label19.Text = "Warcraft #2";
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label18.Location = new Point(8, 391);
      this.label18.Name = "label18";
      this.label18.Size = new Size(75, 15);
      this.label18.TabIndex = 53;
      this.label18.Text = "Warcraft #1";
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label17.Location = new Point(102, 310);
      this.label17.Name = "label17";
      this.label17.Size = new Size(28, 15);
      this.label17.TabIndex = 52;
      this.label17.Text = "Gay";
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label16.Location = new Point(8, 310);
      this.label16.Name = "label16";
      this.label16.Size = new Size(34, 15);
      this.label16.TabIndex = 51;
      this.label16.Text = "Lava";
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label15.Location = new Point(102, 229);
      this.label15.Name = "label15";
      this.label15.Size = new Size(41, 15);
      this.label15.TabIndex = 50;
      this.label15.Text = "Green";
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label14.Location = new Point(8, 229);
      this.label14.Name = "label14";
      this.label14.Size = new Size(43, 15);
      this.label14.TabIndex = 49;
      this.label14.Text = "Yellow";
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label13.Location = new Point(102, 148);
      this.label13.Name = "label13";
      this.label13.Size = new Size(29, 15);
      this.label13.TabIndex = 48;
      this.label13.Text = "Red";
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label12.Location = new Point(8, 148);
      this.label12.Name = "label12";
      this.label12.Size = new Size(36, 15);
      this.label12.TabIndex = 47;
      this.label12.Text = "Frost";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label11.Location = new Point(102, 67);
      this.label11.Name = "label11";
      this.label11.Size = new Size(35, 15);
      this.label11.TabIndex = 46;
      this.label11.Text = "Cyan";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label10.Location = new Point(8, 67);
      this.label10.Name = "label10";
      this.label10.Size = new Size(44, 15);
      this.label10.TabIndex = 45;
      this.label10.Text = "Brown";
      this.label2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.label2.Location = new Point(4, 4);
      this.label2.Name = "label2";
      this.label2.Size = new Size(195, 44);
      this.label2.TabIndex = 15;
      this.label2.Text = "   These logos are totaly custom. Their resolution isnt as big as official ones, but for smaller images, it will do.";
      this.pictureBox18.BackgroundImage = (Image) Resources.warcraft2;
      this.pictureBox18.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox18.Cursor = Cursors.Hand;
      this.pictureBox18.Location = new Point(105, 409);
      this.pictureBox18.Name = "pictureBox18";
      this.pictureBox18.Size = new Size(88, 51);
      this.pictureBox18.TabIndex = 35;
      this.pictureBox18.TabStop = false;
      this.pictureBox18.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox17.BackgroundImage = (Image) Resources.warcraft1;
      this.pictureBox17.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox17.Cursor = Cursors.Hand;
      this.pictureBox17.Location = new Point(11, 409);
      this.pictureBox17.Name = "pictureBox17";
      this.pictureBox17.Size = new Size(88, 51);
      this.pictureBox17.TabIndex = 33;
      this.pictureBox17.TabStop = false;
      this.pictureBox17.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox16.BackgroundImage = (Image) Resources.gay;
      this.pictureBox16.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox16.Cursor = Cursors.Hand;
      this.pictureBox16.Location = new Point(105, 328);
      this.pictureBox16.Name = "pictureBox16";
      this.pictureBox16.Size = new Size(88, 51);
      this.pictureBox16.TabIndex = 31;
      this.pictureBox16.TabStop = false;
      this.pictureBox16.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox9.BackgroundImage = (Image) Resources.lava;
      this.pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox9.Cursor = Cursors.Hand;
      this.pictureBox9.Location = new Point(11, 328);
      this.pictureBox9.Name = "pictureBox9";
      this.pictureBox9.Size = new Size(88, 51);
      this.pictureBox9.TabIndex = 29;
      this.pictureBox9.TabStop = false;
      this.pictureBox9.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox10.BackgroundImage = (Image) Resources.yellow;
      this.pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox10.Cursor = Cursors.Hand;
      this.pictureBox10.Location = new Point(11, 247);
      this.pictureBox10.Name = "pictureBox10";
      this.pictureBox10.Size = new Size(88, 51);
      this.pictureBox10.TabIndex = 27;
      this.pictureBox10.TabStop = false;
      this.pictureBox10.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox11.BackgroundImage = (Image) Resources.green;
      this.pictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox11.Cursor = Cursors.Hand;
      this.pictureBox11.Location = new Point(105, 247);
      this.pictureBox11.Name = "pictureBox11";
      this.pictureBox11.Size = new Size(88, 51);
      this.pictureBox11.TabIndex = 25;
      this.pictureBox11.TabStop = false;
      this.pictureBox11.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox12.BackgroundImage = (Image) Resources.frost;
      this.pictureBox12.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox12.Cursor = Cursors.Hand;
      this.pictureBox12.Location = new Point(11, 166);
      this.pictureBox12.Name = "pictureBox12";
      this.pictureBox12.Size = new Size(88, 51);
      this.pictureBox12.TabIndex = 23;
      this.pictureBox12.TabStop = false;
      this.pictureBox12.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox13.BackgroundImage = (Image) Resources.red;
      this.pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox13.Cursor = Cursors.Hand;
      this.pictureBox13.Location = new Point(105, 166);
      this.pictureBox13.Name = "pictureBox13";
      this.pictureBox13.Size = new Size(88, 51);
      this.pictureBox13.TabIndex = 21;
      this.pictureBox13.TabStop = false;
      this.pictureBox13.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox14.BackgroundImage = (Image) Resources.brown;
      this.pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox14.Cursor = Cursors.Hand;
      this.pictureBox14.Location = new Point(11, 85);
      this.pictureBox14.Name = "pictureBox14";
      this.pictureBox14.Size = new Size(88, 51);
      this.pictureBox14.TabIndex = 19;
      this.pictureBox14.TabStop = false;
      this.pictureBox14.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.pictureBox15.BackgroundImage = (Image) Resources.cyan;
      this.pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox15.Cursor = Cursors.Hand;
      this.pictureBox15.Location = new Point(105, 85);
      this.pictureBox15.Name = "pictureBox15";
      this.pictureBox15.Size = new Size(88, 51);
      this.pictureBox15.TabIndex = 17;
      this.pictureBox15.TabStop = false;
      this.pictureBox15.MouseClick += new MouseEventHandler(this.pictureBox14_MouseClick);
      this.tabPage5.Controls.Add((Control) this.label32);
      this.tabPage5.Controls.Add((Control) this.comboBox1);
      this.tabPage5.Controls.Add((Control) this.checkBox7);
      this.tabPage5.Controls.Add((Control) this.button3);
      this.tabPage5.Controls.Add((Control) this.trackBar4);
      this.tabPage5.Controls.Add((Control) this.label31);
      this.tabPage5.Controls.Add((Control) this.trackBar3);
      this.tabPage5.Controls.Add((Control) this.label30);
      this.tabPage5.Controls.Add((Control) this.trackBar2);
      this.tabPage5.Controls.Add((Control) this.label29);
      this.tabPage5.Controls.Add((Control) this.trackBar1);
      this.tabPage5.Controls.Add((Control) this.label28);
      this.tabPage5.Controls.Add((Control) this.label27);
      this.tabPage5.Controls.Add((Control) this.pictureBox19);
      this.tabPage5.Controls.Add((Control) this.label26);
      this.tabPage5.Location = new Point(4, 23);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(198, 464);
      this.tabPage5.TabIndex = 2;
      this.tabPage5.Text = "Adjustable";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.label32.AutoSize = true;
      this.label32.Location = new Point(7, 204);
      this.label32.Name = "label32";
      this.label32.Size = new Size(56, 14);
      this.label32.TabIndex = 61;
      this.label32.Text = "Based on:";
      this.comboBox1.BackColor = SystemColors.Control;
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.Enabled = false;
      this.comboBox1.Items.AddRange(new object[2]
      {
        (object) "Custom",
        (object) "Classic"
      });
      this.comboBox1.Location = new Point(81, 201);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(104, 22);
      this.comboBox1.TabIndex = 60;
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.checkBox7.AutoSize = true;
      this.checkBox7.Checked = true;
      this.checkBox7.CheckState = CheckState.Checked;
      this.checkBox7.Cursor = Cursors.Hand;
      this.checkBox7.Location = new Point(6, 415);
      this.checkBox7.Name = "checkBox7";
      this.checkBox7.Size = new Size(138, 18);
      this.checkBox7.TabIndex = 59;
      this.checkBox7.Text = "Put shadow under logo";
      this.checkBox7.UseVisualStyleBackColor = true;
      this.checkBox7.CheckedChanged += new EventHandler(this.checkBox7_CheckedChanged);
      this.button3.Cursor = Cursors.Hand;
      this.button3.Enabled = false;
      this.button3.FlatStyle = FlatStyle.Popup;
      this.button3.Font = new Font("Arial", 6.25f);
      this.button3.Location = new Point(6, 439);
      this.button3.Name = "button3";
      this.button3.Size = new Size(179, 19);
      this.button3.TabIndex = 58;
      this.button3.Text = "Reset to default";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.trackBar4.Enabled = false;
      this.trackBar4.Location = new Point(72, 379);
      this.trackBar4.Maximum = 200;
      this.trackBar4.Minimum = 1;
      this.trackBar4.Name = "trackBar4";
      this.trackBar4.Size = new Size(117, 45);
      this.trackBar4.TabIndex = 57;
      this.trackBar4.TickStyle = TickStyle.Both;
      this.trackBar4.Value = 100;
      this.trackBar4.Scroll += new EventHandler(this.trackBar4_Scroll);
      this.trackBar4.MouseDown += new MouseEventHandler(this.trackBar1_MouseDown);
      this.trackBar4.MouseUp += new MouseEventHandler(this.trackBar1_MouseUp);
      this.label31.AutoSize = true;
      this.label31.Location = new Point(7, 389);
      this.label31.Name = "label31";
      this.label31.Size = new Size(51, 14);
      this.label31.TabIndex = 56;
      this.label31.Text = "Contrast:";
      this.trackBar3.Enabled = false;
      this.trackBar3.Location = new Point(72, 328);
      this.trackBar3.Maximum = 150;
      this.trackBar3.Minimum = -150;
      this.trackBar3.Name = "trackBar3";
      this.trackBar3.Size = new Size(117, 45);
      this.trackBar3.TabIndex = 55;
      this.trackBar3.TickStyle = TickStyle.Both;
      this.trackBar3.Scroll += new EventHandler(this.trackBar3_Scroll);
      this.trackBar3.MouseDown += new MouseEventHandler(this.trackBar1_MouseDown);
      this.trackBar3.MouseUp += new MouseEventHandler(this.trackBar1_MouseUp);
      this.label30.AutoSize = true;
      this.label30.Location = new Point(7, 338);
      this.label30.Name = "label30";
      this.label30.Size = new Size(56, 14);
      this.label30.TabIndex = 54;
      this.label30.Text = "Brightnes:";
      this.trackBar2.Enabled = false;
      this.trackBar2.Location = new Point(72, 277);
      this.trackBar2.Maximum = 100;
      this.trackBar2.Minimum = -100;
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new Size(117, 45);
      this.trackBar2.TabIndex = 53;
      this.trackBar2.TickStyle = TickStyle.Both;
      this.trackBar2.Scroll += new EventHandler(this.trackBar1_Scroll);
      this.trackBar2.MouseDown += new MouseEventHandler(this.trackBar1_MouseDown);
      this.trackBar2.MouseUp += new MouseEventHandler(this.trackBar1_MouseUp);
      this.label29.AutoSize = true;
      this.label29.Location = new Point(7, 287);
      this.label29.Name = "label29";
      this.label29.Size = new Size(59, 14);
      this.label29.TabIndex = 52;
      this.label29.Text = "Saturation:";
      this.trackBar1.Enabled = false;
      this.trackBar1.Location = new Point(72, 226);
      this.trackBar1.Maximum = 180;
      this.trackBar1.Minimum = -180;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new Size(117, 45);
      this.trackBar1.TabIndex = 51;
      this.trackBar1.TickStyle = TickStyle.Both;
      this.trackBar1.Scroll += new EventHandler(this.trackBar1_Scroll);
      this.trackBar1.MouseDown += new MouseEventHandler(this.trackBar1_MouseDown);
      this.trackBar1.MouseUp += new MouseEventHandler(this.trackBar1_MouseUp);
      this.label28.AutoSize = true;
      this.label28.Location = new Point(7, 236);
      this.label28.Name = "label28";
      this.label28.Size = new Size(29, 14);
      this.label28.TabIndex = 50;
      this.label28.Text = "Hue:";
      this.label27.AutoSize = true;
      this.label27.Font = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label27.Location = new Point(3, 86);
      this.label27.Name = "label27";
      this.label27.Size = new Size(94, 15);
      this.label27.TabIndex = 49;
      this.label27.Text = "Adjustable logo";
      this.pictureBox19.BackgroundImage = (Image) Resources.ColorPreserver21;
      this.pictureBox19.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox19.Cursor = Cursors.Hand;
      this.pictureBox19.Location = new Point(6, 104);
      this.pictureBox19.Name = "pictureBox19";
      this.pictureBox19.Size = new Size(183, 91);
      this.pictureBox19.TabIndex = 48;
      this.pictureBox19.TabStop = false;
      this.pictureBox19.Click += new EventHandler(this.pictureBox19_Click);
      this.label26.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.label26.Location = new Point(3, 3);
      this.label26.Name = "label26";
      this.label26.Size = new Size(195, 88);
      this.label26.TabIndex = 16;
      this.label26.Text = componentResourceManager.GetString("label26.Text");
      this.tabControl2.Controls.Add((Control) this.tabPage3);
      this.tabControl2.Controls.Add((Control) this.tabPage4);
      this.tabControl2.Location = new Point(0, 490);
      this.tabControl2.Margin = new Padding(3, 4, 3, 4);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(1005, (int) sbyte.MaxValue);
      this.tabControl2.TabIndex = 2;
      this.tabPage3.Controls.Add((Control) this.label33);
      this.tabPage3.Controls.Add((Control) this.checkBox6);
      this.tabPage3.Controls.Add((Control) this.label24);
      this.tabPage3.Controls.Add((Control) this.hScrollBar1);
      this.tabPage3.Controls.Add((Control) this.hScrollBar2);
      this.tabPage3.Controls.Add((Control) this.vScrollBar2);
      this.tabPage3.Controls.Add((Control) this.vScrollBar1);
      this.tabPage3.Controls.Add((Control) this.label23);
      this.tabPage3.Controls.Add((Control) this.numericUpDown2);
      this.tabPage3.Controls.Add((Control) this.label22);
      this.tabPage3.Controls.Add((Control) this.numericUpDown1);
      this.tabPage3.Controls.Add((Control) this.checkBox4);
      this.tabPage3.Controls.Add((Control) this.checkBox5);
      this.tabPage3.Controls.Add((Control) this.checkBox3);
      this.tabPage3.Controls.Add((Control) this.checkBox2);
      this.tabPage3.Controls.Add((Control) this.textBox2);
      this.tabPage3.Controls.Add((Control) this.label21);
      this.tabPage3.Controls.Add((Control) this.textBox1);
      this.tabPage3.Controls.Add((Control) this.label20);
      this.tabPage3.Location = new Point(4, 23);
      this.tabPage3.Margin = new Padding(3, 4, 3, 4);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3, 4, 3, 4);
      this.tabPage3.Size = new Size(997, 100);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "General";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.label33.AutoSize = true;
      this.label33.ForeColor = SystemColors.ControlDarkDark;
      this.label33.Location = new Point(114, 49);
      this.label33.Name = "label33";
      this.label33.Size = new Size(122, 14);
      this.label33.TabIndex = 19;
      this.label33.Text = "| [ = ofthe | ! = the | ] = of";
      this.checkBox6.AutoSize = true;
      this.checkBox6.Cursor = Cursors.Hand;
      this.checkBox6.Location = new Point(60, 48);
      this.checkBox6.Name = "checkBox6";
      this.checkBox6.Size = new Size(58, 18);
      this.checkBox6.TabIndex = 18;
      this.checkBox6.Text = "Enable";
      this.checkBox6.UseVisualStyleBackColor = true;
      this.checkBox6.CheckedChanged += new EventHandler(this.checkBox6_CheckedChanged);
      this.label24.AutoSize = true;
      this.label24.ForeColor = SystemColors.ControlDarkDark;
      this.label24.Location = new Point(539, 45);
      this.label24.Name = "label24";
      this.label24.Size = new Size(283, 14);
      this.label24.TabIndex = 17;
      this.label24.Text = "Use these scrollbars to adjust position of text (if enabled)";
      this.hScrollBar1.Cursor = Cursors.Hand;
      this.hScrollBar1.Enabled = false;
      this.hScrollBar1.Location = new Point(536, 62);
      this.hScrollBar1.Maximum = 800;
      this.hScrollBar1.Name = "hScrollBar1";
      this.hScrollBar1.Size = new Size(455, 38);
      this.hScrollBar1.TabIndex = 16;
      this.hScrollBar1.ValueChanged += new EventHandler(this.hScrollBar2_ValueChanged);
      this.hScrollBar1.Scroll += new ScrollEventHandler(this.hScrollBar1_Scroll);
      this.hScrollBar2.Cursor = Cursors.Hand;
      this.hScrollBar2.Enabled = false;
      this.hScrollBar2.Location = new Point(536, 4);
      this.hScrollBar2.Maximum = 800;
      this.hScrollBar2.Name = "hScrollBar2";
      this.hScrollBar2.Size = new Size(455, 38);
      this.hScrollBar2.TabIndex = 15;
      this.hScrollBar2.ValueChanged += new EventHandler(this.hScrollBar2_ValueChanged);
      this.vScrollBar2.Cursor = Cursors.Hand;
      this.vScrollBar2.Enabled = false;
      this.vScrollBar2.Location = new Point(517, 54);
      this.vScrollBar2.Maximum = 490;
      this.vScrollBar2.Name = "vScrollBar2";
      this.vScrollBar2.Size = new Size(19, 46);
      this.vScrollBar2.TabIndex = 13;
      this.vScrollBar2.ValueChanged += new EventHandler(this.hScrollBar2_ValueChanged);
      this.vScrollBar2.Scroll += new ScrollEventHandler(this.vScrollBar2_Scroll);
      this.vScrollBar1.Cursor = Cursors.Hand;
      this.vScrollBar1.Enabled = false;
      this.vScrollBar1.Location = new Point(517, 4);
      this.vScrollBar1.Maximum = 490;
      this.vScrollBar1.Name = "vScrollBar1";
      this.vScrollBar1.Size = new Size(19, 46);
      this.vScrollBar1.TabIndex = 12;
      this.vScrollBar1.ValueChanged += new EventHandler(this.hScrollBar2_ValueChanged);
      this.label23.AutoSize = true;
      this.label23.ForeColor = SystemColors.ControlDarkDark;
      this.label23.Location = new Point(442, 60);
      this.label23.Name = "label23";
      this.label23.Size = new Size(31, 14);
      this.label23.TabIndex = 11;
      this.label23.Text = "Size:";
      this.numericUpDown2.Cursor = Cursors.Hand;
      this.numericUpDown2.Enabled = false;
      this.numericUpDown2.Increment = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.numericUpDown2.Location = new Point(445, 74);
      this.numericUpDown2.Maximum = new Decimal(new int[4]
      {
        800,
        0,
        0,
        0
      });
      this.numericUpDown2.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new Size(65, 20);
      this.numericUpDown2.TabIndex = 10;
      this.numericUpDown2.Value = new Decimal(new int[4]
      {
        600,
        0,
        0,
        0
      });
      this.numericUpDown2.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged);
      this.label22.AutoSize = true;
      this.label22.ForeColor = SystemColors.ControlDarkDark;
      this.label22.Location = new Point(442, 17);
      this.label22.Name = "label22";
      this.label22.Size = new Size(31, 14);
      this.label22.TabIndex = 9;
      this.label22.Text = "Size:";
      this.numericUpDown1.Cursor = Cursors.Hand;
      this.numericUpDown1.Enabled = false;
      this.numericUpDown1.Increment = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.numericUpDown1.Location = new Point(445, 31);
      this.numericUpDown1.Maximum = new Decimal(new int[4]
      {
        800,
        0,
        0,
        0
      });
      this.numericUpDown1.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new Size(65, 20);
      this.numericUpDown1.TabIndex = 8;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        600,
        0,
        0,
        0
      });
      this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
      this.checkBox4.AutoSize = true;
      this.checkBox4.Cursor = Cursors.Hand;
      this.checkBox4.Location = new Point(280, 77);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new Size(155, 18);
      this.checkBox4.TabIndex = 7;
      this.checkBox4.Text = "Forced position of sub text";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.CheckedChanged += new EventHandler(this.checkBox4_CheckedChanged);
      this.checkBox5.AutoSize = true;
      this.checkBox5.Cursor = Cursors.Hand;
      this.checkBox5.Location = new Point(280, 59);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new Size(138, 18);
      this.checkBox5.TabIndex = 6;
      this.checkBox5.Text = "Forced size of sub text";
      this.checkBox5.UseVisualStyleBackColor = true;
      this.checkBox5.CheckedChanged += new EventHandler(this.checkBox5_CheckedChanged);
      this.checkBox3.AutoSize = true;
      this.checkBox3.Cursor = Cursors.Hand;
      this.checkBox3.Location = new Point(280, 33);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new Size(159, 18);
      this.checkBox3.TabIndex = 5;
      this.checkBox3.Text = "Forced position of main text";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new EventHandler(this.checkBox3_CheckedChanged);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Cursor = Cursors.Hand;
      this.checkBox2.Location = new Point(280, 16);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(142, 18);
      this.checkBox2.TabIndex = 4;
      this.checkBox2.Text = "Forced size of main text";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.textBox2.BorderStyle = BorderStyle.FixedSingle;
      this.textBox2.Enabled = false;
      this.textBox2.Location = new Point(6, 66);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(268, 20);
      this.textBox2.TabIndex = 3;
      this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
      this.label21.AutoSize = true;
      this.label21.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label21.Location = new Point(3, 47);
      this.label21.Name = "label21";
      this.label21.Size = new Size(57, 16);
      this.label21.TabIndex = 2;
      this.label21.Text = "Subtext";
      this.textBox1.BorderStyle = BorderStyle.FixedSingle;
      this.textBox1.Location = new Point(6, 24);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(268, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Arial", 9.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 238);
      this.label20.Location = new Point(3, 4);
      this.label20.Name = "label20";
      this.label20.Size = new Size(70, 16);
      this.label20.TabIndex = 0;
      this.label20.Text = "Main Text";
      this.tabPage4.AutoScroll = true;
      this.tabPage4.Controls.Add((Control) this.label25);
      this.tabPage4.Location = new Point(4, 23);
      this.tabPage4.Margin = new Padding(3, 4, 3, 4);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3, 4, 3, 4);
      this.tabPage4.Size = new Size(997, 100);
      this.tabPage4.TabIndex = 1;
      this.tabPage4.Text = "About";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.label25.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.label25.Location = new Point(3, 4);
      this.label25.Name = "label25";
      this.label25.Size = new Size(968, 318);
      this.label25.TabIndex = 0;
      this.label25.Text = componentResourceManager.GetString("label25.Text");
      this.button1.Cursor = Cursors.Hand;
      this.button1.Enabled = false;
      this.button1.FlatStyle = FlatStyle.Popup;
      this.button1.Font = new Font("Arial", 6.25f);
      this.button1.Location = new Point(884, 491);
      this.button1.Name = "button1";
      this.button1.Size = new Size(119, 19);
      this.button1.TabIndex = 3;
      this.button1.Text = "Background Color";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Cursor = Cursors.Hand;
      this.button2.FlatStyle = FlatStyle.Popup;
      this.button2.Font = new Font("Arial", 6.25f);
      this.button2.Location = new Point(799, 491);
      this.button2.Name = "button2";
      this.button2.Size = new Size(84, 19);
      this.button2.TabIndex = 4;
      this.button2.Text = "Save";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = CheckState.Checked;
      this.checkBox1.Cursor = Cursors.Hand;
      this.checkBox1.Font = new Font("Arial", 6.25f);
      this.checkBox1.Location = new Point(722, 494);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(73, 16);
      this.checkBox1.TabIndex = 6;
      this.checkBox1.Text = "Transparent";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.timer1.Interval = 200;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(0, 0);
      this.pictureBox1.Margin = new Padding(3, 4, 3, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(800, 490);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.saveFileDialog1.Filter = "PNG Image|*.png";
      this.saveFileDialog1.Title = "Select where would you like to have your logo saved.";
      this.AutoScaleMode = AutoScaleMode.None;
      this.ClientSize = new Size(1004, 617);
      this.Controls.Add((Control) this.checkBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.tabControl2);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = nameof (Form1);
      this.Text = "Axxa's World of Warcraft Logo Creator v1.2";
      this.Load += new EventHandler(this.Form1_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox5).EndInit();
      ((ISupportInitialize) this.pictureBox6).EndInit();
      ((ISupportInitialize) this.pictureBox7).EndInit();
      ((ISupportInitialize) this.pictureBox8).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((ISupportInitialize) this.pictureBox18).EndInit();
      ((ISupportInitialize) this.pictureBox17).EndInit();
      ((ISupportInitialize) this.pictureBox16).EndInit();
      ((ISupportInitialize) this.pictureBox9).EndInit();
      ((ISupportInitialize) this.pictureBox10).EndInit();
      ((ISupportInitialize) this.pictureBox11).EndInit();
      ((ISupportInitialize) this.pictureBox12).EndInit();
      ((ISupportInitialize) this.pictureBox13).EndInit();
      ((ISupportInitialize) this.pictureBox14).EndInit();
      ((ISupportInitialize) this.pictureBox15).EndInit();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.trackBar4.EndInit();
      this.trackBar3.EndInit();
      this.trackBar2.EndInit();
      this.trackBar1.EndInit();
      ((ISupportInitialize) this.pictureBox19).EndInit();
      this.tabControl2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.numericUpDown2.EndInit();
      this.numericUpDown1.EndInit();
      this.tabPage4.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
