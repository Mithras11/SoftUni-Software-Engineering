import java.util.Scanner;

public class Commissions {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String city = scan.nextLine();
        double s = scan.nextDouble();
/*Град	0 ≤ s ≤ 500	500 < s ≤ 1 000	1 000 < s ≤ 10 000	s > 10 000
Sofia	5%	7%	8%	12%
Varna	4.5%	7.5%	10%	13%
Plovdiv	5.5%	8%	12%	14.5%
*/
        switch (city) {
            case "Sofia":
                if (s >= 0 && s <= 500) {
                    System.out.printf("%.2f", s * 0.05);
                } else if (s > 500 && s <= 1000) {
                    System.out.printf("%.2f", s * 0.07);
                } else if (s > 1000 && s <= 10000) {
                    System.out.printf("%.2f", s * 0.08);
                } else if (s > 10000) {
                    System.out.printf("%.2f", s * 0.12);
                } else if (s < 0) {
                    System.out.println("error");
                }
                break;
            case "Varna":
                if (s >= 0 && s <= 500) {
                    System.out.printf("%.2f", s * 0.045);
                } else if (s > 500 && s <= 1000) {
                    System.out.printf("%.2f", s * 0.075);
                } else if (s > 1000 && s <= 10000) {
                    System.out.printf("%.2f", s * 0.10);
                } else if (s > 10000) {
                    System.out.printf("%.2f", s * 0.13);
                } else if (s < 0) {
                    System.out.println("error");
                }
                break;
            case "Plovdiv":
                if (s >= 0 && s <= 500) {
                    System.out.printf("%.2f", s * 0.055);
                } else if (s > 500 && s <= 1000) {
                    System.out.printf("%.2f", s * 0.08);
                } else if (s > 1000 && s <= 10000) {
                    System.out.printf("%.2f", s * 0.12);
                } else if (s > 10000) {
                    System.out.printf("%.2f", s * 0.145);
                } else if (s < 0) {
                    System.out.println("error");
                }
                break;
            default:
                System.out.println("error");
                break;


        }
    }
}
