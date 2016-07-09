using System;
using System.Collections.Generic;

namespace YugiohManager.Models
{
  /// <summary>
  /// The view model for <see cref="Deck"/>.
  /// </summary>
  [Serializable]
  public class DeckContext
  {
    /// <summary>
    /// Gets or sets the Name for this deck.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the Cards for this deck.
    /// </summary>
    public IEnumerable<string> Cards { get; set; }
  }
}