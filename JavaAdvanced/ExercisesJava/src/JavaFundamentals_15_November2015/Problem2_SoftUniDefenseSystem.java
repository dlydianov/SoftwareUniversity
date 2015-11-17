package JavaFundamentals_15_November2015;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Frost on 15.11.2015 ã..
 */
public class Problem2_SoftUniDefenseSystem {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String input = scr.nextLine();
        double softuniLiters = 0.000;


        while (!input.equals("OK KoftiShans")){
            Pattern pattern = Pattern.compile(".*?([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?(\\d+)L.*?");
            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){
                softuniLiters += Integer.parseInt(matcher.group(3)) * 0.001;
                System.out.printf("%s brought %d liters of %s!\n", matcher.group(1), Integer.parseInt(matcher.group(3)), matcher.group(2).toLowerCase());
            }

            input = scr.nextLine();
        }
        System.out.printf("%.3f softuni liters", softuniLiters);
    }
}
