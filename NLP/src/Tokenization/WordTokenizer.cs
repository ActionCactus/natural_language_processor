using System;
using System.Collections.Generic;
using NLP.Framework.Entities.Semantics;

namespace NLP.Tokenization
{
    /**
     * Need for semantic meaning to be utilized from within the tokenization
     * process?  Picture processing and guess work?
     */
    public static class WordTokenizer
    {
        public static List<Word> tokenize(string rawString)
        {
            string[] splitString = rawString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Word> tokenizedString = new List<Word>();

            for (int i = 0; i < splitString.Length; i++)
            {
                tokenizedString.Add(WordFactory.make(splitString[i], i));
            }

            return tokenizedString;
        }
    }
}