import java.util.Scanner;

public class InchesToCentimeters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("Inches =");

        double inches = scan.nextDouble();
        double centimeters = inches * 2.54;

        System.out.print("Centimeters = ");
        System.out.println(centimeters);

    }
}
