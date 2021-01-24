import java.util.Scanner;

public class TailoringWorkshop {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int tables = Integer.parseInt(scan.nextLine());
        double lenghth = Double.parseDouble(scan.nextLine());
        double width = Double.parseDouble(scan.nextLine());

        double a = tables * (lenghth + 2 * 0.30 ) * (width + 2 * 0.30);
        double b = tables * (lenghth / 2) * (lenghth / 2);

        double priceUSD = a*7.00+b*9.00;
        double priceBGN = priceUSD*1.85;

        System.out.printf("%.2f USD %n%.2f BGN", priceUSD, priceBGN);



    }
}
