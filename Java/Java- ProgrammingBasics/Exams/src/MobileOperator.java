import java.util.Scanner;

public class MobileOperator {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String duration = scan.nextLine();
        String type = scan.nextLine();
        String addedMobileNet = scan.nextLine();
        int months = Integer.parseInt(scan.nextLine());

        double price = 0.0;

        switch (duration) {
            case "one":
                switch (type) {
                    case "Small":
                        price = 9.98;
                        break;
                    case "Middle":
                        price = 18.99;
                        break;
                    case "Large":
                        price = 25.98;
                        break;
                    case "ExtraLarge":
                        price = 35.99;
                        break;
                }
                break;
            case "two":
                switch (type) {
                    case "Small":
                        price = 8.58;
                        break;
                    case "Middle":
                        price = 17.09;
                        break;
                    case "Large":
                        price = 23.59;
                        break;
                    case "ExtraLarge":
                        price = 31.79;
                        break;
                }
                break;
        }

        if (addedMobileNet.equals("yes")) {
            if (price <= 10.00) {
                price += 5.50;
            } else if (price <= 30.00) {
                price += 4.35;
            } else if (price > 30.00) {
                price += 3.85;
            }
        }
        price*=months;

        if (duration.equals("two")){
            price*=0.9625;
        }

        System.out.printf("%.2f lv.", price);
    }
}