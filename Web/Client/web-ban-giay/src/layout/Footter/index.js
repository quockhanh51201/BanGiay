import Input from '~/component/Input';
import Button from '~/component/Button';
import classNames from 'classnames/bind';
import style from './Footter.module.scss';
const cx = classNames.bind(style);

export default function Footter() {
    return (
        <div className={cx('wrapper')}>
            <div className={cx('footter')}>
                <div className={cx('container-send-email')}>
                    <div className={cx('send-email')}>
                        <div className={cx('text')}>
                            <h3 className={cx('title')}>Đăng ký nhận bản tin</h3>
                            <p className={cx('sub-title')}>
                                Để nhận các thông tin mới từ Biti's cũng như các chương trình khuyến mãi hấp dẫn
                            </p>
                        </div>
                        <div className={cx('input-email')}>
                            <Input pla={'Vui lòng nhập email của bạn...'} className={cx('custom-input')} />
                            <Button className={cx('custom-btn')}>Gửi</Button>
                        </div>
                    </div>
                </div>
                <div className={cx('item-img')}>
                    <div className={cx('item')}>
                        <a>
                            <img src="https://file.hstatic.net/200000522597/file/240x240_1_fcccf4c902ec4c5dbffb267d55480361.jpg" />
                        </a>
                    </div>
                    <div className={cx('item')}>
                        <a>
                            <img src="https://file.hstatic.net/200000522597/file/240x240_2_eb3aab14e3c4460598b186581e14319c.jpg" />
                        </a>
                    </div>
                    <div className={cx('item')}>
                        <a>
                            <img src="https://file.hstatic.net/200000522597/file/240x240_3_4ea1528b7b6c4b768edca82c5177b63f.jpg" />
                        </a>
                    </div>
                    <div className={cx('item')}>
                        <a>
                            <img src="	https://file.hstatic.net/200000522597/file/240x240_4_eff4b4e0d3e5496790737063aefc92d5.jpg" />
                        </a>
                    </div>
                    <div className={cx('item')}>
                        <a>
                            <img src="		https://file.hstatic.net/200000522597/file/240x240_5_796788d0cc3c4cb8becdd4095b9657ec.jpg" />
                        </a>
                    </div>
                    <div className={cx('item')}>
                        <a>
                            <img src="https://file.hstatic.net/200000522597/file/240x240_7_c8ce843f94c74e0e8e8aa51372ddf97b.jpg" />
                        </a>
                    </div>
                    <div className={cx('item')}>
                        <a>
                            <img src="	https://file.hstatic.net/200000522597/file/240x240_4_eff4b4e0d3e5496790737063aefc92d5.jpg" />
                        </a>
                    </div>
                    <div className={cx('item')}>
                        <a>
                            <img src="	https://file.hstatic.net/200000522597/file/240x240_8_bfbc1f9a56f24921979f053befbb7d67.jpg" />
                        </a>
                    </div>
                </div>

                <div className={cx('main-footer')}>
                    <div className={cx('footer-content')}>
                        <div class={cx('container')}>
                            <div className={cx('nav-item')}>
                                <div className={cx('item-1')}>
                                    <h3>Lac Dua</h3>
                                    <p>
                                        Đưa đến một chất lượng sản phẩm hoàn hảo với một giá thành hợp lí nhất. Luôn đặt
                                        khách hàng lên trên cả lợi nhuận. Tự hào là một Local Brand nhận được sự hài
                                        lòng của 99,99% khách hàng!
                                    </p>
                                </div>
                                <div className={cx('item-2')}>
                                    <h3>Thông tin về chúng tôi</h3>
                                    <ul class="footerNav-link">
                                        <li class="item-link">
                                            <a href="/pages/tra-cuu-tinh-trang-don-hang" title="Trạng thái đơn hàng">
                                                Trạng thái đơn hàng
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/q-a" title="Hình thức giao hàng">
                                                Hình thức giao hàng
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/hinh-thuc-thanh-toan" title="Hình thức thanh toán">
                                                Hình thức thanh toán
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/huong-dan-cach-chon-size" title="Hướng dẫn cách chọn Size">
                                                Hướng dẫn cách chọn Size
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/chinh-sach-doi-size" title="Chính sách đổi Size">
                                                Chính sách đổi Size
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/chinh-sach-doi-tra" title="Chính sách đổi trả">
                                                Chính sách đổi trả
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/chinh-sach-bao-hanh" title="Chính sách bảo hành">
                                                Chính sách bảo hành
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/bitis-loyalty" title="Chính sách khách hàng thân thiết">
                                                Chính sách khách hàng thân thiết
                                            </a>
                                        </li>
                                    </ul>
                                </div>

                                <div className={cx('item-2')}>
                                    <h3>Trợ giúp</h3>
                                    <ul class="footerNav-link">
                                        <li class="item-link">
                                            <a href="/pages/tra-cuu-tinh-trang-don-hang" title="Trạng thái đơn hàng">
                                                Tuyển dụng
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/q-a" title="Hình thức giao hàng">
                                                Hệ thống cửa hàng
                                            </a>
                                        </li>
                                        <li class="item-link">
                                            <a href="/pages/hinh-thuc-thanh-toan" title="Hình thức thanh toán">
                                                Liên hệ hợp tác
                                            </a>
                                        </li>
                                    </ul>
                                </div>

                                <div className={cx('item-3')}>
                                    <h3>Liên hệ</h3>
                                    <div className={cx('add')}>
                                        <span>Địa chỉ: </span> <span>115 Ni Su Huỳnh Liên</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <hr style={{ margin: '0' }} />
                <div className={cx('copy')}>
                    <div className={cx('text')}>Copyright © 2023 LongDev.</div>
                </div>
            </div>
        </div>
    );
}
