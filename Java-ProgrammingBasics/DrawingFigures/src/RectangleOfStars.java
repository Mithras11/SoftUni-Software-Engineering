import java.util.Scanner;

public class RectangleOfStars {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();

        for (int i = 1; i <= n; i++) {
            int counter = 0;

            while (counter < n) {
                System.out.print("*");
                counter++;
            }
            System.out.println();
        }
    }
}
