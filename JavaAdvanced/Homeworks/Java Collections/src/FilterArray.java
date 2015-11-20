import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class FilterArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<String> text = Arrays.asList(scanner.nextLine().split(" "));
        StringBuilder elementsLongerThanThree = new StringBuilder();
            text
                    .stream()
                    .filter(strings -> strings.length() > 3)
                    .forEach(element -> elementsLongerThanThree.append(element + " "));
            System.out.print(elementsLongerThanThree.length()>0 ? elementsLongerThanThree.toString():"(empty)");

    }
}
