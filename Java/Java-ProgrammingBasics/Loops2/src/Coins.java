import java.util.Scanner;

public class Coins {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double change = scan.nextDouble();
        change = Math.round(change * 100);
        int sumCoins = 0;

        while (change > 0) {
            if (change >= 200) {
                change -= 200;
            } else if (change >= 100) {
                change -= 100;
            } else if (change >= 50) {
                change -= 50;
            } else if (change >= 20) {
                change -= 20;
            } else if (change >= 10) {
                change -= 10;
            } else if (change >= 5) {
                change -= 5;
            } else if (change >= 2) {
                change -= 2;
            } else if (change == 1) {
                change -= 1;
            }
            sumCoins++;
        }
        System.out.println(sumCoins);
    }
}
