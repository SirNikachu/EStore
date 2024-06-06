export interface Product {
    id: number,
    name: string,
    description: string,
    pictureUrl: string,
    price: number,
    category: string,
    quantityInStock?: number
}

export interface ProductParams {
    orderBy: string;
    searchTerm?: string;
    categories: string[];
    pageNumber: number;
    pageSize: number;
}