import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Frost on 3.11.2015 ã..
 */
public class JavaRetake_Problem2_WeirdScript {
    public static void main (String args[]) {
        Scanner scr = new Scanner(System.in);
        String line = scr.nextLine();
        StringBuilder text = new StringBuilder();
        Integer keyValue = Integer.parseInt(line);

        char[] keys = {
                'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y'
        };

        Integer newKeyValue = keyValue % 52;
        char key = (char)keys[newKeyValue];

        Pattern p = Pattern.compile(key +"" + key + "(.*?)" + key + "" + key);

        while (!line.equals("End")) {
            text.append(line);
            line = scr.nextLine();
        }
        Matcher m = p.matcher(text);
        while (m.find()) {
            System.out.println(m.group(1));
        }
    }
}
