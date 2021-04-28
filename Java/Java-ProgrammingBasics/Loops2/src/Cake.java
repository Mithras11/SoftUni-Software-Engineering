import java.util.Scanner;

public class Cake {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int length = Integer.parseInt(scan.nextLine());
        int width = Integer.parseInt(scan.nextLine());
        int totalPieces = length * width;
        int pieces = 0;
        String input = scan.nextLine();

        while (!input.equals("STOP")) {
            pieces = Integer.parseInt(input);
            totalPieces -= pieces;
            if (totalPieces<0){
                break;
            }
            input=scan.nextLine();
        }
        if (input.equals("STOP")){
            System.out.printf("%d pieces are left.", totalPieces );
        }else{
            System.out.printf("No more cake left! You need %d pieces more.", Math.abs(totalPieces));
        }

    }
}
