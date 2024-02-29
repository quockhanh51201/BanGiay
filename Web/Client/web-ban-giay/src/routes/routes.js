import routeConfig from '~/config/routes';
import Home from '~/page/Home';
import Cart from '~/page/Cart';
import DetailProduct from '~/page/Detail_Product';
const publicRoutes = [
    { path: routeConfig.home, component: Home },
    { path: routeConfig.cart, component: Cart },
    { path: routeConfig.detailProduct, component: DetailProduct },
];

export default publicRoutes;
