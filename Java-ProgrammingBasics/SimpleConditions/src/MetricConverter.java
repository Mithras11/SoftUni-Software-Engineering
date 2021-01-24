import java.util.Scanner;

public class MetricConverter {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double a = Double.parseDouble(scan.nextLine());
        String b = scan.nextLine();
        String c = scan.nextLine();

        if(b.equals("m")){
            a *= 1000;
        } else if(b.equals("cm")){
            a *= 10;
        }
         if(c.equals("m")){
             a /= 1000;
         } else if(c.equals("cm")){
             a /= 10;
         }
        System.out.printf("%.3f", a);
    }
}
