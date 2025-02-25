#include <iostream>
#include <vector>
#include <iomanip>

using namespace std;

// Структура для хранения информации о пожертвовании
struct Donation
{
    string donorName;
    double amount;
};

// Вектор для хранения всех пожертвований в памяти
vector<Donation> donations;

// Функция для добавления пожертвования
void addDonation(const string& name, double amount)
{
    if (amount > 0)
    {
        donations.push_back({ name, amount});
        cout << "Спасибо, " << name << ", за ваше пожертвование: "
             << fixed << setprecision(2) << amount << " ₸!" << endl;
    }
    else
    {
        cout << "Ошибка: сумма должна быть положительной." << endl;
    }
}

// Функция для отображения всех пожертвований
void showDonations()
{
    if (donations.empty())
    {
        cout << "Пока нет пожертвований.\n";
        return;
    }

    cout << "\n=== Список пожертвований ===\n";
    for (const auto&donation : donations) {
        cout << donation.donorName << " пожертвовал: "
             << fixed << setprecision(2) << donation.amount << " ₸\n";
    }
}

// Основное меню программы
int main()
{
    int choice;

    while (true)
    {
        cout << "\nМеню:\n";
        cout << "1. Сделать пожертвование\n";
        cout << "2. Просмотреть пожертвования\n";
        cout << "3. Выход\n";
        cout << "Выберите опцию: ";
        cin >> choice;

        if (choice == 1)
        {
            string name;
            double amount;

            cout << "Введите ваше имя: ";
            cin >> name;
            cout << "Введите сумму пожертвования: ";
            cin >> amount;

            addDonation(name, amount);
        }
        else if (choice == 2)
        {
            showDonations();
        }
        else if (choice == 3)
        {
            cout << "Спасибо за участие в благотворительности!" << endl;
            break;
        }
        else
        {
            cout << "Ошибка: неверный выбор. Попробуйте снова.\n";
        }
    }

    return 0;
}
