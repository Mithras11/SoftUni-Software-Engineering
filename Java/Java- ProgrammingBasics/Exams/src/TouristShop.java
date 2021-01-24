import java.util.Scanner;

public class TouristShop {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double totalPrice = 0.0;
        int boughtProducts = 0;
        boolean isTooExpensive = false;
        double price = 0.0;
        int counter=0;

        double budget = Double.parseDouble(scan.nextLine());
        String input = scan.nextLine();

        while (!input.equals("Stop")) {
            counter++;
            price = Double.parseDouble(scan.nextLine());
            if (counter%3==0){
                price /=2;
            }
            if (price > budget) {
                isTooExpensive = true;
                break;
            }
            boughtProducts++;
            totalPrice += price;
            budget -= price;

            input = scan.nextLine();
        }
        if (isTooExpensive) {
            System.out.printf("You don't have enough money!%n");
            System.out.printf("You need %.2f leva!", price - budget);
        }else{
            System.out.printf("You bought %d products for %.2f leva.", boughtProducts, totalPrice );
        }
    }
}
