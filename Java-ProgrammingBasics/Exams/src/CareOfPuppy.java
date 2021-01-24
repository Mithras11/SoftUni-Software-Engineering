import java.util.Scanner;

public class CareOfPuppy {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int boughtFood = Integer.parseInt(scan.nextLine());
        boughtFood *= 1000;
        int totalEatenFood = 0;
        String input = scan.nextLine();

        while (!input.equals("Adopted")) {
            totalEatenFood += Integer.parseInt(input);
            input =scan.nextLine();
        }
        if (totalEatenFood<=boughtFood){
            System.out.printf("Food is enough! Leftovers: %d grams.", boughtFood-totalEatenFood);
        }else{
            System.out.printf("Food is not enough. You need %d grams more.", totalEatenFood-boughtFood);
        }

    }
}
