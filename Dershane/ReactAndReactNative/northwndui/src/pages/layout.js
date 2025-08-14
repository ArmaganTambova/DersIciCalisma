/*general*/
import { NavLink, Outlet } from 'react-router';

const Layout = () => {
    return (
        <>
        <nav>
            <NavLink to="/">Anasayfa</NavLink>
            <NavLink to="/categories">Kategoriler</NavLink>
            <NavLink to="/products">Ürünler</NavLink>
        </nav>
        <Outlet></Outlet>
        </>
    );
}

export default Layout;