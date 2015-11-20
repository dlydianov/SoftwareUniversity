import java.util.HashSet;
import java.util.Scanner;

public class CardsFrequencies {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] cards = scanner.nextLine().split(" ");
        int countOfAllCards = cards.length;
        cardsFrequencies(cards, countOfAllCards);
    }

    private static void cardsFrequencies(String[] cards, int countOfAllCards) {
        HashSet<String> cardsPrinted = new HashSet<>();
        for (int i = 0; i < cards.length; i++) {
            if(cardsPrinted.contains(cards[i])){
                continue;
            }
            String typeOfCard = gettingTheTypeOfCard(cards[i]);
            double countOfCurrentCard = gettingTheAmountOfOccurrences(cards,typeOfCard);
            output(countOfCurrentCard, countOfAllCards, typeOfCard);
            cardsPrinted.add(cards[i]);
        }
    }

    private static int gettingTheAmountOfOccurrences(String[] cards, String typeOfCard) {
        int countOfCurrentCard = 0;
        for (int j = 0; j < cards.length; j++) {
            if(cards[j].contains(typeOfCard)){
                countOfCurrentCard++;
            }
        }
        return countOfCurrentCard;
    }

    private static String gettingTheTypeOfCard(String card) {
        if(card.length() > 2){
            return card.substring(0, 2);
        } else {
            return card.charAt(0) + "";
        }
    }

    private static void output(double countOfCurrentCard, int countOfAllCards, String typeOfCard) {
        double countAsPercentage = 100 /(countOfAllCards / countOfCurrentCard);
        System.out.printf("%s -> %.2f", typeOfCard, countAsPercentage);
        System.out.print("%");
        System.out.println();
    }
}
