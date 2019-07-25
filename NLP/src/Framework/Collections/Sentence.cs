using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NLP.Framework.Entities.Semantics;

namespace NLP.Framework.Collections
{
    public struct Sentence : IQueryable
    {
        private List<Word> words { get; set; }

        public void AddWord(Word word)
        {
            words.Add(word);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

    }
}