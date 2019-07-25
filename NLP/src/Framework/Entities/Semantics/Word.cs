using System;

namespace NLP.Framework.Entities.Semantics
{
    public struct Word : ISemVal
    {
        public int id;
        public string name;
        public int sentencePosition;

        public Word(int id, string name, int sentencePosition)
        {
            this.id = id;
            this.name = name;
            this.sentencePosition = sentencePosition;
        }
    }

    public static class WordFactory
    {
        private static int wordCount = 0;

        public static Word make(string name, int sentencePosition)
        {
            return new Word(wordCount++, name, sentencePosition);
        }
    }
}