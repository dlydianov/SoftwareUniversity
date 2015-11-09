import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Matcher matcher = Pattern.compile("([a-zA-Z]+)").matcher(scanner.nextLine());
        List<String> words = new ArrayList<>();
        takingAllTheWords(matcher, words);
        findingTheMostUsedWord(words);
    }

    private static void findingTheMostUsedWord(List<String> words) {
        HashMap<String, Long> wordsAndCountOfOccurrences = new HashMap<>();
        takingTheWordsWithTheirCount(wordsAndCountOfOccurrences, words);
        filteringTheMostUsedWords(wordsAndCountOfOccurrences);

    }

    private static void takingTheWordsWithTheirCount(HashMap<String, Long> wordsAndCountOfOccurrences, List<String> words) {
        long mostOccurrences = 0;
        String mostUsedWord;
        String currentWord;
        long countOfWordOccurrences;
        for (int i = 0; i < words.size(); i++) {
            currentWord = words.get(i);
            countOfWordOccurrences = countingTheWordOccurences(words, currentWord);
            if(countOfWordOccurrences >= mostOccurrences){
                mostOccurrences = countOfWordOccurrences;
                mostUsedWord = currentWord;
                wordsAndCountOfOccurrences.put(mostUsedWord, mostOccurrences);
            }
        }
    }

    private static long countingTheWordOccurences(List<String> words, String currentWord) {
        int count = 0;
        for (int i = 0; i < words.size(); i++) {
            if(words.get(i).equals(currentWord)){
                count++;
            }
        }
        return count;
    }

    private static void filteringTheMostUsedWords(HashMap<String, Long> wordsAndCountOfOccurrences) {
       long mostOccurences = wordsAndCountOfOccurrences.values().stream().sorted(Comparator.reverseOrder()).findFirst().get();
        TreeMap<String, Long> wordsWithMostOccurrences = new TreeMap<>();
        for (String word : wordsAndCountOfOccurrences.keySet()) {
            if(wordsAndCountOfOccurrences.get(word) == mostOccurences){
                wordsWithMostOccurrences.put(word, mostOccurences);
            }
        }
        output(wordsWithMostOccurrences);
    }

    private static void output(TreeMap<String, Long> wordsWithMostOccurrences) {
        for (String word : wordsWithMostOccurrences.keySet()){
            System.out.printf("%s -> %d times", word, wordsWithMostOccurrences.get(word));
            System.out.println();
        }
    }

    private static void takingAllTheWords(Matcher matcher, List<String> words) {
        String word;
        while (matcher.find()){
            word = matcher.group(1).toLowerCase();
            words.add(word);
        }
    }
}
