import java.util.Scanner;

public class FoodDelivery {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int chickenMenus = scan.nextInt();
        int fishMenus = scan.nextInt();
        int vegieMenus = scan.nextInt();

        double price = (chickenMenus * 10.35) + (fishMenus * 12.4) + (vegieMenus * 8.15);
        price *= 1.2;
        price += 2.5;

        System.out.printf("Total: %.2f", price);


    }
}
