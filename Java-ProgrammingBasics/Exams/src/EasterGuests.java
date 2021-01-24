import java.util.Scanner;

public class EasterGuests {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double guests = scan.nextDouble();
        int budget = scan.nextInt();

        int easterBread = (int) (Math.ceil(guests / 3));
        int eggs = (int)(guests * 2);
        double easterBreadPrice = easterBread * 4.0;
        double eggPrice = eggs * 0.45;
        double totalPrice = eggPrice + easterBreadPrice;

        if (totalPrice <= budget) {
            System.out.printf("Lyubo bought %d Easter bread and %d eggs.%n", easterBread, eggs);
            System.out.printf("He has %.2f lv. left.", budget - totalPrice);
        } else {
            System.out.printf("Lyubo doesn't have enough money.%n");
            System.out.printf("He needs %.2f lv. more.", totalPrice - budget);
        }
    }
}
