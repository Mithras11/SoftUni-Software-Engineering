import java.util.Scanner;

public class EatserLunch {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int cakes = scan.nextInt();
        int eggs = scan.nextInt();
        int cookies = scan.nextInt();

        double cakePrice = cakes * 3.2;
        double eggPrice = eggs * 4.35;
        double cookiePrice = cookies * 5.4;
        double paint = eggs * 12 * 0.15;
        double totalPrice = cakePrice + eggPrice + cookiePrice + paint;

        System.out.printf("%.2f", totalPrice);
    }
}
