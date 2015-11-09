import java.io.*;

public class CountOfCharacterTypes {
    public static void main(String[] args) throws IOException {
        try(
        BufferedReader bufferedReader =
                new BufferedReader(
                        new FileReader("resources/Casual Text File.txt"));
        BufferedWriter bufferedWriter =
                new BufferedWriter(
                        new FileWriter("resources/count-chars.txt"))
        ){
            String line;
            int countOfVowelsInTheText = 0;
            int countOfPunctuationMarksInTheText = 0;
            int countOfConsonantsInTheText = 0;
            while (!((line=bufferedReader.readLine()) == null)){
                countOfVowelsInTheText += countingTheVowelsInTheLine(line);
                countOfConsonantsInTheText += countingTheConsonantsInTheLine(line);
                countOfPunctuationMarksInTheText = countingThePunctuationMarksInTheLine(line);
            }
            bufferedWriter.write(
                    "Vowels: " + countOfVowelsInTheText +
                            "Consonants: " + countOfConsonantsInTheText +
                            "Punctuation: " + countOfPunctuationMarksInTheText
            );
        }

    }

    private static int countingThePunctuationMarksInTheLine(String line) {
        return ((int) line.chars().filter(ch -> ch == '!' || ch == ',' || ch == '?' || ch == '.' || ch == ';').count());
    }

    private static long countingTheConsonantsInTheLine(String line) {
        return line.chars().filter(ch -> !(ch == 'a' || ch == 'e' || ch=='i' || ch=='o' || ch=='u'|| ch == ' ')).count();
    }

    private static long countingTheVowelsInTheLine(String line) {
        return line.chars().filter(ch -> ch=='a' ||  ch=='e' || ch=='i' || ch=='o' || ch=='u').count();
    }
}
