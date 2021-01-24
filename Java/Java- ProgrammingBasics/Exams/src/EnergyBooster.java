import java.util.Scanner;

public class EnergyBooster {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String fruit = scan.nextLine();
        String size = scan.nextLine();
        int amount = Integer.parseInt(scan.nextLine());

        double pricePerPackage = 0.0;
        double price = 0.0;

        switch (size) {
            case "small":
                if (fruit.equals("Watermelon")) {
                    pricePerPackage = 56.0*2;
                } else if (fruit.equals("Mango")) {
                    pricePerPackage = 36.66*2;
                } else if (fruit.equals("Pineapple")) {
                    pricePerPackage = 42.10*2;
                } else if (fruit.equals("Raspberry")) {
                    pricePerPackage = 20.0*2;
                }
                break;

            case "big":
                if (fruit.equals("Watermelon")) {
                    pricePerPackage = 28.7*5;
                } else if (fruit.equals("Mango")) {
                    pricePerPackage = 19.6*5;
                } else if (fruit.equals("Pineapple")) {
                    pricePerPackage = 24.8*5;
                } else if (fruit.equals("Raspberry")) {
                    pricePerPackage = 15.2*5;
                }
                break;
        }
        price = pricePerPackage * amount;

        if (price >= 400 && price <= 1000) {
            price *= 0.85;
        } else if (price > 1000) {
            price *= 0.5;
        }
        System.out.printf("%.2f lv.", price);
    }
}
