import java.util.Scanner;

public class LeftRightSum {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 1; i <= n; i++) {
            int num = scan.nextInt();
            leftSum += num;
        }
        for (int i = 1; i <= n; i++) {
            int num = scan.nextInt();
            rightSum += num;
        }
        if (leftSum == rightSum){
            System.out.printf("Yes, sum = %d", leftSum);
        } else {
            System.out.printf("No, diff = %d", Math.abs(leftSum-rightSum));
        }
    }
}
