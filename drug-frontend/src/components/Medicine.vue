<template>
    <div class="card mt-5">
<tr >
    <td>{{medicine.id}}</td>
</tr>
<tr>
    
        <td>{{medicine.name}}</td>
</tr>
        
    </div>
</template>

<script>
export default {
    name: "Medicine",
    props: ["medicine"],
    methods: {

    },

}
</script>

<style scoped>
tr{
width: 100%;
}

</style>