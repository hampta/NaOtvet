// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using System;
using System.Runtime.InteropServices;

[ComVisible(false)]
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : Attribute
{
  private string a;
  private bool b;
  private int c;

  public DotfuscatorAttribute(string a, int c, bool b)
  {
    DotfuscatorAttribute dotfuscatorAttribute = this;
    // ISSUE: explicit constructor call
    dotfuscatorAttribute.\u002Ector();
    dotfuscatorAttribute.a = a;
    this.c = c;
    this.b = b;
  }

  public string A => this.a;

  public string a() => this.a;

  public bool B => this.b;

  public bool b() => this.b;

  public int C => this.c;

  public int c() => this.c;
}
