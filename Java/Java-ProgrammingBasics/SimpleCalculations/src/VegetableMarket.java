import java.util.Scanner;

public class VegetableMarket {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double x = Double.parseDouble(scan.nextLine());
        double y = Double.parseDouble(scan.nextLine());
        int a = Integer.parseInt(scan.nextLine());
        int b = Integer.parseInt(scan.nextLine());

        double vegetables = x*a;
        double fruits = y*b;
        double sum = (vegetables + fruits)/1.94;

        System.out.printf("%.2f", sum);



    }
}
