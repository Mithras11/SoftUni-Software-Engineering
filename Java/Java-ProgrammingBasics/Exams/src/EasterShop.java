import java.util.Scanner;

public class EasterShop {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int eggsInStore = Integer.parseInt(scan.nextLine());
        String input = scan.nextLine();
        int eggs = 0;
        int soldEggs = 0;

        while (!input.equals("Close")) {
            eggs = Integer.parseInt(scan.nextLine());
            if (input.equals("Buy")) {
                if (eggs > eggsInStore) {
                    break;
                }
                eggsInStore -= eggs;
                soldEggs += eggs;
            } else if (input.equals("Fill")) {
                eggsInStore += eggs;
            }
            input = scan.nextLine();
        }
        if (input.equals("Close")) {
            System.out.printf("Store is closed!%n%d eggs sold.", soldEggs);
        } else if (eggsInStore < eggs) {
            System.out.printf("Not enough eggs in store!%nYou can buy only %d.", eggsInStore);
        }
    }
}
