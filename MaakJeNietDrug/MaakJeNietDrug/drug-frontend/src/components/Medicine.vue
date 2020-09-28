<template>
    <div>
        <p>
            {{medicine.id}}
            <br/>
            {{medicine.name}}
        </p>
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

</style>