import java.util.Scanner;

public class ChristmasTree {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();

        for (int i = 0; i <= n; i++) {
            for (int j = 1; j <= n - i; j++) {
                System.out.print(" ");
            }
            int counter = 0;
            while (counter < i) {
                System.out.print("*");
                counter++;
            }
            System.out.print("|");

            counter = 0;
            while (counter < i) {
                System.out.print("*");
                counter++;
            }
            System.out.println();


        }

    }
}
