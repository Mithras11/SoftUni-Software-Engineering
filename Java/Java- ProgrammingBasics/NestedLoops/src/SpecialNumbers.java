import java.util.Scanner;

public class SpecialNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        for (int i = 1111; i < 9999; i++) {
            String currentNum = i + "";
            int digitCounter = 0;

            for (int j = 0; j < currentNum.length(); j++) {
                int currentDigit = Integer.parseInt("" + currentNum.charAt(j));
                if (currentDigit == 0) {
                    continue;
                } else if (n % currentDigit == 0) {
                    digitCounter++;
                }
            }
            if (digitCounter == currentNum.length()) {
                System.out.print(currentNum + " ");
            }

        }
    }
}
