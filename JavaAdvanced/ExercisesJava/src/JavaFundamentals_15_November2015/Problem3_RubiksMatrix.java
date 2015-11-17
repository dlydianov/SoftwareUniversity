package JavaFundamentals_15_November2015;

import java.util.Scanner;

/**
 * Created by Frost on 15.11.2015 ã..
 */
public class Problem3_RubiksMatrix {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String input = scr.nextLine();
        String[] rowsAndCols = input.split(" ");
        int rows = Integer.parseInt(rowsAndCols[0]);
        int cols = Integer.parseInt(rowsAndCols[1]);
        input = scr.nextLine();
        int n = Integer.parseInt(input);
        input = scr.nextLine();
        int counter = 1;

        int[][] matrix = new int[rows][cols];
        int[][] resultMatrix = new int[rows][cols];
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                matrix[row][col] = counter;
                resultMatrix[row][col] = counter;
                counter++;
            }
        }


        for (int i = 0; i < n; i++) {
            String[] arr = input.split(" ");
            int rowORcol = Integer.parseInt(arr[0]);
            String direction = arr[1];
            int moves = Integer.parseInt(arr[2]);
            int mod = 0;

            switch (direction) {
                case "down":
                    for (int j = 0; j < rows; j++) {
                        int temp = 0;
                        if (j == 0){
                            temp = resultMatrix[j][rowORcol];
                            resultMatrix[j][rowORcol] = resultMatrix[j + 1][rowORcol];
                            resultMatrix[j + 1][rowORcol] = temp;
                        }else if (j > 0 && j < rows - 1){
                            temp = resultMatrix[j][rowORcol];
                            resultMatrix[j][rowORcol] = matrix[j + 1][rowORcol];
                            resultMatrix[j + 1][rowORcol] = temp;
                        }
                        else if (j == rows - 1){
                            temp = resultMatrix[j - 1][rowORcol];
                            resultMatrix[j - 1][rowORcol] = resultMatrix[rows - 1][rowORcol];
                            resultMatrix[j][rowORcol] = temp;
                        }
                    }
            }

            for (int j = 0; j < rows; j++) {
                for (int k = 0; k < cols; k++) {
                    System.out.print(resultMatrix[j][k]);
                }
                System.out.println();
            }
            if (i == n - 1) {
                break;
            } else {
                input = scr.nextLine();
            }
        }
    }
}
