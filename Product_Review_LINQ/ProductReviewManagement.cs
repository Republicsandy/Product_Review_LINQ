﻿using System;
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

        //retrieve records based on rating and product ID
        public static List<string> RetrieveRecordsBasedOnRatingAndProductId(List<ProductReview> products)
        {
            List<string> list = new List<string>();
            var result = (from product in products where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9) select product).ToList();
            DisplayList(result);
            foreach (var mem in result)
            {
                list.Add(mem.productId + " " + mem.userId + " " + mem.review + " " + mem.rating + " " + mem.isLike);
            }
            return list;
        }

        //retrieve count
        public static string RetrieveCountForProductID(List<ProductReview> products)
        {
            string update = null;
            var result = products.GroupBy(x => x.productId).Select(a => new { ProductId = a.Key, count = a.Count() });
            foreach (var mem in result)
            {
                Console.WriteLine("ProductId" + " " + mem.ProductId + " " + "Count" + " " + mem.count);

                update += mem.ProductId + " " + mem.count + " ";

            }
            return update;
        }

        //Retrieve productId and reviews only
        public static string RetrieveOnlyProductIdAndReviews(List<ProductReview> products)
        {
            string update = null;
            var result = products.Select(product => new { ProductId = product.productId, Review = product.review }).ToList();
            foreach (var mem in result)
            {
                Console.WriteLine(mem.ProductId + " " + mem.Review);
                update += mem.ProductId + " " + mem.Review + " ";
            }
            return update;
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
