using System;

namespace YugiohManager.Models
{
  /// <summary>
  /// The view model for <see cref="Card"/>.
  /// </summary>
  [Serializable]
  public class CardContext
  {
    /// <summary>
    /// Gets or sets the Id.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the Name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the Card Id.
    /// </summary>
    public string CardId { get; set; }

    /// <summary>
    /// Gets or sets the Set.
    /// </summary>
    public string Set { get; set; }

    /// <summary>
    /// Gets or sets the Card Category.
    /// </summary>
    public string CardCategory { get; set; }

    /// <summary>
    /// Gets or sets the Monster Category Type.
    /// </summary>
    public string MonsterCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Magic Category Type.
    /// </summary>
    public string MagicCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Trap Category Type.
    /// </summary>
    public string TrapCategoryType { get; set; }

    /// <summary>
    /// Gets or sets the Monster Attribute.
    /// </summary>
    public string MonsterAttribute { get; set; }

    /// <summary>
    /// Gets or sets the Monster Type.
    /// </summary>
    public string MonsterType { get; set; }

    /// <summary>
    /// Gets or sets the Card Edition.
    /// </summary>
    public string CardEdition { get; set; }

    /// <summary>
    /// Gets or sets the Card Rarity.
    /// </summary>
    public string CardRarity { get; set; }

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