import org.w3c.dom.ls.LSOutput;

import java.util.Scanner;

public class ConcatenateData {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        System.out.print("First Name =");
        String firstName = scan.nextLine();

        System.out.print("Last Name =");
        String lastName = scan.nextLine();

        System.out.print("age = ");
        int age = Integer.parseInt(scan.nextLine());

        System.out.print("town =");
        String town = scan.nextLine();

        System.out.printf("You are %s %s, a %d-years old person from %s.", firstName, lastName, age, town);

    }
}
