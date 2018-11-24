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
        public void Generate_Should_return_array_of_specified_size(int size)
        {
            var sut = RandomBytesGenerator.Generate(size);
            Assert.Equal(size, sut.Length);
        }

        [Fact]
        public void Generate_Should_return_different_array_contents_each_time()
        {
            var a = RandomBytesGenerator.Generate(10);
            var b = RandomBytesGenerator.Generate(10);

            Assert.False(a.SequenceEqual(b));
        }

        [Fact]
        public void GenerateAsBase64_Should_return_different_string_each_time()
        {
            var a = RandomBytesGenerator.GenerateAsBase64(10);
            var b = RandomBytesGenerator.GenerateAsBase64(10);

            Assert.NotEqual(a, b);
        }

        [Fact]
        public void Generate_Should_throw_argument_exception_when_size_is_zero()
        {
            Assert.Throws<ArgumentException>(() => RandomBytesGenerator.Generate(0));
        }
    }
}
