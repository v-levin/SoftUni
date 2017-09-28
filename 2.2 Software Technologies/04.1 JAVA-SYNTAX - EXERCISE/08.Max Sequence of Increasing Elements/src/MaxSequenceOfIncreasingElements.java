import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] strArr = scanner.nextLine().split("\\s+");
        int[] intArr = new int[strArr.length];

        for (int i = 0; i < strArr.length; i++) {
            intArr[i] = Integer.parseInt(strArr[i]);
        }

        int counter = 1;
        int bestLen = 0;
        int startNumPos = 0;
        int longestSeqStart = 0;

        for (int i = 1; i < intArr.length; i++) {
            if (intArr[i] > intArr[i - 1]) {
                counter++;
                if (bestLen < counter) {
                    bestLen = counter;
                    longestSeqStart = startNumPos;
                }
            } else {
                startNumPos = i;
                counter = 1;
            }
        }

        for (int i = longestSeqStart; i < longestSeqStart + bestLen; i++) {
            System.out.print(intArr[i] + " ");
        }
    }
}
