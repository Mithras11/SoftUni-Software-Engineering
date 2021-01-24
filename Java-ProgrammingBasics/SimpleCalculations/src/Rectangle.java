import java.util.Scanner;

public class Rectangle {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double x1 = Double.parseDouble(scan.nextLine());
        double y1 = Double.parseDouble(scan.nextLine());
        double x2 = Double.parseDouble(scan.nextLine());
        double y2 = Double.parseDouble(scan.nextLine());

        double lenght = Math.abs(x1 - x2);
        double width = Math.abs(y1-y2);

        double area = lenght * width;
        double perimeter = 2 * (lenght + width);

        System.out.printf("%.2f %n%.2f", area, perimeter);

    }
}
