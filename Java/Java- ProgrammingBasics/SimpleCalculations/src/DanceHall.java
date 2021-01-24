import java.util.Scanner;

public class DanceHall {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double L = Double.parseDouble(scan.nextLine());
        double W = Double.parseDouble(scan.nextLine());
        double A = Double.parseDouble(scan.nextLine());

        double area = (L * 100) * (W * 100);
        double wardrobe = (A*100)*(A*100);
        double bench = area / 10;
        double space = area - wardrobe - bench;
        double dancers = space / (40 + 7000);

        double x = Math.floor(dancers);

        System.out.printf("%.0f", x);


    }
}
