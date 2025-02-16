import Link from "next/link";
import styles from "../styles/components/header.module.scss";

const Header = () => {
    return (
        <main>
            <div className={styles.header}>
                <div className={styles.logo}>
                    <Link href="/" className={styles.link}>
                        PetMarket
                    </Link>
                </div>
                <div className={styles.navbar}>
                    <Link href="/" className={styles.link}>
                        Home
                    </Link>
                    <Link href="/store" className={styles.link}>
                        Store
                    </Link>
                    <Link href="/about" className={styles.link}>
                        About
                    </Link>
                </div>
            </div>
        </main>
    );
};

export default Header;
