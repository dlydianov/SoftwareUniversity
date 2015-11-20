import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toLowerCase();
        String specificWord = scanner.nextLine();
        Pattern pattern = Pattern.compile(String.format("\\b%s\\b", specificWord));
        Matcher matcher = pattern.matcher(text);
        int countOfSpecifiedWord = 0;
        while (matcher.find()){
            countOfSpecifiedWord++;
        }
        System.out.print( countOfSpecifiedWord);
    }
}
