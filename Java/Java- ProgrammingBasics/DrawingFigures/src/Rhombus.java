import java.util.Scanner;

public class Rhombus {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();

        for (int row = 1; row <= n; row++) {

            for (int i = 1; i <= n - row; i++) {
                System.out.print(" ");
            }
            for (int j = 1; j <= row; j++) {
                System.out.print("* ");
            }
            System.out.println();
        }

        for (int row = 1; row <= n - 1; row++) {
            for (int i = 1; i <= row; i++) {
                System.out.print(" ");
            }
            int counter = 0;
            while (counter < (n - row)) {
                System.out.print("* ");
                counter++;
            }
            System.out.println();

        }
    }
}
