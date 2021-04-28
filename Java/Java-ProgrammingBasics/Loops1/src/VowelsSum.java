import java.util.Scanner;

public class VowelsSum {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine();
        int x =0;
        //буква	a	e	i	o	u
        //стойност	1	2	3	4	5

        for (int i = 0; i < text.length() ; i++) {
            char vowel = text.charAt(i);
            if(vowel== 'a'){
                x +=1;
            } else if(vowel=='e'){
                x +=2;
            }else if(vowel=='i'){
                x +=3;
            }else if(vowel=='o'){
                x +=4;
            }else if(vowel=='u'){
                x +=5;
            }
        }
        System.out.println(x);
    }
}
