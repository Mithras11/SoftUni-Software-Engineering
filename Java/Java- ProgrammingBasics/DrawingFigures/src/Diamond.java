import java.util.Scanner;

public class Diamond {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        int rows = n;
        if (n % 2 == 0) {
            rows = n - 1;
        }

        int leftRight = (n - 1) / 2;

        for (int i = 1; i <= rows; i++) {
            int dashCount = 0;
            while (dashCount < leftRight) {
                System.out.print("-");
                dashCount++;
            }

            System.out.print("*");

            int mid = n - 2 * leftRight - 2;
            dashCount = 0;
            while (dashCount < mid && mid >= 0) {
                System.out.print("-");
                dashCount++;
            }
            if (mid >= 0) {
                System.out.print("*");
            }

            dashCount = 0;
            while (dashCount < leftRight) {
                System.out.print("-");
                dashCount++;
            }
            System.out.println();


            if (i < (rows / 2) + 1) {
                leftRight--;
            } else {
                leftRight++;
            }
        }
    }
}
