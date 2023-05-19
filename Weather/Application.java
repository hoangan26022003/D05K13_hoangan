package Weather;

import java.util.Scanner;

public class Application {
    public static void main(String[] args) {
        Weather weather = new WeatherCityInVietNam();
        Scanner scanner = new Scanner(System.in);

        System.out.print("Nhập tên thành phố: ");
        String city = scanner.nextLine();

        String weatherInfo = weather.getWeather(city);
        System.out.println(weatherInfo);
    }
}
