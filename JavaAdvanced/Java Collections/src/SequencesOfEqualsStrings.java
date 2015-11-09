import java.util.*;

public class SequencesOfEqualsStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        // filling the List of strings on one line using functional programming. I am filling it with a LinkedList because Arrays.asList is creating a fixed sized List and when I want to remove an element later it throws an exception.
        List<String> strings = new LinkedList<>(Arrays.asList(scanner.nextLine().split(" ")));
        output(strings);
    }
    private static void output(List<String> strings) {

        while (strings.size() > 0){
            String word = strings.get(0);
            strings.stream()
                    .filter(s-> s.equals(word))
                    .forEach(s-> System.out.print(s + " "));
            System.out.println();
            strings.removeAll(Collections.singleton(word));
        }
    }
}
