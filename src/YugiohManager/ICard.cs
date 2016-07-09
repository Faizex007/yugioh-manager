using System;
using Faizex.MongoDb;
using YugiohManager.Enums;
using YugiohManager.Models;

namespace YugiohManager
{
  /// <summary>
  /// The interface contract for <see cref="Card"/>.
  /// </summary>
  public interface ICard : IMongoDocument
  {
    /// <summary>
    /// Gets or sets the Name.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the Card Id.
    /// </summary>
    string CardId { get; set; }

    /// <summary>
    /// Gets or sets the card Set.
    /// </summary>
    string Set { get; set; }

    /// <summary>
    /// Gets or sets the Card Category.
    /// </summary>
    CardCategory CardCategory { get; set; }

    /// <summary>
    /// Gets or sets the Monster Category Type.
    /// </summary>
    MonsterCategoryType MonsterCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Magic Category Type.
    /// </summary>
    MagicCategoryType MagicCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Trap Category Type.
    /// </summary>
    TrapCategoryType TrapCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Monster Attribute.
    /// </summary>
    MonsterAttribute MonsterAttribute { get; set; }

    /// <summary>
    /// Gets or sets the Monster Type.
    /// </summary>
    MonsterType MonsterType { get; set; }

    /// <summary>
    /// Gets or sets the Card Edition.
    /// </summary>
    CardEdition CardEdition { get; set; }

    /// <summary>
    /// Gets or sets the Card Rarity.
    /// </summary>
    CardRarity CardRarity { get; set; }

    /// <summary>
    /// Gets or sets the Level or Rank.
    /// </summary>
    int LevelRank { get; set; }

    /// <summary>
    /// Gets or sets the Attack.
    /// </summary>
    int Attack { get; set; }

    /// <summary>
    /// Gets or sets the Defense.
    /// </summary>
    int Defense { get; set; }

    /// <summary>
    /// Gets or sets the Description.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Gets or sets the Image URL.
    /// </summary>
    string ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets the Acquired date.
    /// </summary>
    DateTime Acquired { get; set; }
  }
}