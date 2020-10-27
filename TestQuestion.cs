// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.TestQuestion
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using NaurokAnswers.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NaurokAnswers
{
  public class TestQuestion
  {
    public int Id { get; set; }

    public int Points { get; set; }

    public string Content { get; set; }

    public QuestionType Type { get; set; }

    public List<QuestionOption> Options { get; private set; }

    public List<QuestionOption> Answers { get; private set; }

    public TestQuestion()
    {
      this.Options = new List<QuestionOption>();
      this.Answers = new List<QuestionOption>();
    }

    public bool IsCorrectFlashCard(FlashCard card)
    {
      int A_1 = 17;
      if (card.QuestionContent == null || card.QuestionContent != this.Content)
        return false;
      string answerContent = card.AnswerContent;
      string[] separator = new string[2]
      {
        Info.b("㐇渉攋砍⸏", A_1),
        Info.b("㐇┉栋服昏Ⱁ", A_1)
      };
      foreach (string str in answerContent.Split(separator, StringSplitOptions.RemoveEmptyEntries))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        if (this.Options.Where<QuestionOption>(new Func<QuestionOption, bool>(new TestQuestion.eval_a()
        {
          eval_a = str
        }.eval_b)).Count<QuestionOption>() != 1)
          return false;
      }
      return true;
    }

    public void SetAnswer(FlashCard card, bool isCheckNeeded)
    {
      int A_1 = 19;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      TestQuestion.eval_b evalB = new TestQuestion.eval_b();
      if (isCheckNeeded && !this.IsCorrectFlashCard(card))
        throw new ArgumentException();
      // ISSUE: reference to a compiler-generated field
      evalB.eval_a = card.AnswerContent.Split(new string[2]
      {
        Info.b("㘉栋服昏Ⱁ", A_1),
        Info.b("㘉⌋樍礏搑⨓", A_1)
      }, StringSplitOptions.RemoveEmptyEntries);
      // ISSUE: reference to a compiler-generated method
      this.Answers = this.Options.Where<QuestionOption>(new Func<QuestionOption, bool>(evalB.eval_b)).ToList<QuestionOption>();
    }
  }
}
