import java.util.Scanner;

public class ConvertFromDecimalToBase7 {
    public static void main(String[] args) {
        System.out.println("Enter the number you want to convert to 7 base: ");
        Scanner scanner = new Scanner(System.in);
        Integer numberToConvert = scanner.nextInt();
        System.out.print(Integer.toString(numberToConvert, 7));
    }
}
