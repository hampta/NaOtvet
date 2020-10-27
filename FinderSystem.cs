// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.FinderSystem
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using NaurokAnswers.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NaurokAnswers
{
  public class FinderSystem
  {
    private const double eval_a = 9.55;

    private RequestsSender requestsSender { get; set; } = new RequestsSender();

    private List<DocumentFinder> documentFinders { get; set; } = new List<DocumentFinder>();

    private TestSession testSession { get; set; }

    private AccountLoginData accountData { get; set; }

    public int ThreadsCount { get; private set; }

    public int StartDocumentId { get; private set; }

    public string TestSessionUuId { get; private set; }

    public int FinderIterationsCount { get; private set; }

    public bool IsStoped { get; private set; } = true;

    public bool TestIsFound { get; private set; }

    public int CheckedDocumentsCount => this.documentFinders.Select<DocumentFinder, int>((Func<DocumentFinder, int>) (A_0 => A_0.CheckedDocumentsCount)).Sum();

    public event EventHandler<OnNewDocumentArgs> OnNewDocument;

    public event EventHandler<OnDocumentIsFoundArgs> OnDocumentIsFound;

    public event EventHandler<OnErrorArgs> OnError;

    public FinderSystem(
      AccountLoginData accountData,
      string testSessionUuId,
      int threadsCount,
      int finderIterationsCount)
    {
      this.accountData = accountData;
      this.ThreadsCount = threadsCount;
      this.FinderIterationsCount = finderIterationsCount;
      this.TestSessionUuId = testSessionUuId;
      Task.Run(new Action(this.eval_d)).Wait();
    }

    private void eval_d() => this.requestsSender.Autorization(this.accountData.Login, this.accountData.Password, ResponsesParser.GetCsrf(this.requestsSender.GetLoginPage().Result.Content)).Wait();

    private TestSession eval_a(string A_0) => ResponsesParser.ParseTestSession(this.requestsSender.GetSession(int.Parse(ResponsesParser.GetSessionId(this.requestsSender.GetTestingPage(A_0).Content))).Content);

    private int eval_c() => (int) ((double) this.testSession.Questions.First<TestQuestion>().Id / 9.55);

    private void eval_b()
    {
      for (int index = 0; index < this.ThreadsCount; ++index)
      {
        DocumentFinder documentFinder = new DocumentFinder(this.requestsSender, this.StartDocumentId, index * this.FinderIterationsCount, this.FinderIterationsCount, this.testSession);
        // ISSUE: reference to a compiler-generated field
        documentFinder.OnNewDocument += this.eval_l;
        documentFinder.OnEnd += new EventHandler(this.eval_a);
        documentFinder.OnDocumentIsFound += new EventHandler<OnDocumentIsFoundArgs>(this.eval_a);
        this.documentFinders.Add(documentFinder);
      }
    }

    private void eval_a(object A_0, EventArgs A_1)
    {
      if (this.TestIsFound || this.IsStoped)
        return;
      DocumentFinder documentFinder = (DocumentFinder) A_0;
      documentFinder.Restart(documentFinder.StartIndex + this.documentFinders.Count * this.FinderIterationsCount, this.FinderIterationsCount);
    }

    private void eval_a(object A_0, OnDocumentIsFoundArgs A_1)
    {
      if (this.IsStoped)
        return;
      this.IsStoped = true;
      this.Stop();
      this.testSession.SetAnswers(((IEnumerable<FlashCard>) A_1.FlashCards).ToArray<FlashCard>());
      // ISSUE: reference to a compiler-generated field
      EventHandler<OnDocumentIsFoundArgs> evalM = this.eval_m;
      if (evalM == null)
        return;
      evalM(A_0, A_1);
    }

    public void Start() => this.Restart(this.TestSessionUuId);

    public void Restart(string testSessionUuId)
    {
      int A_1 = 5;
      this.testSession = this.eval_a(testSessionUuId);
      this.StartDocumentId = this.eval_c();
      if (this.testSession.Questions.Count != this.testSession.TestQuestionsCount)
      {
        // ISSUE: reference to a compiler-generated field
        EventHandler<OnErrorArgs> evalN = this.eval_n;
        if (evalN == null)
          return;
        evalN((object) this, new OnErrorArgs(new Exception(Info.b("\xDEFF쯹䇻䀅␃䄁㠃䬍丏㘉國⼕⨗㘕✓娝∟✙ᐛᜥᤧ", A_1))));
      }
      else
      {
        this.eval_b();
        foreach (DocumentFinder documentFinder in this.documentFinders)
          documentFinder.Start();
        this.IsStoped = false;
        Task.Run(new Action(this.eval_a));
      }
    }

    private void eval_a()
    {
      // ISSUE: variable of a compiler-generated type
      FinderSystem.eval_b stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_c = this;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_b = AsyncVoidMethodBuilder.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_a = -1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_b.Start<FinderSystem.eval_b>(ref stateMachine);
    }

    public void Stop()
    {
      foreach (DocumentFinder documentFinder in this.documentFinders)
        documentFinder.Stop();
      this.IsStoped = true;
    }

    public TestSession GetTestSession() => this.testSession;
  }
}
