import java.util.Scanner;

public class HoneyWinterReserves {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double neededHoney = Double.parseDouble(scan.nextLine());
        double totalGatheredHoney = 0;
        String input = scan.nextLine();

        while (!input.equals("Winter has come")) {
            String beeName = input;
            double gatheredHoney = 0;

            for (int i = 1; i <= 6; i++) {
                double honeyPerMonth = Double.parseDouble(scan.nextLine());
                gatheredHoney += honeyPerMonth;
            }
            if (gatheredHoney < 0) {
                System.out.printf("%s was banished for gluttony%n", beeName);
            }
            totalGatheredHoney += gatheredHoney;

            if (totalGatheredHoney >= neededHoney) {
                System.out.printf("Well done! Honey surplus %.2f.", totalGatheredHoney - neededHoney);
                break;
            }

            input = scan.nextLine();
        }

        if (totalGatheredHoney < neededHoney) {
            System.out.printf("Hard Winter! Honey needed %.2f.", neededHoney - totalGatheredHoney);
        }


    }
}
