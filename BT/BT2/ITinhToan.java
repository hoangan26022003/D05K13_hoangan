package day8.BT.BT2;

public interface ITinhToan<T> {
    T cong(T t1, T t2);
    T tru(T t1, T t2);

    T nhan(T t1, T t2);

    T chia(T t1, T t2);
}
