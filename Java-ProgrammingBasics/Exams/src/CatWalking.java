import java.util.Scanner;

public class CatWalking {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int min = scan.nextInt();
        int walksPerDay = scan.nextInt();
        int calories = scan.nextInt();

        int totalMin = min * walksPerDay;
        int burnedCalories = totalMin * 5;
        double caloriesPercentage = calories * 0.5;

        if (burnedCalories>= caloriesPercentage){
            System.out.printf("Yes, the walk for your cat is enough. Burned calories per day: %d.", burnedCalories);
        }else{
            System.out.printf("No, the walk for your cat is not enough. Burned calories per day: %d.", burnedCalories);
        }

    }
}
