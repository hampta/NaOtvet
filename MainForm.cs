// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.MainForm
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
using System.Media;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NaurokAnswers
{
  public class MainForm : Form
  {
    private readonly string a;
    private readonly string eval_b;
    private readonly int eval_c;
    private readonly int eval_d;
    private Stopwatch eval_e;
    private FinderSystem eval_f;
    private bool eval_g;
    private string eval_h;
    private IContainer eval_i;
    private TextBox eval_j;
    private Button eval_k;
    private TextBox eval_l;
    private Button eval_m;
    private Label eval_n;
    private SplitContainer eval_o;
    private PictureBox eval_p;
    private TabControl eval_q;
    private TabPage eval_r;
    private Label eval_s;
    private TabPage eval_t;
    private Label eval_u;
    private LinkLabel eval_v;
    private Label eval_w;
    private Button eval_x;
    private Label eval_y;
    private Label eval_z;
    private Label aa;
    private Label ab;
    private Label eval_ac;
    private Label ad;
    private Label eval_ae;
    private Label eval_af;

    public MainForm()
    {
      int A_1 = 7;
      this.a = Info.b("闽痿码⨃攅朇渉椋\x200D缏琑爓缕笗猙紛爝怟䔡䤣䜥䄧䘩ȫ䴭弯弱", A_1);
      this.eval_b = Info.b("쳽㓿㜁\x3103甅㤇", A_1);
      this.eval_c = 5;
      this.eval_d = 1000;
      this.eval_e = new Stopwatch();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.eval_c();
    }

    private void eval_g(object A_0, EventArgs A_1)
    {
      int A_1_1 = 18;
      try
      {
        using (NaurokAnswers.DataBase.ApplicationContext applicationContext = new NaurokAnswers.DataBase.ApplicationContext())
        {
          string fieldText = applicationContext.Info.First<Info>((Expression<Func<Info, bool>>) (info => info.FieldName == Info.b("䠈笊紌夎琐愒昔縖瘘甚", A_1_1))).FieldText;
          if (int.Parse(Assembly.GetExecutingAssembly().GetName().Version.ToString().Replace(Info.b("✈", A_1_1), "")) < int.Parse(fieldText.Replace(Info.b("✈", A_1_1), "")))
          {
            int num = (int) new OldVersionForm().ShowDialog();
            Application.Exit();
          }
          this.eval_h = applicationContext.Info.First<Info>((Expression<Func<Info, bool>>) (info => info.FieldName == Info.b("倈搊砌笎搐焒瀔䄖瀘缚砜瀞洠䨢䬤䰦", A_1_1))).FieldText;
        }
      }
      catch (MySqlException ex)
      {
        int num = (int) new OldVersionForm().ShowDialog();
        Application.Exit();
      }
    }

    private void eval_f(object A_0, EventArgs A_1)
    {
      int A_1_1 = 2;
      if (!HelpClass.IsUserAdministrator())
      {
        int num = (int) MessageBox.Show(Info.b("\xECFC뫾웸쟺℀ㄆ一✆䰌㔎伈㜊匔☖㤔㜖帜夞⌘㼞ဤ栦Ԥᠢ椬ᔮḨ漪Ĵ༶रܲᤸ笾സฺ罄ņ畀籂祌歊籈ъၔᅖᕐ扒汜睚絜捚彤啦偠╢屬䭪婨彪乴ぶ㑰㕲䅼㥾ㅸ彾뒄튆ꖄ욂ꦈ뒎춈뾊ꎔꎖꦐ꾒릘ꮞꦘꎚ馤麦鶠\xE6A2\xEBAC\xEBAE鶨\xEDAA辴\xF3B6薰馶馸꺾蒸龾\xF0C4胆\xF1C0\xF2C2诌\xEBCA靖ￊ\xE5D4\xE3D6\xE8D0\xF7D6\xE5DC\xEBDE\xE7D8黚\xD9E4\xDFE6헠\xDCE2ꗬ훮ꛨ훪퇰쳶뗰쿲쟼믾엸뷺㐄䄆⬄", A_1_1), Info.b("\xD8FC쇾쏸뿺㼄䈆䜀䬂⤈䬎㴈㸊⼔儖帐", A_1_1), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;
    }

    private void eval_a(object A_0, FormClosingEventArgs A_1)
    {
      int A_1_1 = 13;
      if (this.eval_f == null || this.eval_f.IsStoped)
        return;
      if (MessageBox.Show(Info.b("ᘇ䴁⠇䤍㸏㬉個✕⤗崑㐗㨙嬟尙ḛȡ愧ᠡ樣ር港ᬩု5缷\x0F31稳Ƚ̻", A_1_1), Info.b("ᬇ㠁㰃䠍㸏㬉個␕‗⌑┓∝⤟", A_1_1), MessageBoxButtons.YesNo) == DialogResult.Yes)
        this.d();
      else
        A_1.Cancel = true;
    }

    private void eval_e(object A_0, EventArgs A_1)
    {
      if (this.eval_l.Enabled)
        return;
      this.eval_j.Clear();
      this.eval_e.Restart();
      this.eval_k.Enabled = false;
      this.eval_x.Enabled = false;
      this.eval_k.Enabled = false;
      this.eval_m.Enabled = true;
      try
      {
        if (this.eval_f == null)
        {
          this.eval_f = new FinderSystem(new AccountLoginData()
          {
            Login = this.a,
            Password = this.eval_b
          }, this.eval_l.Text, this.eval_c, this.eval_d);
          this.eval_f.OnNewDocument += new EventHandler<OnNewDocumentArgs>(this.eval_a);
          this.eval_f.OnDocumentIsFound += new EventHandler<OnDocumentIsFoundArgs>(this.eval_a);
          this.eval_f.OnError += new EventHandler<OnErrorArgs>(this.eval_a);
          this.eval_f.Start();
        }
        else
          this.eval_f.Restart(this.eval_l.Text);
      }
      catch (Exception ex)
      {
        this.eval_a((object) this, new OnErrorArgs(ex));
      }
    }

    private void eval_d(object A_0, EventArgs A_1)
    {
      int A_1_1 = 15;
      if (MessageBox.Show(Info.b("ᐁ䌃⨉伏㰉┋刕℗⬑匓㘙㰛夙戛ᰥУ挡ᘣ栭ᐯ氩ԫሱ\x0A37眱稳\x0A3DĿ9爻穅هੁ桇੍籏罉湋ၕ\x1757癕杓ᩝ扟浙⁛剥塧婡⍣啩", A_1_1), Info.b("ᤁ㘃㸍丏㰉┋刕∗∑ⴓ✝␟⬙", A_1_1), MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.d();
    }

    private void d()
    {
      this.eval_f?.Stop();
      this.eval_e.Stop();
      this.eval_m.Enabled = false;
      this.eval_k.Enabled = true;
      this.eval_x.Enabled = true;
      this.eval_k.Enabled = true;
    }

    private void a(string A_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      MainForm.eval_b evalB = new MainForm.eval_b();
      // ISSUE: reference to a compiler-generated field
      evalB.eval_a = this;
      // ISSUE: reference to a compiler-generated field
      evalB.b = A_0;
      if (this.eval_j.InvokeRequired)
      {
        // ISSUE: reference to a compiler-generated method
        this.eval_j.Invoke((Delegate) new Action(evalB.eval_b));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        this.eval_j.AppendText(evalB.b + Environment.NewLine);
      }
    }

    private void eval_a(object A_0, OnNewDocumentArgs A_1) => this.a(A_1.DocumentId.ToString().Last<char>().ToString());

    private void eval_a(object A_0, OnDocumentIsFoundArgs A_1)
    {
      int A_1_1 = 7;
      this.a(Info.b("\xE3F9჻ᬅဇጁᔃᐍⴋ", A_1_1));
      this.a(string.Format(Info.b("\xE9F9・䀅䐇㘁伃㼍ㄏ〉』―吗⌑␓⼝℟☙᨟ȡ弣ᘥ唧Щ", A_1_1), (object) this.eval_e.Elapsed));
      this.Invoke((Delegate) (() =>
      {
        this.d();
        SystemSounds.Asterisk.Play();
        AnswersForm answersForm = new AnswersForm(this.eval_f.GetTestSession());
        answersForm.TopMost = true;
        answersForm.Show();
        answersForm.TopMost = false;
      }));
    }

    private void eval_a(object A_0, OnErrorArgs A_1) => this.Invoke((Delegate) (() =>
    {
      int A_1_1 = 15;
      this.d();
      SystemSounds.Exclamation.Play();
      if (this.eval_f != null && this.eval_f.GetTestSession() != null && this.eval_f.GetTestSession().Questions.Count != this.eval_f.GetTestSession().TestQuestionsCount)
      {
        int num1 = (int) MessageBox.Show(Info.b("ᐁ䌃⨉㈏䰉∋✕嘗⌑⌓∝㰛⌙ရȡᤧጡሣᐭ港ဩ瀫礵ķᘵਲ਼н̿縹縻ͅཇ晅\x0A43罍\x0D4F\x0C49恋繑瑓楑晓\x175Dṟ恙屛Ⅵ䑣奡⡣呭彯\x2E69䁫乵䡷䙱塷䝽䥿幽셻뺅몇낁붃좍겋뎉ꂋꮕ횗꺑뢗꒝\xDE9F겙閛\xE0A5\xEFA7", A_1_1), Info.b("᠁䀃㈍㴏㐉\x200B", A_1_1), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        int num2 = (int) MessageBox.Show(Info.b("ᐁ㘃㴍ㄏ㘉⨋⤕␗㘕┓⼝␟⤙ማᜥ攧搡ᔣᨭ振อห稵షܱȳ\x0A3Dሻḽ刻籅獇穁癃籍煏灉籏牑晗ᵑ硗桝湟歙孛婥䑣孡嵣塭奯\x2E69䵫㥵䵷噵\x2D77ཹ㕻\x1A7Dꁿ명뾇뺁ꢇ좍릏쾉튋늑힗ꂑ궓몙ꮟ꺙骛鲥馧\xE1A1鶣鞭芫", A_1_1), Info.b("᠁䀃㈍㴏㐉\x200B", A_1_1), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }));

    private void eval_a(object A_0, LinkLabelLinkClickedEventArgs A_1) => Process.Start(Info.b("樁瀃爅砇礉㘋ℍ㼏簑甓挕樗甙眛〝䌟䴡䤣ࠥ崧䬩̫娭唯䄱䀳ᤵ刷唹唻倽", 11));

    private void eval_c(object A_0, EventArgs A_1)
    {
      int A_1_1 = 10;
      TextBox textBox = (TextBox) A_0;
      string pattern = Info.b("崀琂縄㼆琈☊儌砎樐✒栔㨖䔘氚昜⬞尠ย礤倦刨Ἢ倬Ȯ洰䐲临ضସ䘺", A_1_1);
      Regex regex1 = new Regex(pattern);
      Regex regex2 = new Regex(Info.b("崀䈂", A_1_1) + pattern + Info.b("崀礂", A_1_1));
      Regex regex3 = new Regex(Info.b("崀䈂ⴄ漆紈缊紌簎⬐㰒㨔㸖☘甚簜樞匠䰢两༦用Ԫ丬䀮尰ᨲ\x0A34欶\x1738为尼ှ㕀♂㙄㍆晈捊㥌⩎≐❒㱔㥖㹘❚⽜㩞`རᅤ\x0E66Ѩ\x0E6A䁬౮ᵰᩲၴ\x1976\x0D78剺剼", A_1_1) + pattern + Info.b("崀礂", A_1_1));
      if (textBox.Text == string.Empty && !regex2.IsMatch(textBox.Text))
        return;
      if (regex3.IsMatch(textBox.Text) && regex1.IsMatch(textBox.Text))
        textBox.Text = regex1.Match(textBox.Text).Value;
      if (regex2.IsMatch(textBox.Text))
      {
        textBox.BackColor = Color.LimeGreen;
        textBox.Enabled = false;
      }
      else
      {
        textBox.Text = string.Empty;
        textBox.BackColor = Color.Red;
      }
    }

    private void eval_b(object A_0, EventArgs A_1)
    {
      this.eval_l.Text = string.Empty;
      this.eval_l.BackColor = Color.FromKnownColor(KnownColor.Control);
      this.eval_l.Enabled = true;
    }

    private void eval_a(object A_0, EventArgs A_1) => Process.Start(Info.b("鋹裻諽烿焁㸃⤅✇紉笋礍㸏欑笓挕気漙縛笝ฟ䄡䬣䬥ܧ䤩̫䔭䔯䠱圳夵尷弹", 3));

    private void eval_a(object A_0, TabControlEventArgs A_1)
    {
      if (this.eval_g)
        return;
      this.eval_g = true;
      Process.Start(this.eval_h);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.eval_i != null)
        this.eval_i.Dispose();
      base.Dispose(disposing);
    }

    private void eval_c()
    {
      int A_1 = 1;
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      this.eval_j = new TextBox();
      this.eval_k = new Button();
      this.eval_l = new TextBox();
      this.eval_m = new Button();
      this.eval_n = new Label();
      this.eval_o = new SplitContainer();
      this.eval_p = new PictureBox();
      this.eval_q = new TabControl();
      this.eval_r = new TabPage();
      this.eval_z = new Label();
      this.eval_x = new Button();
      this.eval_s = new Label();
      this.eval_t = new TabPage();
      this.eval_ae = new Label();
      this.eval_af = new Label();
      this.eval_ac = new Label();
      this.ad = new Label();
      this.aa = new Label();
      this.ab = new Label();
      this.eval_y = new Label();
      this.eval_w = new Label();
      this.eval_u = new Label();
      this.eval_v = new LinkLabel();
      this.eval_o.BeginInit();
      this.eval_o.Panel1.SuspendLayout();
      this.eval_o.Panel2.SuspendLayout();
      this.eval_o.SuspendLayout();
      ((ISupportInitialize) this.eval_p).BeginInit();
      this.eval_q.SuspendLayout();
      this.eval_r.SuspendLayout();
      this.eval_t.SuspendLayout();
      this.SuspendLayout();
      this.eval_j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.eval_j.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 8f);
      this.eval_j.Location = new Point(6, 118);
      this.eval_j.MaxLength = 600000;
      this.eval_j.Multiline = true;
      this.eval_j.Name = Info.b("듷闹鯻\xAAFD旿稁瀃", A_1);
      this.eval_j.ReadOnly = true;
      this.eval_j.ScrollBars = ScrollBars.Both;
      this.eval_j.Size = new Size(248, 221);
      this.eval_j.TabIndex = 0;
      this.eval_j.TabStop = false;
      this.eval_k.Dock = DockStyle.Fill;
      this.eval_k.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_k.Location = new Point(0, 0);
      this.eval_k.Name = Info.b("꯷軹鷻賽瓿䀁焃爅簇攉戋", A_1);
      this.eval_k.Size = new Size(250, 41);
      this.eval_k.TabIndex = 2;
      this.eval_k.Text = Info.b("\xD9F3룽쳿뻹䋻", A_1);
      this.eval_k.UseVisualStyleBackColor = true;
      this.eval_k.Click += new EventHandler(this.eval_e);
      this.eval_l.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.eval_l.Location = new Point(53, 6);
      this.eval_l.Name = Info.b("귷迹뗻髽哿朁簃爅", A_1);
      this.eval_l.Size = new Size(433, 22);
      this.eval_l.TabIndex = 0;
      this.eval_l.TextChanged += new EventHandler(this.eval_c);
      this.eval_m.Dock = DockStyle.Fill;
      this.eval_m.Enabled = false;
      this.eval_m.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_m.Location = new Point(0, 0);
      this.eval_m.Name = Info.b("꯷軹鏻軽䋿省瀃爅朇搉", A_1);
      this.eval_m.Size = new Size(256, 41);
      this.eval_m.TabIndex = 3;
      this.eval_m.Text = Info.b("\xD9F3룽싿쇹", A_1);
      this.eval_m.UseVisualStyleBackColor = true;
      this.eval_m.Click += new EventHandler(this.eval_d);
      this.eval_n.AutoSize = true;
      this.eval_n.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_n.Location = new Point(6, 90);
      this.eval_n.Name = Info.b("铷鯹黻鯽泿㌁", A_1);
      this.eval_n.Size = new Size(52, 25);
      this.eval_n.TabIndex = 4;
      this.eval_n.Text = Info.b("\xE3F3쓽쿿쓽", A_1);
      this.eval_o.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.eval_o.Location = new Point(6, 34);
      this.eval_o.Name = Info.b("请諹郻韽瓿䄁欃栅簇欉攋怍甏怑┓", A_1);
      this.eval_o.Panel1.Controls.Add((Control) this.eval_k);
      this.eval_o.Panel2.Controls.Add((Control) this.eval_m);
      this.eval_o.Size = new Size(510, 41);
      this.eval_o.SplitterDistance = 250;
      this.eval_o.TabIndex = 5;
      this.eval_p.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.eval_p.BackColor = Color.Black;
      this.eval_p.Cursor = Cursors.Hand;
      this.eval_p.Image = (Image) global::eval_b.eval_c;
      this.eval_p.Location = new Point(260, 118);
      this.eval_p.Name = Info.b("듷闹鯻釽䧿漁攃愅洇", A_1);
      this.eval_p.Size = new Size(256, 221);
      this.eval_p.SizeMode = PictureBoxSizeMode.Zoom;
      this.eval_p.TabIndex = 6;
      this.eval_p.TabStop = false;
      this.eval_p.Click += new EventHandler(this.eval_a);
      this.eval_q.Controls.Add((Control) this.eval_r);
      this.eval_q.Controls.Add((Control) this.eval_t);
      this.eval_q.Dock = DockStyle.Fill;
      this.eval_q.Location = new Point(0, 0);
      this.eval_q.Name = Info.b("賷鯹黻뷽濿氁瀃琅朇昉㴋", A_1);
      this.eval_q.Padding = new Point(0, 0);
      this.eval_q.SelectedIndex = 0;
      this.eval_q.Size = new Size(532, 376);
      this.eval_q.TabIndex = 7;
      this.eval_q.Selected += new TabControlEventHandler(this.eval_a);
      this.eval_r.Controls.Add((Control) this.eval_z);
      this.eval_r.Controls.Add((Control) this.eval_x);
      this.eval_r.Controls.Add((Control) this.eval_s);
      this.eval_r.Controls.Add((Control) this.eval_l);
      this.eval_r.Controls.Add((Control) this.eval_p);
      this.eval_r.Controls.Add((Control) this.eval_j);
      this.eval_r.Controls.Add((Control) this.eval_o);
      this.eval_r.Controls.Add((Control) this.eval_n);
      this.eval_r.Location = new Point(4, 25);
      this.eval_r.Name = Info.b("맷铹迻觽旿瀁眃嘅椇洉椋", A_1);
      this.eval_r.Padding = new Padding(3);
      this.eval_r.Size = new Size(524, 347);
      this.eval_r.TabIndex = 0;
      this.eval_r.Text = Info.b("\xE7F3쓽쓿뿹㫻∁㨇䐁㨃㼍丏〉∋", A_1);
      this.eval_r.UseVisualStyleBackColor = true;
      this.eval_z.AutoSize = true;
      this.eval_z.Location = new Point(6, 9);
      this.eval_z.Name = Info.b("铷鯹黻鯽泿㐁", A_1);
      this.eval_z.Size = new Size(41, 17);
      this.eval_z.TabIndex = 8;
      this.eval_z.Text = Info.b("귷迹뗻髽㫿", A_1);
      this.eval_x.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.eval_x.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.eval_x.Location = new Point(492, 5);
      this.eval_x.Name = Info.b("믷雹駻\x9FFD狿圁焃伅氇帉椋瘍搏們愓戕気甙爛", A_1);
      this.eval_x.Size = new Size(24, 24);
      this.eval_x.TabIndex = 1;
      this.eval_x.Text = Info.b("ꃷ", A_1);
      this.eval_x.UseVisualStyleBackColor = true;
      this.eval_x.Click += new EventHandler(this.eval_b);
      this.eval_s.AutoSize = true;
      this.eval_s.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_s.Location = new Point((int) byte.MaxValue, 90);
      this.eval_s.Name = Info.b("铷鯹黻鯽泿、", A_1);
      this.eval_s.Size = new Size(183, 25);
      this.eval_s.TabIndex = 7;
      this.eval_s.Text = Info.b("\xE8F3죽뻿샹䃻∁Ⰳ㬁㠃㰍』㘉刋✕㴓Ⱅ", A_1);
      this.eval_t.Controls.Add((Control) this.eval_ae);
      this.eval_t.Controls.Add((Control) this.eval_af);
      this.eval_t.Controls.Add((Control) this.eval_ac);
      this.eval_t.Controls.Add((Control) this.ad);
      this.eval_t.Controls.Add((Control) this.aa);
      this.eval_t.Controls.Add((Control) this.ab);
      this.eval_t.Controls.Add((Control) this.eval_y);
      this.eval_t.Controls.Add((Control) this.eval_w);
      this.eval_t.Controls.Add((Control) this.eval_u);
      this.eval_t.Controls.Add((Control) this.eval_v);
      this.eval_t.Location = new Point(4, 25);
      this.eval_t.Name = Info.b("뿷迹闻髽旿刁攃愅洇", A_1);
      this.eval_t.Padding = new Padding(3);
      this.eval_t.Size = new Size(524, 347);
      this.eval_t.TabIndex = 1;
      this.eval_t.Text = Info.b("\xE2F3쫽웿\xDEFD㿻㰅㼇䨁㼃㐍㸏㸉刋帕唗夑", A_1);
      this.eval_t.UseVisualStyleBackColor = true;
      this.eval_ae.AutoSize = true;
      this.eval_ae.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_ae.Location = new Point(8, 317);
      this.eval_ae.Name = Info.b("铷鯹黻鯽泿㌁㘃", A_1);
      this.eval_ae.Size = new Size(470, 25);
      this.eval_ae.TabIndex = 10;
      this.eval_ae.Text = Info.b("탳쫽쿿\xDEFD㣿㠁␃㤁㘃⨉㈏㐉⸋⼕北☑┓∝刟㈝\x001Fᴥᨧ椡ᨣር港戩焫紵ᐳ࠱ȳܽȿḽĻ扁穇с穃罍๏繉汋橕", A_1);
      this.eval_af.AutoSize = true;
      this.eval_af.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_af.Location = new Point(8, 279);
      this.eval_af.Name = Info.b("铷鯹黻鯽泿㌁㔃", A_1);
      this.eval_af.Size = new Size(508, 25);
      this.eval_af.TabIndex = 9;
      this.eval_af.Text = Info.b("탳쫽쿿\xDEFD㟿㠁␃㠁㸃㈍㠏㸉⤋倕℗㘕〗☝∟⠙ᔛ急Уᄡᠣᜭ振氩簫ሱ\x0A37琱ᠷ笽िй̻罅灇ു桇繍牏湍ᝋ払ᕗᕑ煗", A_1);
      this.eval_ac.AutoSize = true;
      this.eval_ac.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_ac.Location = new Point(8, 241);
      this.eval_ac.Name = Info.b("铷鯹黻鯽泿㌁㐃", A_1);
      this.eval_ac.Size = new Size(306, 25);
      this.eval_ac.TabIndex = 8;
      this.eval_ac.Text = Info.b("탳쫽쿿\xDEFD㛿㠁␃㬁㠃㰍』㘉刋✕㐓Ⱁ┓␝⌟␙挛ȡأܡ樣ᨭ氯氩ሯ", A_1);
      this.ad.AutoSize = true;
      this.ad.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.ad.Location = new Point(8, 203);
      this.ad.Name = Info.b("铷鯹黻鯽泿㬁", A_1);
      this.ad.Size = new Size(473, 25);
      this.ad.TabIndex = 7;
      this.ad.Text = Info.b("탳쫽쿿\xDEFD㗿㠁␃㌁䤃ㄍ㐏⸍∋匕䔗㘕✓娝ⰟⰙ\x181Bᤥ栧ᬡᘣةఫᄩหवķᘵ礳砽ి̹画E摃煁絃煍ᵏ獉ᭋ湕", A_1);
      this.aa.AutoSize = true;
      this.aa.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 7.8f);
      this.aa.ForeColor = Color.Red;
      this.aa.Location = new Point(10, 135);
      this.aa.Name = Info.b("铷鯹黻鯽泿㨁", A_1);
      this.aa.Size = new Size(427, 17);
      this.aa.TabIndex = 6;
      this.aa.Text = Info.b("\xEAF3믽짿\xDEFD䇻㤅ㄇ㈁䬃䐍䔏㘉┋㈑尗☑⬓∝㰛⌙挛ᐥᤧᠡࠧḭ\x192Fᔩ+瀵砷ᘵਲ਼н᰻హ稻祅瑇牁牃罍汋汍佋汕汗ᝑ打穙扟᱙剛坥♧塡婣䡩", A_1);
      this.ab.AutoSize = true;
      this.ab.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.ab.Location = new Point(8, 165);
      this.ab.Name = Info.b("铷鯹黻鯽泿㔁", A_1);
      this.ab.Size = new Size(353, 25);
      this.ab.TabIndex = 5;
      this.ab.Text = Info.b("탳쫽쿿\xDEFD㓿㠁␃㐁䤃䠍㰏㰉⠋倕堗㘕夓嬝土┙ᨛ愥Уᐡࠧᔭሯᔩԫሱᘳ挵䴷猹堻᰽", A_1);
      this.eval_y.AutoSize = true;
      this.eval_y.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_y.Location = new Point(8, 86);
      this.eval_y.Name = Info.b("铷鯹黻鯽泿㜁", A_1);
      this.eval_y.Size = new Size(260, 25);
      this.eval_y.TabIndex = 4;
      this.eval_y.Text = Info.b("탳쫽쿿\xDEFD㏿㠁␃䜁㈃㐍㌏㘉個Ⱅ☗☑娓嘝㰛弙愛椥ἧᰡ欣", A_1);
      this.eval_w.AutoSize = true;
      this.eval_w.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_w.Location = new Point(8, 48);
      this.eval_w.Name = Info.b("铷鯹黻鯽泿㘁", A_1);
      this.eval_w.Size = new Size(473, 25);
      this.eval_w.TabIndex = 3;
      this.eval_w.Text = Info.b("탳쫽쿿\xDEFD\x32FF㠁␃㐁㨃㼍䴏䰉⠋㈑⸗⠑Ⱃ㘙㰛☙ᰛ津Уḡࠧᜭᰯᠩ+瀵砷ᘵܳ稽п缹縻睅灇繁畃牍๏ɉᅋᵕ", A_1);
      this.eval_u.AutoSize = true;
      this.eval_u.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_u.Location = new Point(8, 13);
      this.eval_u.Name = Info.b("铷鯹黻鯽泿\x3101", A_1);
      this.eval_u.Size = new Size(250, 25);
      this.eval_u.TabIndex = 2;
      this.eval_u.Text = Info.b("탳쫽쿿\xDEFDㇿ㠁␃㤁㴃䨍㤏㜉刋⨕㐓⤑☓㨙崟弙欛ᤥḧጡ", A_1);
      this.eval_v.AutoSize = true;
      this.eval_v.Font = new Font(Info.b("뗷鏹\x9FFB賽濿焁欃怅簇⨉弋漍縏愑㐓䔕紗栙甛砝", A_1), 12f);
      this.eval_v.Location = new Point(252, 13);
      this.eval_v.Name = Info.b("닷闹闻都仿持焃琅朇愉䀋漍爏眑砓", A_1);
      this.eval_v.Size = new Size(214, 25);
      this.eval_v.TabIndex = 1;
      this.eval_v.TabStop = true;
      this.eval_v.Text = Info.b("雷鯹觻賽濿椁⨃攅朇有∋笍焏㴑怓猕欗渙㌛琝伟䬡䨣", A_1);
      this.eval_v.LinkClicked += new LinkLabelLinkClickedEventHandler(this.eval_a);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(532, 376);
      this.Controls.Add((Control) this.eval_q);
      this.Icon = (Icon) componentResourceManager.GetObject(Info.b("\xDCF7軹铻韽珿Ⰱ䴃攅朇搉", A_1));
      this.MaximumSize = new Size(790, 650);
      this.MinimumSize = new Size(550, 423);
      this.Name = Info.b("뗷鯹闻都䛿洁瘃欅", A_1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = Info.b("\xE5F3쫽\xE2FF볹㋻㜅䘇★㤇␉㴋", A_1);
      this.FormClosing += new FormClosingEventHandler(this.eval_a);
      this.Load += new EventHandler(this.eval_g);
      this.Shown += new EventHandler(this.eval_f);
      this.eval_o.Panel1.ResumeLayout(false);
      this.eval_o.Panel2.ResumeLayout(false);
      this.eval_o.EndInit();
      this.eval_o.ResumeLayout(false);
      ((ISupportInitialize) this.eval_p).EndInit();
      this.eval_q.ResumeLayout(false);
      this.eval_r.ResumeLayout(false);
      this.eval_r.PerformLayout();
      this.eval_t.ResumeLayout(false);
      this.eval_t.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
