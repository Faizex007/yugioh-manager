using System.Collections.Generic;
using System.Linq;
using Faizex.Common;
using MongoDB.Bson;
using YugiohManager.Models;

namespace YugiohManager.Extensions
{
  public static class UserProfileExtensions
  {
    /// <summary>
    /// Converts <see cref="UserProfileContext"/> to <see cref="IUserProfile"/>.
    /// </summary>
    /// <param name="userProfile">The user profile.</param>
    /// <returns>IUserProfile</returns>
    public static IUserProfile ToDocument(this UserProfileContext userProfile)
    {
      return userProfile.IsNull() ? null : new UserProfile
      {
        Id = userProfile.Id.IsNullOrEmpty() ? ObjectId.GenerateNewId() : new ObjectId(userProfile.Id),
        Username = userProfile.Username,
        PasswordHash = userProfile.PasswordHash,
        Decks = userProfile.Decks.ToDocumentList()
      };
    }

    /// <summary>
    /// Converts <see cref="IUserProfile"/> to <see cref="UserProfileContext"/>.
    /// </summary>
    /// <param name="userProfile">The user profile.</param>
    /// <returns>UserProfileContext</returns>
    public static UserProfileContext ToContext(this IUserProfile userProfile)
    {
      return userProfile.IsNull() ? new UserProfileContext() : new UserProfileContext
      {
        Id = userProfile.Id.ToString(),
        Username = userProfile.Username,
        PasswordHash = userProfile.PasswordHash,
        Decks = userProfile.Decks.ToContextList()
      };
    }

    /// <summary>
    /// Converts a list of <see cref="UserProfileContext"/> to a list of <see cref="IUserProfile"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>IEnumerable{IUserProfile}</returns>
    public static IEnumerable<IUserProfile> ToDocumentList(this IEnumerable<UserProfileContext> list)
    {
      var users = list as IList<UserProfileContext> ?? list?.ToList() ?? new List<UserProfileContext>();
      return users.IsNullOrEmpty() ? null : users.Select(ToDocument);
    }

    /// <summary>
    /// Converts a list of <see cref="IUserProfile"/> to a list of <see cref="UserProfileContext"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>IEnumerable{UserProfileContext}</returns>
    public static IEnumerable<UserProfileContext> ToContextList(this IEnumerable<IUserProfile> list)
    {
      var users = list as IList<IUserProfile> ?? list?.ToList() ?? new List<IUserProfile>();
      return users.IsNullOrEmpty() ? new List<UserProfileContext>() : users.Select(ToContext);
    }
  }
}