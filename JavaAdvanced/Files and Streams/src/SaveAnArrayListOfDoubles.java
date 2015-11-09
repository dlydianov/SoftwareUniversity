import java.io.*;
import java.util.Arrays;
import java.util.List;

public class SaveAnArrayListOfDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {

        List<Double> doubles = Arrays.asList(4.5, 5.5, 1.5, 13.5);
        try (
            ObjectOutputStream writer =
                    new ObjectOutputStream(
                            new BufferedOutputStream(
                                    new FileOutputStream("resources/doubles.list")))
        ) {
            writer.writeObject(doubles);
        }
        try (
                ObjectInputStream reader =
                        new ObjectInputStream(
                                new BufferedInputStream(
                                        new FileInputStream("resources/doubles.list")))
                ) {
            String fileRead = reader.readObject().toString();
            System.out.println(fileRead);
        }


    }
}
