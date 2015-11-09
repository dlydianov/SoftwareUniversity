import java.util.*;

public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<List<Integer>> increasingSequences = new ArrayList<>();
        List<Integer> numbers = new ArrayList<>();
        fillingTheNumbers(numbers, scanner);
        findingTheIncreasingSequences(numbers, increasingSequences);
        List<Integer> longestSequence = findingLongestSequence(increasingSequences);
        output(increasingSequences, longestSequence);
    }

    private static List<Integer> findingLongestSequence(List<List<Integer>> increasingSequences) {
        // I am taking the longest sequence only if there is more than one increasing sequence. Even if there is more than one element it can throw an exception if there is more than one equal value. So if this exception is thrown I am returning the leftmost sequence.
        List<Integer> longestSequence;
        if(increasingSequences.size()> 1){
            try {
                    longestSequence = increasingSequences.stream()
                        .filter(list -> list.size() > increasingSequences.stream().findAny().get().size())
                        .findFirst()
                        .get();
                return longestSequence;
           } catch (NoSuchElementException ex) {
                return increasingSequences.stream()
                        .findFirst()
                        .get();
            }
        }
        return increasingSequences.stream()
                .findFirst()
                .get();
    }

    private static void output(List<List<Integer>> increasingSequences, List<Integer> longestSequence){
        for (List<Integer> increasingSequence : increasingSequences){
            // printing each number from the list
            increasingSequence.forEach(number-> System.out.print(number + " "));
            System.out.println();
        }
        System.out.print("Longest: ");
        longestSequence.forEach(number-> System.out.print(number + " "));
    }

    private static void findingTheIncreasingSequences(List<Integer> numbers, List<List<Integer>> increasingSequences) {
        for (int i = 0; i < numbers.size(); i++) {
            if(i > 0 && numbers.get(i) > numbers.get(i - 1)){
                // If the current number is bigger than the last number I am putting it in the last created list else I am creating a new list.
                increasingSequences.get(increasingSequences.size() - 1).add(numbers.get(i));
            } else {
                increasingSequences.add(new LinkedList<>(Arrays.asList(numbers.get(i))));
            }
        }
    }

    private static void fillingTheNumbers(List<Integer> numbers, Scanner scanner) {
        String[] input = scanner.nextLine().split(" ");
        for (int i = 0; i < input.length; i++) {
            numbers.add(Integer.parseInt(input[i]));
        }
    }
}
