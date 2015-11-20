import com.google.common.base.Joiner;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class RandomizeNumbers {
    public static void main(String[] args) {
        System.out.println("Enter two integers: ");
        Scanner scanner = new Scanner(System.in);
        Integer firstInteger = scanner.nextInt();
        Integer secondInteger = scanner.nextInt();
        Integer smallerNumber = Math.min(firstInteger, secondInteger);
        Integer biggerNumber = Math.max(firstInteger, secondInteger);
        List<Integer> randomizedNumbers = new ArrayList<>();
        randomizeNumbers(smallerNumber, biggerNumber,randomizedNumbers);
        System.out.println(Joiner.on(' ').join(randomizedNumbers));
    }

    private static void randomizeNumbers(Integer smallerNumber, Integer biggerNumber, List<Integer> randomizedNumbers) {
        Random randomGenerator = new Random();

        for (int i = 0; i <= biggerNumber - smallerNumber; i++) {
            Integer randomNumber = randomGenerator.nextInt(biggerNumber - smallerNumber + 1) + smallerNumber;
            while (randomizedNumbers.contains(randomNumber)) {
                randomNumber = randomGenerator.nextInt(biggerNumber - smallerNumber + 1) + smallerNumber;
            }
            randomizedNumbers.add(randomNumber);
        }
    }
}
