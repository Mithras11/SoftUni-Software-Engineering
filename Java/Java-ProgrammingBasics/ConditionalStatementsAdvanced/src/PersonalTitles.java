import java.util.Scanner;
import java.util.concurrent.DelayQueue;

public class PersonalTitles {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double age = Double.parseDouble(scan.nextLine());
        String sex = scan.nextLine();

        if (age >= 16){
            if("m".equals(sex)){
                System.out.println("Mr.");
            } else if("f".equals(sex)){
                System.out.println("Ms.");
            }
        } else if(age < 16){
            if(sex.equals("m")){
                System.out.println("Master");
            } else if(sex.equals("f")){
                System.out.println("Miss");
            }
        }
    }
}
