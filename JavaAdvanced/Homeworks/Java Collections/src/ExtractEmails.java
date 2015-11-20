import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractEmails {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Pattern pattern = Pattern.compile("[\\w.-]+@[A-Za-z]+.[.A-Za-z]{2,}");
        Matcher matcher = pattern.matcher(scanner.nextLine());
        List<String> emails = new LinkedList<>();
        while (matcher.find()){
            emails.add(matcher.group(0));
        }
        emails.stream().forEach(email-> System.out.println(email));
    }
}
