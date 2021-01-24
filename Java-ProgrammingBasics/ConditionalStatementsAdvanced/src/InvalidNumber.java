import java.util.Scanner;

public class InvalidNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int num = scan.nextInt();

        if (num != 0 && num < 100 || num > 200) {
            System.out.println("invalid");
        }

    }
}
