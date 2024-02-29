import classNames from "classnames/bind";
import style from "./ProLoop.module.scss";
const cx = classNames.bind(style);

export default function ProLoop() {
  return (
    <div className={cx("pro-loop")}>
      <div className={cx("pro-title")}>
        <a>
          <img src="https://product.hstatic.net/1000230642/product/hao-nam-hunter-street-bloomin-central-dsmh08500den-den-7vy7y-color-den_9bc67f7ec91245c3a8c7c4dde07824d9_large.jpg" />
        </a>
      </div>
      <div className={cx("product-detail")}>
        <h3>Dép Thông Dụng Si Đế TPR Nam Biti's BTM000100</h3>
        <div className={cx("price")}>
          <div className={cx("price-cost")}>Giá : 314,000 ₫</div>
          <div className={cx("price-sell")}>100.000.0 đ</div>
        </div>
      </div>
      {/* <div>add to cart</div> */}
    </div>
  );
}
