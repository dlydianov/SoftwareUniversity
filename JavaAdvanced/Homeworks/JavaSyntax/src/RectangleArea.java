import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        System.out.println("Enter the sides of the rectangle: ");
        Scanner reader = new Scanner(System.in);
        Integer height = reader.nextInt();
        Integer width = reader.nextInt();
        Integer rectangleArea = height * width;
        System.out.print("The area of rectangle is: ");
        System.out.print(rectangleArea);
    }
}
