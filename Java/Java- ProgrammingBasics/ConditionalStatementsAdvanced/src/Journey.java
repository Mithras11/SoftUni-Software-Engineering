import java.util.Scanner;

public class Journey {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double budget = Double.parseDouble(scan.nextLine());
        String season = scan.nextLine();
        double price = 0.0;
        String destination = null;
        String vacationType = null;

        if (budget <= 100) {
            destination = "Bulgaria";
            switch (season) {
                case "summer":
                    price = budget * 0.3;
                    break;
                case "winter":
                    price = budget * 0.7;
                    break;
            }
        } else if (budget <= 1000) {
            destination = "Balkans";
            switch (season) {
                case "summer":
                    price = budget * 0.4;
                    break;
                case "winter":
                    price = budget * 0.8;
                    break;
            }
        } else if (budget > 1000) {
            destination = "Europe";
            price = budget * 0.9;
        }
        switch (season) {
            case "summer":
                vacationType = "Camp";
                break;
            case "winter":
                vacationType = "Hotel";
                break;
        }
        if (destination.equals("Europe")) {
            vacationType = "Hotel";
        }
        System.out.printf("Somewhere in %s%n", destination);
        System.out.printf("%s - %.2f", vacationType, price);
    }
}
