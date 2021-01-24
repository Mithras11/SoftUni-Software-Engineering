import java.util.Scanner;

public class MinNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);


        int n = scan.nextInt();
        int min = Integer.MAX_VALUE;
        int counter = 1;

        while (counter <= n) {
            int num = scan.nextInt();
            if (num < min) {
                min = num;
            }
            counter++;
        }
        System.out.print(min);
    }
}

