import java.util.Scanner;

public class Password {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String name = scan.nextLine();
        String password = scan.nextLine();

        String inputPassword = scan.nextLine();

        while (!inputPassword.equals(password)) {
            inputPassword = scan.nextLine();
        }
        System.out.print("Welcome " + name+"!");
    }
}
