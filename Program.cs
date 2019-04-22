// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Program
// Assembly: Axxa`s Wow Logo Creator v1.2, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3199C0A8-7792-4FE1-8122-460CFE3FEFA3
// Assembly location: C:\Users\hands\Desktop\Axxa`s Wow Logo Creator v1.2.exe

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
