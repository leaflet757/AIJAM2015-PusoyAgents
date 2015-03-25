using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PusoyAgent
{
    class Deck<T>
    {

        /// <summary>
        /// Gets a card from the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <remarks>this property creates an illusion that the deck object is an array of cards</remarks>
        public T this[int index]
        {
            get 
            {
                return _deck[index];    
            }
        }

        //from abe... why not use a stack instead?
        List<T> _deck;


        public Deck()
        {
            _deck = new List<T>();
        }

        public void AddCard(T c)
        {
            _deck.Add(c);
        }

        public T PeekCard(int index = 0) 
        {
            return _deck[index];
        }

        public List<T> PeekRange(int index, int count)
        {
            List<T> list = new List<T>();
            for (int i = index; i < index + count; i++)
            {
                list.Add(_deck[i]);
            }
            return list;
        }

        public T DealCard(int index = 0)
        {
            // remove the last card from the deck
            index += (_deck.Count - 1) & _deck.Count;
            T card = _deck[index];
            _deck.RemoveAt(index);
            return card;
        }

        public List<T> DealCards(int index, int count)
        {
            List<T> list = new List<T>();
            for (int i = index; i < index + count; i++)
            {
                list.Add(_deck[i]);
            }
            _deck.RemoveRange(index, count);
            return list;
        }

        public void Shuffle()
        {
            
            int n = _deck.Count;
            while (n > 1)
            {
                n--;
                int k = Global.Utils.randomNum.Next(n + 1);
                T value = _deck[k];
                _deck[k] = _deck[n];
                _deck[n] = value;
            }  
        }

        public int GetCount()
        {
            return _deck.Count;
        }
    }
}
