// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.OldVersionForm
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using MySql.Data.MySqlClient;
using NaurokAnswers.DataBase;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace NaurokAnswers
{
  public class OldVersionForm : Form
  {
    private IContainer eval_a;
    private Label eval_b;
    private Button eval_c;
    private Label eval_d;

    public OldVersionForm() => this.eval_a();

    private void eval_a(object A_0, EventArgs A_1)
    {
      int A_1_1 = 13;
      try
      {
        using (NaurokAnswers.DataBase.ApplicationContext applicationContext = new NaurokAnswers.DataBase.ApplicationContext())
          Process.Start(applicationContext.Info.First<Info>((Expression<Func<Info, bool>>) (info => info.FieldName == Info.b("䀃椅缇搉怋愍焏瘑䐓眕缗缙", A_1_1))).FieldText);
      }
      catch (MySqlException ex)
      {
        Process.Start(Info.b("氃爅簇稉㘋ℍ㼏簑甓礕気氙礛樝ฟ刡吣ࠥ崧䬩", A_1_1));
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.eval_a != null)
        this.eval_a.Dispose();
      base.Dispose(disposing);
    }

    private void eval_a()
    {
      int A_1 = 18;
      this.eval_b = new Label();
      this.eval_c = new Button();
      this.eval_d = new Label();
      this.SuspendLayout();
      this.eval_b.AutoSize = true;
      this.eval_b.Font = new Font(Info.b("䐈戊渌紎縐怒稔焖洘㬚东縞传倢Ԥ琦䰨太䐬䤮", A_1), 12f);
      this.eval_b.Location = new Point(12, 9);
      this.eval_b.Name = Info.b("攈樊漌樎紐−", A_1);
      this.eval_b.Size = new Size(334, 25);
      this.eval_b.TabIndex = 0;
      this.eval_b.Text = Info.b("ᬌ㬎䔈㼊ㄐ№‐園堜⌞刘㼞Ḥ挦ᬠᐢ椬ᬮᄨጪ稴ጲ瘰瘲笼ା紸\x0A3A穄獆", A_1);
      this.eval_c.Font = new Font(Info.b("䐈戊渌紎縐怒稔焖洘㬚东縞传倢Ԥ琦䰨太䐬䤮", A_1), 12f);
      this.eval_c.Location = new Point(73, 85);
      this.eval_c.Name = Info.b("䴈搊稌愎紐簒琔猖嬘渚検欞丠䴢", A_1);
      this.eval_c.Size = new Size(214, 54);
      this.eval_c.TabIndex = 1;
      this.eval_c.Text = Info.b("⠌ㄎ㴈䠊℔儖夐㜖␜┞⼘尚漤", A_1);
      this.eval_c.UseVisualStyleBackColor = true;
      this.eval_c.Click += new EventHandler(this.eval_a);
      this.eval_d.AutoSize = true;
      this.eval_d.Font = new Font(Info.b("䐈戊渌紎縐怒稔焖洘㬚东縞传倢Ԥ琦䰨太䐬䤮", A_1), 7.8f);
      this.eval_d.Location = new Point(26, 43);
      this.eval_d.Name = Info.b("攈樊漌樎紐ℒ", A_1);
      this.eval_d.Size = new Size(311, 17);
      this.eval_d.TabIndex = 2;
      this.eval_d.Text = Info.b("⨌㼎㴈㐊⤔儖‐㜖☜嬞⌘Ⱊ愤ጦᤠᬢ樬ପᔨ\x0F2E瀴श\x0530瀲़Ⱦ缸\x0A3A慀繆筀畂ੌՎ浌絊摔ፖᑐ潒\x175C", A_1);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(361, 162);
      this.Controls.Add((Control) this.eval_d);
      this.Controls.Add((Control) this.eval_c);
      this.Controls.Add((Control) this.eval_b);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = Info.b("䘈朊椌夎琐愒昔縖瘘甚嬜瀞匠丢", A_1);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = Info.b("ᜌ㨎〈ㄊ⌔⬖圐−㤘␞崘ℚሤ挦ᔠᬢᔬ栮", A_1);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
