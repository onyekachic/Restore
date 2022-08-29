import axios from 'axios';
import { useState, useEffect } from 'react';
import { Product } from '../../app/models/product';
import ProductList from './ProductList';

export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    axios
      .get('http://localhost:5000/api/products')
      .then(response => setProducts(response.data));
  }, []);

  return (
    <>
      <ProductList products={products} />
    </>
  );
}
