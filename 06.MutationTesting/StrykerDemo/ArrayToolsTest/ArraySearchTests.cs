using ArrayTools;
using FluentAssertions;

namespace ArrayToolsTest
{
    [TestFixture]
    public class ArraySearchTests
    {
        [Test]
        public void CheckArrayFindElement()
        {
            int[] numbers = { 1, 3, 5, 2, 4 };
            int valueToFind = 2;
            int expected = 3;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(expected);
        }

        [Test]
        public void ElementIsFoundInMiddle()
        {
            int[] numbers = { 1, 3, 5, 2, 4 };
            int valueToFind = 2;
            int expected = 3;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(expected);
        }

        [Test]
        public void ElementNotFoundReturnsMinusOne()
        {
            int[] numbers = { 1, 2, 3 };
            int valueToFind = 10;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(-1);
        }

        [Test]
        public void ElementIsFirstInArray()
        {
            int[] numbers = { 7, 8, 9 };
            int valueToFind = 7;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(0);
        }

        [Test]
        public void ElementIsLastInArray()
        {
            int[] numbers = { 11, 12, 13 };
            int valueToFind = 13;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(2);
        }

        [Test]
        public void ArrayHasOnlyOneMatchingElement()
        {
            int[] numbers = { 99 };
            int valueToFind = 99;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(0);
        }

        [Test]
        public void ArrayHasOnlyOneNonMatchingElement()
        {
            int[] numbers = { 99 };
            int valueToFind = 100;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(-1);
        }

        [Test]
        public void EmptyArrayReturnsMinusOne()
        {
            int[] numbers = { };
            int valueToFind = 42;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(-1);
        }

        [Test]
        public void NegativeNumbersAreHandledCorrectly()
        {
            int[] numbers = { -5, -10, -15 };
            int valueToFind = -10;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(1);
        }

        [Test]
        public void DuplicateValuesReturnsFirstIndex()
        {
            int[] numbers = { 2, 3, 2, 4 };
            int valueToFind = 2;

            int result = ArraySearch.FindIndex(numbers, valueToFind);
            result.Should().Be(0);
        }
    }
}