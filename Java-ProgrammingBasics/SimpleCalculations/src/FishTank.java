import java.util.Scanner;

public class FishTank {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double a = Double.parseDouble(scan.nextLine());
        double b = Double.parseDouble(scan.nextLine());
        double c = Double.parseDouble(scan.nextLine());

        double d = a * b * c;

        double e = d * 0.001;

        double f = Double.parseDouble(scan.nextLine());

        double percentage = f * 0.01;

        double answer = e * (1 - percentage);

        System.out.printf("%.3f", answer);



    }
}
