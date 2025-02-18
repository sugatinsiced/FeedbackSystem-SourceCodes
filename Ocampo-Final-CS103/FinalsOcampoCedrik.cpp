#include <iostream>
#include <vector>
#include <string>
#include <limits>

using namespace std;

struct Review {
    string name;
    string feedback;
    int rating;
};

void addReview(vector<Review>& reviews) {
    Review newReview;
    cout << "==================================\n";
    cout << "---------Leave a Review-----------\n\n";
    cout << "Enter your name: ";
    cin.ignore();
    getline(cin, newReview.name);
    cout << "Enter your feedback: ";
    getline(cin, newReview.feedback);

    while (true) {
        cout << "Enter your rating (1-5): ";
        cin >> newReview.rating;
        if (cin.fail() || newReview.rating < 1 || newReview.rating > 5) {
            cin.clear(); // clear the error flag
            cin.ignore(numeric_limits<streamsize>::max(), '\n'); // discard invalid input
            cout << "Invalid rating. Please enter a number between 1 and 5." << endl;
        }
        else {
            break;
        }
    }

    reviews.push_back(newReview);
}

void displayReviews(const vector<Review>& reviews) {
    if (reviews.empty()) {
        cout << "No reviews yet." << endl;
        return;
    }

    double totalRating = 0;
    cout << "==================================\n";
    cout << "-------------Reviews--------------\n\n";
    for (const auto& review : reviews) {
        cout << "Name: " << review.name << endl;
        cout << "Feedback: " << review.feedback << endl;
        cout << "Rating: " << review.rating << "/5" << endl;
        cout << "----------------------------------" << endl;
        totalRating += review.rating;
    }

    double averageRating = totalRating / reviews.size();
    cout << "Average Rating: " << averageRating << "/5" << endl;
}

int main() {
    vector<Review> reviews;
    int choice;

    do {
        cout << "==================================\n";
        cout << "--------Restaurant Review---------\n\n";
        cout << "1. Add Review" << endl;
        cout << "2. Display Reviews" << endl;
        cout << "3. Exit\n\n";
        cout << "--------(Input no.: 1 - 3)--------\n";
        cout << "Enter your choice: ";
        cin >> choice;

        if (cin.fail() || choice < 1 || choice > 3) {
            cin.clear(); // clear the error flag
            cin.ignore(numeric_limits<streamsize>::max(), '\n'); // discard invalid input
            cout << "Invalid choice. Please enter a number between 1 and 3." << endl;
            continue;
        }

        switch (choice) {
        case 1:
            addReview(reviews);
            break;
        case 2:
            displayReviews(reviews);
            break;
        case 3:
            cout << "Exiting..." << endl;
            break;
        }
    } while (choice != 3);

    return 0;
}
