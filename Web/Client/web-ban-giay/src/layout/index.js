import Header from './Header';
import Footter from './Footter';
import classNames from 'classnames/bind';
import style from './LayoutDefaut.module.scss';
const cx = classNames.bind(style);

export default function LayoutDefaut({ children }) {
    return (
        <>
            <div className={cx('main-content')}>
                <Header />
                <div>{children}</div>
                <Footter />
            </div>
        </>
    );
}
