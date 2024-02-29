import Button from '~/component/Button';
import ItemCartProduct from './ItemCartProduct';
import classNames from 'classnames/bind';
import style from './Cart.module.scss';

const cx = classNames.bind(style);

export default function Cart() {
    return (
        <div className={cx('wrapp-cart')}>
            <div className={cx('container')}>
                <div className={cx('content')}>
                    <div className={cx('product-cart')}>
                        <div className={cx('cart-detail')}>
                            <h3>Giỏ Hàng Của Bạn </h3>
                            <hr />
                            <div className={cx('list-product')}>
                                <ItemCartProduct />
                                <ItemCartProduct />
                                <ItemCartProduct />
                                <ItemCartProduct />
                                <ItemCartProduct />
                                <ItemCartProduct />
                                <ItemCartProduct />
                                <ItemCartProduct />
                                <ItemCartProduct />
                            </div>
                        </div>
                    </div>
                    <div className={cx('info-oder')}>
                        <div className={cx('item-oder')}>
                            <h3 className={cx('title-oder')}>Thông tin đơn hàng của bạn </h3>
                            <hr />

                            <div className={cx('sum-price')}>
                                <span>Tổng tiền: </span>
                                <span>104,000 ₫</span>
                            </div>
                            <div className={cx('sum-title')}>
                                <li>Phí vận chuyển sẽ được tính ở trang thanh toán.</li>
                                <li>Bạn cũng có thể nhập mã giảm giá ở trang thanh toán.</li>
                            </div>
                            <div className={cx('payment')}>
                                <Button className={cx('custom-btn-pay')}>Đặt Hàng Ngay</Button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}
