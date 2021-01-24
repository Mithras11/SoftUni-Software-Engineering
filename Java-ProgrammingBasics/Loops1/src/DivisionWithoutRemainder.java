import java.util.Scanner;

public class DivisionWithoutRemainder {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        double p1 = 0.0;
        double p2 = 0.0;
        double p3 = 0.0;

        for (int i = 1; i <= n; i++) {
            int num = scan.nextInt();
            if (num % 2 == 0) {
                p1++;
            }
            if (num % 3 == 0) {
                p2++;
            }
            if (num % 4 == 0) {
                p3++;
            }
        }
        p1 = p1 / n * 100;
        p2 = p2 / n * 100;
        p3 = p3 / n * 100;

        System.out.printf("%.2f%%", p1);
        System.out.printf("%n%.2f%%", p2);
        System.out.printf("%n%.2f%%", p3);

    }
}
