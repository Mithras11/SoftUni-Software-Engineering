import java.util.Scanner;

public class EvenOddPositions {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        double OddSum = 0;
        double OddMin = 1000_000_000.0;
        double OddMax = -1000_000_000.0;
        double EvenSum = 0;
        double EvenMin = 1000_000_000.0;
        double EvenMax = -1000_000_000.0;

        for (int i = 1; i <= n; i++) {
            double num = scan.nextDouble();
            if (i % 2 != 0) {
                OddSum += num;
                if (num < OddMin) {
                    OddMin = num;
                }
                if (num > OddMax) {
                    OddMax = num;
                }
            } else if (i % 2 == 0) {
                EvenSum += num;
                if (num < EvenMin) {
                    EvenMin = num;
                }
                if (num > EvenMax) {
                    EvenMax = num;
                }
            }

        }


        System.out.printf("OddSum=%.2f,%n", OddSum);
        if (OddMin == 1000_000_000.0) {
            System.out.println("OddMin=No,");
        } else {
            System.out.printf("OddMin=%.2f,%n", OddMin);
        }
        if (OddMax == -1000_000_000.0) {
            System.out.println("OddMax=No,");
        } else {
            System.out.printf("OddMax=%.2f,%n", OddMax);
        }
        System.out.printf("EvenSum=%.2f,%n", EvenSum);
        if (EvenMin == 1000_000_000.0) {
            System.out.println("EvenMin=No,");
        } else {
            System.out.printf("EvenMin=%.2f,%n", EvenMin);
        }
        if (EvenMax == -1000_000_000.0) {
            System.out.println("EvenMax=No");
        } else {
            System.out.printf("EvenMax=%.2f", EvenMax);
        }
    }
}

