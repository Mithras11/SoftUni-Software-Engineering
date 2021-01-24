import java.util.Scanner;

public class Travelling {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();
        while (!input.equals("End")) {
            double budget = Double.parseDouble(scan.nextLine());
            double sum = 0.0;

            while (sum < budget) {
                double saved = Double.parseDouble(scan.nextLine());
                sum += saved;
            }
            System.out.printf("Going to %s!%n", input);
            input= scan.nextLine();
        }

    }
}
