using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace YugiohManager.Models
{
  /// <summary>
  /// The data access class for <see cref="UserProfileContext"/>.
  /// </summary>
  [Serializable, JsonObject]
  [BsonDiscriminator(Required = true), BsonKnownTypes(typeof(UserProfile))]
  public class UserProfile : IUserProfile
  {
    /// <summary>
    /// Gets or sets the Id.
    /// </summary>
    [BsonId]
    public ObjectId Id { get; set; }

    /// <summary>
    /// Gets or sets the Username.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the Password Hash.
    /// </summary>
    public string PasswordHash { get; set; }

    /// <summary>
    /// Gets or sets the Decks for this user.
    /// </summary>
    [BsonIgnoreIfNull]
    public IEnumerable<IDeck> Decks { get; set; }
  }
}