import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class ReverseCharacters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        ArrayList<Character> chrList = new ArrayList<>();

        for (int i = 0; i < 3; i++) {
            String input = scanner.nextLine();
            chrList.add(input.charAt(0));
        }

        Collections.reverse(chrList);

        System.out.println(chrList.toString()
                .replace("[", "")
                .replace(",", "")
                .replace("]", "")
                .replace(" ", ""));
    }
}
