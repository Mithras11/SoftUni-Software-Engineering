import java.lang.invoke.SwitchPoint;
import java.util.Scanner;

public class Safari {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double budget = Double.parseDouble(scan.nextLine());
        double gas = Double.parseDouble(scan.nextLine());
        String day = scan.nextLine();

        gas *= 2.1;

        double price = gas + 100;

        switch (day) {
            case "Saturday":
                price *= 0.9;
                break;
            case "Sunday":
                price *= 0.8;
                break;
        }
        if (price <= budget) {
            System.out.printf("Safari time! Money left: %.2f lv.", budget - price);
        } else {
            System.out.printf("Not enough money! Money needed: %.2f lv.", price - budget);
        }

    }
}
