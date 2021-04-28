import java.util.Scanner;

public class Vacation {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double neededMoney = Double.parseDouble(scan.nextLine());
        double ownedMoney = Double.parseDouble(scan.nextLine());
        int spendingDays = 0;
        int totalDays = 0;

        while (spendingDays < 5 && ownedMoney < neededMoney) {
            String action = scan.nextLine();
            double money = Double.parseDouble(scan.nextLine());
            totalDays++;
            if (action.equals("spend")) {
                ownedMoney -= money;
                spendingDays++;
                if (ownedMoney < 0) {
                    ownedMoney = 0;
                }
            } else if (action.equals("save")) {
                ownedMoney += money;
                spendingDays=0;
            }
        }
        if (spendingDays == 5) {
            System.out.println("You can't save the money.");
            System.out.printf("%d", totalDays);
        }
        if (ownedMoney >= neededMoney) {
            System.out.printf("You saved the money for %d days.", totalDays);
        }
    }
}
