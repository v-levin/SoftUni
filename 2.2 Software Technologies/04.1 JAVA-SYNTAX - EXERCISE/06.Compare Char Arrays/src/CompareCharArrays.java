import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] strArr1 = scanner.nextLine().split("\\s+");
        String[] strArr2 = scanner.nextLine().split("\\s+");

        int counter = Math.min(strArr1.length, strArr2.length);
        Boolean areEqual = true;

        for (int i = 0; i < counter; i++) {
            Character currChr1 = strArr1[i].charAt(0);
            Character currChr2 = strArr2[i].charAt(0);
            if (currChr1 < currChr2) {
                printResult(strArr1, strArr2);
                areEqual = false;
                break;
            } else if (currChr2 < currChr1) {
                printResult(strArr2, strArr1);
                areEqual = false;
                break;
            }
        }

        if (areEqual) {
            if (strArr1.length < strArr2.length) {
                printResult(strArr1, strArr2);
            } else {
                printResult(strArr2, strArr1);
            }
        }
    }

    private static void printResult(String[] strArr1, String[] strArr2) {
        System.out.println(strArr1.toString().join("", strArr1));
        System.out.println(strArr2.toString().join("", strArr2));
    }
}
