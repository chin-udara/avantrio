<template>
    <div>
        <div>{{ props.item.name }}</div>
        <div>{{ props.item.price }}</div>
        <div>{{ props.item.availableQuantity }}</div>
    </div>
</template>
<script lang="ts" setup>
import {Product} from '../types/product';
import { PropType } from 'vue';

const props = defineProps({
    item:{
        required: true,
        type: Object as PropType<Product>
    }
});
</script>