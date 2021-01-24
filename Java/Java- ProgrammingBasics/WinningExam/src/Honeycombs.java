import java.util.Scanner;

public class Honeycombs {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int bees = scan.nextInt();
        int flowers = scan.nextInt();

        double honey = flowers * bees * 0.21;
        int honeycombs= (int)(honey/100);
        double leftOverHoney= honey%100;

        System.out.printf("%d honeycombs filled.%n", honeycombs);
        System.out.printf("%.2f grams of honey left", leftOverHoney);


    }
}
