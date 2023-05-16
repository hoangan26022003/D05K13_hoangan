package design_pattern.Cafe;

import java.util.Scanner;

public class Client {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        CaPheFactory capheFactory = new CaPheFactory();

        while (true) {
            System.out.println("\n--- MÁY PHA CÀ PHÊ ---");
            System.out.println("1. Espresso");
            System.out.println("2. Đen đá");
            System.out.println("3. Nâu đá");
            System.out.println("4. Latte");
            System.out.println("5. Bạc xỉu");
            System.out.println("0. Thoát");
            System.out.print("Chọn loại cafe: ");
            int choice = scanner.nextInt();

            if (choice == 0) {
                break;
            }

            CaPhe caphe = capheFactory.taoCaPhe(choice);

            if (caphe != null) {
                caphe.taoCaPhe();
            } else {
                System.out.println("Không hỗ trợ loại cafe này!");
            }
        }
    }
}