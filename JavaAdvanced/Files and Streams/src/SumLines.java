import java.io.*;

public class SumLines {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferReader =
                new BufferedReader(
                        new FileReader("resources/Casual Text File.txt"));

        String line = bufferReader.readLine();
        while (line != null){
            System.out.println(sumOfASCIISymbols(line));
            line = bufferReader.readLine();
        }
        bufferReader.close();
    }

    private static int sumOfASCIISymbols(String line) {
        int sum = line.chars().sum();
        return sum;
    }
}
