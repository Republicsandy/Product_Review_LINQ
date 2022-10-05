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
    }
}