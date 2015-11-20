import java.util.*;

public class ImplementRecursiveBinarySearch {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Integer integerToSearchFor = Integer.parseInt(scanner.nextLine());
        List<String> input = Arrays.asList(scanner.nextLine().split(" "));
        List<Integer> numbers = new LinkedList<>();
        input.forEach(number-> numbers.add(Integer.parseInt(number)));
        numbers.sort(Comparator.naturalOrder());
        Integer index = binarySearch(integerToSearchFor, numbers);
        System.out.print(index);
    }

    private static Integer binarySearch(Integer integerToSearchFor, List<Integer> numbers) {
        Integer middleNumber = numbers.get(numbers.size() / 2);
        if(middleNumber > integerToSearchFor){
            for (int i = middleNumber; i >= 0; i--) {
                if(numbers.get(i).equals(integerToSearchFor)){
                    return i;
                }
            }
        } else {
            for (int i = middleNumber; i < numbers.size(); i++) {
                if(numbers.get(i).equals(integerToSearchFor)){
                    return i;
                }
            }
        }
        return -1;
    }
}
