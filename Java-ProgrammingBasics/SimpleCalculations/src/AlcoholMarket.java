import java.util.Scanner;

public class AlcoholMarket {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double x = Double.parseDouble(scan.nextLine());
        double a = Double.parseDouble(scan.nextLine());
        double b = Double.parseDouble(scan.nextLine());
        double c = Double.parseDouble(scan.nextLine());
        double d = Double.parseDouble(scan.nextLine());

        double y = x/2;
        double z = y-(0.4*y);
        double w = y-(0.8*y);

        double rakia = y * c;
        double wine = z * b;
        double beer = w * a;
        double whiskey = x * d;
        double sum = rakia+wine+beer+whiskey;

        System.out.printf("%.2f", sum);


    }
}
