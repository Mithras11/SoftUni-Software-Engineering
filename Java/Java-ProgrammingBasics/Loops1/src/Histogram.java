import java.util.Scanner;

public class Histogram {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;

        for (int i = 1; i <= n; i++) {
            int num = scan.nextInt();
            if (num < 200) {
                p1++;
            } else if (num >= 200 && num <= 399) {
                p2++;
            } else if (num >= 400 && num <= 599) {
                p3++;
            } else if (num >= 600 && num <= 799) {
                p4++;
            } else if (num >= 800) {
                p5++;
            }
        }
        p1 = p1 / n * 100;
        p2 = p2 / n * 100;
        p3 = p3 / n * 100;
        p4 = p4 / n * 100;
        p5 = p5 / n * 100;

        System.out.printf("%.2f%%", p1);
        System.out.printf("%n%.2f%%", p2);
        System.out.printf("%n%.2f%%", p3);
        System.out.printf("%n%.2f%%", p4);
        System.out.printf("%n%.2f%%", p5);

    }
}
