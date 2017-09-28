import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String inputLine = scanner.nextLine();

        StringBuilder result = new StringBuilder(inputLine);

        if (inputLine.toCharArray().length < 20) {
            int asterisksCount = 20 - inputLine.toCharArray().length;
            for (int i = 0; i < asterisksCount; i++) {
                result.append("*");
            }
        } else {
            result.delete(20, result.length());
        }

        System.out.println(result);
    }
}
