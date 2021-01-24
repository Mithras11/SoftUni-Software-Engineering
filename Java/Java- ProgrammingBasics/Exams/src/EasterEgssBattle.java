import java.util.Scanner;

public class EasterEgssBattle {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int eggs1 = Integer.parseInt(scan.nextLine());
        int eggs2 = Integer.parseInt(scan.nextLine());
        String input = scan.nextLine();

        while (!input.equals("End of battle")) {
            if (input.equals("one")) {
                eggs2--;
            } else if (input.equals("two")) {
                eggs1--;
            }
            if (eggs1 == 0 || eggs2 == 0) {
                break;
            }
            input = scan.nextLine();
        }

        if (eggs1 == 0) {
            System.out.printf("Player one is out of eggs. Player two has %d eggs left.", eggs2);
        } else if (eggs2 == 0) {
            System.out.printf("Player two is out of eggs. Player one has %d eggs left.", eggs1);
        }
        if (input.equals("End of battle")) {
            System.out.printf("Player one has %d eggs left.%n", eggs1);
            System.out.printf("Player two has %d eggs left.", eggs2);
        }

    }

}

