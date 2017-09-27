import java.util.Scanner;

public class IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int input = Integer.parseInt(scanner.nextLine());

        String hex = Integer.toHexString(input);
        String bin = Integer.toBinaryString(input);

        System.out.println(hex.toUpperCase());
        System.out.println(bin);
    }
}
