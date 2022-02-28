using System;
using System.Collections;

namespace card
{
    public class deck
    {
        ArrayList cards;
        
        public deck() {
            cards = new ArrayList() { "1","2","3","4","5","6","7","8","9","10","hearts", "spades", "king", "queen", "jack"};
        }

        public string PickCard(){
            var r = new Random();
            int pickCard = r.Next(0, cards.Count-1);
            string card = (string)cards[pickCard];
            cards.RemoveAt(pickCard);
            return card;
        }

        public bool isEmpty(){
            return (cards.Count == 0);
        }

    }
}