using System.Collections.Generic;
using MongoDB.Bson;
using YugiohManager.Models;

namespace YugiohManager
{
  /// <summary>
  /// The interface contract for <see cref="Deck"/>.
  /// </summary>
  public interface IDeck
  {
    /// <summary>
    /// Gets or sets the Deck Name.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="ICard"/> in this Deck.
    /// </summary>
    IEnumerable<ObjectId> Cards { get; set; }
  }
}