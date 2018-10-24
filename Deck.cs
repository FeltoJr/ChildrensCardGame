using System;
using System.Collections.Generic;

namespace ChildrensCardGame
{
    class Deck
    {
        List<Card> cards = new List<Card>();
        string name;

        public Deck(string name)
        {
            this.name = name;
        }
        
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++) 
            {
                int swapeePosition = random.Next(cards.Count);
                Card swapee = cards[swapeePosition];
                Card swapper = cards[i];
                cards[i] = swapee;
                cards[swapeePosition] = swapper;

            }
        }
        
        public Card Draw()
        {
           Card topCard = cards[0];
           cards.RemoveAt(0);
           return topCard;
        }
        
        public Card Pick(int number)
        {
           Card topCard = cards[number];
           cards.RemoveAt(number);
           return topCard;
        }

        public Card DrawBottom()
        {
           Card bottomCard = cards[cards.Count];
           cards.RemoveAt(cards.Count);
           return bottomCard;
        }

        public Card DrawRandom()
        {
            Random random = new Random();
            int rando = random.Next(cards.Count);
            Card randomCard = cards[rando];
            cards.RemoveAt(rando);
            return randomCard;
        }

        public List<Card> Peek(int numberOfCards)
        {
            return cards.GetRange(0, numberOfCards);
        }

        public Card Peek()
        {
            return cards[0];
        }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public List<Card> List()
        {
            return cards.GetRange(0,cards.Count);            
        }

    }
    
}