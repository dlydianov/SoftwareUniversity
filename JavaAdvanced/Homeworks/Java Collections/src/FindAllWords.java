import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class FindAllWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Pattern pattern = Pattern.compile("[a-zA-Z]+");
        Matcher matcher = pattern.matcher(scanner.nextLine());
        int countOfWords = 0;
        while (matcher.find()){
            countOfWords++;
        }
        System.out.print(countOfWords);
    }
}
