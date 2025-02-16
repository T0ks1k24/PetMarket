export const fetchProducts = async ()=> {
    try{
        const response = await fetch("https://localhost:7117/api/Product"); // Замініть URL на свій
        if (!response.ok) {
            throw new Error("Failed to fetch products");
        }
        return await response.json();
    } catch (error) {
        console.error("Error fetching products:", error);
        return [];
    }
};