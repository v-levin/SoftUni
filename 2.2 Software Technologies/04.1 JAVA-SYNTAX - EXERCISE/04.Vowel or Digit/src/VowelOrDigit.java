import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        if (isDigit(input)) {
            System.out.println("digit");
        } else if (isVowel(input)) {
            System.out.println("vowel");
        } else {
            System.out.println("other");
        }
    }

    private static boolean isVowel(String input) {
        switch (input) {
            case "A":
                return true;
            case "a":
                return true;
            case "E":
                return true;
            case "e":
                return true;
            case "I":
                return true;
            case "i":
                return true;
            case "O":
                return true;
            case "o":
                return true;
            case "U":
                return true;
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
