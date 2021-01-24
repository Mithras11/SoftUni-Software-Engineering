import java.util.Scanner;

public class SuitcasesLoad {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int counter = 0;
        int sumSuitcases = 0;
        double size = 0.0;
        double capacity = Double.parseDouble(scan.nextLine());
        String input = scan.nextLine();

        while (!input.equals("End")) {
            counter++;
            size = Double.parseDouble(input);
            if (counter % 3 == 0) {
                size *= 1.1;
            }
            if (capacity < size) {
                break;
            }
            capacity -= size;
            sumSuitcases++;
            input = scan.nextLine();
        }
        if (input.equals("End")) {
            System.out.println("Congratulations! All suitcases are loaded!");
        } else if (capacity < size) {
            System.out.println("No more space!");
        }
        System.out.printf("Statistic: %d suitcases loaded.", sumSuitcases);

    }
}
