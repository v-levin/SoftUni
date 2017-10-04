import java.util.Scanner;

public class IntersectionOfCircles {
    private static class Circle {
        private Point center;
        private int radius;

        private Circle(Point center, int radius) {
            this.center = center;
            this.radius = radius;
        }
    }

    private static class Point {
        private int x;
        private int y;

        private Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Circle firstCircle = getCircle(scanner);
        Circle secondCircle = getCircle(scanner);
        double distance = getDistance(firstCircle.center, secondCircle.center);
        if (distance <= firstCircle.radius + secondCircle.radius) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }

    private static double getDistance(Point center1, Point center2) {
        double distance = Math.sqrt(Math.pow(center2.x - center1.x, 2) + Math.pow(center2.y - center1.y, 2));
        return distance;
    }

    private static Circle getCircle(Scanner scanner) {
        String[] inputParams = scanner.nextLine().split("\\s+");
        int x = Integer.parseInt(inputParams[0]);
        int y = Integer.parseInt(inputParams[1]);
        int r = Integer.parseInt(inputParams[2]);

        Point point = new Point(x, y);
        Circle circle = new Circle(point, r);

        return circle;
    }
}
