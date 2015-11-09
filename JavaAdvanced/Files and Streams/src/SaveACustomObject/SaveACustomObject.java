package SaveACustomObject;
import com.google.common.base.Charsets;
import com.google.common.base.Joiner;
import java.io.*;
import java.util.Arrays;
import java.util.List;


public class SaveACustomObject {
    public static void main(String[] args) throws IOException, ClassNotFoundException {

        List<Student> students = Arrays.asList(
                new Student("Plamen", 22, Arrays.asList(4.5, 5.6,6.0)),
                new Student("Kremena", 20,Arrays.asList(3.5, 4.6,2.0)),
                new Student("Hristina", 25,Arrays.asList(5.2, 2.6,5.0)),
                new Student("Nikola", 23,Arrays.asList(3.8, 5.6,6.0)));
        try (
                ObjectOutputStream writer =
                        new ObjectOutputStream(
                                new BufferedOutputStream(
                                        new FileOutputStream("resources/students.list")))
        ) {
            writer.writeObject(Joiner.on("\n").join(students));
        }
        try (
                ObjectInputStream reader =
                        new ObjectInputStream(
                                new BufferedInputStream(
                                        new FileInputStream("resources/students.list")))
        ) {
            String fileRead = reader.readObject().toString();
            System.out.println(fileRead);
        }


    }
}
