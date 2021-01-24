import java.util.Scanner;

public class EasterBakery {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double flourPrice = scan.nextDouble();
        double flour = scan.nextDouble();
        double sugar = scan.nextDouble();
        int eggs = scan.nextInt();
        int packages = scan.nextInt();

        double sugarPrice = flourPrice * 0.75;
        double eggPrice = flourPrice * 1.1;
        double packagePrice = sugarPrice * 0.2;

        flourPrice *= flour;
        sugarPrice *= sugar;
        eggPrice *= eggs;
        packagePrice *= packages;
        double totalPrice = flourPrice + sugarPrice + eggPrice + packagePrice;

        System.out.printf("%.2f", totalPrice);

    }
}
