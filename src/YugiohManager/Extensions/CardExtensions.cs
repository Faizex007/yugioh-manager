using System.Collections.Generic;
using System.Linq;
using Faizex.Common;
using MongoDB.Bson;
using YugiohManager.Enums;
using YugiohManager.Models;

namespace YugiohManager.Extensions
{
  public static class CardExtensions
  {
    /// <summary>
    /// Converts <see cref="CardContext"/> to <see cref="ICard"/>.
    /// </summary>
    /// <param name="card">The card.</param>
    /// <returns>ICard</returns>
    public static ICard ToDocument(this CardContext card)
    {
      if (card.IsNull())
        return null;

      var cardCategory = card.CardCategory.ToEnum<CardCategory>();
      return new Card
      {
        Id = card.Id.IsNullOrEmpty() ? ObjectId.GenerateNewId() : new ObjectId(card.Id),
        Name = card.Name,
        CardId = card.CardId,
        Set = card.Set,
        CardCategory = cardCategory,
        MonsterCategoryType = cardCategory != CardCategory.Monster ? MonsterCategoryType.None : card.MonsterCategoryType.ToEnum<MonsterCategoryType>(),
        MagicCategoryType = cardCategory != CardCategory.Spell ? MagicCategoryType.None : card.MagicCategoryType.ToEnum<MagicCategoryType>(),
        TrapCategoryType = cardCategory != CardCategory.Trap ? TrapCategoryType.None : card.TrapCategoryType.ToEnum<TrapCategoryType>(),
        MonsterAttribute = cardCategory != CardCategory.Monster ? MonsterAttribute.None : card.MonsterAttribute.ToEnum<MonsterAttribute>(),
        MonsterType = cardCategory != CardCategory.Monster ? MonsterType.None : card.MonsterType.ToEnum<MonsterType>(),
        CardEdition = card.CardEdition.ToEnum<CardEdition>(),
        CardRarity = card.CardRarity.ToEnum<CardRarity>(),
        LevelRank = card.LevelRank,
        Attack = card.Attack,
        Defense = card.Defense,
        Description = card.Description,
        Acquired = card.Acquired
      };
    }

    /// <summary>
    /// Converts <see cref="ICard"/> to <see cref="CardContext"/>.
    /// </summary>
    /// <param name="card">The card.</param>
    /// <returns>CardContext</returns>
    public static CardContext ToContext(this ICard card)
    {
      return card.IsNull() ? new CardContext() : new CardContext
      {
        Id = card.Id.ToString(),
        Name = card.Name,
        CardId = card.CardId,
        Set = card.Set,
        CardCategory = card.CardCategory.ToTitleCase(),
        MonsterCategoryType = card.MonsterCategoryType.ToTitleCase(),
        MagicCategoryType = card.MagicCategoryType.ToTitleCase(),
        TrapCategoryType = card.TrapCategoryType.ToTitleCase(),
        MonsterAttribute = card.MonsterAttribute.ToTitleCase(),
        MonsterType = card.MonsterType.ToTitleCase(),
        CardEdition = card.CardEdition.ToTitleCase(),
        CardRarity = card.CardRarity.ToTitleCase(),
        LevelRank = card.LevelRank,
        Attack = card.Attack,
        Defense = card.Defense,
        Description = card.Description,
        Acquired = card.Acquired
      };
    }

    /// <summary>
    /// Converts a list of <see cref="CardContext"/> to a list of <see cref="ICard"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>IEnumerable{ICard}</returns>
    public static IEnumerable<ICard> ToDocumentList(this IEnumerable<CardContext> list)
    {
      var cards = list as IList<CardContext> ?? list?.ToList() ?? new List<CardContext>();
      return cards.IsNullOrEmpty() ? null : cards.Select(ToDocument);
    }

    /// <summary>
    /// Converts a list of <see cref="ICard"/> to a list of <see cref="CardContext"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>IEnumerable{CardContext}</returns>
    public static IEnumerable<CardContext> ToContextList(this IEnumerable<ICard> list)
    {
      var cards = list as IList<ICard> ?? list?.ToList() ?? new List<ICard>();
      return cards.IsNullOrEmpty() ? null : cards.Select(ToContext);
    }
  }
}