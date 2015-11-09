import com.sun.org.apache.xpath.internal.operations.Bool;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.TreeSet;

public class Biggest3PrimeNumbers {

    public static void main(String[] args) {

        //read the input line from the console
        Scanner str = new Scanner(System.in);
        String input = str.nextLine();

        //split the input into string array
        String[] stringArray = input.split("[( )]+");

        //parse and add numbers to TreeSet for automatic sorting in reverse order
        TreeSet<Integer> numberSet = new TreeSet<>(Collections.reverseOrder());
        for (int i = 0; i < stringArray.length; i++) {
            if (!stringArray[i].equals("")) {
                int number = Integer.parseInt(stringArray[i]);
                numberSet.add(number);
            }
        }

        int primeSum = 0;
        int count = 0;

        for (Integer possiblePrime : numberSet) {

            if (possiblePrime <= 1 || count == 3){
                break;
            }

            boolean isPrime = true;
            for (int i = 2; i < possiblePrime; i++) {
                if (possiblePrime % i == 0){
                    isPrime = false;
                }
            }

            if (isPrime){
                primeSum += possiblePrime;
                count++;
            }
        }
        if (count == 3){
            System.out.println(primeSum);
        }
        else {
            System.out.println("No");
        }

    }
}
