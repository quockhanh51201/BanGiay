import Button from '~/component/Button';
import Input from '~/component/Input';

import { useState } from 'react';
import classNames from 'classnames/bind';
import style from './ItemCartProduct.module.scss';
const cx = classNames.bind(style);

export default function ItemCartProduct() {
    const [number, setNumber] = useState(1);

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
        <div className={cx('pro-cart')}>
            <div className={cx('item')}>
                <div className={cx('img-pro')}>
                    <img src="https://product.hstatic.net/1000230642/product/08500den__9__c06ae143a3c44c05ae5df346ec894fac_medium.jpg" />
                </div>
                <div className={cx('pro-text')}>
                    <div className={cx('name-product')}>
                        <span>Giày Thể Thao Nữ Biti's Hunter Street Bloomin' Central DSWH08500</span>
                    </div>
                    <div className={cx('detail-product')}>
                        <div className={cx('pro-color')}>
                            <span>Mã sản phẩm: </span> <span>MC0012</span>
                        </div>
                        <div className={cx('pro-color')}>
                            <span>Size giày: </span> <span>40.5</span>
                        </div>
                        <div className={cx('btn-add-number')}>
                            <Button onClick={handleReduce} className={cx('custom-btn')}>
                                -
                            </Button>
                            <Input
                                onChange={(value) => handleChange(value)}
                                value={number}
                                textCenter
                                className={cx('custom-input')}
                            />
                            <Button onClick={handleIncrease} className={cx('custom-btn')}>
                                +
                            </Button>
                        </div>

                        <div className={cx('pro-price')}>
                            <div className={cx('price-sale')}>
                                <span>2,088,000 ₫</span>
                            </div>
                            <div className={cx('cost')}>
                                <span>2,088,000 ₫</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}
