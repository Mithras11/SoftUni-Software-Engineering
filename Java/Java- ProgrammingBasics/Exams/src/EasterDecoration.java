import java.util.Scanner;

public class EasterDecoration {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int customers = Integer.parseInt(scan.nextLine());
        double totalPrice = 0.0;

        for (int i = 1; i <= customers; i++) {
            String input = scan.nextLine();
            int purchases = 0;
            double price = 0.0;
            while (!input.equals("Finish")) {
                switch (input) {
                    case "basket":
                        price += 1.5;
                        break;
                    case "wreath":
                        price += 3.8;
                        break;
                    case "chocolate bunny":
                        price += 7;
                        break;
                }
                purchases++;
                input = scan.nextLine();
            }
            if (purchases % 2 == 0) {
                price *= 0.8;
            }
            System.out.printf("You purchased %d items for %.2f leva.%n", purchases, price);
            totalPrice += price;
        }
        System.out.printf("Average bill per client is: %.2f leva.", totalPrice / customers);
    }
}
