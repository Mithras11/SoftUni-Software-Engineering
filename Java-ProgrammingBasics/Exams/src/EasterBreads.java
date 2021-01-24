import java.util.Scanner;

public class EasterBreads {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int easterBreads = scan.nextInt();
        int usedSugar = 0;
        int usedFlour = 0;
        int maxSugar = Integer.MIN_VALUE;
        int maxFlour = Integer.MIN_VALUE;

        for (int i = 1; i <= easterBreads; i++) {
            int sugar = scan.nextInt();
            int flour = scan.nextInt();
            usedSugar += sugar;
            usedFlour += flour;
            if (sugar > maxSugar) {
                maxSugar = sugar;
            }
            if ((flour > maxFlour)) {
                maxFlour = flour;
            }
        }
        double sugarPackages = Math.ceil(1.0 * usedSugar / 950);
        double flourPackages = Math.ceil(1.0 * usedFlour / 750);

        System.out.printf("Sugar: %.0f%n", sugarPackages);
        System.out.printf("Flour: %.0f%n", flourPackages);
        System.out.printf("Max used flour is %d grams, max used sugar is %d grams.", maxFlour, maxSugar);
    }
}
