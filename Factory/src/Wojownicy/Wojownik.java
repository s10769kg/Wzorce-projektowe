package Wojownicy;

abstract class Wojownik {
    protected String nazwa;

    public Wojownik(String nazwa) {
        this.nazwa = nazwa;
    }

    public void walcz() {
        System.out.println(nazwa + " gotowy do walki!");
    }
}
