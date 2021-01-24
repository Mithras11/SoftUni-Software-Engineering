import java.util.Scanner;

public class EasterEggs {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int totalEggs = Integer.parseInt(scan.nextLine());
        int redEggs = 0;
        int orangeEggs = 0;
        int blueEggs = 0;
        int greenEggs = 0;
        int maxEggs = Integer.MIN_VALUE;
        String outputColor=null;

        for (int i = 1; i <= totalEggs; i++) {
            String color = scan.nextLine();
            switch (color) {
                case "red":
                    redEggs++;
                    if (redEggs > maxEggs) {
                        maxEggs = redEggs;
                        outputColor="red";
                    }
                    break;
                case "orange":
                    orangeEggs++;
                    if (orangeEggs > maxEggs) {
                        maxEggs = orangeEggs;
                        outputColor="orange";
                    }
                    break;
                case "blue":
                    blueEggs++;
                    if (blueEggs > maxEggs) {
                        maxEggs = blueEggs;
                        outputColor="blue";
                    }
                    break;
                case "green":
                    greenEggs++;
                    if (greenEggs > maxEggs) {
                        maxEggs = greenEggs;
                        outputColor="green";
                    }
                    break;
            }
        }
        System.out.printf("Red eggs: %d%nOrange eggs: %d%nBlue eggs: %d%nGreen eggs: %d%nMax eggs: %d -> %s", redEggs, orangeEggs, blueEggs, greenEggs, maxEggs, outputColor);

    }
}
