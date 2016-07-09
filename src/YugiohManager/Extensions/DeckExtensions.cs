using System.Collections.Generic;
using System.Linq;
using Faizex.Common;
using MongoDB.Bson;
using YugiohManager.Models;

namespace YugiohManager.Extensions
{
  public static class DeckExtensions
  {
    /// <summary>
    /// Converts <see cref="DeckContext"/> to <see cref="IDeck"/>.
    /// </summary>
    /// <param name="deck">The deck.</param>
    /// <returns>IDeck</returns>
    public static IDeck ToDocument(this DeckContext deck)
    {
      return deck.IsNull() ? null : new Deck
      {
        Name = deck.Name,
        Cards = deck.Cards.Select(f => new ObjectId(f))
      };
    }

    /// <summary>
    /// Converts <see cref="IDeck"/> to <see cref="DeckContext"/>.
    /// </summary>
    /// <param name="deck">The deck.</param>
    /// <returns>DeckContext</returns>
    public static DeckContext ToContext(this IDeck deck)
    {
      return deck.IsNull() ? new DeckContext() : new DeckContext
      {
        Name = deck.Name,
        Cards = deck.Cards.Select(f => f.ToString())
      };
    }

    /// <summary>
    /// Converts a list of <see cref="DeckContext"/> to a list of <see cref="IDeck"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>IEnumerable{IDeck}</returns>
    public static IEnumerable<IDeck> ToDocumentList(this IEnumerable<DeckContext> list)
    {
      var decks = list as IList<DeckContext> ?? list?.ToList() ?? new List<DeckContext>();
      return decks.IsNullOrEmpty() ? null : decks.Select(ToDocument);
    }

    /// <summary>
    /// Converts a list of <see cref="IDeck"/> to a list of <see cref="DeckContext"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>IEnumerable{DeckContext}</returns>
    public static IEnumerable<DeckContext> ToContextList(this IEnumerable<IDeck> list)
    {
      var decks = list as IList<IDeck> ?? list?.ToList() ?? new List<IDeck>();
      return decks.IsNullOrEmpty() ? new List<DeckContext>() : decks.Select(ToContext);
    }
  }
}