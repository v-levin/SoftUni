import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        if (isDigit(input)) {
            System.out.println("digit");
        } else if (isVowel(input.toLowerCase())) {
            System.out.println("vowel");
        } else {
            System.out.println("other");
        }
    }

    private static boolean isVowel(String input) {
        switch (input) {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                return true;
            default:
                return false;
        }
    }

    private static boolean isDigit(String input) {
        try {
            Integer.parseInt(input);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }
}
