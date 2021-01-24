import java.util.Scanner;

public class OldLibraryX {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String book = scan.nextLine();
        int totalBooks = Integer.parseInt(scan.nextLine());
        int checkedBooks = 0;
        String currentBook = scan.nextLine();

        while (!currentBook.equals(book) && checkedBooks < totalBooks) {
            checkedBooks++;
            currentBook = scan.nextLine();
        }
        if (currentBook.equals(book)) {
            System.out.printf("You checked %d books and found it.", checkedBooks);
        } else {
            System.out.println("The book you search is not here!");
            System.out.printf("You checked %d books.", checkedBooks);
        }
    }
}
