import java.util.Scanner;

public class PaintingEggs {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String size = scan.nextLine();
        String colour = scan.nextLine();
        int series = Integer.parseInt(scan.nextLine());

        int pricePerSeries = 0;

        switch (size) {
            case "Large":
                if (colour.equals("Red")) {
                    pricePerSeries = 16;
                } else if (colour.equals("Green")) {
                    pricePerSeries = 12;
                } else if (colour.equals("Yellow")) {
                    pricePerSeries = 9;
                }
                break;
            case "Medium":
                if (colour.equals("Red")) {
                    pricePerSeries = 13;
                } else if (colour.equals("Green")) {
                    pricePerSeries = 9;
                } else if (colour.equals("Yellow")) {
                    pricePerSeries = 7;
                }
                break;
            case "Small":
                if (colour.equals("Red")) {
                    pricePerSeries = 9;
                } else if (colour.equals("Green")) {
                    pricePerSeries = 8;
                } else if (colour.equals("Yellow")) {
                    pricePerSeries = 5;
                }
                break;

        }
        int totalPrice = pricePerSeries * series;
        double income = totalPrice * 0.65;

        System.out.printf("%.2f leva.", income);
    }
}
