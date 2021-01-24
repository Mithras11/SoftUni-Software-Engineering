import java.util.Scanner;

public class GodzillaVsKong {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double budget = Double.parseDouble(scan.nextLine());
        int people = Integer.parseInt(scan.nextLine());
        double priceCostumes = Double.parseDouble(scan.nextLine());

        double costumes = priceCostumes * people;
        double decorum = budget * 0.1;

        if(people > 150){
            costumes *= 0.9;
        }
        if(decorum + costumes > budget){
            System.out.println("Not enough money!");
            System.out.printf("Wingard needs %.2f leva more.", (decorum + costumes) - budget );
        } else{
            System.out.println("Action!");
            System.out.printf("Wingard starts filming with %.2f leva left.", budget - decorum - costumes);
        }

    }
}
