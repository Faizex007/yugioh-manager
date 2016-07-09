using System.Configuration;
using Faizex.MongoDb;
using Ninject.Modules;
using YugiohManager.Models;

namespace YugiohManager
{
  public class AppModule : NinjectModule
  {
    public override void Load()
    {
      Bind<IMongoAccess>().ToMethod(m =>
      {
        var access = new MongoAccess(ConfigurationManager.ConnectionStrings["databaseConnectionString"].ToString(), ConfigurationManager.AppSettings["databaseName"]);
        access.RegisterClassMap<Card>();
        access.RegisterClassMap<Deck>();
        access.RegisterClassMap<UserProfile>();

        return access;
      });

      Bind<string>().ToMethod(m => ConfigurationManager.AppSettings["secretPhrase"]).Named("secretPhrase");
    }
  }
}