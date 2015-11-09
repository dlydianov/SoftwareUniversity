import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Frost on 9.11.2015 ã..
 */
public class JavaRetake_Problem4_LegendaryFarming {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);
        String input = scr.nextLine();
        TreeMap<String, Integer> materials = new TreeMap<String, Integer>(){{
            put("fragments", 0);
            put("motes", 0);
            put("shards", 0);
        }};
        TreeMap<String, Integer> junks = new TreeMap<>();
        String firstWin = "";

        while (true){
            Pattern pattern = Pattern.compile("((\\d+)\\s+([a-zA-Z-_.]+))");
            Matcher match = pattern.matcher(input);

            while (match.find()){
                int quantity = Integer.parseInt(match.group(2).trim());
                String material = match.group(3).toLowerCase().trim();

                if (materials.containsKey(material)){
                    materials.put(material, materials.get(material) + quantity);
                    if (materials.get(material) >= 250){
                        firstWin = material;
                        materials.put(material, materials.get(material) - 250);
                        break;
                    }
                }
                else {
                    if (!junks.containsKey(material)){
                        junks.put(material, 0);
                    }
                    junks.put(material, junks.get(material) + quantity);
                }
            }
            if (firstWin.length() >0){
                break;
            }
            else {
                input = scr.nextLine();
            }
        }
        if (firstWin.equals("shards")){
            System.out.println("Shadowmourne obtained!");
        }
        else if (firstWin.equals("fragments")){
            System.out.println("Valanyr obtained!");
        }
        else if (firstWin.equals("motes")) {
            System.out.println("Dragonwrath obtained!");
        }

        materials.entrySet()
                .stream()
                .sorted((a, b) -> b.getValue().compareTo(a.getValue()))
                .forEach(entry ->
                        System.out.printf("%s: %d\n", entry.getKey(), entry.getValue()));
        junks.entrySet()
                .stream()
                .forEach(e ->
                        System.out.printf("%s: %d\n", e.getKey(), e.getValue()));
    }
}
