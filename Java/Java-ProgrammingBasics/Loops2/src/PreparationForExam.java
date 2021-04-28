import java.util.Scanner;

public class PreparationForExam {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int failedThreshold = Integer.parseInt(scan.nextLine());
        int failedTimes = 0;
        int solvedProblems = 0;
        double gradesSum = 0.0;
        String lastProblem = null;

        while (failedTimes < failedThreshold) {
            String problemName = scan.nextLine();
            if (problemName.equals("Enough")){
                break;
            }
            double grade=Double.parseDouble(scan.nextLine());
            if (grade<=4){
                failedTimes++;
            }
            solvedProblems++;
            lastProblem=problemName;
            gradesSum+=grade;

        }
        if (failedTimes==failedThreshold){
            System.out.printf("You need a break, %d poor grades.", failedTimes);
        }else{
            System.out.printf("Average score: %.2f%n", gradesSum/solvedProblems);
            System.out.printf("Number of problems: %d%n", solvedProblems);
            System.out.printf("Last problem: %s", lastProblem);
        }

    }
}
