import java.util.Scanner;

public class AnimalClass {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

       String animal = scan.nextLine();

        if ("dog".equals(animal)) {
            System.out.print("mammal");
        } else if ("crocodile".equals(animal) || "tortoise".equals(animal) || "snake".equals(animal)) {
            System.out.print("reptile");
        } else {
            System.out.print("unknown");
        }


    }
}
