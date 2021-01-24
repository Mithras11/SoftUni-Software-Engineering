import java.util.Scanner;

public class HoneyHarvest {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String flower = scan.nextLine();
        int flowerCount = Integer.parseInt(scan.nextLine());
        String season = scan.nextLine();
        double honey = 0;

        switch (season) {
            case "Spring":
                if (flower.equals("Sunflower")) {
                    honey = flowerCount * 10;
                } else if (flower.equals("Daisy")) {
                    honey = flowerCount * 12;
                    honey *= 1.1;
                } else if (flower.equals("Lavender")) {
                    honey = flowerCount * 12;
                } else if (flower.equals("Mint")) {
                    honey = flowerCount * 10;
                    honey *= 1.1;
                }
                break;

            case "Summer":
                if (flower.equals("Sunflower")) {
                    honey = flowerCount * 8;
                } else if (flower.equals("Daisy")) {
                    honey = flowerCount * 8;
                } else if (flower.equals("Lavender")) {
                    honey = flowerCount * 8;
                } else if (flower.equals("Mint")) {
                    honey = flowerCount * 12;
                }
                honey *= 1.1;
                break;

            case "Autumn":
                if (flower.equals("Sunflower")) {
                    honey = flowerCount * 12;
                } else if (flower.equals("Daisy")) {
                    honey = flowerCount * 6;
                } else if (flower.equals("Lavender")) {
                    honey = flowerCount * 6;
                } else if (flower.equals("Mint")) {
                    honey = flowerCount * 6;
                }
                honey *= 0.95;
                break;

        }

        System.out.printf("Total honey harvested: %.2f", honey);
    }
}
