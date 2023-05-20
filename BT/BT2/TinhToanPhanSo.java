package day8.BT.BT2;
public class TinhToanPhanSo implements ITinhToan<PhanSo> {
    @Override
    public PhanSo cong(PhanSo t1, PhanSo t2) {
        return t1.cong(t2);
    }

    @Override
    public PhanSo tru(PhanSo t1, PhanSo t2) {
        return t1.tru(t2);
    }

    @Override
    public PhanSo nhan(PhanSo t1, PhanSo t2) {
        return t1.nhan(t2);
    }

    @Override
    public PhanSo chia(PhanSo t1, PhanSo t2) {
        return t1.chia(t2);
    }
}