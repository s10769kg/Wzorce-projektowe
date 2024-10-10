package Wojownicy;

class Garnizon {
    public static Wojownik wyszkolWojownika(String profesja) {
        switch (profesja) {
            case "Piechur":
                return new Piechur();
            case "Strzelec":
                return new Strzelec();
            case "Konny":
                return new Konny();
            default:
                throw new IllegalArgumentException("Nieznana profesja wojownika: " + profesja);
        }
    }
}
