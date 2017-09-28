import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] lettersArr = scanner.nextLine().toLowerCase().split("");

        int[] letterPosition = new int[lettersArr.length];

        for (int i = 0; i < letterPosition.length; i++) {
            char currentChar = lettersArr[i].charAt(0);
            letterPosition[i] = (int)currentChar - 'a';
        }

        for (int i = 0; i < letterPosition.length; i++) {
            System.out.printf("%s -> %d\n", lettersArr[i], letterPosition[i]);
        }

    }
}
