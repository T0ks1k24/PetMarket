import styles from "../styles/components/Card.module.scss";

const Card = ({ title, price, image}) => {
    return (
        <div className={styles.card}>
            <img src={image} className={styles.productThumb} alt={title} />
            <div className={styles.productInfo}>
                <h2 className={styles.productBrand}>{title}</h2>
                <div className={styles.priceContainer}>
                    <span className={styles.price}>${price}</span>
                </div>
                <button className={styles.cardBtn}>Add to Wishlist</button>
            </div>
        </div>
    );
};

export default Card;
