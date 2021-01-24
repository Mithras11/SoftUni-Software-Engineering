import java.util.Scanner;

public class EasterParty {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int guests = scan.nextInt();
        double pricePerPerson = scan.nextDouble();
        double budget = scan.nextDouble();

        double cake = 0.1 * budget;

        if (guests >= 10 && guests <= 15) {
            pricePerPerson *= 0.85;
        } else if (guests > 15 && guests <= 20) {
            pricePerPerson *= 0.8;
        } else if (guests > 20) {
            pricePerPerson *= 0.75;
        }
        double totalPrice = (pricePerPerson * guests) + cake;

        if (totalPrice <= budget) {
            System.out.printf("It is party time! %.2f leva left.", budget - totalPrice);
        } else {
            System.out.printf("No party! %.2f leva needed.", totalPrice - budget);
        }
    }
}
