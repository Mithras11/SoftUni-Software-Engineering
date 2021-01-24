import java.util.Scanner;

public class TrainTheTrainers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int jury = Integer.parseInt(scan.nextLine());
        String input = scan.nextLine();
        int markCounter = 0;
        double totalMarks = 0.0;

        while (!input.equals("Finish")) {
            String presentationName = input;
            double sumMark = 0.0;

            for (int i = 1; i <= jury; i++) {
                double mark = Double.parseDouble(scan.nextLine());
                sumMark += mark;
                markCounter++;
            }
            totalMarks += sumMark;
            System.out.printf("%s - %.2f.%n", presentationName, (sumMark / jury));

            input = scan.nextLine();
        }
        System.out.printf("Student's final assessment is %.2f.", (totalMarks / markCounter));

    }
}
