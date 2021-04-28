import java.util.Scanner;

public class Elemenet {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        int max = Integer.MIN_VALUE;
        int sum = 0;

        for (int i = 1; i <= n; i++) {
            int num = Integer.parseInt(scan.nextLine());
            sum += num;

            if (num > max) {
                max = num;
            }
        }

        if (sum - max == max) {
            System.out.println("Yes");
            System.out.printf("Sum = %d", max);
        } else {
            System.out.println("No");
            System.out.printf("Diff = %d", Math.abs(max-(sum-max)));
        }
    }
}
