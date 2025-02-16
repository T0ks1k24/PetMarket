"use client"; // Додаємо це, щоб компонент працював на клієнті

import { useEffect, useState } from "react";
import { fetchProducts } from "../services/productService";
import Card from "./Card";
import styles from "../styles/components/CardList.module.scss";

const CardList = () => {
    const [products, setProducts] = useState([]);

    useEffect(() => {
        const loadProducts = async () => {
            try {
                const data = await fetchProducts();
                setProducts(data);
            } catch (error) {
                console.error("Error fetching products:", error);
            }
        };
        loadProducts();
    }, []);

    return (
        <div className={styles.cardList}>
            {products.map((product) => (
                <Card 
                    key={product.id} 
                    name={product.name} 
                    price={product.price} 
                    image={product.imageUrl} 
                />
            ))}
        </div>
    );
};

export default CardList;
