import java.util.Scanner;

public class SumOfTwoNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int a = scan.nextInt();
        int b = scan.nextInt();
        int x = scan.nextInt();
        int counter = 0;
        boolean combinationExist = false;

        for (int i = a; i <= b; i++) {
            if (combinationExist==true){
                break;
            }
            for (int j = a; j <= b; j++) {
                counter++;
                if (i + j == x) {
                    System.out.printf("Combination N:%d (%d + %d = %d)", counter, i, j, x);
                    combinationExist = true;
                    break;
                }
            }
        }
        if (combinationExist == false) {
            System.out.printf("%d combinations - neither equals %d", counter, x);

        }
    }
}
