import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String email = scanner.nextLine();
        String[] emailParams = email.split("@");
        String username = emailParams[0];
        String domain = emailParams[1];

        StringBuilder aserisks = new StringBuilder();

        for (int i = 0; i < username.length(); i++) {
            aserisks.append("*");
        }

        StringBuilder text = new StringBuilder(scanner.nextLine());

        while (text.toString().contains(email)) {
            int start = text.indexOf(email);
            int end = start + email.length();
            String replacement = aserisks.toString() + "@" + domain;
            text.replace(start, end, replacement);
        }

        System.out.println(text);
    }
}
