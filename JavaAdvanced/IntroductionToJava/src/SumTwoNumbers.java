import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        System.out.println("Enter the first number: ");
        Integer firstNumber = reader.nextInt();
        System.out.println("Enter the second5 number: ");
        Integer secondNumber = reader.nextInt();
        Integer sum = firstNumber + secondNumber;
        System.out.println("The sum is: ");
        System.out.println(sum);
    }
}
