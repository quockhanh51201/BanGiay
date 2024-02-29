import Input from '~/component/Input';
import routes from '~/config/routes';
import { Link } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUser, faCartShopping, faMagnifyingGlass } from '@fortawesome/free-solid-svg-icons';

import classNames from 'classnames/bind';
import style from './Header.module.scss';
const cx = classNames.bind(style);

export default function Header() {
    return (
        <div className={cx('header')}>
            <div className={cx('header-wrapper')}>
                <div className={cx('logo')}>
                    <img src="https://lacdau.com/static/assets/default/images/logo.png" />
                </div>

                <div className={cx('list-nav')}>
                    <div className={cx('item')}>
                        <a>Giớ thiêu</a>
                    </div>
                    <div className={cx('item')}>
                        <a>Giớ thiêu</a>
                    </div>
                    <div className={cx('item')}>
                        <a>Giày thời trang</a>
                    </div>
                    <div className={cx('item')}>
                        <a>Giày thể thao</a>
                    </div>

                    <div className={cx('item')}>
                        <a>Sandal và Dép</a>
                    </div>
                </div>

                <div className={cx('action')}>
                    <div className={cx('input-search')}>
                        <Input pla={'Tìm kiếm...'} icon={<FontAwesomeIcon icon={faMagnifyingGlass} />} />
                    </div>
                    <div className={cx('login')}>
                        <a>
                            <FontAwesomeIcon icon={faUser} style={{ color: '#358ca7', fontSize: '20px' }} />
                        </a>
                    </div>
                    <div className={cx('cart')}>
                        <Link to={routes.cart}>
                            <FontAwesomeIcon icon={faCartShopping} style={{ color: '#358ca7', fontSize: '20px' }} />
                            <span className={cx('count-cart')}>
                                <span>50</span>
                            </span>
                        </Link>
                    </div>
                </div>
            </div>
        </div>
    );
}
