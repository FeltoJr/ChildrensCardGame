using System;

namespace ChildrensCardGame
{
    class Card
    {
        string value;
        string suit;
        bool hidden;
        
        public override string ToString()
        {
            return $"{value} of {suit}";
        }
    }
}