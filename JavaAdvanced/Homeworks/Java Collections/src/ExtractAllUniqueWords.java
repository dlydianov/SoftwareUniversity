import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeSet uniqueWords = new TreeSet();
        Matcher matcher = Pattern.compile("([a-zA-Z]+)").matcher(scanner.nextLine());
        String foundWord;
        while (matcher.find()){
            foundWord = matcher.group(1);
            uniqueWords.add(foundWord.toLowerCase());
        }
        uniqueWords.stream().forEach(element-> System.out.print(element + " "));
    }
}
