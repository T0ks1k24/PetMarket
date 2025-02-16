import { useRouter } from "next/router";

export default function () {
    const router = useRouter()
    console.log(router)

    return (
        <div>
            <h1>Product</h1>
        </div>
    )
}