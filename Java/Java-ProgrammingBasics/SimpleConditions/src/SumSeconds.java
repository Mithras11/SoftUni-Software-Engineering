import java.util.Scanner;

public class SumSeconds {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int a = Integer.parseInt(scan.nextLine());
        int b = Integer.parseInt(scan.nextLine());
        int c = Integer.parseInt(scan.nextLine());

        /* въвеждаме времената на тримата
        променлива сбор на времената в секунди
        преобразуваме в мин:сек
        отпечатваме
         */
        int sum = a + b + c;
        int min = sum / 60;
        int seconds = sum % 60;

        System.out.printf("%d:%02d", min, seconds);




    }

}
