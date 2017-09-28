import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] seqNums = scanner.nextLine().split("\\s+");
        String[] bombAndPower = scanner.nextLine().split("\\s+");

        List<Integer> integers = new LinkedList<>();
        int bomb = Integer.parseInt(bombAndPower[0]);
        int power = Integer.parseInt(bombAndPower[1]);

        for (int i = 0; i < seqNums.length; i++) {
            integers.add(Integer.parseInt(seqNums[i]));
        }

        for (int i = 0; i < integers.size(); i++) {
            if (integers.get(i) == bomb) {
                int start = Math.max(i - power, 0);
                int end = Math.min(i + power, integers.size() - 1) + 1;

                integers.subList(start, end).clear();
                i = 0;
            }
        }

        int sum = integers.stream().mapToInt(Integer::intValue).sum();
        System.out.println(sum);
    }
}
