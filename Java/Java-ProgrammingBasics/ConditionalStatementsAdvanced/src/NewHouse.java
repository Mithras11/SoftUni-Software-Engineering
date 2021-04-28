import java.util.Scanner;

public class NewHouse {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String flower = scan.nextLine();
        int amount = Integer.parseInt(scan.nextLine());
        int budget = Integer.parseInt(scan.nextLine());
        double price = 0.0;

        switch (flower) {
            case "Roses":
                if (amount <= 80) {
                    price = amount * 5;
                } else if (amount > 80) {
                    price = 0.9 * (amount * 5);
                }
                break;
            case "Dahlias":
                if (amount <= 90) {
                    price = amount * 3.80;
                } else if (amount > 90) {
                    price = 0.85 * (amount * 3.8);
                }
                break;
            case "Tulips":
                if (amount <= 80) {
                    price = amount * 2.80;
                } else if (amount > 80) {
                    price = 0.85 * (amount * 2.80);
                }
                break;
            case "Narcissus":
                if (amount >= 120) {
                    price = amount * 3;
                } else if (amount < 120) {
                    price = 1.15 * (amount * 3);
                }
                break;
            case "Gladiolus":
                if (amount >= 80) {
                    price = amount * 2.50;
                } else if (amount < 80) {
                    price = 1.20 * (amount * 2.50);
                }
                break;
        }
        if (budget >= price) {
            System.out.printf("Hey, you have a great garden with %d %s and %.2f leva left.", amount, flower, (budget - price));
        } else if (budget < price) {
            System.out.printf("Not enough money, you need %.2f leva more.", (price-budget));
        }
    }
}
