using NUnit.Framework;
using Product_Review_LINQ;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        List<ProductReview> productreview;
        [SetUp]
        public void Setup()
        {
            productreview = ProductReviewManagement.GetProductReviewList();
        }
        [Test]
        public void TestMethodForRetrieveTopThreeRecord()
        {
            List<int> actual = ProductReviewManagement.RetrieveTopThreeRating(productreview);
            int[] temp = { 1, 7, 2 };
            var expected = new List<int>(temp);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethodForRetrieveBasedonProductIdandRating()
        {
            List<string> actual = ProductReviewManagement.RetrieveRecordsBasedOnRatingAndProductId(productreview);
            string[] temp = { "1 1 Nice 5 True", "4 7 Nice 5 True", "4 4 Average 4 True" };
            var expected = new List<string>(temp);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMethodForCountBasedOnProductId()
        {
            string expected = "1 3 2 4 3 4 4 3 9 3 5 2 7 1 10 3 11 2 ";
            string actual = ProductReviewManagement.RetrieveCountForProductID(productreview);
            Assert.AreEqual(expected, actual);
        }

    }
}