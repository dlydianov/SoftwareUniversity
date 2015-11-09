import java.util.*;

public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        // filling the List of strings on one line using functional programming. I am filling it with a LinkedList because Arrays.asList is creating a fixed sized List and when I want to remove an element later it throws an exception.
        List<String> strings = new LinkedList<>(Arrays.asList(scanner.nextLine().split(" ")));
        findingLongestSequence(strings);
    }

    private static void findingLongestSequence(List<String> strings) {
        String stringWithMostOccurrences = " ";
        int longestCount = 0;
        // I am taking the count of every word in the list and if is bigger than the currentBiggest count I save its count and value in variables to print it later, after that I remove the word from the list until no elements are left.
        while (strings.size() > 0){
            String word = strings.get(0);
            long countOccurrences = strings.stream()
                    .filter(s-> s.equals(word))
                    .count();
            if(countOccurrences > longestCount){
                longestCount = ((int) countOccurrences);
                stringWithMostOccurrences = word;
            }
            strings.removeAll(Collections.singleton(word));
        }
        output(stringWithMostOccurrences, longestCount);
    }

    private static void output(String stringWithMostOccurrences, int longestCount) {
        for (int i = 0; i <longestCount ; i++) {
            System.out.print(stringWithMostOccurrences + " ");
        }
    }
}
