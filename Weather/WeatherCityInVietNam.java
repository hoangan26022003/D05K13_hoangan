package Weather;
import java.util.Random;
public class WeatherCityInVietNam implements Weather {
    public String getWeather(String city) {
        if (!isVietnameseCity(city)) {
            return "Không hỗ trợ nước ngoài";
        }

        Random random = new Random();
        int temperature = random.nextInt(11) + 30;
        int humidity = random.nextInt(41) + 40;

        return "Temperature: " + temperature + "*C, Humidity: " + humidity + "%";
    }

    private boolean isVietnameseCity(String city) {
        // Code để kiểm tra thành phố Việt Nam
        return true;
    }
}
