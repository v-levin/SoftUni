import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;

public class CountWorkingDays {

    private static class Holiday {
        private int month;
        private int day;

        private Holiday(int month, int day) {
            this.month = month;
            this.day = day;
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        SimpleDateFormat df = new SimpleDateFormat("dd-MM-yyyy");
        Date startDate = null;
        Date endDate = null;
        try {
            startDate = df.parse(scanner.nextLine());
            endDate = df.parse(scanner.nextLine());
        } catch (ParseException e) {
            e.printStackTrace();
        }

        List<Holiday> holidays = getHolidays();
        Calendar calendar = Calendar.getInstance();
        calendar.setTime(startDate);
        int workingDaysCount = 0;
        while (!calendar.getTime().after(endDate)) {
            if (isWorkingDay(calendar.getTime(), holidays)) {
                workingDaysCount++;
            }
            calendar.add(Calendar.DAY_OF_MONTH, 1);
        }
        System.out.println(workingDaysCount);
    }

    private static boolean isWorkingDay(Date date, List<Holiday> holidays) {
        Calendar calendar = Calendar.getInstance();
        calendar.setTime(date);
        int dayOfWeek = calendar.get(Calendar.DAY_OF_WEEK);

        if (dayOfWeek == Calendar.SATURDAY || dayOfWeek == Calendar.SUNDAY) {
            return false;
        }

        for (Holiday holiday : holidays) {
            if (holiday.month == calendar.get(Calendar.MONTH) && holiday.day == calendar.get(Calendar.DAY_OF_MONTH)) {
                return false;
            }
        }

        return true;
    }

    private static List<Holiday> getHolidays() {
        List<Holiday> holidays = new ArrayList<>();
        holidays.add(new Holiday(Calendar.JANUARY, 1));
        holidays.add(new Holiday(Calendar.MARCH, 3));
        holidays.add(new Holiday(Calendar.MAY, 1));
        holidays.add(new Holiday(Calendar.MAY, 6));
        holidays.add(new Holiday(Calendar.MAY, 24));
        holidays.add(new Holiday(Calendar.SEPTEMBER, 6));
        holidays.add(new Holiday(Calendar.SEPTEMBER, 22));
        holidays.add(new Holiday(Calendar.NOVEMBER, 1));
        holidays.add(new Holiday(Calendar.DECEMBER, 24));
        holidays.add(new Holiday(Calendar.DECEMBER, 25));
        holidays.add(new Holiday(Calendar.DECEMBER, 26));
        return holidays;
    }
}
