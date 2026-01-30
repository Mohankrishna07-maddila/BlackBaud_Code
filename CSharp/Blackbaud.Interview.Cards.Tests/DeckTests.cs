using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Blackbaud.Interview.Cards.Tests;

public class DeckTests
{
    [Fact]
    public void CanCreateANewDeck()
    {
        var deck = Deck.NewDeck();
        Assert.Equal(52, deck.RemainingCards);
    }

    [Fact]
    public void Shuffle_PreservetheCardCount()
    {
        var deck = Deck.NewDeck();
        deck.Shuffle(3);
        Assert.Equal(52, deck.RemainingCards);
    }

    [Fact]
    public void Shuffle_PreservetheCardCountAndContent()
    {
        var unshuffled = Deck.NewDeck();
        var lstUnshuffledCards = new List<Card>();

        while (!unshuffled.Empty)
            lstUnshuffledCards.Add(unshuffled.NextCard());

        var lstshuffledCards = new List<Card>();
        var shuffled = Deck.NewDeck();
        shuffled.Shuffle(2);

        while (!shuffled.Empty)
            lstshuffledCards.Add(shuffled.NextCard());

        // Ensure the multisets of cards are equal (same contents)

        var orderedUnshuffleList = lstUnshuffledCards.OrderBy(c => c.ToString()).ToList();
        var orderedShuffledList = lstshuffledCards.OrderBy(c => c.ToString()).ToList();

        Assert.Equal(orderedUnshuffleList, orderedShuffledList);
    }

}
