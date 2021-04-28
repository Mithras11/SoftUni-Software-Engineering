import java.util.Scanner;

public class PointOnRectangle {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double x1 = scan.nextDouble();
        double y1 = scan.nextDouble();
        double x2 = scan.nextDouble();
        double y2 = scan.nextDouble();
        double x = scan.nextDouble();
        double y = scan.nextDouble();

        if ((x == x1 || x == x2) && (y >= y1) && (y <= y2)) {
            System.out.println("Border");
        } else if ((y == y1 || y == y2) && (x >= x1) && (x <= x2)) {
            System.out.println("Border");
        } else {
            System.out.println("Inside / Outside");
        }

    }
}
