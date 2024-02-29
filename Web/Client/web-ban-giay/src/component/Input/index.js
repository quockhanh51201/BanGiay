import classNames from 'classnames/bind';
import style from './Input.module.scss';

const cx = classNames.bind(style);

export default function input({ label, pla, name, value, onChange, type, icon, className, textCenter }) {
    // ham nay nhan su kien onChange de set gia tri

    const handleChange = (e) => {
        const { value } = e.target;
        onChange(value);
    };

    const propsStyle = cx('input', {
        [className]: className,
        // outLine,
        // w100,
    });
    const propsStyleInput = cx({
        textCenter,
        // outLine,
        // w100,
    });
    return (
        <div className={propsStyle}>
            {label && <label>{label}</label>}
            {icon && <span>{icon}</span>}
            <input
                className={propsStyleInput}
                type={type}
                placeholder={pla}
                value={value}
                name={name}
                onChange={handleChange}
            />
        </div>
    );
}
