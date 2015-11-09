import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class CreateZipArchive {
    public static void main(String[] args) throws IOException {

        try(FileOutputStream fileOutput = new FileOutputStream("resources/zippedFiles.zip");
        ZipOutputStream outputZipped = new ZipOutputStream(fileOutput)){

            String pathToFirstFile="resources/Casual Text File.txt";
            String pathToSecondFile = "resources/2ndFile.txt";
            String pathToThirdFile = "resources/count-chars.txt";

            addFileToZip(outputZipped, pathToFirstFile);
            addFileToZip(outputZipped, pathToSecondFile);
            addFileToZip(outputZipped, pathToThirdFile);
        }
    }
    private static void addFileToZip(ZipOutputStream outputZipped, String pathToFile) throws IOException {
        try(FileInputStream fileInput = new FileInputStream(pathToFile)){
            ZipEntry zipEntry = new ZipEntry(pathToFile);
            outputZipped.putNextEntry(zipEntry);
            byte[] buffer = new byte[4096];
            int byteReader;
            while ((byteReader = fileInput.read(buffer,0, buffer.length)) >= 0){
                outputZipped.write(byteReader);
            }

        }
    }
}
