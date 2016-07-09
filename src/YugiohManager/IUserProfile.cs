using System.Collections.Generic;
using Faizex.MongoDb;
using YugiohManager.Models;

namespace YugiohManager
{
  /// <summary>
  /// The interface contract for <see cref="UserProfile"/>.
  /// </summary>
  public interface IUserProfile : IMongoDocument
  {
    /// <summary>
    /// Gets or sets the Username.
    /// </summary>
    string Username { get; set; }

    /// <summary>
    /// Gets or sets the Password Hash.
    /// </summary>
    string PasswordHash { get; set; }

    /// <summary>
    /// Gets or sets the Decks for this User.
    /// </summary>
    IEnumerable<IDeck> Decks { get; set; }
  }
}