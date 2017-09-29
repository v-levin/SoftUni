import java.util.Scanner;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();

        String upcaseOpenTag = "<upcase>";
        String upcaseCloseTag = "</upcase>";

        while (text.contains(upcaseOpenTag) && text.contains(upcaseCloseTag)) {

            int upcaseTagIndex = text.indexOf(upcaseOpenTag);
            int upcaseCloseIndex = text.indexOf(upcaseCloseTag);

            String textToModify = text.substring(upcaseTagIndex + upcaseOpenTag.length(), upcaseCloseIndex);

            text = text.replaceFirst(textToModify, textToModify.toUpperCase());
            text = text.replaceFirst(upcaseOpenTag, "");
            text = text.replaceFirst(upcaseCloseTag, "");
        }

        System.out.println(text);
    }
}
