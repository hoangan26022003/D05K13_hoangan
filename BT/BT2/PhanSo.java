package day8.BT.BT2;

public class PhanSo {
    private int tuSo;
    private int mauSo;

    public PhanSo(int tuSo, int mauSo) {
        this.tuSo = tuSo;
        this.mauSo = mauSo;
    }

    public int getTuSo() {
        return tuSo;
    }

    public void setTuSo(int tuSo) {
        this.tuSo = tuSo;
    }

    public int getMauSo() {
        return mauSo;
    }

    public void setMauSo(int mauSo) {
        if (mauSo == 0) {
            throw new IllegalArgumentException("Mẫu số không thể bằng 0");
        }
        this.mauSo = mauSo;
    }

    public PhanSo cong(PhanSo phanSo) {
        int tuSoTong = this.tuSo * phanSo.mauSo + phanSo.tuSo * this.mauSo;
        int mauSoTong = this.mauSo * phanSo.mauSo;
        return rutGonPhanSo(new PhanSo(tuSoTong, mauSoTong));
    }

    public PhanSo tru(PhanSo phanSo) {
        int tuSoHieu = this.tuSo * phanSo.mauSo - phanSo.tuSo * this.mauSo;
        int mauSoHieu = this.mauSo * phanSo.mauSo;
        return rutGonPhanSo(new PhanSo(tuSoHieu, mauSoHieu));
    }

    public PhanSo nhan(PhanSo phanSo) {
        int tuSoTich = this.tuSo * phanSo.tuSo;
        int mauSoTich = this.mauSo * phanSo.mauSo;
        return rutGonPhanSo(new PhanSo(tuSoTich, mauSoTich));
    }

    public PhanSo chia(PhanSo phanSo) {
        if (phanSo.tuSo == 0) {
            throw new ArithmeticException("Không thể chia cho 0");
        }
        int tuSoThuong = this.tuSo * phanSo.mauSo;
        int mauSoThuong = this.mauSo * phanSo.tuSo;
        return rutGonPhanSo(new PhanSo(tuSoThuong, mauSoThuong));
    }

    private int timUocChungLonNhat(int a, int b) {
        if (b == 0) {
            return a;
        }
        return timUocChungLonNhat(b, a % b);
    }

    private PhanSo rutGonPhanSo(PhanSo phanSo) {
        int ucln = timUocChungLonNhat(phanSo.tuSo, phanSo.mauSo);
        phanSo.tuSo /= ucln;
        phanSo.mauSo /= ucln;
        return phanSo;
    }

    @Override
    public String toString() {
        return tuSo + "/" + mauSo;
    }
}


