using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_LINQ
{
    public class ProductReviewManagement
    {
        //Add details to list
        public static List<ProductReview> GetProductReviewList()
        {
            List<ProductReview> products = new List<ProductReview>();
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Nice", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 2, review = "Very Good", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 4, review = "Nice", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 4, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Very Good", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Nice", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 8, review = "Average", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 3, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 7, userId = 10, review = "Very Good", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 5, review = "Very Good", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 3, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 5, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 9, review = "Average", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 11, review = "Nice", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 3, isLike = false });
            products.Add(new ProductReview() { productId = 9, userId = 11, review = "Very Good", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 10, userId = 9, review = "Bad", rating = 5, isLike = false });
            products.Add(new ProductReview() { productId = 11, userId = 1, review = "Very Good", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Nice", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Nice", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 11, userId = 8, review = "Average", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 3, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 1, isLike = true });
           // IterateThroughList(products);
            return products;
        }
        /// Display the details in list
        //Retrieve top three records
        public static List<int> RetrieveTopThreeRating(List<ProductReview> products)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Top Three Records Based On Rating");
            var result = (from product in products orderby product.rating descending select product).Take(3).ToList();
            DisplayList(result);
            foreach (var mem in result)
            {
                list.Add(mem.userId);
            }
            return list;
        }
        /// Display the details in list
        public static void DisplayList(List<ProductReview> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("ProductId:{0} | UserId:{1} | Review:{2} | Rating:{3} | IsLike:{4}", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
    }
}
