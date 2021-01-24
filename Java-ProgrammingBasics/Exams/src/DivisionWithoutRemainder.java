import java.util.Scanner;

public class DivisionWithoutRemainder {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        int num = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;

        for (int i = 1; i <= n; i++) {
            num = scan.nextInt();
            if (num % 2 == 0) {
                count2++;
            }
            if (num % 3 == 0) {
                count3++;
            }
            if (num % 4 == 0) {
                count4++;
            }
        }
        System.out.printf("%.2f%%%n", 1.0*count2/n*100);
        System.out.printf("%.2f%%%n", 1.0*count3/n*100);
        System.out.printf("%.2f%%", 1.0*count4/n*100);

    }
}
