class Review:
    def __init__(self, name, feedback, rating):
        self.name = name
        self.feedback = feedback
        self.rating = rating

def add_review(reviews):
    print("==================================")
    print("---------Leave a Review-----------\n")
    name = input("Enter your name: ")
    feedback = input("Enter your feedback: ")

    while True:
        try:
            rating = int(input("Enter your rating (1-5): "))
            if 1 <= rating <= 5:
                break
            else:
                print("Invalid rating. Please enter a number between 1 and 5.")
        except ValueError:
            print("Invalid input. Please enter a number between 1 and 5.")

    reviews.append(Review(name, feedback, rating))

def display_reviews(reviews):
    if not reviews:
        print("No reviews yet.")
        return

    total_rating = 0
    print("==================================")
    print("-------------Reviews--------------\n")
    for review in reviews:
        print(f"Name: {review.name}")
        print(f"Feedback: {review.feedback}")
        print(f"Rating: {review.rating}/5")
        print("----------------------------------")
        total_rating += review.rating

    average_rating = total_rating / len(reviews)
    print(f"Average Rating: {average_rating:.1f}/5")

def main():
    reviews = []
    while True:
        print("==================================")
        print("--------Restaurant Review---------\n")
        print("1. Add Review")
        print("2. Display Reviews")
        print("3. Exit\n")
        print("--------(Input no.: 1 - 3)--------")
        try:
            choice = int(input("Enter your choice: "))
            if choice == 1:
                add_review(reviews)
            elif choice == 2:
                display_reviews(reviews)
            elif choice == 3:
                print("Exiting...")
                break
            else:
                print("Invalid choice. Please enter a number between 1 and 3.")
        except ValueError:
            print("Invalid choice. Please enter a number between 1 and 3.")

if __name__ == "__main__":
    main()

