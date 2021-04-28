import java.util.Scanner;

public class FishingBoat {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int budget = Integer.parseInt(scan.nextLine());
        String season = scan.nextLine();
        int fishermen = Integer.parseInt(scan.nextLine());
        double price = 0.0;

        switch (season) {
            case "Spring":
                price = 3000.0;
                break;
            case "Summer":
            case "Autumn":
                price = 4200.0;
                break;
            case "Winter":
                price = 2600;
                break;
        }
        if (fishermen <= 6) {
            price *= 0.9;
        } else if (fishermen <= 11) {
            price *= 0.85;
        } else if (fishermen >= 12) {
            price *= 0.75;
        }
        if (fishermen % 2 == 0 && !season.equals("Autumn")) {
            price *= 0.95;
        }
        if (budget >= price) {
            System.out.printf("Yes! You have %.2f leva left.", budget - price);
        } else if (budget < price) {
            System.out.printf("Not enough money! You need %.2f leva.", price - budget);
        }


    }

}
