import java.util.Scanner;

public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toLowerCase();
        String stringToMatch = scanner.nextLine().toLowerCase();

        int occurrences = 0;
        int searchIndex = 0;
        int findIndex;
        // with pattern matcher you cannot find aa in aaaaaa 5 times becuse it cannot match one element in 2 matches.
        while ((findIndex = text.indexOf(stringToMatch, searchIndex)) >= 0) {
            occurrences++;
            searchIndex = findIndex + 1;
        }
        System.out.println(occurrences);
    }
}