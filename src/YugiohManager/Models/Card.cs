using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using YugiohManager.Enums;

namespace YugiohManager.Models
{
  /// <summary>
  /// The data access class for <see cref="CardContext"/>.
  /// </summary>
  [Serializable, JsonObject]
  [BsonDiscriminator(Required = true), BsonKnownTypes(typeof(Card))]
  public class Card : ICard
  {
    /// <summary>
    /// Gets or sets the Id.
    /// </summary>
    [BsonId]
    public ObjectId Id { get; set; }

    /// <summary>
    /// Gets or sets the Name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the Card Id.
    /// </summary>
    public string CardId { get; set; }

    /// <summary>
    /// Gets or sets the card Set.
    /// </summary>
    public string Set { get; set; }

    /// <summary>
    /// Gets or sets the Card Category.
    /// </summary>
    [BsonRepresentation(BsonType.String)]
    public CardCategory CardCategory { get; set; }

    /// <summary>
    /// Gets or sets the Monster Category Type.
    /// </summary>
    [BsonRepresentation(BsonType.String), BsonDefaultValue(MonsterCategoryType.None), BsonIgnoreIfDefault]
    public MonsterCategoryType MonsterCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Magic Category Type.
    /// </summary>
    [BsonRepresentation(BsonType.String), BsonDefaultValue(MagicCategoryType.None), BsonIgnoreIfDefault]
    public MagicCategoryType MagicCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Trap Category Type.
    /// </summary>
    [BsonRepresentation(BsonType.String), BsonDefaultValue(TrapCategoryType.None), BsonIgnoreIfDefault]
    public TrapCategoryType TrapCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Monster Attribute.
    /// </summary>
    [BsonRepresentation(BsonType.String), BsonDefaultValue(MonsterAttribute.None), BsonIgnoreIfDefault]
    public MonsterAttribute MonsterAttribute { get; set; }

    /// <summary>
    /// Gets or sets the Monster Type.
    /// </summary>
    [BsonRepresentation(BsonType.String), BsonDefaultValue(MonsterType.None), BsonIgnoreIfDefault]
    public MonsterType MonsterType { get; set; }

    /// <summary>
    /// Gets or sets the Card Edition.
    /// </summary>
    [BsonRepresentation(BsonType.String)]
    public CardEdition CardEdition { get; set; }

    /// <summary>
    /// Gets or sets the Card Rarity.
    /// </summary>
    [BsonRepresentation(BsonType.String)]
    public CardRarity CardRarity { get; set; }

    /// <summary>
    /// Gets or sets the Level or Rank.
    /// </summary>
    public int LevelRank { get; set; }

    /// <summary>
    /// Gets or sets the Attack.
    /// </summary>
    public int Attack { get; set; }

    /// <summary>
    /// Gets or sets the Defense.
    /// </summary>
    public int Defense { get; set; }

    /// <summary>
    /// Gets or sets the Description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the Image URL.
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets the Acquired date.
    /// </summary>
    public DateTime Acquired { get; set; }
  }
}