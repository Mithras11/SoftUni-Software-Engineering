import java.util.Scanner;

public class SquareFrame {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();

        System.out.print("+");
        for (int i = 1; i <= (n - 2); i++) {
            System.out.print("-");
        }
        System.out.println("+");

        for (int j = 1; j <= (n - 2); j++) {
            System.out.print("|");
            for (int l = 1; l <= (n - 2); l++) {
                System.out.print("-");
            }
            System.out.println("|");
        }

        System.out.print("+");
        for (int p = 1; p <= (n - 2); p++) {
            System.out.print("-");
        }
        System.out.print("+");


    }
}
