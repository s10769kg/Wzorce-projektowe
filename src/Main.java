//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Vault vault = Vault.getInstance();

        String firstKey = vault.getAccessKey();
        System.out.println("Pierwszy klucz: " + firstKey);

        String secondKey = vault.getAccessKey();
        System.out.println("Drugi klucz: " + secondKey);
    }
}