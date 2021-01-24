import java.util.Scanner;

public class Graduation {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String name = scan.nextLine();
        int counter = 1;
        double grade = 0.0;
        double sumGrades = 0.0;

        while (counter <= 12) {
            grade = scan.nextDouble();
            if (grade >= 4.0) {
                sumGrades += grade;
                counter++;
            }
        }
        double averageGrade = sumGrades / 12;
        System.out.printf("%s graduated. Average grade: %.2f", name, averageGrade);

    }
}
