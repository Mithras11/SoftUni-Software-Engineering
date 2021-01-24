import java.util.Scanner;

public class TriangleOfDollars {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n=scan.nextInt();

        for (int row = 1; row <=n ; row++) {
            for (int column = 1; column <=row ; column++) {
                System.out.print("$");
            }
            System.out.println();

        }
    }
}
