<template>
    <div>
        <div v-bind:key="medicine.id" v-for="medicine in medicineList">
        <Medicine v-bind:medicine="medicine"/>
        </div>
    </div>
</template>

<script>

import Medicine from "./Medicine";

export default {
    name: "MedicineList",
    props: ["medicineList"],
    data(){
        return null
    },
    methods:{

    },
    components: {
        Medicine,
    }
}
</script>

<style scoped>

</style>