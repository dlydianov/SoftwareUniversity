import java.util.Locale;
import java.util.Scanner;

public class CalculateExpressions {
    public static void main(String[] args) {
        Float[] threeNumbers = new Float[3];
        enteringTheThreeNumbers(threeNumbers);
        float firstFormulaResult = calculatingByTheFirstFormula(threeNumbers);
        float secondFormulaResult = calculatingByTheSecondFormula(threeNumbers);
        float averageOfFormulasResults = (firstFormulaResult + secondFormulaResult) / 2;
        float averageOfNumbers= (threeNumbers[0] + threeNumbers[1] + threeNumbers[2]) / 3;
        float differenceBetweenAverage = Math.abs(averageOfNumbers - averageOfFormulasResults);
        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", firstFormulaResult, secondFormulaResult, differenceBetweenAverage);

    }

    private static float calculatingByTheSecondFormula(Float[] threeNumbers) {
        Float a = threeNumbers[0];
        Float b = threeNumbers[1];
        Float c = threeNumbers[2];
        return (float) Math.pow((a * a + b * b - c * c * c), (a - b));
    }

    private static float calculatingByTheFirstFormula(Float[] threeNumbers) {
        Float a = threeNumbers[0];
        Float b = threeNumbers[1];
        Float c = threeNumbers[2];
        return (float)Math.pow(((a * a + b*b) / (a * a - b*b)), ((a + b + c) / Math.sqrt(c)));
    }

    private static void enteringTheThreeNumbers(Float[] threeNumbers) {
        System.out.println("Enter three floating numbers: ");
        Scanner reader = new Scanner(System.in);
        reader.useLocale(Locale.ENGLISH);
        for (int i = 0; i < threeNumbers.length ; i++) {
            threeNumbers[i] = reader.nextFloat();
        }
    }
}
