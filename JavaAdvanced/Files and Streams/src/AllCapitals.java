import java.io.*;

public class AllCapitals {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader =
                new BufferedReader(
                        new FileReader("resources/Casual Text File.txt"));
        BufferedWriter bufferedWriter =
                new BufferedWriter(
                        new FileWriter("resources/Text File Overwritten.txt"));
        String line;
        while (!((line = bufferedReader.readLine()) == null)){
            bufferedWriter.write(line.toUpperCase());
            bufferedWriter.newLine();
        }

    }
}
