import java.util.Scanner;

public class NumberSequence {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        int MaxNum = Integer.MIN_VALUE;
        int MinNum = Integer.MAX_VALUE;

        for (int i = 1; i <= n; i++) {
            int num = Integer.parseInt(scan.nextLine());

            if (num > MaxNum) {
                MaxNum = num;
            }
            if (num < MinNum) {
                MinNum = num;
            }
        }
        System.out.printf("Max number: %d%n", MaxNum);
        System.out.printf("Min number: %d", MinNum);
    }
}
