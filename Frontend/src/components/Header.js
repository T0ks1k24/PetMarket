import Link from "next/link";
import styles from "../styles/components/header.module.scss"

const Header = () => {
    return (
        <main>
            <div className={styles.header}>
                <Link href="/" className={styles.link}>
                    PetMarket
                </Link>
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
        </main>
    );
};

export default Header;
