import { Link } from 'react-router-dom';

const NavBar = () => {
  return (
    <nav className="navbar navbar-expand-lg navbar-light bg-info py-3">
        <div className="container-fluid">
            <Link className="navbar-brand" to="/">What is the weather?</Link>
            <div className="collapse navbar-collapse">
            <ul className="navbar-nav me-auto mb-2 mb-lg-0">
                <li className="nav-item">
                <Link className="nav-link" to="/">Home</Link>
                </li>
            </ul>
            </div>
        </div>
    </nav>
  );
};

export default NavBar;
