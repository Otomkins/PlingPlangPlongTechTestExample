using NUnit.Framework;
using PlingPlangPlong_Code;

namespace PlingPlangPlong_Tests
{
    public class PlingPlangPlongTests
    {
        readonly PlingPlangPlongCode pppCode = new PlingPlangPlongCode();

        [TestCase(28, "1 2 4 7 14 28")]
        [TestCase(30, "1 2 3 5 6 10 15 30")]
        [TestCase(34, "1 2 17 34")]
        [TestCase(45, "1 3 5 9 15 45")]
        public void GivenIHaveANumber_WhenIEnterItIntoReturnFactors_ThenItReturnsAListOfAllCorrectFactors(int num, string expected)
        {
            var factorsList = pppCode.ReturnFactors(num);
            var factorsString = "";

            foreach (var factor in factorsList)
            {
                factorsString += $"{factor} ";
            }

            Assert.That(factorsString.TrimEnd(), Is.EqualTo(expected));
        }

        [TestCase(9, "Pling")]
        public void GivenIHaveANumberWithAFactorOf3_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPling(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }
        [TestCase(10, "Plang")]
        public void GivenIHaveANumberWithAFactorOf5_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlang(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }
        [TestCase(28, "Plong")]
        public void GivenIHaveANumberWithFactorOf7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }
        [TestCase(30, "PlingPlang")]
        public void GivenIHaveANumberWithFactorsOf3And5_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlingPlang(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }
        [TestCase(105, "PlingPlangPlong")]
        public void GivenIHaveANumberWithFactorsOf3And5And7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlingPlangPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }
        [TestCase(42, "PlingPlong")]
        public void GivenIHaveANumberWithFactorsOf3And7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlingPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }
        [TestCase(35, "PlangPlong")]
        public void GivenIHaveANumberWithFactorsOf5And7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlangPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }
        [TestCase(34, "34")]
        public void GivenIHaveANumberWithNoFactorsOf3And5And7_WhenIEnterItIntoPlingPlangPlong_ThenTheOriginalNumber(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }
    }
}