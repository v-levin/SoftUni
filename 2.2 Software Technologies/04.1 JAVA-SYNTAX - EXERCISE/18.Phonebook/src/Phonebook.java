import java.util.LinkedHashMap;
import java.util.Scanner;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String inputLine = scanner.nextLine();

        LinkedHashMap<String, String> phoneBook = new LinkedHashMap<>();

        while (!inputLine.equals("END")) {

            String[] inputParams = inputLine.split("\\s+");
            String command = inputParams[0];

            switch (command) {
                case "A":
                    String name = inputParams[1];
                    String phoneNumber = inputParams[2];
                    phoneBook.put(name, phoneNumber);
                    break;
                case "S":
                    name = inputParams[1];
                    if (!phoneBook.containsKey(name)) {
                        System.out.printf("Contact %s does not exist.\n", name);
                    } else {
                        System.out.printf("%s -> %s\n", name, phoneBook.get(name));
                    }
                    break;
            }

            inputLine = scanner.nextLine();
        }
    }
}
