import java.util.Scanner;

public class PasswordGenerator {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        int l = scan.nextInt();
        String romanLetters = "abcdefghi";

        for (int char1 = 1; char1 < n; char1++) {
            String firstSymbol = char1 + "";
            for (int char2 = 1; char2 < n; char2++) {
                String secondSymbol = char2 + "";
                for (int char3 = 0; char3 < l; char3++) {
                    String thirdSymbol = romanLetters.charAt(char3) + "";
                    for (int char4 = 0; char4 < l; char4++) {
                        String fourthSymbol = romanLetters.charAt(char4) + "";
                        for (int char5 = 1; char5 <= n; char5++) {
                            if (char5 > char1 && char5 > char2) {
                                String fifthSymbol = char5 + "";
                                System.out.print(firstSymbol + secondSymbol + thirdSymbol + fourthSymbol + fifthSymbol + " ");
                            } else {
                                continue;
                            }
                        }
                    }
                }
            }
        }
    }
}
