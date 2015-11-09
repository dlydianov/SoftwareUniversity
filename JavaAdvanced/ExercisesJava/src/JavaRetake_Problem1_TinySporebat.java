import sun.misc.resources.Messages_es;

import java.text.MessageFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Frost on 3.11.2015 ã..
 */
public class JavaRetake_Problem1_TinySporebat {
    public static void main(String arg[]) {
        Scanner scr = new Scanner(System.in);
        String line = scr.nextLine();
        List collection = new ArrayList<>();
        Integer health = 5800;
        Integer glowcaps = 0;


        while (!line.equals("Sporeggar")) {
            char[] symbols = line.toCharArray();
            for (int i = 0; i < symbols.length - 1; i++) {
                if (symbols[i] == 'L') {
                    health += 200;
                }
                else {
                    health -= (int)symbols[i];
                }
            }
            if (health <= 0) {
                break;
            }
            glowcaps += Character.getNumericValue(line.charAt(line.length()-1));
            line = scr.nextLine();
        }
        if (health <= 0) {
            System.out.printf("Died. Glowcaps: %d", glowcaps);
        }
        else if (health >= 0 && glowcaps >= 30){
            System.out.printf("Health left: %d\n", health);
            System.out.printf("Bought the sporebat. Glowcaps left: %d", glowcaps - 30);
        }
        else {
            System.out.printf("Health left: %d\n", health);
            System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.", 30-glowcaps);
        }
    }
}
