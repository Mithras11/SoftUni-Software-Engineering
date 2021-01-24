import java.util.Scanner;

public class SkiTravel {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int days = Integer.parseInt(scan.nextLine());
        String room = scan.nextLine();
        String grade = scan.nextLine();

        int nights = days - 1;
        double price = 0.0;
        double discount = 0.0;

        switch (room) {
            case "room for one person":
                price = nights * 18.0;
                break;
            case "apartment":
                price = nights * 25.0;
                break;
            case "president apartment":
                price = nights * 35.0;
                break;
        }

        if (days < 10) {
            if (room.equals("room for one person")) {
                discount = 0.0;
            } else if (room.equals("apartment")) {
                discount = price * 0.3;
            } else if (room.equals("president apartment")) {
                discount = price * 0.1;
            }
        } else if (days <= 15) {
            if (room.equals("room for one person")) {
                discount = 0.0;
            } else if (room.equals("apartment")) {
                discount = price * 0.35;
            } else if (room.equals("president apartment")) {
                discount = price * 0.15;
            }

        } else if (days > 15) {
            if (room.equals("room for one person")) {
                discount = 0.0;
            } else if (room.equals("apartment")) {
                discount = price * 0.5;
            } else if (room.equals("president apartment")) {
                discount = price * 0.2;
            }
        }

        price -= discount;

        switch (grade){
            case"positive":
                price *=1.25;
                break;

            case"negative":
                price*=0.9;
                break;
        }
        System.out.printf("%n%.2f", price);
    }
}