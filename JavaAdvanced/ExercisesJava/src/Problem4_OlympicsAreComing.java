import sun.awt.image.ImageWatched;
import sun.util.resources.cldr.zh.CalendarData_zh_Hans_HK;

import java.util.*;

/**
 * Created by Frost on 9.11.2015 ã..
 */
public class Problem4_OlympicsAreComing {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        LinkedHashMap<String, LinkedHashMap<String, Integer>> map = new LinkedHashMap<>();
        LinkedHashMap<String, Integer> win = new LinkedHashMap<>();

        String input = scr.nextLine();
        while (!input.equals("report")){
            String[] arg = input.split("\\|");
            String athlete = arg[0].replaceAll("\\s+", " ").trim();
            String country = arg[1].replaceAll("\\s+", " ").trim();

            if (!map.containsKey(country)){
                map.put(country, new LinkedHashMap<>());
            }
            if (!map.get(country).containsKey(athlete)){
                map.get(country).put(athlete, 0);
            }
            int wins = map.get(country).get(athlete) + 1;
            map.get(country).put(athlete, wins);

            input = scr.nextLine();
        }

        map.entrySet().stream().forEach(entry -> win.put(entry.getKey(), countryWins(entry.getValue().entrySet())));

        win.entrySet()
                .stream()
                .sorted((a,b) -> b.getValue().compareTo(a.getValue()))
                .forEach(entry ->
                        System.out.printf("%s (%d participants): %d wins\n",
                                entry.getKey(),
                                map.get(entry.getKey()).size(),
                                win.get(entry.getKey())));
    }
    private static Integer countryWins(Set<Map.Entry<String, Integer>> entrySet){
        int sum = 0;
        for (Map.Entry<String, Integer> stringIntegerEntry : entrySet){
            sum += stringIntegerEntry.getValue();
        }
        return sum;
    }
}
