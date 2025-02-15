import styles from "../styles/home.module.scss";

export default function Home() {
    return (
        <main className={styles.main}>
            <header className={styles.header}>
                <h1>Головна сторінка</h1>
                <p>
                    Ласкаво просимо на наш сайт! Тут ви знайдете найкращі
                    пропозиції для ваших улюбленців.
                </p>
            </header>

            <section className={styles.section}>
                <h2>Популярні новини</h2>
                <div className={styles.news}>
                    <article className={styles.article}>
                        <h3>Що таке IT</h3>
                        <p>
                            IT - це йобля мозгів щоб стати успішним треба відкинути все.
                        </p>    
                        <a href="#">Читати більше</a>
                    </article>
                    <article className={styles.article}>
                        <h3>Cyber Attack</h3>
                        <p>
                            Хакери атакували FBI відомості не розголошуються
                        </p>
                        <a href="#">Читати більше</a>
                    </article>
                </div>
            </section>
        </main>
    );
}
