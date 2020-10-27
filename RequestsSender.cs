// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.RequestsSender
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using NaurokAnswers.DataBase;
using RestSharp;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NaurokAnswers
{
  public class RequestsSender
  {
    public const string BaseUrl = "https://naurok.com.ua";
    private CookieContainer eval_a;
    private RestClient eval_b;

    public RequestsSender()
    {
      int A_1 = 17;
      this.eval_a = new CookieContainer();
      this.eval_b = new RestClient(Info.b("怇縉砋縍挏⠑㬓㤕瘗笙椛氝伟䤡ਣ䔥䜧䜩ȫ嬭儯", A_1));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.eval_b.CookieContainer = this.eval_a;
    }

    public Task<IRestResponse> GetLoginPage()
    {
      // ISSUE: variable of a compiler-generated type
      RequestsSender.eval_a stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_c = this;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_b = AsyncTaskMethodBuilder<IRestResponse>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_a = -1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_b.Start<RequestsSender.eval_a>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.eval_b.Task;
    }

    public IRestResponse GetTestingPage(string sessionUuid) => this.eval_b.Get((IRestRequest) new RestRequest(Info.b("Ⰲ焄戆稈缊∌笎琐怒愔縖眘簚㈜", 12) + sessionUuid));

    public Task<IRestResponse> Autorization(
      string login,
      string password,
      string csrf)
    {
      // ISSUE: variable of a compiler-generated type
      RequestsSender.eval_b stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_f = this;
      // ISSUE: reference to a compiler-generated field
      stateMachine.d = login;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_e = password;
      // ISSUE: reference to a compiler-generated field
      stateMachine.c = csrf;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_b = AsyncTaskMethodBuilder<IRestResponse>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_a = -1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_b.Start<RequestsSender.eval_b>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.eval_b.Task;
    }

    public IRestResponse GetSession(int id) => this.eval_b.Get((IRestRequest) new RestRequest(string.Format(Info.b("ퟷ鯹賻韽\x32FFⴁ瀃挅笇縉⌋納甏愑朓缕眗琙漛ㄝ嬟ሡ夣", 1), (object) id)));

    public IRestResponse GetFlashCards(int documentId)
    {
      int A_1 = 19;
      RestRequest restRequest = new RestRequest(string.Format(Info.b("┉洋縍礏㴑怓猕欗渙㌛稝伟䄡儣䬥䴧䐩堫崭Ἧ䤱г䬵\x1737尹倻弽㌿⩁❃❅㩇\x2E49", A_1), (object) documentId));
      restRequest.AddHeader(Info.b("堉椋栍甏怑焓搕", A_1), string.Format(Info.b("焉㰋猍㼏昑焓攕気㔙望⼝崟ഡ䈣䨥䤧天䐫䴭儯䀱倳", A_1), (object) Info.b("戉砋稍怏愑⸓㤕㜗琙紛欝刟䴡伣ࠥ䬧䔩䄫-䔯匱", A_1), (object) documentId));
      return this.eval_b.Post((IRestRequest) restRequest);
    }

    public Task<IRestResponse> GetProfileTests(int profileId, int page)
    {
      // ISSUE: variable of a compiler-generated type
      RequestsSender.eval_c stateMachine;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_e = this;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_c = profileId;
      // ISSUE: reference to a compiler-generated field
      stateMachine.d = page;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_b = AsyncTaskMethodBuilder<IRestResponse>.Create();
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_a = -1;
      // ISSUE: reference to a compiler-generated field
      stateMachine.eval_b.Start<RequestsSender.eval_c>(ref stateMachine);
      // ISSUE: reference to a compiler-generated field
      return stateMachine.eval_b.Task;
    }
  }
}
