import java.util.Scanner;

/**
 * Created by Frost on 8.11.2015 ã..
 */
public class DozensofEggs {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String input = scr.nextLine();
        String[] arr = input.split(" ");
        Integer count = 0;
        Integer dozens = 0;

        for (int i = 0; i < 7; i++) {
            arr = input.split(" ");
            if (arr[1].equals("eggs")) {
                count += Integer.parseInt(arr[0]);
                if (count >= 12){
                    dozens += count / 12;
                    count = count % 12;
                }
            }
            else {
                dozens += Integer.parseInt(arr[0]);
            }
            input = scr.nextLine();
        }
        System.out.printf("%d dozens + %d eggs",dozens,count);

    }
}
