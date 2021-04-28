import java.util.Scanner;

public class YardGreening {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double area = Double.parseDouble(scan.nextLine());
        System.out.println();

        double price = area * 7.61;
        double discount = price * 0.18;
        double finalPrice = price - discount;

        System.out.printf("The final price is: %.2f lv.", finalPrice);
        System.out.printf("%nThe discount is: %.2f lv.", discount);







    }
}
