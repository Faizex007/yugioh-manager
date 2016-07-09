using System;
using System.Configuration;
using System.Threading.Tasks;
using Faizex.Common;
using Faizex.MongoDb;
using MongoDB.Bson;
using MongoDB.Driver;

namespace YugiohManager.Logic
{
  public class UserProfileLogic
  {
    private readonly IMongoProvider<IUserProfile> _provider;

    public UserProfileLogic(IMongoProvider<IUserProfile> provider)
    {
      _provider = provider;
    }

    public async Task<IUserProfile> GetByUsername(string username)
    {
      try
      {
        return await _provider.Collection.Find(new BsonDocument(nameof(IUserProfile.Username), username)).FirstOrDefaultAsync();
      }
      catch (Exception e)
      {
        Diagnostic.TraceError(e);
        throw;
      }
    }

    public async Task<IUserProfile> GetByUsernameAndPassword(string username, string password)
    {
      try
      {
        return await _provider.Collection.Find(new BsonDocument { { nameof(IUserProfile.Username), username },
                                                                  { nameof(IUserProfile.PasswordHash), FaizexCrypto.Decrypt(password, ConfigurationManager.AppSettings["secretPhrase"]) } }).FirstOrDefaultAsync();
      }
      catch (Exception e)
      {
        Diagnostic.TraceError(e);
        throw;
      }
    }
  }
}