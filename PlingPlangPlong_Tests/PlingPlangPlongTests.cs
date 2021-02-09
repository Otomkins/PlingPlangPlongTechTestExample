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

        [Category("Factors Of 3 - Pling")]
        [TestCase(9, "Pling")]
        [TestCase(-9, "Pling")]
        public void GivenIHaveANumberWithAFactorOf3_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPling(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

        [Category("Factors Of 5 - Plang")]
        [TestCase(10, "Plang")]
        [TestCase(-10, "Plang")]
        public void GivenIHaveANumberWithAFactorOf5_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlang(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

        [Category("Factors Of 7 - Plong")]
        [TestCase(28, "Plong")]
        [TestCase(-28, "Plong")]
        public void GivenIHaveANumberWithFactorOf7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

        [Category("Factors Of 3 & 5 - PlingPlang")]
        [TestCase(30, "PlingPlang")]
        [TestCase(-30, "PlingPlang")]
        public void GivenIHaveANumberWithFactorsOf3And5_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlingPlang(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

        [Category("Factors Of 3, 5 & 7 - PlingPlangPlong")]
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        public void GivenIHaveANumberWithFactorsOf3And5And7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlingPlangPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

        [Category("Factors Of 3 & 7 - PlingPlong")]
        [TestCase(42, "PlingPlong")]
        [TestCase(-42, "PlingPlong")]
        public void GivenIHaveANumberWithFactorsOf3And7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlingPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

        [Category("Factors Of 5 & 7 - PlangPlong")]
        [TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        public void GivenIHaveANumberWithFactorsOf5And7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlangPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

        [Category("No Factors Of 3, 5 OR 7")]
        [TestCase(34, "34")]
        [TestCase(-34, "-34")]
        public void GivenIHaveANumberWithNoFactorsOf3And5And7_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsTheOriginalNumber(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

        [Category("Zero - PlingPlangPlong")]
        [TestCase(0, "PlingPlangPlong")]
        public void GivenIUse0_WhenIEnterItIntoPlingPlangPlong_ThenItReturnsPlingPlangPlong(int num, string expected)
        {
            pppCode.PlingPlangPlong(num);

            Assert.That(pppCode.PlingPlangPlong(num), Is.EqualTo(expected));
        }

    }
}