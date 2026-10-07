using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TwoDecksWPF
{
    internal class Deck : ObservableCollection<Card>
    {
        private static Random random = new Random();
        public Deck()
        {
            Reset();
        }
        public void Reset()
        {
            /* Call Clear() to remove all cards from the deck, then use two for loops to add
            * all combinations of suit and value, calling Add(new Card(...)) to add each card */
            throw new NotImplementedException("The Reset method restes the 52-card deck");
        }
        public Card Deal(int index)
        {
            // Use base[index] to pull out the specific card and RemoveAt(index) to remove it
            throw new NotImplementedException("The Deal method will deal a card from the deck");
        }
        public void Shuffle()
        {
            /* Use new List<Card>(this) to create a copy of the deck, then pick a random card
            * from copy, call copy.RemoveAt to remove it, and Add(card) to add it */
            throw new NotImplementedException("The Shuffle method will randomize the cards");
        }
        public void Sort()
        {
            List<Card> sortedCards = new List<Card>(this);
            sortedCards.Sort(new CardComparer());
            // Use a foreach loop to call Add for each card in sortedCards
            throw new NotImplementedException("The Sort method sorts the cards.");
        }
    }
}
