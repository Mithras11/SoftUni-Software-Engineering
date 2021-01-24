import java.util.Scanner;

public class CharityCampaign {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int days = Integer.parseInt(scan.nextLine());
        int people = Integer.parseInt(scan.nextLine());
        int cakes = Integer.parseInt(scan.nextLine());
        int gof = Integer.parseInt(scan.nextLine());
        int pancakes = Integer.parseInt(scan.nextLine());

        int a = cakes * 45;
        double b = gof * 5.80;
        double c = pancakes * 3.20;
        double sum = (a+b+c)*people;
        double total = sum*days;
        double money = total - total/8;

        System.out.printf("%.2f", money);




    }
}
