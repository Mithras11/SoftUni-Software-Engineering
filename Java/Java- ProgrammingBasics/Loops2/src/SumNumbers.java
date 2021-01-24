import java.util.Scanner;

public class SumNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int number = 0;
        int sum = 0;

        String input = scan.nextLine();

        while (!input.equals("Stop")) {
            number = Integer.parseInt(input);
            sum += number;
            input=scan.nextLine();
        }
        System.out.println(sum);
    }
}
