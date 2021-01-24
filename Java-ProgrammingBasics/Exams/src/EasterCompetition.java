import java.util.Scanner;

public class EasterCompetition {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int easterBread = Integer.parseInt(scan.nextLine());
        int highestMark = Integer.MIN_VALUE;
        String topChef = null;

        for (int i = 1; i <= easterBread; i++) {
            String chefName = scan.nextLine();
            int sumMarks = 0;
            String input = scan.nextLine();

            while (!input.equals("Stop")) {
                int mark = Integer.parseInt(input);
                sumMarks += mark;
                input = scan.nextLine();
            }
            System.out.printf("%s has %d points.%n", chefName, sumMarks);
            if (sumMarks > highestMark) {
                highestMark = sumMarks;
                topChef = chefName;
                System.out.printf("%s is the new number 1!%n", chefName);
            }
        }
        System.out.printf("%s won competition with %d points!", topChef, highestMark);
    }
}
