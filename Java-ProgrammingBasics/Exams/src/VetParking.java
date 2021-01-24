import java.util.Scanner;

public class VetParking {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int days = scan.nextInt();
        int hours = scan.nextInt();

        double totalPrice = 0.0;
        double pricePerDay = 0.0;

        for (int i = 1; i <= days; i++) {
            for (int j = 1; j <= hours; j++) {
                if (i % 2 == 0 && j % 2 != 0) {
                    pricePerDay += 2.50;
                } else if (i % 2 != 0 && j % 2 == 0) {
                    pricePerDay += 1.25;
                } else {
                    pricePerDay += 1;
                }

            }
            System.out.printf("Day: %d - %.2f leva.%n", i, pricePerDay);
            totalPrice += pricePerDay;
            pricePerDay=0;

        }
        System.out.printf("Total: %.2f leva.", totalPrice);

    }
}
