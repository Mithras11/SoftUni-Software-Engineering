import java.util.Scanner;

public class BonusScores {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int a = Integer.parseInt(scan.nextLine());
        double b = 0;

        if (a <= 100) {
            b = 5;
        } else if (a > 1000) {
            b = a * 0.1;
        } else {
            b = a * 0.2;
        }

        if (a % 2 == 0) {
            b += 1;
        } else if (a % 10 == 5) {
            b += 2;
        }
        System.out.println(b);
        System.out.println(a + b);


    }
}
