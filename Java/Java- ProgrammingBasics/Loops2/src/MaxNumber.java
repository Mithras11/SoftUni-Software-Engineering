import java.util.Scanner;

public class MaxNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        int max = Integer.MIN_VALUE;
        int counter = 1;

        while (counter <= n) {
            int num = scan.nextInt();
            if (num > max) {
                max = num;
            }
            counter++;
        }
        System.out.print(max);
    }
}
