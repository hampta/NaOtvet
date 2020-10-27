// Decompiled with JetBrains decompiler
// Type: NaurokAnswers.DataBase.ApplicationContext
// Assembly: NaurokAnswers, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0E5F98D0-7D46-4F60-8A9B-1E1B8B0B6D21
// Assembly location: C:\Program Files (x86)\KuzCode\НаОтвет\NaurokAnswers.exe

using Microsoft.EntityFrameworkCore;

namespace NaurokAnswers.DataBase
{
  public class ApplicationContext : DbContext
  {
    public DbSet<NaurokAnswers.DataBase.Info> Info { get; set; }

    public ApplicationContext() => this.Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      int A_1 = 12;
      optionsBuilder.UseMySql(NaurokAnswers.DataBase.Info.b("倂怄甆缈渊缌㈎挐瘒研砖洘縚瀜昞删刢䤤द䨨䐪䀬ᐮ愰尲䜴䌶и࠺\x0E3C༾着硂ń♆㵈⩊⽌\x2E4E≐㙒桔བ㑘\x0D5Aќ㭞ᡠ\x0E62⍤⍦ᩨ偪㡬ٮᕰ乲\x2D74᩶⽸≺\x197Cپ\xEC80얂솄\xF486늈\xDB8A戴\xEB8E겐\xDA92쾔쾖킘햚횜\xEC9E\xF8A0醢醤鲦", A_1));
    }
  }
}
