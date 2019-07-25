using System;
using System.Collections.Generic;
using Xunit;
using NLP.Tokenization;
using NLP.Framework.Entities.Semantics;

namespace NLP.Tests.Tokenization
{
    public class WordTokenizerTest
    {
        [Fact]
        public void TestSimpleSentence()
        {
            List<Word> tokenizedString = WordTokenizer.tokenize("this is a test sentence");
            Assert.Equal(5, tokenizedString.Count);
        }

        [Fact]
        public void TestEmptyString()
        {
            List<Word> tokenizedString = WordTokenizer.tokenize("");

            Assert.Equal(0, tokenizedString.Count);
        }
    }
}