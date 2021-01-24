import java.util.Scanner;

public class ChangeBureau {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int bitCoin = Integer.parseInt(scan.nextLine());
        double yuan = Double.parseDouble(scan.nextLine());
        double fee = Double.parseDouble(scan.nextLine());

        int bitCoinToBGn = bitCoin * 1168;
        double yuanToDollars = yuan * 0.15;
        double yuanToBGN = yuanToDollars * 1.76;
        double sum = (bitCoinToBGn + yuanToBGN);
        double sumToEuro = sum / 1.95;

        fee /= 100;
        fee *= sumToEuro;
        sumToEuro -= fee;

        System.out.printf("%.2f",sumToEuro);

    }
}
