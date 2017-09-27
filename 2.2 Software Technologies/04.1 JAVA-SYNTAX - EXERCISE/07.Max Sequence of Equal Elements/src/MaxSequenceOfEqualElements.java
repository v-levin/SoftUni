import java.util.Scanner;

public class MaxSequenceOfEqualElements {
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

        for (int i = 1; i < intArr.length; i++) {
            if (intArr[i] == intArr[i - 1]) {
                counter++;
                if (bestLen < counter) {
                    number = intArr[i];
                    bestLen = counter;
                }
            } else {
                if (bestLen < counter) {
                    number = intArr[i - 1];
                    bestLen = counter;
                }
                counter = 1;
            }
        }

        for (int i = 0; i < bestLen; i++) {
            System.out.print(number + " ");
        }
    }
}
