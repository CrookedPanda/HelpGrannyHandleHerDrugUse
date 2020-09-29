<template>
<div>
    
      <btd >
      {{ medicine.id }}
      </btd><btd >
      {{ medicine.name }}
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