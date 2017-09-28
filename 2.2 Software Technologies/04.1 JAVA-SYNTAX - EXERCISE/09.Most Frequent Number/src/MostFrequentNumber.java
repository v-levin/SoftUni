import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] strArr = scanner.nextLine().split("\\s+");

        int[] intArr = new int[strArr.length];

        for (int i = 0; i < strArr.length; i++) {
            intArr[i] = Integer.parseInt(strArr[i]);
        }

        int counter = 1;
        int number = 0;
        int bestLen = 0;

        for (int i = 0; i < intArr.length; i++) {
            for (int j = i + 1; j < intArr.length; j++) {
                if (intArr[i] == intArr[j]) {
                    counter++;
                }
            }
            if (bestLen < counter) {
                number = intArr[i];
                bestLen = counter;
            }
            counter = 1;
        }

        System.out.println(number);
    }
}
