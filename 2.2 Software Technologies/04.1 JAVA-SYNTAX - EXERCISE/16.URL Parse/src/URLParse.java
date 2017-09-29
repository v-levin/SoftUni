import java.util.Scanner;

public class URLParse {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String inputLine = scanner.nextLine();
        String[] inputParams = inputLine.split("://");
        String protocol = "";
        String server = "";
        String resource = "";
        if (inputParams.length > 1) {
            protocol = inputParams[0];
            String[] serverResourceParams = inputParams[1].split("/", 2);
            if (serverResourceParams.length == 1) {
                server = serverResourceParams[0];
            } else {
                server = serverResourceParams[0];
                resource = serverResourceParams[1];
            }
        } else {
            String[] serverResourceParams = inputParams[0].split("/", 2);
            if (serverResourceParams.length == 1) {
                server = serverResourceParams[0];
            } else {
                server = serverResourceParams[0];
                resource = serverResourceParams[1];
            }
        }

        System.out.printf("[protocol] = \"%s\"\n[server] = \"%s\"\n[resource] = \"%s\"", protocol, server, resource);
    }
}
