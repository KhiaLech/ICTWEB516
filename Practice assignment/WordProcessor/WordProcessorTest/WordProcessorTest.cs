using System;
using NUnit.Framework;
using WordProcessor;

namespace WordProcessorTest
{
    [TestFixture]
    public class Tests
    {


        Processor processor;
        [SetUp]
        public void Setup()
        {
            processor = new Processor();
        }

        [Test]
        [TestCase ("abcdefghij", "aBcDeFgHiJ")]
        [TestCase ("ABCDEFGHIJ","AbCdEfGhIj")]
        [TestCase ("aBCDefghIJ","aBcDeFgHiJ")]
        public void AlternateCase_ValidInput_CorrectResult(string word, string ans)
        {
            var result = processor.AlternateCase(word);

            Assert.AreEqual(result, ans);
        }

        [Test]
        [TestCase("abcdefghi5")]
        [TestCase("abc$$efghi")]
        public void AlternateCase_InvalidInput_InvalidWordExceptionThrown(string word)
        {

            Assert.Throws<InvalidWordException>(() => {processor.AlternateCase(word); });
        }
    }
}
