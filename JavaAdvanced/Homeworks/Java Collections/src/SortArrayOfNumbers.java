import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;

public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Integer numberOfIntegers = Integer.parseInt(scanner.nextLine());
        Integer[] array = new Integer[numberOfIntegers];
        fillingTheArray(array, scanner);
        sorting(array);
        // printing back to the console
        Arrays.stream(array)
                .forEachOrdered(number -> System.out.print(number + " "));

    }

    private static void sorting(Integer[] array) {
        // comparing method for integer
        Arrays.asList(array).sort((o1, o2) -> o1.compareTo(o2));
    }

    private static void fillingTheArray(Integer[] array, Scanner scanner) {
        for (int i = 0; i < array.length; i++) {
            array[i] = scanner.nextInt();
        }
    }
}
