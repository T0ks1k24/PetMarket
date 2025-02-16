import Link from "next/link";
import styles from "../styles/components/Card.module.scss";

const Card = ({ id, name, price, image }) => {
    return (
        <div className={styles.card}>
            {/* Обгортаємо тільки картинку та заголовок */}
            <Link href={`/product/${id}`} className={styles.cardLink}>
                <img src={image} className={styles.productThumb} alt={name} />
                <h2 className={styles.productBrand}>{name}</h2>
            </Link>

            <div className={styles.productInfo}>
                <div className={styles.priceContainer}>
                    <span className={styles.price}>${price}</span>
                </div>
                <button className={styles.cardBtn}>Add to Wishlist</button>
            </div>
        </div>
    );
};

export default Card;
