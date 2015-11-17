package JavaFundamentals_15_November2015;

import java.util.Scanner;

/**
 * Created by Frost on 15.11.2015 ã..
 */
public class Problem1_SoftUniPalatkaConf {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String input = scr.nextLine();
        int people = Integer.parseInt(input);
        input = scr.nextLine();
        int n = Integer.parseInt(input);
        input = scr.nextLine();
        int beds = 0;
        int food = 0;

        for (int i = 0; i < n; i++) {
            String[] arr = input.split(" ");
            int quantity = Integer.parseInt(arr[1]);

            if (arr[0].equals("tents")) {
                if (arr[2].equals("normal")) {
                    beds += quantity * 2;
                } else if (arr[2].equals("firstClass")) {
                    beds += quantity * 3;
                }
            } else if (arr[0].equals("rooms")) {
                if (arr[2].equals("single")) {
                    beds += quantity;
                } else if (arr[2].equals("double")) {
                    beds += quantity * 2;
                } else if (arr[2].equals("triple")) {
                    beds += quantity * 3;
                }
            } else if (arr[0].equals("food")) {
                if (arr[2].equals("musaka")) {
                    food += quantity * 2;
                } else if (arr[2].equals("zakuska")) {
                    food += 0;
                }
            }
            if (i == n - 1){
                break;
            }
            else {
                input = scr.nextLine();
            }
        }
        int freeBeds = beds - people;
        int mealsLeft = food - people;

        if (freeBeds >= 0) {
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d\n", freeBeds);
        } else if (freeBeds < 0) {
            System.out.printf("Some people are freezing cold. Beds needed: %d\n", Math.abs(freeBeds));
        }
        if (mealsLeft >= 0) {
            System.out.printf("Nobody left hungry. Meals left: %d\n", mealsLeft);
        } else if (mealsLeft < 0) {
            System.out.printf("People are starving. Meals needed: %d\n", Math.abs(mealsLeft));
        }
    }
}
