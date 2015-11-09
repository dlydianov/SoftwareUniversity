import java.util.*;

/**
 * Created by Frost on 8.11.2015 ã..
 */
public class ActivityTracker {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        int n = Integer.parseInt(scr.nextLine());

        TreeMap<Integer, TreeMap<String, Integer>> months = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] input = scr.nextLine().split(" ");
            String[] date = input[0].split("/");

            int month = Integer.parseInt(date[1]);
            String user = input[1];
            int distance = Integer.parseInt(input[2]);

            if (!months.containsKey(month)){
                TreeMap<String, Integer> users = new TreeMap<>();
                users.put(user, distance);
                months.put(month, users);
            }
            else {
                TreeMap<String, Integer> users = months.get(month);
                if (!users.containsKey(user)) {
                    users.put(user, distance);
                }
                else {
                    int tempDistance = users.get(user);
                    tempDistance += distance;
                    users.put(user, tempDistance);
                }
                months.put(month, users);
            }

        }
        for (Iterator it = months.entrySet().iterator(); it.hasNext();) {
            Map.Entry month = (Map.Entry) it.next();

            String outputLine = month.getKey() + ": ";

            TreeMap users = (TreeMap) month.getValue();
            for (Iterator it2 = users.entrySet().iterator(); it2.hasNext();) {
                Map.Entry user = (Map.Entry) it2.next();

                outputLine += user.getKey() + "(" + user.getValue() + "), ";
            }

            outputLine = outputLine.substring(0, outputLine.length() - 2);
            System.out.println(outputLine);
        }


    }
}
