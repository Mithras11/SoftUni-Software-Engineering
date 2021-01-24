import java.util.Scanner;

public class FoodsForPets {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int days = Integer.parseInt(scan.nextLine());
        double totalFood = Double.parseDouble(scan.nextLine());

        double totalBiscuits = 0.0;
        double totalEatenFood = 0.0;
        double totalFoodEatenByDog = 0.0;
        double totalFoodEatenByCat = 0.0;

        for (int i = 1; i <= days; i++) {
            double foodEatenByDog = Double.parseDouble(scan.nextLine());
            double foodEatenByCat = Double.parseDouble(scan.nextLine());
            totalFoodEatenByDog += foodEatenByDog;
            totalFoodEatenByCat += foodEatenByCat;
            totalEatenFood += (foodEatenByDog + foodEatenByCat);

            if (i % 3 == 0) {
                totalBiscuits += 0.1 * (foodEatenByDog + foodEatenByCat);
            }
        }
        System.out.printf("Total eaten biscuits: %dgr.%n", Math.round(totalBiscuits));
        System.out.printf("%.2f%% of the food has been eaten.%n", (totalEatenFood/totalFood)*100);
        System.out.printf("%.2f%% eaten from the dog.%n", (totalFoodEatenByDog/totalEatenFood)*100);
        System.out.printf("%.2f%% eaten from the cat.", (totalFoodEatenByCat/totalEatenFood)*100);

    }
}
