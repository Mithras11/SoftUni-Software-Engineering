import java.util.Scanner;

public class SumPrimeNonPrime {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();
        int sumPrimeNum = 0;
        int sumNonPrimeNum = 0;

        while (!input.equals("stop")) {
            int currentNum = Integer.parseInt(input);
            boolean isPrime = true;
            boolean isNegative = false;

            if (currentNum < 0) {
                System.out.println("Number is negative.");
            } else {
                for (int i = 2; i <= currentNum / 2; i++) {
                    if (currentNum % i == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) {
                    sumPrimeNum += currentNum;
                } else {
                    sumNonPrimeNum += currentNum;
                }
            }
            input = scan.nextLine();
        }
        System.out.printf("Sum of all prime numbers is: %d%n", sumPrimeNum);
        System.out.printf("Sum of all non prime numbers is: %d", sumNonPrimeNum);
    }
}