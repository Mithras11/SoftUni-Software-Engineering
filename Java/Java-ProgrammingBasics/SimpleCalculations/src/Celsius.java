import java.util.Scanner;

public class Celsius {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double x = Double.parseDouble(scan.nextLine());
        double y = x*1.8+32;

        System.out.printf("%.2f", y);



    }
}
