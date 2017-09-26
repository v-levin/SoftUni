import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split("\\s+");

        int[] numbers = new int[input.length];

        for (int i = 0; i < input.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }

        int num1 = numbers[0];
        int num2 = numbers[1];
        int num3 = numbers[2];

        if (!checkNumbers(num1, num2, num3) && !checkNumbers(num1, num3, num2) && !checkNumbers(num2, num3, num1)) {
            System.out.println("No");
        }
    }

    private static boolean checkNumbers(int num1, int num2, int num3) {

        if (num1 + num2 != num3) {
            return false;
        }

        int small = Math.min(num1, num2);
        int big = Math.max(num1, num2);

        System.out.printf("%d + %d = %d", small, big, num3);

        return true;
    }
}