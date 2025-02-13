import product from "./product.json";

const index = () => {
    return (
        <main>
            <div>
                <h1>PetMarket</h1>
            </div>
            <div>
                {product.map((prod) => {
                    return (
                        <li key={prod}>
                             <h2>{prod.name}</h2>
                             <p>{prod.description}</p>
                            <p>{prod.price} ₴</p>
                        </li>
                    );
                })}
            </div>
        </main>
    );
};

export default index;
