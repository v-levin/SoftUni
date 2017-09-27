import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i <= n; i++) {
            if (isSymmetric(i)) {
                System.out.print(i + " ");
            }
        }
    }

    private static boolean isSymmetric(int number) {
        String strN = Integer.toString(number);
        int length = strN.length();

        for (int j = 0; j < length / 2; j++) {
            if (strN.charAt(j) != strN.charAt(length - j - 1)) {
                return false;
            }
        }

        return true;
    }
}
