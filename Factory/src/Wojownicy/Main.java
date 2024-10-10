package Wojownicy;

public class Main {
    public static void main(String[] args) {
        // Tworzenie tablicy wojowników za pomocą fabryki
        Wojownik[] wojownicy = {
                Garnizon.wyszkolWojownika("Piechur"),
                Garnizon.wyszkolWojownika("Piechur"),
                Garnizon.wyszkolWojownika("Piechur"),
                Garnizon.wyszkolWojownika("Konny"),
                Garnizon.wyszkolWojownika("Konny"),
                Garnizon.wyszkolWojownika("Konny"),
                Garnizon.wyszkolWojownika("Strzelec"),
                Garnizon.wyszkolWojownika("Strzelec"),
                Garnizon.wyszkolWojownika("Strzelec"),
                Garnizon.wyszkolWojownika("Strzelec")
        };

        // Wypisanie gotowych wojowników
        for (Wojownik wojownik : wojownicy) {
            wojownik.walcz();
        }
    }
}
