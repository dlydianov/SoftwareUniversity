import java.awt.*;
import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        System.out.println("Enter three points to calculate the area: ");
        Scanner reader = new Scanner(System.in);
        Point pointA = new Point();
        pointA.setLocation(reader.nextInt(), reader.nextInt());
        Point pointB = new Point();
        pointB.setLocation(reader.nextInt(),reader.nextInt());
        Point pointC = new Point();
        pointC.setLocation(reader.nextInt(),reader.nextInt());

        Double area = calculatingArea(pointA, pointB, pointC);
        System.out.println(area);
    }

    private static Double calculatingArea(Point pointA, Point pointB, Point pointC) {
        Double area = (pointA.getX()*(pointB.getY() - pointC.getY()) + pointB.getX()*(pointC.getY()-pointA.getY()) + pointC.getX()*(pointA.getY() -pointB.getY())) / 2;
        if(area<0){
            return -area;
        }
        return  area;
    }
}
