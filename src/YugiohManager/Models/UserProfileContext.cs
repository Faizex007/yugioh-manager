using System;
using System.Collections.Generic;

namespace YugiohManager.Models
{
  /// <summary>
  /// The view model for <see cref="UserProfile"/>.
  /// </summary>
  [Serializable]
  public class UserProfileContext
  {
    /// <summary>
    /// Gets or sets the Id
    /// </summary>
    public string Id { get; set; }

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
    public IEnumerable<DeckContext> Decks { get; set; }
  }
}