import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCar } from '@fortawesome/free-solid-svg-icons';
import ProLoop from '~/component/Pro_Loop';
import classNames from 'classnames/bind';
import style from './Home.module.scss';
const cx = classNames.bind(style);

export default function Home() {
    return (
        <div className={cx('home-wrapp')}>
            <div className={cx('wrapper')}>
                <div className={cx('slider')}>
                    <img src="/img_sd_1.jpg" />
                </div>
                <div className={cx('section-commit')}>
                    <div class={cx('section-content')}>
                        <div class={cx('commit-item')}>
                            <div class={cx('commit-content')}>
                                <div class={cx('commit-icon')}>
                                    <FontAwesomeIcon icon={faCar} style={{ color: '#358ca7', fontSize: '20px' }} />
                                </div>
                                <div class={cx('commit-tile')}>
                                    <h4>FreeShip</h4>
                                </div>
                                <div class={cx('commit-cmd')}>
                                    <p>Giao hàng tận nơi khắp các tỉnh thành trên cả nước</p>
                                </div>
                            </div>
                        </div>

                        <div class={cx('commit-item')}>
                            <div class={cx('commit-content')}>
                                <div class={cx('commit-icon')}>
                                    <FontAwesomeIcon icon={faCar} style={{ color: '#358ca7', fontSize: '20px' }} />
                                </div>
                                <div class={cx('commit-tile')}>
                                    <h4>FreeShip</h4>
                                </div>
                                <div class={cx('commit-cmd')}>
                                    <p>Giao hàng tận nơi khắp các tỉnh thành trên cả nước</p>
                                </div>
                            </div>
                        </div>

                        <div class={cx('commit-item')}>
                            <div class={cx('commit-content')}>
                                <div class={cx('commit-icon')}>
                                    <FontAwesomeIcon icon={faCar} style={{ color: '#358ca7', fontSize: '20px' }} />
                                </div>
                                <div class={cx('commit-tile')}>
                                    <h4>FreeShip</h4>
                                </div>
                                <div class={cx('commit-cmd')}>
                                    <p>Giao hàng tận nơi khắp các tỉnh thành trên cả nước</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                {/* phan content  */}
                <section className={cx('collection')}>
                    <div className={cx('container')}>
                        <div className={cx('title')}>DEAL SỐC</div>
                        <div className={cx('collection-product')}>
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                        </div>
                    </div>
                </section>

                <section className={cx('collection')}>
                    <div className={cx('container')}>
                        <div className={cx('title')}>DEAL SỐC</div>
                        <div className={cx('collection-product')}>
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                        </div>
                    </div>
                </section>

                <section className={cx('collection')}>
                    <div className={cx('container')}>
                        <div className={cx('title')}>DEAL SỐC</div>
                        <div className={cx('collection-product')}>
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                        </div>
                    </div>
                </section>

                <section className={cx('banner')}>
                    <div className={cx('container')}>
                        <div className={cx('title')}>DEAL SỐC</div>
                        <div className={cx('banner-product')}>
                            <div className={cx('item-banner')}>
                                <a>
                                    <img src="https://file.hstatic.net/1000230642/file/dune_510x275_px_18c1407e41e348778d55e2f930e56cb8.jpg" />
                                </a>
                            </div>
                            <div className={cx('item-banner')}>
                                <a>
                                    <img src="https://file.hstatic.net/1000230642/file/dune_510x275_px_18c1407e41e348778d55e2f930e56cb8.jpg" />
                                </a>
                            </div>
                            <div className={cx('item-banner')}>
                                <a>
                                    <img src="https://file.hstatic.net/1000230642/file/dune_510x275_px_18c1407e41e348778d55e2f930e56cb8.jpg" />
                                </a>
                            </div>
                        </div>
                    </div>
                </section>

                <section className={cx('collection')}>
                    <div className={cx('container')}>
                        <div className={cx('title')}>DEAL SỐC</div>
                        <div className={cx('collection-product')}>
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                            <ProLoop />
                        </div>
                    </div>
                </section>

                <div className={cx('slider')}>
                    <img src="https://file.hstatic.net/1000230642/file/1920x750__1__ababa5e5dd20461aab9cbf65d9277383_master.jpg" />
                </div>

                <section className={cx('news')}>
                    <div className={cx('container')}>
                        <div className={cx('title')}>Tin Tuc</div>
                        <div className={cx('new-list')}>
                            <div className={cx('item')}>
                                <div className={cx('gr-item')}>
                                    <a>
                                        <img src="https://kingshoes.vn/data/upload/media/cach-do-size-giay-chuan-tai-viet-nam-US-UK-Chuan-xac-tai-KINGSHOES-VN-tphcm-tanbinh.jpg" />
                                    </a>
                                    <div className={cx('item-title')}>
                                        <h3>Chọn Size Giày Nike, Adidas</h3>
                                        <span>Tân Bình mua giày thể thao chạy bộ -tập gym adidas -nike chính hãng</span>
                                    </div>
                                </div>
                            </div>

                            <div className={cx('item')}>
                                <div className={cx('gr-item')}>
                                    <a>
                                        <img src="https://kingshoes.vn/data/upload/media/cach-do-size-giay-chuan-tai-viet-nam-US-UK-Chuan-xac-tai-KINGSHOES-VN-tphcm-tanbinh.jpg" />
                                    </a>
                                    <div className={cx('item-title')}>
                                        <h3>Chọn Size Giày Nike, Adidas</h3>
                                        <span>Tân Bình mua giày thể thao chạy bộ -tập gym adidas -nike chính hãng</span>
                                    </div>
                                </div>
                            </div>

                            <div className={cx('item')}>
                                <div className={cx('gr-item')}>
                                    <a>
                                        <img src="https://kingshoes.vn/data/upload/media/cach-do-size-giay-chuan-tai-viet-nam-US-UK-Chuan-xac-tai-KINGSHOES-VN-tphcm-tanbinh.jpg" />
                                    </a>
                                    <div className={cx('item-title')}>
                                        <h3>Chọn Size Giày Nike, Adidas</h3>
                                        <span>Tân Bình mua giày thể thao chạy bộ -tập gym adidas -nike chính hãng</span>
                                    </div>
                                </div>
                            </div>

                            <div className={cx('item')}>
                                <div className={cx('gr-item')}>
                                    <a>
                                        <img src="https://kingshoes.vn/data/upload/media/cach-do-size-giay-chuan-tai-viet-nam-US-UK-Chuan-xac-tai-KINGSHOES-VN-tphcm-tanbinh.jpg" />
                                    </a>
                                    <div className={cx('item-title')}>
                                        <h3>Chọn Size Giày Nike, Adidas</h3>
                                        <span>Tân Bình mua giày thể thao chạy bộ -tập gym adidas -nike chính hãng</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>
    );
}
