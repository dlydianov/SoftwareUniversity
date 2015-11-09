import java.util.Scanner;

/**
 * Created by Frost on 8.11.2015 ã..
 */
public class AddingAngles {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        int n = Integer.parseInt(scr.nextLine());
        int[] angles = new int[n];
        for (int i = 0; i < angles.length; i++) {
            angles[i] = scr.nextInt();
        }
        int count = 0;
        for (int i = 0; i < angles.length; i++) {
            for (int j = i + 1; j < angles.length; j++) {
                for (int k = j + 1; k < angles.length; k++) {
                    int a = angles[i];
                    int b = angles[j];
                    int c = angles[k];

                    int sum = a + b + c;
                    if (sum % 360 == 0) {
                        System.out.printf("%d + %d + %d = %d degrees\n", a, b, c, sum);
                        count++;
                    }
                }
            }
        }
        if (count == 0){
            System.out.println("No");
        }

    }
}
