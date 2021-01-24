import java.util.Scanner;

public class OperationsBetweenNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int num1 = Integer.parseInt(scan.nextLine());
        int num2 = Integer.parseInt(scan.nextLine());
        char operator = scan.nextLine().charAt(0);

        switch (operator){
            case '+':
                int sum = num1+num2;
                if (sum %2 == 0){
                    System.out.printf("%d %c %d = %d - even", num1,operator, num2, sum);
                }else{
                    System.out.printf("%d %c %d = %d - odd", num1,operator, num2, sum);
                }
                break;
            case '-':
                int subtraction = num1-num2;
                if (subtraction %2 == 0){
                    System.out.printf("%d %c %d = %d - even", num1,operator, num2, subtraction);
                }else{
                    System.out.printf("%d %c %d = %d - odd", num1,operator, num2, subtraction);
                }
                break;
            case '*':
                int multiplication = num1*num2;
                if (multiplication %2 == 0){
                    System.out.printf("%d %c %d = %d - even", num1,operator, num2, multiplication);
                }else{
                    System.out.printf("%d %c %d = %d - odd", num1,operator, num2, multiplication);
                }
                break;
            case '/':
                if(num2==0){
                    System.out.printf("Cannot divide %d by zero", num1);
                }else{
                    double division = 1.0*num1/num2;
                    System.out.printf("%d / %d = %.2f", num1,num2,division);
                }
                break;
            case '%':
                if (num2==0){
                    System.out.printf("Cannot divide %d by zero", num1);
                }else{
                    int rest =num1%num2;
                    System.out.printf("%d %% %d = %d", num1,num2,rest);
                }
                break;
                }



        }


    }

