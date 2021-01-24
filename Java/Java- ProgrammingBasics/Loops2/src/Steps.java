import java.util.Scanner;

public class Steps {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int totalSteps = 10000;
        int sumSteps = 0;
        int steps = 0;

        while (sumSteps < totalSteps) {
            String input = scan.nextLine();
            if (input.equals("Going home")) {
                steps = scan.nextInt();
                sumSteps += steps;
                break;
            }
            steps = Integer.parseInt(input);
            sumSteps += steps;
        }

        if (sumSteps < totalSteps) {
            System.out.printf("%d more steps to reach goal.", totalSteps - sumSteps);
        } else {
            System.out.println("Goal reached! Good job!");

        }
    }
}
