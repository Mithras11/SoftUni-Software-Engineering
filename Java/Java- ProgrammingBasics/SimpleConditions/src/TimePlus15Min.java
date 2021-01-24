import java.util.Scanner;

public class TimePlus15Min {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int hour = Integer.parseInt(scan.nextLine());
        int min = Integer.parseInt(scan.nextLine());
        int z = hour * 60 + min + 15;

        int hour1 = z / 60;
        int min1 = z % 60;

        if (hour1 >= 24){
            hour1 -= 24;
        }
        if(min1 >= 60){
            min1 -= 60;
        }

        System.out.printf("%d:%02d", hour1, min1);

    }

}
