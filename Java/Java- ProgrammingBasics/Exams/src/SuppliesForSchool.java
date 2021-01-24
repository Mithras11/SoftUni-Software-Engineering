import java.util.Scanner;

public class SuppliesForSchool {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int pens = Integer.parseInt(scan.nextLine());
        int markers = Integer.parseInt(scan.nextLine());
        double cleaner = Double.parseDouble(scan.nextLine());
        int discount = Integer.parseInt(scan.nextLine());

        double pricePens = pens * 5.80;
        double priceMarkers = markers * 7.20;
        double priceCleaner = cleaner * 1.20;
        double sumPrice = pricePens + priceMarkers + priceCleaner;
        double finalPrice = sumPrice - (sumPrice * (1.0 * discount / 100));

        System.out.printf("%.3f", finalPrice);

    }
}
