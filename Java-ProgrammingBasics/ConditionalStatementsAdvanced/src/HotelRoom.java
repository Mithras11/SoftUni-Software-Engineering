import java.util.Scanner;

public class HotelRoom {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String month = scan.nextLine();
        int nights = Integer.parseInt(scan.nextLine());
        double priceApt = 0.0;
        double priceStud = 0.0;

        switch (month) {
            case "May":
            case "October":
                priceStud = 50.0 * nights;
                priceApt = 65.0 * nights;

                if (nights > 7 && nights <= 14) {
                    priceStud *= 0.95;
                } else if (nights > 14) {
                    priceStud *= 0.7;
                }
                break;

            case "June":
            case "September":
                priceStud = 75.20 * nights;
                priceApt = 68.70 * nights;
                if (nights > 14) {
                    priceStud *= 0.8;
                }
                break;

            case "July":
            case "August":
                priceStud = 76.0 * nights;
                priceApt = 77.0 * nights;
                break;
        }
        if (nights > 14) {
            priceApt *= 0.9;
        }
        System.out.printf("Apartment: %.2f lv.%n", priceApt);
        System.out.printf("Studio: %.2f lv.", priceStud);

    }
}
