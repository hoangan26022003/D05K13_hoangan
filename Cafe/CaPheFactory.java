package design_pattern.Cafe;

public class CaPheFactory {
    public static CaPhe taoCaPhe(int loai) {
        if (loai == 1) {
            return new Espresso();
        } else if (loai == 2) {
            return new DenDa();
        } else if (loai == 3) {
            return new NauDa();
        } else if (loai == 4) {
            return new Latte();
        } else if (loai == 5) {
            return new BacXiu();
        } else {
            return null;
        }
    }
}
