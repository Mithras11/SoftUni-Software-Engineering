import java.util.Scanner;

public class ReadText {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String text = scan.nextLine();
        int words = 0;

        while (!text.equals("Stop")) {
            words++;
            text = scan.nextLine();
        }
        System.out.print(words);
    }
}
