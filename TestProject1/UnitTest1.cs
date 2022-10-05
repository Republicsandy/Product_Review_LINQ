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

        [Test]
        public void TestMethodForRetrievingProductIdandReview()
        {
            string expected = "1 Nice 2 Very Good 3 Nice 2 Bad 1 Very Good 2 Average 4 Nice 9 Average 3 Bad 5 Average 7 Very Good 9 Very Good 10 Bad 1 Bad 5 Average 3 Nice 10 Bad 9 Very Good 10 Bad 11 Very Good 2 Nice 4 Nice 11 Average 3 Bad 4 Average ";
            string actual = ProductReviewManagement.RetrieveOnlyProductIdAndReviews(productreview);
            Assert.AreEqual(expected, actual);
        }

    }
}