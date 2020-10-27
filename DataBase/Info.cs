// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.DataBase.Info
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

namespace NaurokAnswers.DataBase
{
  public class Info
  {
    public int Id { get; set; }

    public string FieldName { get; set; }

    public string FieldText { get; set; }

    internal static string b(string A_0, int A_1)
    {
      char[] charArray = A_0.ToCharArray();
      int num1 = 477439709 + A_1 + 25;
      int num2 = 0;
      if (num2 < 1)
        goto label_2;
label_1:
      int index1 = num2;
      char[] chArray = charArray;
      int index2 = index1;
      int num3 = (int) (short) charArray[index1];
      int num4 = num3 & (int) byte.MaxValue;
      int num5 = num1;
      int num6 = num5 + 1;
      byte num7 = (byte) (num4 ^ num5);
      int num8 = num3 >> 8;
      int num9 = num6;
      num1 = num9 + 1;
      int num10 = (int) (byte) (num8 ^ num9);
      int num11 = (int) (ushort) ((uint) num7 << 8 | (uint) (byte) num10);
      chArray[index2] = (char) num11;
      ++num2;
label_2:
      if (num2 >= charArray.Length)
        return string.Intern(new string(charArray));
      goto label_1;
    }
  }
}
