using System;
using System.Collections.Generic;

class Program
{
    struct Review
    {
        public string Name;
        public string Feedback;
        public int Rating;
    }

    static void AddReview(List<Review> reviews)
    {
        Console.WriteLine("==================================");
        Console.WriteLine("---------Leave a Review-----------\n");
        Review newReview;

        Console.Write("Enter your name: ");
        newReview.Name = Console.ReadLine();

        Console.Write("Enter your feedback: ");
        newReview.Feedback = Console.ReadLine();

        while (true)
        {
            Console.Write("Enter your rating (1-5): ");
            if (int.TryParse(Console.ReadLine(), out newReview.Rating) && newReview.Rating >= 1 && newReview.Rating <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid rating. Please enter a number between 1 and 5.");
            }
        }

        reviews.Add(newReview);
    }

    static void DisplayReviews(List<Review> reviews)
    {
        if (reviews.Count == 0)
        {
            Console.WriteLine("No reviews yet.");
            return;
        }

        double totalRating = 0;
        Console.WriteLine("==================================");
        Console.WriteLine("-------------Reviews--------------\n");
        foreach (var review in reviews)
        {
            Console.WriteLine($"Name: {review.Name}");
            Console.WriteLine($"Feedback: {review.Feedback}");
            Console.WriteLine($"Rating: {review.Rating}/5");
            Console.WriteLine("----------------------------------");
            totalRating += review.Rating;
        }

        double averageRating = totalRating / reviews.Count;
        Console.WriteLine($"Average Rating: {averageRating:F1}/5");
    }

    static void Main()
    {
        List<Review> reviews = new List<Review>();
        int choice;

        do
        {
            Console.WriteLine("==================================");
            Console.WriteLine("--------Restaurant Review---------\n");
            Console.WriteLine("1. Add Review");
            Console.WriteLine("2. Display Reviews");
            Console.WriteLine("3. Exit\n");
            Console.WriteLine("--------(Input no.: 1 - 3)--------");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddReview(reviews);
                        break;
                    case 2:
                        DisplayReviews(reviews);
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
					default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            }
        } while (choice != 3);
    }
}
