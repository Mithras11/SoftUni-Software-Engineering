import java.util.Scanner;

public class PetShop {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int dogs = Integer.parseInt(scan.nextLine());
        int other = Integer.parseInt(scan.nextLine());

       double price = dogs * 2.50 + other * 4;

        System.out.printf("%.2f lv.", price);

    }
}
