import java.util.Scanner;

public class EvenOddSum {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        int evenSum = 0;
        int oddSum = 0;

        for (int i = 1; i <= n; i++) {
            int num = scan.nextInt();
            if (i % 2 == 0) {
                evenSum += num;
            } else {
                oddSum += num;
            }
        }
        if(evenSum==oddSum){
            System.out.println("Yes");
            System.out.printf("Sum = %d", evenSum);
        }else{
            System.out.println("No");
            System.out.printf("Diff = %d", Math.abs(evenSum - oddSum));
        }
    }
}
