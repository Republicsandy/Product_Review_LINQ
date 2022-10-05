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
            productreview = ProjectReviewManagement.GetProductReviewList();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}