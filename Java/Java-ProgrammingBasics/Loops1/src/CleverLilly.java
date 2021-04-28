import java.util.Scanner;

public class CleverLilly {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int age = scan.nextInt();
        double washingMachine = scan.nextDouble();
        int toyPrice = scan.nextInt();
        int toyCount = 0;
        int receivedMoney = 0;
        int savedMoney = 0;

        for (int i = 1; i <= age; i++) {
            if (i % 2 != 0) {
                toyCount++;
            } else if (i % 2 == 0) {
                receivedMoney += 10;
                savedMoney += receivedMoney - 1;
            }
        }
        int soldToys = toyCount * toyPrice;
        savedMoney += soldToys;

        if (savedMoney < washingMachine) {
            System.out.printf("No! %.2f", washingMachine - 1.0 * savedMoney);
        } else {
            System.out.printf("Yes! %.2f", 1.0 * savedMoney - washingMachine);
        }
    }
}
