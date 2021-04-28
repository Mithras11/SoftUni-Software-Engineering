import java.util.Scanner;

public class TournamentOfChristmas {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int days = Integer.parseInt(scan.nextLine());
        int totalWins = 0;
        int totalLosses = 0;
        double totalMoney = 0.0;
        String input = null;

        for (int i = 1; i <= days; i++) {
            input = scan.nextLine();

            int winsPerDay = 0;
            int lossesPerDay = 0;
            double moneyPerDay = 0.0;

            while (!input.equals("Finish")) {
                String result = scan.nextLine();

                if (result.equals("win")) {
                    moneyPerDay += 20;
                    winsPerDay++;
                } else {
                    lossesPerDay++;
                }
                input = scan.nextLine();
            }
            if (winsPerDay > lossesPerDay) {
                moneyPerDay *= 1.1;
                totalWins++;
            } else {
                totalLosses++;
            }
            totalMoney += moneyPerDay;
        }
        if (totalWins > totalLosses) {
            totalMoney *= 1.2;
            System.out.printf("You won the tournament! Total raised money: %.2f", totalMoney);
        } else {
            System.out.printf("You lost the tournament! Total raised money: %.2f", totalMoney);
        }
    }
}
