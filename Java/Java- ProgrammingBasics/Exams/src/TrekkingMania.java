import java.util.Scanner;

public class TrekkingMania {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int groups = scan.nextInt();
        int people = 0;
        int totalPeople = 0;
        int Mussala = 0;
        int MontBlanc = 0;
        int Kilimanjaro = 0;
        int K2 = 0;
        int Everest = 0;


        for (int i = 1; i <= groups; i++) {
            people = scan.nextInt();
            if (people <= 5) {
                Mussala += people;
            } else if (people <= 12) {
                MontBlanc += people;
            } else if (people <= 25) {
                Kilimanjaro += people;
            } else if (people <= 40) {
                K2 += people;
            } else if (people >= 41) {
                Everest += people;
            }
            totalPeople += people;
        }
        System.out.printf("%.2f%%%n", (1.0 * Mussala / totalPeople) * 100);
        System.out.printf("%.2f%%%n", (1.0 * MontBlanc / totalPeople) * 100);
        System.out.printf("%.2f%%%n", (1.0 * Kilimanjaro / totalPeople) * 100);
        System.out.printf("%.2f%%%n", (1.0 * K2 / totalPeople) * 100);
        System.out.printf("%.2f%%", (1.0 * Everest / totalPeople) * 100);
    }
}
