import java.util.Scanner;

public class TimeTravel {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double inheritedMoney = scan.nextDouble();
        int yearOfDeath = scan.nextInt();
        double spentMoney = 0.0;

        for (int i = 1800; i <= yearOfDeath; i++) {
            if (i % 2 == 0) {
                spentMoney += 12000;
            } else {
                int age = 18 + (i - 1800);
                spentMoney += 12000 + (age * 50);
            }
        }
        double leftMoney = inheritedMoney - spentMoney;
        if (leftMoney >= 0) {
            System.out.printf("Yes! He will live a carefree life and will have %.2f dollars left.", leftMoney);
        } else {
            System.out.printf("He will need %.2f dollars to survive.", Math.abs(leftMoney));
        }
    }
}
