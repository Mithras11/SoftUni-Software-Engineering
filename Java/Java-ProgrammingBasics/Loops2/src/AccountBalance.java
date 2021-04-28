import java.util.Scanner;

public class AccountBalance {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double account = 0.0;
        int totalInput = scan.nextInt();
        int input = 1;
        double increase = 0.0;

        while (input <= totalInput) {
            increase = scan.nextDouble();

            if (increase < 0) {
                System.out.println("Invalid operation!");
                break;
            }
            account += increase;
            System.out.printf("Increase: %.2f%n", increase);

            input++;
        }
        System.out.printf("Total: %.2f", account);
    }
}
