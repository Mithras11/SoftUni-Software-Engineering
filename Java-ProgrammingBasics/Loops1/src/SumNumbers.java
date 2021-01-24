import java.util.Scanner;

public class SumNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        int sum = 0;
        for (int i = 1; i <= n; i++) {
            int num = scan.nextInt();
            sum += num;
        }
        System.out.println(sum);


    }
}
