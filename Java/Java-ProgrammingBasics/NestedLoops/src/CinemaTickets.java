import java.util.Scanner;

public class CinemaTickets {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();
        int totalTickets = 0;
        int totalStudentTickets = 0;
        int totalStandardTickets = 0;
        int totalKidTickets = 0;

        while (!input.equals("Finish")) {
            String movie = input;
            int emptySeats = Integer.parseInt(scan.nextLine());
            int tickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            String text = scan.nextLine();
            while (!text.equals("End")) {

                if (text.equals("student")) {
                    studentTickets++;
                } else if (text.equals("standard")) {
                    standardTickets++;
                } else if (text.equals("kid")) {
                    kidTickets++;
                }
                tickets++;
                emptySeats--;
                if (emptySeats==0){
                    break;
                }

                text = scan.nextLine();
            }
            double percentage = (1.0 * tickets / (emptySeats + tickets)) * 100;
            if (percentage >= 100) {
                System.out.printf("%s - 100.00%% full.%n", movie);
            } else {
                System.out.printf("%s - %.2f%% full.%n", movie, percentage);
            }
            totalTickets += tickets;
            totalStudentTickets += studentTickets;
            totalStandardTickets += standardTickets;
            totalKidTickets += kidTickets;

            input = scan.nextLine();
        }
        System.out.printf("Total tickets: %d%n", totalTickets);
        System.out.printf("%.2f%% student tickets.%n", (1.0 * totalStudentTickets / totalTickets)*100);
        System.out.printf("%.2f%% standard tickets.%n", (1.0 * totalStandardTickets / totalTickets)*100);
        System.out.printf("%.2f%% kids tickets.", (1.0 * totalKidTickets / totalTickets)*100);
    }

}
