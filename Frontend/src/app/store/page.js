import CardList from "../../components/CardList";
import styles from "../../styles/store.module.scss";

export default function Store() {
    return (
        <main className={styles.store}>
            <div>
                <h1>Store</h1>
                <h2>Тут ви знайдете великий вибір товарів для ваших улюбленців.</h2>
            </div>
            <CardList />
        </main>
    );
}
