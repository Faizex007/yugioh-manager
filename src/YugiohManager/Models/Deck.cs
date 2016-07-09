using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace YugiohManager.Models
{
  /// <summary>
  /// The data access class for <see cref="DeckContext"/>.
  /// </summary>
  [Serializable, JsonObject]
  [BsonDiscriminator(Required = true), BsonKnownTypes(typeof(Deck))]
  public class Deck : IDeck
  {
    /// <summary>
    /// Gets or sets the Deck Name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="ICard"/> in this Deck.
    /// </summary>
    public IEnumerable<ObjectId> Cards { get; set; }
  }
}