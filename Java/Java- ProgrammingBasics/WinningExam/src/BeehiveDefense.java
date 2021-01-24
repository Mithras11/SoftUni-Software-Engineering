import java.util.Scanner;

public class BeehiveDefense {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int beeNum = scan.nextInt();
        int bearStamina = scan.nextInt();
        int bearAttack = scan.nextInt();

        beeNum -= bearAttack;

        while (beeNum >= 100) {
            bearStamina -= beeNum * 5;

            if (bearStamina<=0){
                System.out.printf("Beehive won! Bees left %d.", beeNum);
                break;
            }

            beeNum -= bearAttack;
        }


        if (beeNum < 0) {
            System.out.printf("The bear stole the honey! Bees left 0.");
        } else if (beeNum < 100) {
            System.out.printf("The bear stole the honey! Bees left %d.", beeNum);
        }
    }
}
