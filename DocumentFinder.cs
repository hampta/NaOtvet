// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.DocumentFinder
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using NaurokAnswers.DataBase;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace NaurokAnswers
{
  public class DocumentFinder
  {
    private RequestsSender eval_a;

    public int StartDocumentId { get; set; }

    public int StartIndex { get; set; }

    public int IterationsCount { get; set; }

    public TestSession TestSession { get; set; }

    public bool IsStopped { get; private set; }

    public int CheckedDocumentsCount { get; private set; }

    public event EventHandler<OnNewDocumentArgs> OnNewDocument;

    public event EventHandler<OnDocumentIsFoundArgs> OnDocumentIsFound;

    public event EventHandler OnEnd;

    public DocumentFinder(
      RequestsSender requestsSender,
      int startDocumentId,
      int startIndex,
      int iterationsCount,
      TestSession testSession)
    {
      this.eval_a = requestsSender;
      this.StartDocumentId = startDocumentId;
      this.StartIndex = startIndex;
      this.IterationsCount = iterationsCount;
      this.TestSession = testSession;
    }

    public void Restart(int startIndex, int iterationsCount)
    {
      this.StartIndex = startIndex;
      this.IterationsCount = iterationsCount;
      Task.Run(new Action(this.eval_a));
    }

    public void Start() => this.Restart(this.StartIndex, this.IterationsCount);

    public void Stop() => this.IsStopped = true;

    private void eval_a()
    {
      this.IsStopped = false;
      for (int startIndex = this.StartIndex; startIndex < this.StartIndex + this.IterationsCount && !this.IsStopped; ++startIndex)
      {
        for (int index = 0; index < 2 && !this.IsStopped && !this.IsStopped; ++index)
        {
          if (startIndex == 0)
            index = 1;
          int documentId = index % 2 == 0 ? this.StartDocumentId + startIndex : this.StartDocumentId - startIndex;
          FlashCard[] flashCards;
          int num = DocumentFinder.IsCorrectDocument(this.TestSession, documentId, this.eval_a, out flashCards) ? 1 : 0;
          ++this.CheckedDocumentsCount;
          if (num != 0)
          {
            // ISSUE: reference to a compiler-generated field
            this.eval_i((object) this, new OnDocumentIsFoundArgs(documentId, flashCards));
            this.Stop();
            break;
          }
          // ISSUE: reference to a compiler-generated field
          this.eval_h((object) this, new OnNewDocumentArgs(documentId));
        }
      }
      this.IsStopped = true;
      // ISSUE: reference to a compiler-generated field
      this.j((object) this, new EventArgs());
    }

    public static bool IsCorrectDocument(
      TestSession testSession,
      int documentId,
      RequestsSender requestsSender,
      out FlashCard[] flashCards)
    {
      int A_1 = 0;
      IRestResponse flashCards1 = requestsSender.GetFlashCards(documentId);
      if (!flashCards1.Content.StartsWith(Info.b("賶\xDBF8觺飼賾琀漂焄┆㌈洊氌挎成瘒", A_1)))
      {
        flashCards = ResponsesParser.ParseFlashCards(flashCards1.Content).ToArray();
        return testSession.IsCorrectFlashCards(flashCards);
      }
      flashCards = (FlashCard[]) null;
      return false;
    }
  }
}
