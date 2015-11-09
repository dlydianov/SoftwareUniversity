package AdvancedCSharpPractice;

import java.util.Scanner;
import java.util.function.BinaryOperator;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Frost on 9.11.2015 ã..
 */
public class Problem_11_LittleJohn {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        StringBuilder str = new StringBuilder();
        int small = 0;
        int medium = 0;
        int large = 0;

        for (int i = 0; i < 4; i++) {
            String input = scr.nextLine();
            str.append(input);
            str.append(" ");
        }
        String string = str.toString();

        Pattern pattern = Pattern.compile("(>----->)|(>>----->)|(>>>----->>)");
        Matcher match = pattern.matcher(string);

        while (match.find()) {
            String arrow = match.group();
            if (arrow.equals(">----->")) {
                small++;
            } else if (arrow.equals(">>----->")) {
                medium++;
            } else if (arrow.equals(">>>----->>")) {
                large++;
            }
        }
        StringBuilder number = new StringBuilder();
        number.append(small);
        number.append(medium);
        number.append(large);
        int num = Integer.parseInt(number.toString());
        String bin = Integer.toBinaryString(num);
        String reversed = new StringBuilder(bin).reverse().toString();
        bin += reversed;
        int result = Integer.parseInt(bin, 2);

        System.out.println(result);
    }
}
