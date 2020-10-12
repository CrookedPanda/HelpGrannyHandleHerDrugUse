<template>
<div>
    
      <btd >
      {{ medicine.name }}
      </btd><btd >
      {{ medicine.description }}
      </btd>

</div>
</template>

<script>
export default {
  name: "Medicine",
  props: ["medicine"],
  methods: {},
};
</script>

<style scoped>
</style>