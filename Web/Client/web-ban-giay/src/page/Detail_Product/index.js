import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faStar } from '@fortawesome/free-solid-svg-icons';

import Button from '~/component/Button';
import Input from '~/component/Input';
import classNames from 'classnames/bind';
import style from './Detail_product.module.scss';
import { useState } from 'react';
const cx = classNames.bind(style);

export default function DetailProduct() {
    const [activeBtn, setActiveBtn] = useState(null);

    const [number, setNumber] = useState(1);
    const handleButtonClick = (btnIndex) => {
        setActiveBtn(btnIndex);
    };

    const handleReduce = () => {
        if (number === 1) {
            return;
        } else {
            setNumber(number - 1);
        }
    };
    const handleIncrease = () => {
        setNumber(parseInt(number, 10) + 1);
        console.log(typeof number);
    };

    const handleChange = (value) => {
        setNumber(value);
    };
    return (
        <div className={cx('wrapp')}>
            <div className={cx('container')}>
                <div className={cx('content-detail')}>
                    <div className={cx('img-product')}>
                        <div className={cx('list-img')}>
                            <div className={cx('img-main')}>
                                <img src="https://product.hstatic.net/1000230642/product/dswh06200trg39_2__971ab4c67d94481ebdafa135434fd5ec_1024x1024.jpg" />
                            </div>
                        </div>
                    </div>
                    <div className={cx('detail-product')}>
                        <div className={cx('wrapper-detail')}>
                            <div className={cx('name-product')}>
                                <h3>Giày Thể Thao Nam Biti's Hunter Street Z Collection DSMH06200</h3>
                            </div>
                            <div className={cx('price')}>
                                <span>853,000 ₫</span>
                                <span>853,000 ₫</span>
                            </div>
                            <div className={cx('status')}>
                                <span>Tình trạng : </span>
                                <span>Còn hàng (10)</span>
                            </div>
                            <div className={cx('evaluate')}>
                                <div className={cx('start')}></div>
                                <div className={cx('quantily-human')}></div>
                            </div>
                            <div className={cx('size')}>
                                <div className={cx('select-size')}>
                                    <Button
                                        className={cx('custom-btn', {
                                            'active-button': activeBtn === 1,
                                        })}
                                        onClick={() => handleButtonClick(1)}
                                    >
                                        40
                                    </Button>
                                    <Button
                                        className={cx('custom-btn', {
                                            'active-button': activeBtn === 2,
                                        })}
                                        onClick={() => handleButtonClick(2)}
                                    >
                                        39
                                    </Button>
                                </div>
                            </div>

                            <div className={cx('btn-add-number')}>
                                <div className={cx('btn')}>
                                    <Button onClick={handleReduce} className={cx('custom-btn-number')}>
                                        -
                                    </Button>
                                    <Input
                                        onChange={(value) => handleChange(value)}
                                        value={number}
                                        textCenter
                                        className={cx('custom-input')}
                                    />
                                    <Button onClick={handleIncrease} className={cx('custom-btn-number')}>
                                        +
                                    </Button>
                                </div>
                            </div>
                            <div className={cx('add-cart')}>
                                <Button className={cx('custom-add-cart')}>Thêm Vào Giỏ</Button>
                            </div>
                        </div>
                    </div>
                </div>

                <div className={cx('evaluate-product')}>
                    <div className={cx('evaluate-product-content')}>
                        <h3>Đánh Giá Sản Phẩm</h3>

                        <div className={cx('content')}>
                            <div className={cx('product-star')}>
                                <div className={cx('view-star')}>
                                    <div className={cx('point')}>
                                        <strong>4.5</strong>/<span>5</span>
                                    </div>
                                    <div className={cx('start')}>
                                        <span>
                                            <FontAwesomeIcon icon={faStar} />
                                        </span>
                                        <span>
                                            <FontAwesomeIcon icon={faStar} />
                                        </span>
                                        <span>
                                            <FontAwesomeIcon icon={faStar} />
                                        </span>
                                        <span>
                                            <FontAwesomeIcon icon={faStar} />
                                        </span>
                                        <span>
                                            <FontAwesomeIcon icon={faStar} />
                                        </span>
                                    </div>
                                    <div className={cx('btn-')}>
                                        <Button>Viết Đánh Giá</Button>
                                    </div>
                                </div>
                            </div>
                            <div className={cx('view-evaluate')}>
                                <div className={cx('view-comment')}>
                                    <div className={cx('heading')}>
                                        <span>Đánh giá sản phẩm</span>
                                    </div>
                                    <div className={cx('list-comment')}>
                                        <div className={cx('item-comment')}>
                                            <div className={cx('info-comment')}>
                                                <div className={cx('left')}>
                                                    <span>Nguyễn Bạch long</span>
                                                    <span>Đã mua trên website | </span>
                                                    <div className={cx('start')}>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                    </div>
                                                </div>
                                                <div className={cx('right')}>
                                                    <span>21/12/2023</span>
                                                    <span>14:34:24</span>
                                                </div>
                                            </div>

                                            <div className={cx('comment')}>
                                                <span>
                                                    Giày đẹp, mà đúng như mọi người nói, phải xuống 1 size, mình mang
                                                    thường mang giày 40, giờ mang đôi này size 40 dư khoảng 1cm - 2cm
                                                </span>
                                            </div>
                                        </div>

                                        <div className={cx('item-comment')}>
                                            <div className={cx('info-comment')}>
                                                <div className={cx('left')}>
                                                    <span>Nguyễn Bạch long</span>
                                                    <span>Đã mua trên website | </span>
                                                    <div className={cx('start')}>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                        <span>
                                                            <FontAwesomeIcon icon={faStar} />
                                                        </span>
                                                    </div>
                                                </div>
                                                <div className={cx('right')}>
                                                    <span>21/12/2023</span>
                                                    <span>14:34:24</span>
                                                </div>
                                            </div>

                                            <div className={cx('comment')}>
                                                <span>
                                                    Giày đẹp, mà đúng như mọi người nói, phải xuống 1 size, mình mang
                                                    thường mang giày 40, giờ mang đôi này size 40 dư khoảng 1cm - 2cm
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}
