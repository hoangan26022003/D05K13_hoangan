package Weather;

// Lớp Adapter để tra cứu thông tin thời tiết cho các thành phố nước ngoài thông qua dịch vụ OpenWeather
public class OpenWeatherAdapter implements Weather {
    private OpenWeather openWeather;

    public OpenWeatherAdapter() {
        this.openWeather = new OpenWeather();
    }

    public String getWeather(String city) {
        // Gọi dịch vụ OpenWeather để lấy thông tin thời tiết
        String weatherInfo = openWeather.getWeatherCity(city);

        // Phân tích thông tin thời tiết để lấy nhiệt độ và độ ẩm
        String temperature = parseTemperature(weatherInfo);
        String humidity = parseHumidity(weatherInfo);

        // Trả về thông tin thời tiết đã được định dạng
        return "Nhiệt độ: " + temperature + " *F, Độ ẩm: " + humidity + "%";
    }

    private String parseTemperature(String weatherInfo) {
        // Tìm vị trí bắt đầu và kết thúc của thông tin nhiệt độ trong chuỗi kết quả thời tiết
        int startIndex = weatherInfo.indexOf("Temp:") + 6;
        int endIndex = weatherInfo.indexOf("*F", startIndex);

        // Trích xuất và trả về thông tin nhiệt độ đã được định dạng
        return weatherInfo.substring(startIndex, endIndex).trim();
    }

    private String parseHumidity(String weatherInfo) {
        // Tìm vị trí bắt đầu và kết thúc của thông tin độ ẩm trong chuỗi kết quả thời tiết
        int startIndex = weatherInfo.indexOf("Hump:") + 6;
        int endIndex = weatherInfo.indexOf("%", startIndex);

        // Trích xuất và trả về thông tin độ ẩm đã được định dạng
        return weatherInfo.substring(startIndex, endIndex).trim();
    }
}

