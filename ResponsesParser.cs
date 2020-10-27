// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.ResponsesParser
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using HtmlAgilityPack;
using NaurokAnswers.DataBase;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NaurokAnswers
{
  public static class ResponsesParser
  {
    private static QuestionOption eval_e(JToken A_0)
    {
      int A_1 = 3;
      return new QuestionOption()
      {
        Id = A_0[(object) Info.b("鏹飻", A_1)].Value<int>(),
        Content = A_0[(object) Info.b("賹鷻鋽痿朁", A_1)].ToString()
      };
    }

    private static TestQuestion eval_d(JToken A_0)
    {
      int A_1 = 17;
      TestQuestion testQuestion = new TestQuestion();
      testQuestion.Id = A_0[(object) Info.b("愇渉", A_1)].Value<int>();
      testQuestion.Content = A_0[(object) Info.b("欇攉戋稍甏簑怓", A_1)].ToString();
      testQuestion.Points = A_0[(object) Info.b("砇攉攋怍搏", A_1)].Value<int>();
      string str = A_0[(object) Info.b("簇猉簋欍", A_1)].ToString();
      testQuestion.Type = str == Info.b("礇缉攋琍", A_1) ? QuestionType.OneAnswer : (str == Info.b("攇缉怋稍礏挑愓缕戗", A_1) ? QuestionType.ManyAnswers : QuestionType.Unknown);
      foreach (JToken A_0_1 in (IEnumerable<JToken>) A_0[(object) Info.b("朇稉砋服缏簑朓", A_1)])
      {
        QuestionOption questionOption = ResponsesParser.eval_e(A_0_1);
        questionOption.Question = testQuestion;
        testQuestion.Options.Add(questionOption);
      }
      return testQuestion;
    }

    private static TestSession eval_c(JToken A_0)
    {
      int A_1 = 4;
      TestSession testSession1 = new TestSession();
      testSession1.Id = A_0[(object) Info.b("裺飼賾爀樂樄椆", A_1)][(object) Info.b("鋺駼", A_1)].Value<int>();
      TestSession testSession2 = testSession1;
      JToken jtoken = A_0[(object) Info.b("裺飼课甀樂欄怆稈", A_1)][(object) Info.b("髺黼鳾渀瘂欄猆嘈戊椌", A_1)];
      int? nullable = jtoken != null ? jtoken.Value<int?>() : new int?();
      testSession2.CreatorId = nullable;
      testSession1.TestName = A_0[(object) Info.b("裺飼课甀樂欄怆稈", A_1)][(object) Info.b("闺鳼鋾搀", A_1)].ToString();
      testSession1.TestQuestionsCount = A_0[(object) Info.b("\x9FFA鋼鳾琀渂怄椆紈", A_1)][(object) Info.b("諺裼髾爀眂氄栆月砊", A_1)].Value<int>();
      foreach (JToken A_0_1 in (IEnumerable<JToken>) A_0[(object) Info.b("諺裼髾爀眂氄栆月砊", A_1)])
      {
        TestQuestion testQuestion = ResponsesParser.eval_d(A_0_1);
        testSession1.Questions.Add(testQuestion);
      }
      return testSession1;
    }

    public static TestSession ParseTestSession(string data) => ResponsesParser.eval_c((JToken) JObject.Parse(data));

    private static FlashCard eval_b(JToken A_0)
    {
      int A_1 = 16;
      return new FlashCard()
      {
        Id = A_0[(object) Info.b("渆洈", A_1)].Value<int>(),
        QuestionContent = A_0[(object) Info.b("瘆簈渊縌笎砐簒笔", A_1)][(object) Info.b("猆氈猊礌", A_1)].ToString(),
        AnswerContent = A_0[(object) Info.b("昆月砊稌樎挐", A_1)]?[(object) Info.b("猆氈猊礌", A_1)].ToString()
      };
    }

    private static List<FlashCard> eval_a(JToken A_0)
    {
      int A_1 = 3;
      List<FlashCard> flashCardList = new List<FlashCard>();
      foreach (JToken A_0_1 in (IEnumerable<JToken>) A_0[(object) Info.b("駹鷻賽擿焁", A_1)])
      {
        FlashCard flashCard = ResponsesParser.eval_b(A_0_1);
        flashCardList.Add(flashCard);
      }
      return flashCardList;
    }

    public static List<FlashCard> ParseFlashCards(string data) => ResponsesParser.eval_a((JToken) JObject.Parse(data));

    private static string eval_d(HtmlDocument A_0)
    {
      int A_1 = 8;
      return A_0.DocumentNode.SelectSingleNode(Info.b("탾⸀渂怄猆栈倊䴌愎瀐縒瀔⨖㸘砚渜洞䜠ย儤䠦䈨个䌬\x082E氰", A_1)).Attributes[Info.b("鳾渀洂焄戆月缊", A_1)].Value;
    }

    public static string GetCsrf(string html)
    {
      HtmlDocument A_0 = new HtmlDocument();
      A_0.LoadHtml(html);
      return ResponsesParser.eval_d(A_0);
    }

    private static string eval_c(HtmlDocument A_0)
    {
      int A_1 = 3;
      string input = A_0.DocumentNode.SelectSingleNode(Info.b("헹폻髽槿琁弃䘅昇洉ℋ漍怏我䤓", A_1)).Attributes[Info.b("铹鯻폽槿氁洃爅", A_1)].Value;
      return new Regex(Info.b("ꇹ쳻폽㧿弁⼃∅∇", A_1)).Matches(input)[1].Value;
    }

    public static string GetSessionId(string html)
    {
      HtmlDocument A_0 = new HtmlDocument();
      A_0.LoadHtml(html);
      return ResponsesParser.eval_c(A_0);
    }

    private static string[] eval_b(HtmlDocument A_0_1)
    {
      int A_1_1 = 1;
      return A_0_1.DocumentNode.SelectNodes(Info.b("ퟷ헹飻韽盿夁䐃攅搇欉缋納ⴏ㔑紓戕紗眙漛㤝紟ഡଣ䜥", A_1_1)).Select<HtmlNode, string>((Func<HtmlNode, string>) (A_0_2 =>
      {
        int A_1_2 = 5;
        return A_0_2.Attributes[Info.b("铻賽旿搁", A_1_2)].Value;
      })).ToArray<string>();
    }

    public static string[] GetProfileTestsUrls(string html)
    {
      HtmlDocument A_0 = new HtmlDocument();
      A_0.LoadHtml(html);
      return ResponsesParser.eval_b(A_0);
    }

    private static bool eval_a(HtmlDocument A_0)
    {
      int A_1 = 3;
      HtmlNode htmlNode1 = A_0.DocumentNode.SelectSingleNode(Info.b("헹폻诽泿夁䐃攅搇欉缋納ⴏ㔑搓眕缗猙爛缝吟䬡䬣䠥༧眩", A_1));
      HtmlNode htmlNode2 = A_0.DocumentNode.SelectSingleNode(Info.b("헹폻诽泿夁䐃攅搇欉缋納ⴏ㔑搓眕缗猙爛缝吟䬡䬣䠥༧眩̫䈭夯椱琳唵吷嬹伻䴽紿敁⩃⍅ぇ㹉汋⩍㥏\x2151㕓㑕㑗㽙㡛祝㵟", A_1));
      return htmlNode1 == null || htmlNode2 != null;
    }

    public static bool IsLastProfileTestsPage(string html)
    {
      HtmlDocument A_0 = new HtmlDocument();
      A_0.LoadHtml(html);
      return ResponsesParser.eval_a(A_0);
    }
  }
}
