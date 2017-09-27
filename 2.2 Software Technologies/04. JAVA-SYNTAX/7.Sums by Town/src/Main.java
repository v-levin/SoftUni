import java.util.Scanner;
import java.util.TreeMap;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, Double> townsIncome = new TreeMap<>();

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String[] tokens = scanner.nextLine().split("\\|");
            String town = tokens[0].trim();
            double income = Double.parseDouble(tokens[1].trim());

            if (townsIncome.containsKey(town)) {
                townsIncome.put(town, townsIncome.get(town) + income);
            } else {
                townsIncome.put(town, income);
            }
        }

        for (String key : townsIncome.keySet()) {
            System.out.println(key + " -> " + townsIncome.get(key));
        }
    }
}
