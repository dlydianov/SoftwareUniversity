import java.util.Scanner;

public class CombineListOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String firstString = scanner.nextLine();
        String secondString = scanner.nextLine();
        StringBuilder combinedString = new StringBuilder();
        combinedString.append(firstString);
        for (int i = 0; i < secondString.length(); i++) {
            char currentElement = secondString.charAt(i);
            if(firstString.chars().noneMatch(ch-> ch == currentElement)){
                combinedString.append(" " + currentElement);
            }
        }
        System.out.print(combinedString.toString());
    }
}
