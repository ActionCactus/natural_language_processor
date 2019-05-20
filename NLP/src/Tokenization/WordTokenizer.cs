using System;
using System.Collections.Generic;
using NLP.Framework;

namespace NLP.Tokenization
{
    public static class WordTokenizer
    {
        public static List<Word> tokenize(string rawString)
        {
            string[] splitString = rawString.Split(new char[] { ' ' });
            List<Word> tokenizedString = new List<Word>();

            for (int i = 0; i < splitString.Length; i++)
            {
                tokenizedString.Add(WordFactory.make(splitString[i], i));
            }

            return tokenizedString;
        }
    }
}