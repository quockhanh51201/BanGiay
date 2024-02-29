import { BrowserRouter, Route, Routes } from 'react-router-dom';

import LayoutDefaut from './layout';
import publicRoutes from './routes/routes';
import { Fragment } from 'react';
function App() {
    return (
        <BrowserRouter>
            <>
                <Routes>
                    {publicRoutes.map((route, index) => {
                        const Layout = route.layout === null ? Fragment : LayoutDefaut;
                        const Page = route.component;
                        return (
                            <Route
                                path={route.path}
                                element={
                                    <Layout>
                                        <Page />
                                    </Layout>
                                }
                            />
                        );
                    })}
                </Routes>
            </>
        </BrowserRouter>
    );
}

export default App;
