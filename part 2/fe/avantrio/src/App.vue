<script setup lang="ts">
import { onMounted, ref } from 'vue';
import ProductItemComp from './components/product-item.vue';
import {Product} from './types/product';

var items = ref<Product[]>([]);
onMounted(()=>{
  fetch("http://localhost:5207/Product").then(d=>{
    return d.json()
  }).then(d=>{
    items.value = d as Product[];
  });
});
</script>

<template>
  <div v-for="(item, n) in items" :key="n">
    <ProductItemComp :item="item" />
  </div>
</template>

