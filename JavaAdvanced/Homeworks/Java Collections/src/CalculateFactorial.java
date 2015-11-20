import java.util.Scanner;

public class CalculateFactorial {
    public static void main(String[] args) {
        Integer number = Integer.parseInt(new Scanner(System.in).nextLine());
        long factorialSum = factorial(number);
        System.out.print(factorialSum);
    }

    private static long factorial(Integer number) {
            if(number == 0){
                return  1;
            } else {
                return number * factorial(number - 1);
            }
    }
}
