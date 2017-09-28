import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] strArr = scanner.nextLine().split("\\s+");

        int[] intArr = new int[strArr.length];

        for (int i = 0; i < strArr.length; i++) {
            intArr[i] = Integer.parseInt(strArr[i]);
        }

        if (intArr.length == 1) {
            System.out.println(0);
            return;
        } else if (intArr.length == 2) {
            System.out.println("no");
            return;
        } else {
            for (int i = 0; i < intArr.length; i++) {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++) {
                    leftSum += intArr[j];
                }
                for (int j = i + 1; j < intArr.length; j++) {
                    rightSum += intArr[j];
                }
                if (leftSum == rightSum) {
                    System.out.println(i);
                    return;
                }
            }
        }

        System.out.println("no");
    }
}
