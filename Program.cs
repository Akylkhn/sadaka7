#include <iostream>
#include <vector>
#include <iomanip>

using namespace std;

struct Donation
{
    string donorName;
    double amount;
};

vector<Donation> donations;

void addDonation(const string& name, double amount)
{
    if (amount > 0)
    {
        donations.push_back({ name, amount});
        cout << "Сіздің қайырымдылықыңыз үшін, " << name << "рахмет!: "
             << fixed << setprecision(2) << amount << " ₸!" << endl;
    }
    else
    {
        cout << "Қате: сомасы оң болуы қажет." << endl;
    }
}

void showDonations()
{
    if (donations.empty())
    {
        cout << "Әзірге қайырымдылық жасалмады.\n";
        return;
    }

    cout << "\n=== Қайырымдылық тізімі ===\n";
    for (const auto&donation : donations) {
        cout << donation.donorName << " садақа жасады: "
             << fixed << setprecision(2) << donation.amount << " ₸\n";
    }
}

int main()
{
    int choice;

    while (true)
    {
        cout << "\nМеню:\n";
        cout << "1. Қайырымдылық жасау\n";
        cout << "2. Қайырымдылықтарды қарау\n";
        cout << "3. Шығу\n";
        cout << "Опцияны таңдаңыз: ";
        cin >> choice;

        if (choice == 1)
        {
            string name;
            double amount;

            cout << "Атыңызды енгізіңіз: ";
            cin >> name;
            cout << "Қайырымдылық сомасын енгізіңіз: ";
            cin >> amount;

            addDonation(name, amount);
        }
        else if (choice == 2)
        {
            showDonations();
        }
        else if (choice == 3)
        {
            cout << "Қайырымдылыққа қатысқандарыңызға рахмет!" << endl;
            break;
        }
        else
        {
            cout << "Қате таңдау. Қайтадан байқап көріңіз.\n";
        }
    }

    return 0;
}
