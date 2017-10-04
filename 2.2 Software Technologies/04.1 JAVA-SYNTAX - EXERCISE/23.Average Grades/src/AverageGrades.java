import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class AverageGrades {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int studentsCount = Integer.parseInt(scanner.nextLine());

        List<Student> students = new ArrayList<>();

        for (int i = 0; i < studentsCount; i++) {
            String[] tokens = scanner.nextLine().split(" ");

            String name = tokens[0];
            Double[] grades = Arrays.stream(tokens).skip(1).map(Double::parseDouble).toArray(Double[]::new);

            Student student = new Student() {{
                setName(name);
                setGrades(Arrays.asList(grades));
            }};

            students.add(student);
        }

        Student[] filtredStudents = students.stream()
                .filter(s -> s.getAverageGrade() >= 5.00)
                .sorted((a, b) -> {
                    int comparisonResult = a.getName().compareTo(b.getName());

                    if (comparisonResult == 0) {
                        comparisonResult = Double.compare(b.getAverageGrade(), a.getAverageGrade());
                    }

                    return comparisonResult;
                })
                .toArray(Student[]::new);

        for (Student student : filtredStudents) {
            System.out.printf("%s -> %.2f\n", student.getName(), student.getAverageGrade());
        }
    }
}
