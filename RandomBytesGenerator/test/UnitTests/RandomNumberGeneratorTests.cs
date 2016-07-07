using System;
using System.Linq;
using Xunit;

namespace Savage
{
    public class RandomBytesGeneratorTests
    {
        [Fact]
        public void ThrowsExceptionWhenGenerateGivenZeroValue()
        {
            Assert.Throws<ArgumentException>(() => RandomBytesGenerator.Generate(0));
        }

        [Theory]
        [InlineData(8)]
        [InlineData(20)]
        [InlineData(512)]
        public void GenerateCreatesArrayOfCorrectSize(int size)
        {
            var sut = RandomBytesGenerator.Generate(size);
            Assert.Equal(size, sut.Length);
        }

        [Fact]
        public void GenerateCreatesDifferentSequence()
        {
            var a = RandomBytesGenerator.Generate(10);
            var b = RandomBytesGenerator.Generate(10);

            Assert.False(a.SequenceEqual(b));
        }

        [Fact]
        public void GenerateAsBase64CreatesDifferentSequence()
        {
            var a = RandomBytesGenerator.GenerateAsBase64(10);
            var b = RandomBytesGenerator.GenerateAsBase64(10);

            Assert.NotEqual(a, b);
        }
    }
}
