// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.TestSession
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace NaurokAnswers
{
  public class TestSession
  {
    public int Id { get; set; }

    public int? CreatorId { get; set; }

    public string TestName { get; set; }

    public int TestQuestionsCount { get; set; }

    public List<TestQuestion> Questions { get; private set; }

    public TestSession() => this.Questions = new List<TestQuestion>();

    public bool IsCorrectFlashCards(FlashCard[] cards)
    {
      if (cards == null || cards.Length != this.Questions.Count)
        return false;
      TestQuestion[] array1 = this.Questions.OrderBy<TestQuestion, int>((Func<TestQuestion, int>) (A_0 => A_0.Id)).ToArray<TestQuestion>();
      FlashCard[] array2 = ((IEnumerable<FlashCard>) cards).OrderBy<FlashCard, int>((Func<FlashCard, int>) (A_0 => A_0.Id)).ToArray<FlashCard>();
      for (int index = 0; index < this.Questions.Count; ++index)
      {
        if (!array1[index].IsCorrectFlashCard(array2[index]))
          return false;
      }
      return true;
    }

    public void SetAnswers(FlashCard[] cards)
    {
      if (!this.IsCorrectFlashCards(cards))
        throw new ArgumentException();
      TestQuestion[] array1 = this.Questions.OrderBy<TestQuestion, int>((Func<TestQuestion, int>) (A_0 => A_0.Id)).ToArray<TestQuestion>();
      FlashCard[] array2 = ((IEnumerable<FlashCard>) cards).OrderBy<FlashCard, int>((Func<FlashCard, int>) (A_0 => A_0.Id)).ToArray<FlashCard>();
      for (int index = 0; index < this.Questions.Count; ++index)
        array1[index].SetAnswer(array2[index], false);
    }
  }
}
