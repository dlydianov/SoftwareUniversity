import com.google.common.base.Strings;
import com.sun.deploy.util.StringUtils;

import java.util.Locale;
import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        scanner.useLocale(Locale.ENGLISH);

        System.out.println("Enter three number you wish to format: ");
        short firstNumber = scanner.nextShort();

        float secondNumber = scanner.nextFloat();
        float thirdNumber = scanner.nextFloat();

        System.out.printf("|%-10x|%s|%10.2f|%-10.3f|", firstNumber, Strings.padStart(Integer.toBinaryString(firstNumber), 10, '0'), secondNumber,thirdNumber);

    }

}
