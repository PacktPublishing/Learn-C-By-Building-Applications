using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordUnscambler.Workers;

namespace WordUnscrambler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher _wordMatcher = new WordMatcher();

        [TestMethod]
        public void ScrambledWordMatchesGivenWordInTheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] scrambledWords = { "omre" };

            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 1);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
        }

        [TestMethod]
        public void ScrambledWordMatchesGivenWordsInTheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] scrambledWords = { "omre", "act" };

            var matchedWords = _wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 2);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
            Assert.IsTrue(matchedWords[1].ScrambledWord.Equals("act"));
            Assert.IsTrue(matchedWords[1].Word.Equals("cat"));
        }
    }
}
