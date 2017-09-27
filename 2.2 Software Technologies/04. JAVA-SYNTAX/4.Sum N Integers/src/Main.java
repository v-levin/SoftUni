import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        long sum = 0L;

        while (n > 0) {
            sum += Integer.parseInt(scanner.nextLine());
            n--;
        }

        System.out.printf("Sum = %d", sum);
    }
}
