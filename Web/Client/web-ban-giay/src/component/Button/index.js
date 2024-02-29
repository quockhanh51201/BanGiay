import { Link } from 'react-router-dom';
import classNames from 'classnames/bind';
import style from './Button.module.scss';
const cx = classNames.bind(style);

export default function Button({ href, to, children, onClick, className, btnPrimary, outLine, leftIcon, w100 }) {
    let Comp = 'button';

    const props = {
        onClick,
    };

    if (to) {
        Comp = Link;
        props.to = to;
    } else if (href) {
        Comp = 'a';
        props.href = href;
    }
    const propsStyle = cx('btnwrap', {
        [className]: className,
        btnPrimary,
        outLine,
        w100,
    });

    return (
        <Comp className={propsStyle} {...props}>
            {leftIcon && <span className={cx('icon')}>{leftIcon}</span>}
            <span>{children}</span>
        </Comp>
    );
}
