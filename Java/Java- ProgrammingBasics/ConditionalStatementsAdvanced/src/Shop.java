import java.util.Scanner;

public class Shop {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String product = scan.nextLine();
        String city = scan.nextLine();
        double amount = Double.parseDouble(scan.nextLine());

        switch(city){
            case "Sofia":
                if(product.equals("coffee")){
                    System.out.println(0.50 * amount);
                }else if(product.equals("water")) {
                    System.out.println(0.80 * amount);
                }else if(product.equals("beer")) {
                    System.out.println(1.20 * amount);
                }else if(product.equals("sweets")) {
                    System.out.println(1.45 * amount);
                }else if(product.equals("peanuts")) {
                    System.out.println(1.60 * amount);
                }
                break;

            case "Plovdiv":
                if(product.equals("coffee")){
                    System.out.println(0.40 * amount);
                }else if(product.equals("water")) {
                    System.out.println(0.70 * amount);
                }else if(product.equals("beer")) {
                    System.out.println(1.15 * amount);
                }else if(product.equals("sweets")) {
                    System.out.println(1.30 * amount);
                }else if(product.equals("peanuts")) {
                    System.out.println(1.50 * amount);
                }
                break;

            case "Varna":
                if(product.equals("coffee")){
                    System.out.println(0.45 * amount);
                }else if(product.equals("water")) {
                    System.out.println(0.70 * amount);
                }else if(product.equals("beer")) {
                    System.out.println(1.10 * amount);
                }else if(product.equals("sweets")) {
                    System.out.println(1.35 * amount);
                }else if(product.equals("peanuts")) {
                    System.out.println(1.55 * amount);
                }
                break;




        }
    }
}
