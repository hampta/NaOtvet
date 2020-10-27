// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.AnswersForm
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using NaurokAnswers.DataBase;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NaurokAnswers
{
  public class AnswersForm : Form
  {
    private TestSession eval_a;
    private IContainer eval_b;
    private RichTextBox eval_c;
    private Panel eval_d;

    public AnswersForm(TestSession testSession)
    {
      this.eval_a();
      this.eval_a = testSession;
    }

    private void eval_a(object A_0, EventArgs A_1) => this.eval_b();

    private int eval_c() => this.eval_a.Questions.Select<TestQuestion, int>((Func<TestQuestion, int>) (A_0 => A_0.Points)).Sum();

    private void eval_b()
    {
      int A_1 = 3;
      int num1 = this.eval_c();
      Regex regex = new Regex(Info.b("웹ꟻꃽ㻿弁⸃㠅", A_1));
      this.eval_c.Clear();
      foreach (TestQuestion question in this.eval_a.Questions)
      {
        string str1 = regex.Replace(question.Content, "");
        double num2 = Math.Round((double) question.Points * 12.0 / (double) num1, 1);
        RichTextBox evalC = this.eval_c;
        evalC.Text = evalC.Text + Info.b("\xE8FD\xE2FF\xE1F9\x20FBᰅ┇㰅⠇", A_1) + str1;
        this.eval_c.Text += Environment.NewLine;
        this.eval_c.Text += string.Format(Info.b("\xEBFD\xECFF\xE5F9\x1BFB⤅␃ᄁ᠃⨉ḏဉ་㈕ਗ㜑∗㨙望⸝崟ጥਣ", A_1), (object) num2);
        this.eval_c.Text += Environment.NewLine;
        if (question.Answers.Count > 1)
        {
          this.eval_c.Text += Info.b("\xE4FD\xDEFF\xECF9ᗻ ⼇㰅⠇", A_1);
          this.eval_c.Text += Environment.NewLine;
          for (int index = 0; index < question.Answers.Count; ++index)
          {
            string str2 = regex.Replace(question.Answers[index].Content, "");
            this.eval_c.Text += string.Format(Info.b("\xDAF9\xDCFB藽ヿ缁⨃★猇㬉焋", A_1), (object) (index + 1), (object) str2);
            this.eval_c.Text += Environment.NewLine;
          }
        }
        else
        {
          this.eval_c.Text += Info.b("\xE4FD\xDEFF\xECF9ᗻ 㸃★", A_1);
          this.eval_c.Text += regex.Replace(question.Answers.First<QuestionOption>().Content, "");
          this.eval_c.Text += Environment.NewLine;
        }
        this.eval_c.Text += Environment.NewLine;
      }
    }

    private void eval_a(object A_0, FormClosingEventArgs A_1)
    {
      int A_1_1 = 6;
      if (MessageBox.Show(Info.b("\xEFF8듺℀䄆㬀䀂㐌㔎ⴌ䨊⼔儖ⴐ唒Ⱌ㬚⨘⼚ᬤ挦渠攢攬ପ怨洪༴ጲରലмԾȼ", A_1_1), Info.b("\xE2F8쇺䌄㜆㜀㈂䤌㴎㤈㨊Ⱄ⬖‐", A_1_1), MessageBoxButtons.YesNo) == DialogResult.Yes)
        return;
      A_1.Cancel = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.eval_b != null)
        this.eval_b.Dispose();
      base.Dispose(disposing);
    }

    private void eval_a()
    {
      int A_1 = 10;
      this.eval_c = new RichTextBox();
      this.eval_d = new Panel();
      this.eval_d.SuspendLayout();
      this.SuspendLayout();
      this.eval_c.BackColor = SystemColors.Control;
      this.eval_c.BorderStyle = BorderStyle.None;
      this.eval_c.Dock = DockStyle.Fill;
      this.eval_c.Font = new Font(Info.b("䰀樂昄甆昈砊戌椎攐㌒䘔瘖眘栚㴜䰞䐠儢䰤䄦", A_1), 12f);
      this.eval_c.Location = new Point(0, 0);
      this.eval_c.Name = Info.b("唀昂約猆䬈搊甌", A_1);
      this.eval_c.ReadOnly = true;
      this.eval_c.Size = new Size(803, 484);
      this.eval_c.TabIndex = 1;
      this.eval_c.TabStop = false;
      this.eval_c.Text = "";
      this.eval_d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.eval_d.Controls.Add((Control) this.eval_c);
      this.eval_d.Location = new Point(12, 12);
      this.eval_d.Name = Info.b("焀戂欄戆攈㨊", A_1);
      this.eval_d.Size = new Size(803, 484);
      this.eval_d.TabIndex = 2;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(827, 508);
      this.Controls.Add((Control) this.eval_d);
      this.Name = Info.b("䀀洂瘄瀆氈礊縌䤎縐愒研", A_1);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = Info.b("ጄ㴆㨀䜂㜌䨎\x200Cㄊ匔№‐唒", A_1);
      this.FormClosing += new FormClosingEventHandler(this.eval_a);
      this.Load += new EventHandler(this.eval_a);
      this.eval_d.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
