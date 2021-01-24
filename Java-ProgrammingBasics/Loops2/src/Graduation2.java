import java.util.Scanner;

public class Graduation2 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int repeatedYears = 0;
        double sumGrades = 0.0;
        String name = scan.nextLine();
        double grade = 0.0;
        int counter = 1;

        while (counter <= 12) {
            grade = scan.nextDouble();
            if (grade < 4.0) {
                repeatedYears++;
                if (repeatedYears == 2) {
                    break;
                }
            } else {
                sumGrades += grade;
                counter++;
            }
        }
        if (repeatedYears < 2) {
            System.out.printf("%s graduated. Average grade: %.2f", name, sumGrades / 12);
        } else {
            System.out.printf("%s has been excluded at %d grade", name, counter);
        }
    }
}
