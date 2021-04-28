import java.util.Scanner;

public class Population {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int population = scan.nextInt();
        int years = scan.nextInt();

        for (int i = 1; i <= years; i++) {
            int newBorn = population / 10 * 2;
            population += newBorn;

            if (i % 5 == 0) {
                int migrated = population / 50 * 5;
                population -= migrated;
            }

            int dead = population / 20 * 2;
            population -= dead;

        }
        System.out.printf("Beehive population: %d", population);

    }
}
