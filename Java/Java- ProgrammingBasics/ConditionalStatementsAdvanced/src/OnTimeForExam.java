import java.util.Scanner;

public class OnTimeForExam {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int examHour = Integer.parseInt(scan.nextLine());
        int examMinutes = Integer.parseInt(scan.nextLine());
        int arrivalHour = Integer.parseInt(scan.nextLine());
        int arrivalMinutes = Integer.parseInt(scan.nextLine());

        if (examHour == 0) {
            examHour = 24;
        }
        if (arrivalHour == 0) {
            arrivalHour = 24;
        }
        int exam = examHour * 60 + examMinutes;
        int arrival = arrivalHour * 60 + arrivalMinutes;

        if (arrival == exam) {
            System.out.printf("On time");
        } else if (exam - arrival <= 30 && exam - arrival>0) {
            System.out.printf("On time %n");
            System.out.printf("%d minutes before the start.", exam - arrival);

        } else if (exam - arrival > 30) {
            System.out.printf("Early %n");
            if (exam - arrival < 60) {
                System.out.printf("%d minutes before the start.", exam - arrival);
            } else if (exam - arrival >= 60) {
                int Hour = (exam - arrival) / 60;
                if (Hour == 24) {
                    Hour = 0;
                }
                int Min = (exam - arrival) % 60;
                System.out.printf("%d : %02d hours before the start", Hour, Min);
            }

        } else if (arrival > exam) {
            System.out.printf("Late %n");
            if (arrival - exam < 60) {
                System.out.printf("%d minutes after the start.", arrival - exam);
            } else if (arrival - exam >= 60) {
                int Hour = (arrival - exam) / 60;
                if (Hour == 24) {
                    Hour = 0;
                }
                int Min = (arrival - exam) % 60;
                System.out.printf("%d : %02d hours after the start", Hour, Min);
            }

        }


    }
}
