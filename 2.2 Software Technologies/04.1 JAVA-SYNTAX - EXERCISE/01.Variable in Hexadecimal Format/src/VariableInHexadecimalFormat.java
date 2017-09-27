import java.util.Scanner;

public class VariableInHexadecimalFormat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int hexadecimal = 16;

        int result = Integer.parseInt(scanner.nextLine(), hexadecimal);

        System.out.println(result);
    }
}
