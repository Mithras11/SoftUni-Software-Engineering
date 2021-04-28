import java.util.Scanner;

public class SwimmingRecord {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double seconds = Double.parseDouble(scan.nextLine());
        double metres = Double.parseDouble(scan.nextLine());
        double velocity = Double.parseDouble(scan.nextLine());

        double time = velocity * metres;
        double x = Math.floor(metres / 15);
        double delay = x * 12.5;
        double time1 = time + delay;

        if(time1 < seconds){
            System.out.printf("Yes, he succeeded! The new world record is %.2f seconds.", time1);
        } else if(time1 >= seconds){
            System.out.printf("No, he failed! He was %.2f seconds slower.", time1 - seconds);
        }
    }
}
